# MainForm：Camera / Vision / Config OOP 示範

這是同一個 WinForms 專案內的小範例，用資料夾與 class 區分責任，方便先看懂 OOP。啟動專案會進入 MainForm。相機為模擬實作，不需要 pylon 或 Open eVision。

## 從哪裡看

| 檔案 | 保存的變數／資料 | 負責的功能 |
| --- | --- | --- |
| MainForm.Designer.cs | Button、NumericUpDown、PictureBox 等控件 | 建立控件、位置大小、屬性、綁定事件 |
| MainForm.cs | ICamera、BrightnessInspector、ConfigStore 物件 | 按鈕事件、讀取控件值、呼叫物件、顯示結果、釋放預覽影像 |
| Camera/ICamera.cs | 相機操作合約 | 定義連線、斷線、取像與資源釋放 |
| Camera/SimulatedCamera.cs | IsConnected 相機狀態 | 管理連線、產生 320×240 灰階影像 |
| Vision/BrightnessInspector.cs | 不需要長期狀態；total/average 為區域變數 | 計算 RGB 平均亮度、判斷門檻 |
| Vision/InspectionResult.cs | AverageBrightness、Passed | 保存一次檢測結果 |
| Config/InspectionConfig.cs | SimulatedBrightness、MinimumBrightness | 保存設定資料、驗證 0–255 範圍 |
| Config/ConfigStore.cs | _filePath | XML 設定存檔、讀檔 |

## 一次檢測的呼叫關係

```text
Designer 的 inspectButton.Click
  → MainForm.InspectButton_Click
    → ReadSettingsFromUi()                控件值轉成設定物件
    → _camera.Capture(brightness)         相機回傳 Bitmap
    → _inspector.Inspect(frame, threshold) 演算法回傳 InspectionResult
    → previewBox / resultLabel            MainForm 更新畫面
```

MainForm.cs 裡的核心呼叫：

```csharp
var config = ReadSettingsFromUi();
using (var frame = _camera.Capture(config.SimulatedBrightness))
{
    var result = _inspector.Inspect(frame, config.MinimumBrightness);
    // MainForm 用 result.Passed 與 result.AverageBrightness 顯示結果。
}
```

## 為什麼這樣拆

- 封裝：相機的 IsConnected 只有相機自己能修改；表單必須呼叫 Connect / Disconnect。
- 組合：MainForm 持有不同職責的物件，事件裡使用物件的方法。
- 多型：MainForm 的欄位型別是 ICamera。未來實作 PylonCamera : ICamera，再把建構子的 new SimulatedCamera() 換掉即可；真實硬體的曝光等參數應另外建模，不能把模擬亮度当成曝光。
- 資料與操作分開：InspectionConfig 是資料，ConfigStore 是儲存行為；InspectionResult 是資料，BrightnessInspector 是計算行為。
- 變數按生命週期放：控件在 Designer；物件欄位在所屬 class；單次計算 total、average 留在 method 裡，無須全部變成欄位。

Designer 與 MainForm.cs 是同一個 partial class 的兩個檔案；這只是 UI 分檔。真正 OOP 拆分的是相機、演算法、設定等獨立 class。這些 class 不依賴 Button、Label 或 MainForm。

## 操作

1. 啟動 opusViewerPro.csproj，按「連線相機」。
2. 亮度 150、門檻 100，按「取像並檢測」：PASS，平均 150。
3. 亮度改 50，再檢測：FAIL，平均 50。
4. 亮度等於門檻時為 PASS。
5. 「儲存設定」後更改數值，再「載入設定」可還原。
6. 中斷相機後，檢測按鈕停用。

設定位置：%LOCALAPPDATA%\opusViewerPro\inspection.xml。檔案不存在時採預設設定；格式錯誤會顯示錯誤訊息。

影像所有權：Capture 回傳的 Bitmap 由 using 釋放；PictureBox 使用複本，換圖和表單 Dispose 時釋放舊圖。演算法只借用影像，不釋放傳入的 Bitmap。

這是同步的小影像教學範例，GetPixel 用於方便閱讀；實際高速取像需再加入非同步流程、取消機制與高效像素讀取。

## 新增：Single Shot / Continuous / Live Display

先看 Camera/ICamera.cs 的操作與事件，再看 SimulatedCamera.cs，最後回到 MainForm.cs 的事件處理。

```text
Single Shot 按鈕 → ICamera.SingleShot → FrameReceived（一次）
Continuous 按鈕 → ICamera.StartContinuous → FrameReceived（背景持續）
                                              ↓
MainForm.Camera_FrameReceived → Clone 到 _latestFrame（只保留最新一張）
                                              ↓
Designer.previewTimer → PreviewTimer_Tick → PictureBox
Stop 按鈕 → ICamera.Stop → 等正在執行的影像回呼結束
```

- Single Shot 只取像顯示；「取像並檢測」仍透過 Capture 同步取得一張影像送 Vision。
- Continuous 每 50 ms 模擬背景取像，移動藍色方塊表示 Live 正在更新，不會執行檢測。
- UI Timer 每 33 ms 檢查最新影像，沒有新圖便不做事。這個 Timer 不控制相機取像。
- 相機管理 IsConnected、IsGrabbing、背景 Timer、取像序號；UI 管理 PictureBox 和預覽暫存。
- Continuous 時停用 Single Shot、取像檢測及亮度設定；Stop 後恢復。亮度在開始取像時讀入。
- FrameReceived 的影像屬於相機，事件回呼返回後釋放；UI 必須 Clone 才能保留。
- 相機內的 _gate 保證 Stop 返回後不再送出影像。_generation 排除上一次取像殘留的排隊回呼。
- 回呼內不可等待 UI，也不要執行耗時檢測；此教學範例的接收者只複製影像。正式 SDK 還需按其執行緒契約實作錯誤通知與斷線處理。
- 表單 Dispose：停 UI Timer → Stop 等待相機回呼結束 → 解除訂閱／Dispose 相機 → 釋放暫存與顯示影像。

這裡保留 Capture 與 SingleShot 兩種形式，供比較「同步回傳結果」和「事件通知結果」；實際專案可以依 SDK 和流程需求統一。沒有加入 PylonCamera 空實作，避免把未完成的方法誤當成可用的硬體支援。
