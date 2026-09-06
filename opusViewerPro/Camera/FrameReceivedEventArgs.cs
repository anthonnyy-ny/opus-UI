using System;
using System.Drawing;

namespace opusViewerPro.Camera
{
    // Image 僅在事件回呼期間有效；要保留到 UI 顯示必須 Clone。
    public sealed class FrameReceivedEventArgs : EventArgs
    {
        public Bitmap Image { get; private set; }
        public FrameReceivedEventArgs(Bitmap image) { Image = image; }
    }
}
