namespace opusViewerPro.Vision
{
    // 結果物件：演算法回傳資料，由畫面決定怎麼顯示。
    public class InspectionResult
    {
        public double AverageBrightness { get; private set; }
        public bool Passed { get; private set; }
        public InspectionResult(double averageBrightness, bool passed)
        {
            AverageBrightness = averageBrightness;
            Passed = passed;
        }
    }
}
