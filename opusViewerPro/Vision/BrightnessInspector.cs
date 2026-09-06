using System;
using System.Drawing;

namespace opusViewerPro.Vision
{
    // 不保存表單或相機，也不負責讀檔；只做影像計算。
    public class BrightnessInspector
    {
        public InspectionResult Inspect(Bitmap frame, int minimumBrightness)
        {
            if (frame == null) throw new ArgumentNullException(nameof(frame));
            if (minimumBrightness < 0 || minimumBrightness > 255)
                throw new ArgumentOutOfRangeException(nameof(minimumBrightness));
            double total = 0;
            for (int y = 0; y < frame.Height; y++)
                for (int x = 0; x < frame.Width; x++)
                {
                    var pixel = frame.GetPixel(x, y);
                    total += (pixel.R + pixel.G + pixel.B) / 3.0;
                }
            double average = total / ((double)frame.Width * frame.Height);
            return new InspectionResult(average, average >= minimumBrightness);
        }
    }
}
