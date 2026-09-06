using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using opusViewerPro.Camera;
using opusViewerPro.Config;
using opusViewerPro.Vision;

namespace opusViewerPro
{
    public partial class MainForm : Form
    {
        // 依責任分類：相機、檢測、設定讀寫。控件欄位在 Designer。
        private readonly ICamera _camera;
        private readonly BrightnessInspector _inspector;
        private readonly ConfigStore _configStore;

        // UI 預覽暫存：最多保留一張，避免連續取像塞滿 UI 訊息佇列。
        private readonly object _previewLock = new object();
        private Bitmap _latestFrame;
        private bool _resourcesReleased;

        public MainForm()
        {
            InitializeComponent();
            _camera = new SimulatedCamera();
            _camera.FrameReceived += Camera_FrameReceived;
            _inspector = new BrightnessInspector();
            _configStore = new ConfigStore(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "opusViewerPro", "inspection.xml"));
            UpdateConnectionUi();
        }

        private void MainForm_Load(object sender, EventArgs e) { LoadSettings(); }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            RunUiAction(() =>
            {
                if (_camera.IsConnected) _camera.Disconnect();
                else _camera.Connect();
                ClearPendingFrame();
                UpdateConnectionUi();
            });
        }

        // 方法是 UI 命令相機；事件是相機把影像交回 UI。
        private void SingleShotButton_Click(object sender, EventArgs e)
        {
            RunUiAction(() => _camera.SingleShot((int)brightnessInput.Value));
        }

        private void ContinuousButton_Click(object sender, EventArgs e)
        {
            RunUiAction(() =>
            {
                _camera.StartContinuous((int)brightnessInput.Value);
                resultLabel.Text = "Live 預覽中（未執行檢測）";
                UpdateConnectionUi();
            });
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            RunUiAction(() =>
            {
                _camera.Stop();
                ClearPendingFrame();
                UpdateConnectionUi();
            });
        }

        private void Camera_FrameReceived(object sender, FrameReceivedEventArgs e)
        {
            // 背景回呼只複製影像，不存取控件，也不呼叫 Invoke。
            lock (_previewLock)
            {
                _latestFrame?.Dispose();
                _latestFrame = (Bitmap)e.Image.Clone();
            }
        }

        private void PreviewTimer_Tick(object sender, EventArgs e)
        {
            Bitmap frame;
            lock (_previewLock)
            {
                frame = _latestFrame;
                _latestFrame = null;
            }
            if (frame == null) return;
            var previous = previewBox.Image;
            previewBox.Image = frame;
            previous?.Dispose();
        }

        private void ClearPendingFrame()
        {
            lock (_previewLock)
            {
                _latestFrame?.Dispose();
                _latestFrame = null;
            }
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            RunUiAction(() =>
            {
                ClearPendingFrame();
                var config = ReadSettingsFromUi();
                // 呼叫順序：UI 參數 → 相機取像 → Vision 計算 → UI 顯示。
                using (var frame = _camera.Capture(config.SimulatedBrightness))
                {
                    var result = _inspector.Inspect(frame, config.MinimumBrightness);
                    var preview = (Bitmap)frame.Clone();
                    var previous = previewBox.Image;
                    previewBox.Image = preview;
                    previous?.Dispose();
                    resultLabel.Text = string.Format("{0}  |  平均亮度：{1:F1}  |  門檻：{2}",
                        result.Passed ? "PASS" : "FAIL", result.AverageBrightness, config.MinimumBrightness);
                    resultLabel.ForeColor = result.Passed ? Color.DarkGreen : Color.Firebrick;
                }
            });
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RunUiAction(() =>
            {
                _configStore.Save(ReadSettingsFromUi());
                statusLabel.Text = "設定已儲存。";
            });
        }

        private void LoadButton_Click(object sender, EventArgs e) { LoadSettings(); }

        private void LoadSettings()
        {
            RunUiAction(() =>
            {
                var config = _configStore.Load();
                brightnessInput.Value = config.SimulatedBrightness;
                thresholdInput.Value = config.MinimumBrightness;
                statusLabel.Text = "已載入設定（首次使用為預設值）。";
            });
        }

        private InspectionConfig ReadSettingsFromUi()
        {
            return new InspectionConfig
            {
                SimulatedBrightness = (int)brightnessInput.Value,
                MinimumBrightness = (int)thresholdInput.Value
            };
        }

        private void UpdateConnectionUi()
        {
            connectButton.Text = _camera.IsConnected ? "中斷相機" : "連線相機";
            inspectButton.Enabled = _camera.IsConnected && !_camera.IsGrabbing;
            singleShotButton.Enabled = inspectButton.Enabled;
            continuousButton.Enabled = inspectButton.Enabled;
            stopButton.Enabled = _camera.IsGrabbing;
            brightnessInput.Enabled = !_camera.IsGrabbing;
            loadButton.Enabled = !_camera.IsGrabbing;
            statusLabel.Text = _camera.IsGrabbing ? "連續取像中：背景取像 → 最新影像 → UI Timer 顯示。" : _camera.IsConnected ? "模擬相機已連線。" : "模擬相機未連線。";
        }

        private void RunUiAction(Action action)
        {
            try { action(); }
            catch (Exception ex)
            {
                statusLabel.Text = "操作失敗：" + ex.Message;
                MessageBox.Show(this, ex.Message, "操作失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReleaseResources()
        {
            if (_resourcesReleased) return;
            _resourcesReleased = true;
            previewTimer?.Stop();
            // 先等背景取像結束，再釋放預覽；禁止在持有預覽鎖時 Stop。
            if (_camera != null)
            {
                _camera.Stop();
                _camera.FrameReceived -= Camera_FrameReceived;
                _camera.Dispose();
            }
            ClearPendingFrame();
            var previous = previewBox.Image;
            previewBox.Image = null;
            previous?.Dispose();
        }
    }
}
