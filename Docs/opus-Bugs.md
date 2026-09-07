
# Keywords
---
```C#=
throw → 抛出异常
```


# Debug Flash
---
4- 小程序测试runtime debug
```
Stopwatch.start
Trace.writeline (stopwatch.milisecond)
Stopwatch.Stop
```
3- 打开路径的时候没有指定路径就打开picture
```
string path = @"D:\dev\opus-Viewer\assets";

openFileDialog.InitialDirectory = Directory.Exists(path)
    ? path
    : Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
```
2- picturebox /camera协调   ok
https://chatgpt.com/s/cx_6a8fd75a73ac8191a20969f485d39195
```
Open File 更新 currentImagePath 和 parentImage
Camera Single Shot 更新 tempPath 和 parentImage
Pattern Learn 却固定执行 parentImage.Load(tempPath)
```
1- roi 1,2 camera matching 会跳exception
```
Open File    → 设置 H=500 → CropToImage → H=180
Single Shot  → 读取 H=500 → 只限制到图片总高度 → 不裁切 → H=494/500
```


# Debug Pro
---

B4 滑鼠mouse move roi learn/match 没有限制好图片范围 超出异常
---
图片在checkboxmatchRoi.checked的时候没有限制在图片范围内，但是checked=false的时候有限制所以没事

解法- 加try catch防呆

mainform.cs  修复代码
```C#=
private void picBoxCamera_MouseMove(object sender, MouseEventArgs e)
{
    //加上try catch防呆
}
```
mainform.cs  bug code
```C#=
private void picBoxCamera_MouseMove(object sender, MouseEventArgs e)
{
    // 限制 ROI1,2 不超出原图边界。
#region ROi1原图边界
//int width = Math.Min(myRoi.Width, parentImage.Width);
//int height = Math.Min(myRoi.Height, parentImage.Height);
//int x = Math.Max(0, Math.Min(myRoi.OrgX, parentImage.Width - width));
//int y = Math.Max(0, Math.Min(myRoi.OrgY, parentImage.Height - height));
//myRoi.SetPlacement(x, y, width, height);
#endregion
if (checkBoxSearchROI.Checked)
{
    int width = Math.Min(learnRoi.Width, searchRoi.Width);
    int height = Math.Min(learnRoi.Height, searchRoi.Height);
    int x = Math.Max(
        searchRoi.OrgX,
        Math.Min(learnRoi.OrgX, searchRoi.OrgX + searchRoi.Width - width)
     );
    int y = Math.Max(
        searchRoi.OrgY,
        Math.Min(learnRoi.OrgY, searchRoi.OrgY + searchRoi.Height - height)
    );
    learnRoi.SetPlacement(x, y, width, height);
}
else
{
    int width = Math.Min(learnRoi.Width, parentImage.Width);
    int height = Math.Min(learnRoi.Height, parentImage.Height);
    int x = Math.Max(0, Math.Min(learnRoi.OrgX, parentImage.Width - width));
    int y = Math.Max(0, Math.Min(learnRoi.OrgY, parentImage.Height - height));
    learnRoi.SetPlacement(x, y, width, height);

}
}
```

B3
---
Bug：continuous shot没有画面

原因：
UI队列塞满

解决：
建议把“实时显示”和“Open eVision 处理”拆开。现在最大问题是每一帧都存硬盘、重新读取、绑定 ROI，导致 UI 队列塞满。

推荐优化顺序：

1. Continuous Shot 每帧只做：

```
GrabResult → Bitmap 转换 → PictureBox 显示
```

不要在每帧执行：

```
bitmap.Save(...)
parentImage.Load(...)
myRoi.Attach(...)
myRoi2.Attach(...)
```

这些工作应放在：

- Single Shot 后
- Continuous Stop 后
- 用户按下“冻结/分析”按钮时

2. UI 只保留最新一帧

`GrabStrategy.LatestImages` 只能丢弃相机缓冲区的旧帧，无法清除已经进入 `BeginInvoke` 的 UI 任务。应增加“是否已有画面等待显示”的标记：

```
private int displayPending;
private volatile bool stopping;
```

收到影像时：

```
if (stopping ||
    Interlocked.Exchange(ref displayPending, 1) == 1)
{
    return; // UI 正忙，直接丢弃这帧
}
```

UI 显示完成后：

```
Interlocked.Exchange(ref displayPending, 0);
```

这样 UI 最多只积压一帧。

3. Stop 应先阻止新回调

推荐停止顺序：

```
stopping = true;
swTriggerRunning = false;

camera.StreamGrabber.ImageGrabbed -= OnImageGrabbed;

if (camera.StreamGrabber.IsGrabbing)
{
    camera.StreamGrabber.Stop();
}
```

已排队的 UI 回调开始时也要检查：

```
if (stopping)
{
    grabResult.Dispose();
    return;
}
```

这样 Stop 后不会继续处理旧帧。

4. Stop 完成后再同步 Open eVision

停止相机以后，只针对最后显示的 Bitmap 执行一次：

```
bitmap.Save(tempPath);
parentImage.Load(tempPath);
```

然后重新绑定 ROI。这样裁切和匹配仍然有最新影像，但不会每秒重复写硬盘。

5. ROI 边界必须扣除起点

例如 ROI2 应按剩余空间计算：

```
width  <= parentImage.Width  - x
height <= parentImage.Height - y
```

不能只使用：

```
Math.Min(width, parentImage.Width)
```

最核心的架构应为：

```
Continuous:
相机 → 丢弃旧帧 → UI 显示最新帧

Stop/Single Shot:
最后一帧 → Open eVision → ROI/裁切/匹配
```

这样 Stop 会立即响应，CPU、内存和硬盘负担也会明显下降。当前没有修改代码；如果你要，我可以按这个方案直接优化并验证。

10:18 AM

要如何修改代码 核心不要复杂

10:20 AM

Worked for 31s

核心只改三处：连续模式不做硬盘/Open eVision 处理、UI 最多排队一帧、Stop 先取消事件。

### 1. 增加一个字段

放在类的变量区域：

```
private int frameUiPending = 0;
```

项目已经引用 `System.Threading`，不用新增 using。

### 2. 修改 `OnImageGrabbed`

将目前的 `OnImageGrabbed` 替换成：

```
private void OnImageGrabbed(object sender, ImageGrabbedEventArgs e)
{
    // UI 还有一帧没显示完，就丢弃当前帧。
    if (Interlocked.Exchange(ref frameUiPending, 1) == 1)
        return;

    IGrabResult grabResult = null;

    try
    {
        grabResult = e.GrabResult.Clone();

        BeginInvoke(new Action(() =>
        {
            try
            {
                if (grabResult.GrabSucceeded)
                {
                    // Continuous 模式只显示，不更新 Open eVision。
                    ShowGrabResult(grabResult, false);
                }
            }
            finally
            {
                grabResult.Dispose();
                Interlocked.Exchange(ref frameUiPending, 0);
            }
        }));
    }
    catch
    {
        grabResult?.Dispose();
        Interlocked.Exchange(ref frameUiPending, 0);
        throw;
    }
}
```

这样 UI 最多等待一张图，不会累计几百个 `BeginInvoke`。

### 3. 调整 `ShowGrabResult`

修改方法签名：

```
private void ShowGrabResult(
    IGrabResult grabResult,
    bool updateOpenVision = true)
```

把保存 BMP、载入 `parentImage` 和绑定 ROI 的代码包起来：

```
if (updateOpenVision)
{
    bitmap.Save(tempPath, ImageFormat.Bmp);
    parentImage.Load(tempPath);

    int x1 = 174;
    int y1 = 375;
    int width1 = Math.Min(75, parentImage.Width - x1);
    int height1 = Math.Min(49, parentImage.Height - y1);

    if (width1 > 0 && height1 > 0)
    {
        myRoi.Attach(
            parentImage,
            x1,
            y1,
            width1,
            height1);
    }

    int x2 = 50;
    int y2 = 300;
    int width2 = Math.Min(550, parentImage.Width - x2);
    int height2 = Math.Min(500, parentImage.Height - y2);

    if (width2 > 0 && height2 > 0)
    {
        myRoi2.Attach(
            parentImage,
            x2,
            y2,
            width2,
            height2);
    }
}
```

PictureBox 显示部分继续放在 `if` 外面：

```
Image oldImage = picBoxCamera.Image;
picBoxCamera.Image = bitmap;
oldImage?.Dispose();
```

Single Shot 原本的调用不用修改：

```
ShowGrabResult(grabResult);
```

因为默认 `updateOpenVision = true`。

### 4. 调整 Stop 顺序

Stop 中先取消影像事件，再停止：

```
swTriggerRunning = false;

if (camera != null)
{
    camera.StreamGrabber.ImageGrabbed -= OnImageGrabbed;

    if (camera.StreamGrabber.IsGrabbing)
    {
        camera.StreamGrabber.Stop();
    }
}
```

最终效果：

- Single Shot：显示画面并更新 Open eVision。
- Continuous Shot：只显示最新画面，不存硬盘。
- UI 不会累积旧帧。
- Stop 能快速响应。
- ROI2 不再越界。

B2
---
Bug：num Matcher MInScale MaxScale 换算比例不准确

原因：
比例不对 1:100  float

解决：
把numUpDown 的数值/100
B1
---
Bug：roi2 drag resize
 roi1会一起拖拉
 
原因：
ROI1,2 共用一个draghandle

解决：
用一个变量记住「当前拖动的 ROI」

```
private EROIC24 selectedRoi = null;
```

鼠标按下：

```
dragHandle = myRoi2.HitTest(e.X, e.Y, zoom, zoom, panX, panY);

if (dragHandle != EDragHandle.NoHandle)
{
    selectedRoi = myRoi2;
}
else
{
    dragHandle = myRoi.HitTest(e.X, e.Y, zoom, zoom, panX, panY);
    selectedRoi = myRoi;
}
```

鼠标移动时，只拖当前 ROI：

```
if (e.Button == MouseButtons.Left &&
    dragHandle != EDragHandle.NoHandle)
{
    selectedRoi.Drag(
        dragHandle,
        e.X,
        e.Y,
        zoom,
        zoom,
        panX,
        panY);
}
```

鼠标放开：

```
dragHandle = EDragHandle.NoHandle;
selectedRoi = null;
```

核心就是：

```
selectedRoi.Drag(...);
```

不要同时执行：

```
myRoi.Drag(...);
myRoi2.Drag(...);
```

---


# CS003 26.2.4 evision roi1 drawframe checkbox debug
---
https://chatgpt.com/s/cx_6a8ba5b45a5481919bd7f3d1008f7f89 roi1 drawframe开关 debug参考

roi1 总开关debug 不是只是drawframe关闭
最简单的修改：把 `checkBoxROI1.Checked` 放进所有 ROI 事件的入口判断。只修改 [MainForm.cs](D:\\dev\\opus-Viewer\\opus 1.0 beta\\MainForm.cs)。
### 1. Checkbox 切换时停止拖动并刷新两个画面

```
private void checkBoxROI1_CheckedChanged(object sender, EventArgs e)
{
    if (!checkBoxROI1.Checked)
    {
        dragHandle = EDragHandle.NoHandle;
    }

    pictureBoxCamera.Invalidate();
    picBoxROI.Invalidate();
}
```

### 2. 关闭时不显示裁切预览

修改 `picBoxROI_Paint`：

```
private void picBoxROI_Paint(object sender, PaintEventArgs e)
{
    if (!checkBoxROI1.Checked || !cropCreated)
        return;

    float zoom = Math.Min(
        (float)picBoxROI.ClientSize.Width / croppedImage.Width,
        (float)picBoxROI.ClientSize.Height / croppedImage.Height);

    float panX = (picBoxROI.ClientSize.Width / zoom - croppedImage.Width) / 2;
    float panY = (picBoxROI.ClientSize.Height / zoom - croppedImage.Height) / 2;

    croppedImage.Draw(e.Graphics, zoom, zoom, panX, panY);
}
```

你的 `pictureBoxCamera_Paint` 已经有判断，不需要改：

```
if (!checkBoxROI1.Checked ||
    parentImage.Width == 0 ||
    parentImage.Height == 0)
{
    return;
}
```

### 3. 关闭时禁止点选 ROI

修改 `MouseDown` 开头：

```
private void pictureBoxCamera_MouseDown(object sender, MouseEventArgs e)
{
    if (!checkBoxROI1.Checked ||
        parentImage.Width == 0 ||
        parentImage.Height == 0)
    {
        return;
    }

    // 原本代码继续……
}
```

### 4. 关闭时禁止拖动 ROI

修改 `MouseMove` 开头：

```
private void pictureBoxCamera_MouseMove(object sender, MouseEventArgs e)
{
    if (!checkBoxROI1.Checked)
        return;

    if (e.Button == MouseButtons.Left &&
        dragHandle != EDragHandle.NoHandle)
    {
        // 原本代码继续……
    }
}
```

### 5. 关闭时禁止裁切

修改 `MouseUp` 开头：

```
private void pictureBoxCamera_MouseUp(object sender, MouseEventArgs e)
{
    if (!checkBoxROI1.Checked)
    {
        dragHandle = EDragHandle.NoHandle;
        return;
    }

    dragHandle = EDragHandle.NoHandle;

    croppedImage.SetSize(myRoi.Width, myRoi.Height);
    EasyImage.Copy(myRoi, croppedImage);

    cropCreated = true;
    picBoxROI.Invalidate();
}
```

这样 checkbox 的行为就是：

```
Checked = true
→ 显示、点击、拖动、裁切 ROI

Checked = false
→ 隐藏、禁止点击、禁止拖动、禁止裁切
```

`ShowGrabResult()` 中的 `myRoi.Attach(...)` 建议保留。它只是让 ROI 绑定最新影像，确保之后重新开启 checkbox 时可以立即使用。



# CS002 26.2.4 evision camera single shot后 crop图片预览  ok
---
https://chatgpt.com/s/cx_6a8ac79a3ce48191a4ef65136ee2d5e2 codex参考
最简单的核心修复：在 `ShowGrabResult()` 取得相机 `bitmap` 后，把它同步载入 `parentImage`，再重新绑定 `myRoi`。

流程就是：

```
相机 bitmap
    ↓
转成/载入 EImageC24 parentImage
    ↓
myRoi.Attach(parentImage, ...)
    ↓
pictureBoxCamera.Invalidate()
```

最省事的实现方式是：

1. 把相机 `bitmap` 暂存成 BMP。
2. 使用 `parentImage.Load(暂存路径)`。
3. 重新执行：

```
int roiWidth = Math.Min(400, parentImage.Width);
int roiHeight = Math.Min(300, parentImage.Height);

myRoi.Attach(parentImage, 0, 0, roiWidth, roiHeight);
```

这样现有的：

```
EasyImage.Copy(myRoi, croppedImage);
```

就能直接裁剪相机照片。

关键点：不能只更新 `pictureBoxCamera.Image`；它只是显示画面。必须同时更新真正用于裁剪的 `parentImage`。

这个“暂存 BMP 再 Load”的方法最简单、改动最少，但速度一般。单张 camera shot 很适合；连续拍摄则建议只在停止或选定某一帧时同步，避免每帧写硬盘。

下午6:10

那要怎么写 给我最核心 不要复杂代码参考

下午6:11

處理了 9 秒

把下面代码放在 `ShowGrabResult()` 的：

```
bitmap.UnlockBits(bitmapData);
```

后面：

```
string tempPath = Path.Combine(Path.GetTempPath(), "camera_frame.bmp");

bitmap.Save(tempPath, ImageFormat.Bmp);
parentImage.Load(tempPath);

int roiWidth = Math.Min(400, parentImage.Width);
int roiHeight = Math.Min(300, parentImage.Height);

myRoi.Attach(parentImage, 0, 0, roiWidth, roiHeight);
pictureBoxCamera.Invalidate();
```

核心就是这两句：

```
parentImage.Load(tempPath);
myRoi.Attach(parentImage, 0, 0, roiWidth, roiHeight);
```

这样相机拍到的画面就会成为真正的裁剪来源。

这段适合单张拍摄。连续拍摄不要每一帧都这样执行，否则会不断写入硬盘。


# CS001 26.2.3 evision picturebox Zoom 截图格式匹配   ok
---
不要截 PictureBox，直接从原图 parentImage 裁切，并把 PictureBox 坐标转换回原图坐标。
https://chatgpt.com/s/cx_6a8ac69c59988191b4cfae1fa61ef5ec  codex参考
```
鼠标坐标：PictureBox → 转换 → 原图坐标
ROI 数据：永远保存原图坐标
裁切来源：parentImage
ROI 显示：原图坐标 → 缩放 → PictureBox
```
## ROI 原图裁切 SOP

目标：PictureBox 只负责显示，实际裁切永远从 `parentImage` 原图执行。

### 1. 图片等比例显示

```
pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
```

不要使用 `StretchImage`，否则不同尺寸图片会变形。

### 2. 图片加载后建立 ROI

```
parentImage.Load(currentImagePath);

int roiWidth = Math.Min(400, parentImage.Width);
int roiHeight = Math.Min(300, parentImage.Height);

myRoi.Attach(
    parentImage,
    0,
    0,
    roiWidth,
    roiHeight);
```

注意：不能在 `parentImage` 尚未加载时执行 `Attach()`。

### 3. 计算显示缩放和留白

```
private void GetImageView(
    out float zoom,
    out float panX,
    out float panY)
{
    zoom = Math.Min(
        (float)pictureBoxCamera.ClientSize.Width / parentImage.Width,
        (float)pictureBoxCamera.ClientSize.Height / parentImage.Height);

    panX =
        (pictureBoxCamera.ClientSize.Width / zoom -
         parentImage.Width) / 2;

    panY =
        (pictureBoxCamera.ClientSize.Height / zoom -
         parentImage.Height) / 2;
}
```

`zoom` 是缩放比例，`panX/panY` 是 Zoom 模式产生的留白。

### 4. ROI 绘制与拖动使用同一套参数

绘制 ROI：

```
GetImageView(out float zoom, out float panX, out float panY);

myRoi.DrawFrame(
    e.Graphics,
    true,
    zoom,
    zoom,
    panX,
    panY);
```

鼠标按下：

```
GetImageView(out float zoom, out float panX, out float panY);

dragHandle = myRoi.HitTest(
    e.X,
    e.Y,
    zoom,
    zoom,
    panX,
    panY);
```

鼠标移动：

```
GetImageView(out float zoom, out float panX, out float panY);

myRoi.Drag(
    dragHandle,
    e.X,
    e.Y,
    zoom,
    zoom,
    panX,
    panY);
```

绘制、点击和拖动必须使用相同参数，否则 ROI 会失调。

### 5. 直接裁切原图

```
croppedImage.SetSize(
    myRoi.Width,
    myRoi.Height);

EasyImage.Copy(
    myRoi,
    croppedImage);
```

禁止使用：

```
pictureBoxCamera.DrawToBitmap(...);
```

也不要在裁切时重新执行：

```
parentImage.Load(...);
myRoi.Attach(...);
```

### 新人检查流程

更换横图、直图和正方形图片，确认：

1. 图片没有被拉伸。
2. ROI 框跟随鼠标。
3. ROI 没有超过原图范围。
4. 裁切结果与 ROI 框内容一致。
5. 保存后的宽高等于 `myRoi.Width × myRoi.Height`。

核心原则：

```
PictureBox = 显示
parentImage = 原图
myRoi = 原图坐标
EasyImage.Copy = 实际裁切
```


