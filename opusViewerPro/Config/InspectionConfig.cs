using System;

namespace opusViewerPro.Config
{
    // 設定資料：只保存參數與驗證，不認識任何控件。
    public class InspectionConfig
    {
        public int SimulatedBrightness { get; set; } = 150;
        public int MinimumBrightness { get; set; } = 100;

        public void Validate()
        {
            if (SimulatedBrightness < 0 || SimulatedBrightness > 255 ||
                MinimumBrightness < 0 || MinimumBrightness > 255)
                throw new ArgumentOutOfRangeException("亮度必須介於 0 到 255。");
        }
    }
}
