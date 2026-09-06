namespace opusViewerPro
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button singleShotButton;
        private System.Windows.Forms.Button continuousButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer previewTimer;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button inspectButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown brightnessInput;
        private System.Windows.Forms.NumericUpDown thresholdInput;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox previewBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ReleaseResources();
                if (components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.singleShotButton = new System.Windows.Forms.Button();
            this.continuousButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.previewTimer = new System.Windows.Forms.Timer(this.components);
            this.connectButton = new System.Windows.Forms.Button();
            this.inspectButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.brightnessInput = new System.Windows.Forms.NumericUpDown();
            this.thresholdInput = new System.Windows.Forms.NumericUpDown();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // Single Shot / Continuous / Stop：控件在 Designer，功能在 MainForm.cs。
            this.singleShotButton.Name = "singleShotButton";
            this.singleShotButton.Text = "Single Shot";
            this.singleShotButton.Location = new System.Drawing.Point(24, 240);
            this.singleShotButton.Size = new System.Drawing.Size(140, 36);
            this.singleShotButton.TabIndex = 9;
            this.singleShotButton.Click += new System.EventHandler(this.SingleShotButton_Click);
            this.continuousButton.Name = "continuousButton";
            this.continuousButton.Text = "Continuous";
            this.continuousButton.Location = new System.Drawing.Point(180, 240);
            this.continuousButton.Size = new System.Drawing.Size(140, 36);
            this.continuousButton.TabIndex = 10;
            this.continuousButton.Click += new System.EventHandler(this.ContinuousButton_Click);
            this.stopButton.Name = "stopButton";
            this.stopButton.Text = "Stop";
            this.stopButton.Location = new System.Drawing.Point(24, 290);
            this.stopButton.Size = new System.Drawing.Size(140, 36);
            this.stopButton.TabIndex = 11;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // Timer 只刷新預覽；相機自己負責背景取像。
            this.previewTimer.Interval = 33;
            this.previewTimer.Enabled = true;
            this.previewTimer.Tick += new System.EventHandler(this.PreviewTimer_Tick);
            //
            // connectButton
            //
            this.connectButton.Location = new System.Drawing.Point(24, 24);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(140, 36);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "連線相機";
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            //
            // inspectButton
            //
            this.inspectButton.Location = new System.Drawing.Point(180, 24);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.Size = new System.Drawing.Size(140, 36);
            this.inspectButton.TabIndex = 1;
            this.inspectButton.Text = "取像並檢測";
            this.inspectButton.Click += new System.EventHandler(this.InspectButton_Click);
            //
            // saveButton
            //
            this.saveButton.Location = new System.Drawing.Point(24, 180);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 36);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "儲存設定";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            //
            // loadButton
            //
            this.loadButton.Location = new System.Drawing.Point(180, 180);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 36);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "載入設定";
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            //
            // brightnessInput
            //
            this.brightnessInput.Location = new System.Drawing.Point(220, 82);
            this.brightnessInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessInput.Name = "brightnessInput";
            this.brightnessInput.Size = new System.Drawing.Size(100, 41);
            this.brightnessInput.TabIndex = 2;
            this.brightnessInput.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            //
            // thresholdInput
            //
            this.thresholdInput.Location = new System.Drawing.Point(220, 122);
            this.thresholdInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdInput.Name = "thresholdInput";
            this.thresholdInput.Size = new System.Drawing.Size(100, 41);
            this.thresholdInput.TabIndex = 3;
            this.thresholdInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            //
            // brightnessLabel
            //
            this.brightnessLabel.Location = new System.Drawing.Point(24, 85);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(180, 25);
            this.brightnessLabel.TabIndex = 2;
            this.brightnessLabel.Text = "模擬影像亮度 (0–255)";
            //
            // thresholdLabel
            //
            this.thresholdLabel.Location = new System.Drawing.Point(24, 125);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(180, 25);
            this.thresholdLabel.TabIndex = 3;
            this.thresholdLabel.Text = "合格最低亮度 (0–255)";
            //
            // resultLabel
            //
            this.resultLabel.Location = new System.Drawing.Point(24, 350);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(726, 32);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "尚未檢測";
            //
            // statusLabel
            //
            this.statusLabel.Location = new System.Drawing.Point(24, 395);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(726, 50);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "模擬相機未連線";
            //
            // previewBox
            //
            this.previewBox.BackColor = System.Drawing.Color.Black;
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBox.Location = new System.Drawing.Point(350, 24);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(400, 300);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 6;
            this.previewBox.TabStop = false;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 518);
            this.Controls.Add(this.singleShotButton);
            this.Controls.Add(this.continuousButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.inspectButton);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.brightnessInput);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.thresholdInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.statusLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera / Vision / Config — OOP 示範（模擬相機）";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
