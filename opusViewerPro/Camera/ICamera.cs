using System;
using System.Drawing;

namespace opusViewerPro.Camera
{
    public interface ICamera : IDisposable
    {
        bool IsConnected { get; }
        bool IsGrabbing { get; }
        event EventHandler<FrameReceivedEventArgs> FrameReceived;
        void Connect();
        void Disconnect();
        void SingleShot(int brightness);
        void StartContinuous(int brightness);
        void Stop();
        // 同步取像供「取像並檢測」使用；呼叫者負責 Dispose。
        Bitmap Capture(int brightness);
    }
}
