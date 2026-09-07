
# Keywords
---
```C#=

```



# Concept
---
```
Single Shot:
点击 → GrabOne → GrabSucceeded → ShowGrabResult

Continuous Shot:
点击 → Start
                 ↓ 每帧
           OnImageGrabbed
                 ↓
           GrabSucceeded
                 ↓
           ShowGrabResult
```












# 005 Pixel Format Control
---
拉一个comboBox,camera open()的时候loadpixelformats,用plcamera做getvalue(),把结果setvalue设定进去camera
https://chatgpt.com/share/6a9a3eb7-2420-83e8-9345-dfe662b04262 概念参考
1- 拖进空comboBox
2- void load function 放去connect camera button
3- combobox 取format 后写入camera
1st
```C#=
 private void cmbPixelFormat_SelectedIndexChanged(object sender, EventArgs e)
 {
     try
     {
	     // Camera 未连接时退出
         if (camera == null || !camera.IsOpen)
             return;
		// Camera 正在抓图时不允许修改 Pixel Format
         if (camera.StreamGrabber.IsGrabbing)
             return;
		// 取得 ComboBox 当前选择的 Pixel Format
         string format = cmbPixelFormat.SelectedItem.ToString();
		// 将选择的 Pixel Format 写入 Camera
         camera.Parameters[PLCamera.PixelFormat].SetValue(format);
         // 重新读取当前 Pixel Format，确认是否写入成功
         string currentFormat = camera.Parameters[PLCamera.PixelFormat].GetValue();
         Debug.WriteLine($"PixelFormat = {currentFormat}");
     }
     catch (Exception ex)
     {
         Controller.ShowEx(ex);
     }
 }
 private void LoadPixelFormats()
 {
	 // 清空 ComboBox 原本的选项
     cmbPixelFormat.Items.Clear();
	// 取得 Camera 的 PixelFormat 参数
     IEnumParameter pixelFormat = camera.Parameters[PLCamera.PixelFormat];
	// 读取 Camera 支持的所有 Pixel Format，并加入 ComboBox
     foreach (string format in pixelFormat.GetAllValues())
     {
     
         cmbPixelFormat.Items.Add(format);
     }
	// 将 Camera 当前使用的 Pixel Format 显示在 ComboBox
     cmbPixelFormat.SelectedItem = pixelFormat.GetValue();
 }
```



# 004 Width,Height Control
---
codex 参考exposure/gain/gamma 改造 
https://chatgpt.com/share/6a82d0d5-c0d0-83e8-964c-53207895e071 概念原理参考
core
```C#
//concept
NumericUpDown → decimal
TrackBar → int
相机整数参数 → long
//sample code
long width = decimal.ToInt64(numericUpDownWidth.Value);
trackBarWidth.Value = (int)width;
camera.Parameters[PLCamera.Width].SetValue(width);
```
tips- get set value


# 003 SW trigger On singleShot, continuousShot
---
可以看draw.io codex visual studio sample code 参考
SWTriggerOn Continuous Shot
---
https://chatgpt.com/share/6a7eb877-cfc0-83ee-87f6-8311f14fc211 sw triggeron continuous shot 概念参考
关键点是将 grabstrategy.onebyone 改成 latest image
SWTriggerOn SingleShot
---
https://chatgpt.com/share/6a7e9086-d580-83ee-9bb9-5aaaea5ed41e  sw triggeron singleshot 概念参考

关键点是将 GrabLoop.ProvidedByStreamGrabber 改成 GrabLoop.ProvidedByUser，然后主动 RetrieveResult() 并调用 ShowGrabResult()。




# 002- camera paremeter control
---
1- gain exposure gamma 调参     ok
2- trackbar numericUpDown controller 设定max min value数值   ok
gamma
---
复制gain流程 codex
gain
---
keywords- PLCamera
Gain 的核心流程就这样，重点只有三步：
```
camera.Open();

camera.Parameters[PLCamera.GainAuto]
      .TrySetValue(PLCamera.GainAuto.Off);

InitializeGain(); // 读取相机范围并写进 UI
```
然后保留两个 UI 事件：
- `numericUpDownGain_ValueChanged`：把 UI 值写入相机。
- `trackBarGain_Scroll`：同步到 `numericUpDownGain`。
sample code
```C#=
camera.Parameters[PLCamera.GainAuto] .TrySetValue(PLCamera.GainAuto.Off); camera.Parameters[PLCamera.Gain] .SetValue((double)numericUpDownGain.Value);
```
这跟 Basler 官方 sample 的做法一致：先尝试把 `GainAuto` 设置成 `Off`，之后才能手动指定 Gain。
exposure
---
- 自写程式参考
	1- https://chatgpt.com/share/6a7c379d-e920-83e8-8847-5f0b03c74d8b chatgpt exposure numUpDown trackbar 同步调参

keywords- PLCamera
```
PLCamera.ExposureTime
PLCamera.ExposureAuto
Parameter SetValue GetValue
```
sample code
```C#=
// 1. 关闭自动曝光 
camera.Parameters[PLCamera.ExposureAuto] .TrySetValue(PLCamera.ExposureAuto.Off); // 2. 设置曝光时间 
camera.Parameters[PLCamera.ExposureTime] .SetValue(10000); 
// 3. 读取目前曝光时间 
double exposure = camera.Parameters[PLCamera.ExposureTime].GetValue();
```
tips- 善用PLCamera函数，先初始化trackbar数值，然后trackbar numericUpDown 数值同步


# 001- auto-detect usb camera listview    ok
---
1- DeviceRemovalHandling usb插拔防呆   ok
2- picture box single/continuous display    ok
3- 自动侦测usb     ok
4- 刷新device list   ok

- 自写程式参考
	1- https://chatgpt.com/share/6a79a402-0974-83ee-8268-f467e66b2686 listview USB detect
	2- https://chatgpt.com/share/6a7af98a-b028-83ee-a1e1-9ad3df462dca camera shot function 
	3- https://chatgpt.com/share/6a7be9dc-b220-83ee-b955-c146c53bc5cd camera usb自动侦测
	
camera class/method
```
camera.open()
camera.close()
camera.dipose()
CameraFinder.Enumerate   
CameraInfoKey            
```
自写 void function
```
UpdateDeviceList   ok
OnConnectionLost   ok
SearchCameras      ok
OnImageGrabbed     ok
ContinuousShot     o
Stop               o
DestroyCamera      o
```
tips- Basler.Pylon.CameraFinderBasler, Pylon.CameraInfoKey SerialNumber 抓取




## 常用 API 速查

| 目的       | API / 成員                       | 備註                       |
| -------- | ------------------------------ | ------------------------ |
| 搜尋相機     | `CameraFinder.Enumerate()`     | 回傳目前可用裝置                 |
| 識別相機     | `CameraInfoKey.SerialNumber`   | 不要只依賴清單順序                |
| 開啟相機     | `camera.Open()`                | 開啟後才讀寫多數參數               |
| 關閉相機     | `camera.Close()`               | 停止取像後再關閉                 |
| 釋放資源     | `camera.Dispose()`             | 關閉程式與錯誤路徑都要執行            |
| 連續取像事件   | `StreamGrabber.ImageGrabbed`   | 回呼通常不在 UI 執行緒            |
| USB 斷線事件 | `camera.ConnectionLost`        | UI 提示與資源清理要分開處理          |
| 讀取參數     | `GetValue()`                   | 先確認參數是否存在且可讀             |
| 寫入參數     | `SetValue()` / `TrySetValue()` | `TrySetValue()` 適合處理機型差異 |



## 一分鐘操作流程

```text
CameraFinder.Enumerate()
        ↓
選擇相機（建議用 SerialNumber 識別）
        ↓
new Camera(cameraInfo) → Open()
        ↓
設定參數 / 註冊事件
        ↓
單張取像，或 StreamGrabber.Start(...)
        ↓
ImageGrabbed → 轉換影像 → 更新 PictureBox
        ↓
StreamGrabber.Stop()
        ↓
Close() → Dispose()
```
正常關閉、使用者停止、USB 拔除與程式例外，最後都要走到同一個資源清理流程。
