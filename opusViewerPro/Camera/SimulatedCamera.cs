using System;
using System.Drawing;
using System.Threading;

namespace opusViewerPro.Camera
{
    // 相機管理取像狀態；不認識 Form、PictureBox 或 UI Timer。
    // 公開操作由 UI 執行緒呼叫；影像事件可能由背景執行緒送出。
    public class SimulatedCamera : ICamera
    {
        private readonly object _gate = new object();
        private Timer _timer;
        private bool _disposed;
        private int _brightness;
        private int _frameNumber;
        private int _generation;
        public bool IsConnected { get; private set; }
        public bool IsGrabbing { get; private set; }
        public event EventHandler<FrameReceivedEventArgs> FrameReceived;

        public void Connect()
        {
            lock (_gate) { ThrowIfDisposed(); IsConnected = true; }
        }

        public void SingleShot(int brightness)
        {
            lock (_gate)
            {
                using (var frame = Capture(brightness))
                    FrameReceived?.Invoke(this, new FrameReceivedEventArgs(frame));
            }
        }

        public Bitmap Capture(int brightness)
        {
            lock (_gate)
            {
                ValidateCapture(brightness);
                return CreateFrame(brightness, false);
            }
        }

        public void StartContinuous(int brightness)
        {
            lock (_gate)
            {
                ValidateCapture(brightness);
                _brightness = brightness;
                _frameNumber = 0;
                int generation = ++_generation;
                IsGrabbing = true;
                // 模擬 SDK 背景回呼，不使用 WinForms Timer 取像。
                _timer = new Timer(_ => ProduceFrame(generation), null, 0, 50);
            }
        }

        private void ProduceFrame(int generation)
        {
            lock (_gate)
            {
                // 避免 Stop 後尚在排隊的舊回呼影響下一次 Start。
                if (!IsGrabbing || generation != _generation) return;
                using (var frame = CreateFrame(_brightness, true))
                    FrameReceived?.Invoke(this, new FrameReceivedEventArgs(frame));
            }
        }

        private Bitmap CreateFrame(int brightness, bool animate)
        {
            var frame = new Bitmap(320, 240);
            using (var graphics = Graphics.FromImage(frame))
            {
                graphics.Clear(Color.FromArgb(brightness, brightness, brightness));
                // 連續預覽用移動方塊辨識畫面確實在更新。
                if (animate)
                {
                    graphics.FillRectangle(Brushes.DodgerBlue, (_frameNumber++ % 56) * 5, 100, 40, 40);
                }
            }
            return frame;
        }

        public void Stop()
        {
            lock (_gate)
            {
                IsGrabbing = false;
                ++_generation;
                _timer?.Dispose();
                _timer = null;
                // 事件也在同一把鎖內：Stop 返回後不再送出影像。
            }
        }

        public void Disconnect()
        {
            lock (_gate) { Stop(); IsConnected = false; }
        }

        public void Dispose()
        {
            lock (_gate)
            {
                if (_disposed) return;
                Disconnect();
                FrameReceived = null;
                _disposed = true;
            }
        }

        private void ValidateCapture(int brightness)
        {
            ThrowIfDisposed();
            if (!IsConnected) throw new InvalidOperationException("請先連線相機。");
            if (IsGrabbing) throw new InvalidOperationException("請先停止連續取像。");
            if (brightness < 0 || brightness > 255) throw new ArgumentOutOfRangeException(nameof(brightness));
        }

        private void ThrowIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException(nameof(SimulatedCamera));
        }
    }
}
