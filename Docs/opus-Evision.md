
# Keywords
---
```C#=
| 方法                                | 作用            |
| --------------------------------- | ------------- |
| `Attach(parentImage)`             | ROI 绑定哪张母图    |
| `SetPlacement(x, y, w, h)`        | ROI 在母图的哪里、多大 |
| `Attach(parentImage, x, y, w, h)` | 一次完成绑定和设置范围   |

load()   path
attach()      4
setplacement()   4
cropToImage()
setsize()    2
save()    path
Invalidate()
easyImage.copy()
```

# Concept
---
easyMatch
```C#=
CheckBox 决定哪个 ROI 可操作 
selectedRoi 决定当前正在拖哪个 ROI

Max Occurrences          10
Max Initial Occurrences  10～20
Min Score                0.70
Max Overlap              0.50
Final Reduction          0
Sub-Pixel Interpolate    开启
Contrast                 Normal
Correlation Mode         Normalized
Angle                    0° ～ 0°
Scale                    100% ～ 100%
Scaling                  Isotropic

Score   = 匹配得像不像
CenterX = 找到的位置 X
CenterY = 找到的位置 Y
Angle   = 目标旋转多少
Scale   = 目标放大或缩小多少

ROI 范围：int
匹配参数与匹配结果：float
```
easyGauge 主要是用来： 测量影像中的圆，找出实际圆心、半径和直径。
```C#=
ECircleGauge → 负责找圆
ECircle      → 负责描述一个圆
EPoint       → 负责描述圆心坐标

circleGauge.SetCircle(...);   // 先给一个大概圆的位置
circleGauge.Measure(imageBW8); // 寻找圆形边缘
ECircle result = circleGauge.MeasuredCircle; // 取得实际圆

1. Center X / Y → 预估圆心位置
2. Diameter → 预估圆的直径
3. Measure → 执行圆形测量
4. Measured Circle → 取得实际圆心和实际半径/直径

CenterX / CenterY → 圆心
Radius            → 半径
Diameter          → 直径

center = new EPoint(
    grayImage.Width / 2.0f,   // 圆心 X：图片宽度的一半
    grayImage.Height / 2.0f   // 圆心 Y：图片高度的一半
);
circle = new ECircle(
    center,   // 圆心位置
    200.0f,   // 圆的直径：200 px，半径就是 100 px
    0.0f,     // 起始角度：0°
    360.0f    // 测量范围：360°完整圆
);
ECircle.Center = EPoint;
ECircle.Diameter = 200.0f;
ECircle.Angle = 0.0f;
ECircle.Amplitude = 360.0f;

ECircleGauge.Circle = ECircle;

```












# 008 26.2.7 CircleGauge
---

Step 2 Show position/Measured Results Save/Load Xml 
---
用opus-config skill xml  +  datagridview ok
加颜色标记
 ```C#=
dataGridViewCircleSamplesResult.Rows[rowIndex].Cells[3].Style.BackColor = valid ? Color.LightGreen : Color.LightCoral;
 ```

Step 1- 建立 Gauge → 设置大概圆 → Measure → 读取圆心和半径
---
sample code
https://chatgpt.com/s/cx_6a969ab42e148191b5b33fca60453b2d  mouse控件num数值整合
```C#=
private void btnCircleGauge_Click(object sender, EventArgs e)
{
    try
    {
        Controller.CheckImage(parentImage);
        //colour to gray
        ConvertToGray(parentImage, grayImage);
        // Circle Gauge 初始化圆参数
        //center = new EPoint(grayImage.Width / 2.0f, grayImage.Height / 2.0f);
        center = new EPoint((float)numXCircle.Value, (float)numYCircle.Value);
        circle = new ECircle(center, (float)numDiameterCircle.Value, (float)numAngleCircle.Value, (float)numAmplitudeCircle.Value);
        circleGauge.Circle = circle;

        circleGauge.Dragable = true;   // 可以移动
        circleGauge.Resizable = true;  // 可以调整直径
        circleGauge.Rotatable = true;  // 可以调整圆弧角度
        circleGauge.Selected = true;   // 显示操作把手

        //picBoxCamera.Invalidate();

        // 执行测量
        circleGauge.Measure(grayImage);

        // output
        if (circleGauge.GetFound())
        {
            ECircle result = circleGauge.MeasuredCircle;

            Debug.WriteLine(
                $"Center=({result.CenterX:F2}, {result.CenterY:F2}), " +
                $"Diameter={result.Diameter:F2}");
        }
        else
        {
            Debug.WriteLine("没有找到有效圆形");
        }

        //output
        //circleGauge.Save(@"D:\dev\opus-Viewer\assets\myCircleGauge.gge");
        //grayImage.Save(@"D:\dev\opus-Viewer\assets\gray.bmp");
        Debug.WriteLine($"grayImage saved to D:\\dev\\opus-Viewer\\assets\\gray.bmp");
        lblImagePath.Text = currentImagePath;
    }
    catch (Exception ex)
    {
        Controller.ShowEx(ex);
    }
    finally
    {
        checkBoxLearnROI.Checked = false;
        checkBoxSearchROI.Checked = false;
        checkBoxCircle.Checked = true;
        checkBoxShowResult.Checked = false;
    }
}
```
tips CircleGauge只能灰图  

C24 to BW8 sample function
```C#=
private void ConvertToGray(EImageC24 parentImage, EImageBW8 grayImage)
{
    // 设置灰阶影像尺寸，与彩色影像相同
    grayImage.SetSize(parentImage);
    // 建立颜色转换表
    EColorLookup lookup = new EColorLookup();
    // 设置颜色系统：RGB 转换成 LSH
    lookup.ConvertFromRgb(EColorSystem.Lsh);
    // 取出 LSH 的亮度分量，转换成 BW8 灰阶影像
    EasyColor.GetComponent(parentImage, grayImage, 0, lookup);
    // 释放颜色转换表资源
    lookup.Dispose();
}
```








# 007 26.2.5 Show results 核心concept
---
### Max Occurrences = 10
最多输出多少个匹配结果。
```
EMatcher1.MaxPositions = 10;
```
### Min Score = 0.5000
最低接受分数。
```
EMatcher1.MinScore = 0.5f;
```
分数范围通常可理解为：
- `1.0`：非常相似
- `0.8`：相似度高
- `0.5`：条件比较宽松
- 低于设定值：不返回
## Angle：允许旋转范围
截图中：
```
Min = 0°
Max = 0°
```
表示只找与模板方向完全一样的目标，不允许旋转。

例如允许旋转正负 10°：
```
EMatcher1.MinAngle = -10f;
EMatcher1.MaxAngle = 10f;
```
范围越大：

- 越能找到旋转目标
- 搜索越慢
- 误匹配机会也可能增加

固定治具建议保持 `0～0`；零件可能旋转时再开放角度。

---

## Scale：允许尺寸变化范围
截图中：
```
Min = 100%
Max = 100%
```
表示目标必须和学习模板大小相同。

例如允许目标大小变化 ±10%：

```
Min Scale = 90%
Max Scale = 110%
```

对应概念：

```
EMatcher1.MinScale = 0.9f;
EMatcher1.MaxScale = 1.1f;
```

你之前看到的：

```
EMatcher1.MinScale = 1.00f;
EMatcher1.MaxScale = 1.00f;
```

就是固定在原始尺寸，不搜索缩放版本。



# 006 26.2.5 learn/match 秀出result  ok
---
第5步 zoom in /zoom out   ok
https://chatgpt.com/s/cx_6a912f391e1c8191bce81b776a45a1fd
设定picBox.SizeMode = stretchImage, 设定float初始化，mousescroll, mousedown hitest,mouse move都用zoom 
```C#=
picBoxCamera.SizeMode = PictureBoxSizeMode.StretchImage;

private void picBoxCamera_MouseScroll(object sender, MouseEventArgs e)
{
    if (picBoxCamera.Image == null)
        return;

    if (e.Delta > 0)
        zoom *= 1.1f;
    else
        zoom /= 1.1f;

    zoom = Math.Max(0.1f, Math.Min(zoom, 10.0f));

    picBoxCamera.Size = new Size(
        (int)(picBoxCamera.Image.Width * zoom),
        (int)(picBoxCamera.Image.Height * zoom));

    picBoxCamera.Invalidate();
}

myRoi.DrawFrame(
    e.Graphics,
    true,
    zoom,
    zoom,
    0,
    0);
    
Matcher.DrawPositions(
    e.Graphics,
    new ERGBColor(0, 255, 0),
    true,
    zoom,
    zoom,
    0,
    0);
```
滚轮
  ↓
改变 zoom
  ↓
改变 PictureBox.Size
  ↓
Panel 自动显示 scrollbar
  ↓
ROI 使用相同 zoom 绘制和操作


第4步 show matching result    OK

先拉个dataGridView做mainform初始化格式让btm内放output
```C#=

public MainForm()
{
    InitializeComponent();

    dataGridViewResults.AllowUserToAddRows = false;
    dataGridViewResults.ReadOnly = true;
    dataGridViewResults.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;

    dataGridViewResults.Columns.Add("Number", "结果");
    dataGridViewResults.Columns.Add("Score", "Score");
    dataGridViewResults.Columns.Add("X", "X");
    dataGridViewResults.Columns.Add("Y", "Y");
    dataGridViewResults.Columns.Add("Width", "W");
    dataGridViewResults.Columns.Add("Height", "H");
    dataGridViewResults.Columns.Add("Angle", "Angle");
    dataGridViewResults.Columns.Add("Scale", "Scale");
}
```

```C#=
uint count = Matcher.NumPositions;

// 清除上一次匹配结果
dataGridViewResults.Rows.Clear();

if (count > 0)
{
    for (uint i = 0; i < count; i++)
    {
        EMatchPosition result = Matcher.GetPosition(i);

        float width = myRoi.Width * result.Scale;
        float height = myRoi.Height * result.Scale;

        float x = result.CenterX - width / 2f;
        float y = result.CenterY - height / 2f;

        dataGridViewResults.Rows.Add(
            i + 1,
            result.Score.ToString("F3"),
            x.ToString("F1"),
            y.ToString("F1"),
            width.ToString("F1"),
            height.ToString("F1"),
            result.Angle.ToString("F2") + "°",
            result.Scale.ToString("F3")
        );
    }
}
else
{
    dataGridViewResults.Rows.Add(
        "-", "找不到目标", "", "", "", "", "", ""
    );
}
```



第3步 ROI2 matching完善    ok

show/hide matching result sample code
```C#=
if (checkBoxShowResult.Checked )
{
    Matcher.DrawPositions(
        e.Graphics,
        new ERGBColor(0, 255, 0),
        true,
        zoom,
        zoom,
        panX,
        panY);
}
```
tips- 加一个checkbox

第2步：Camera shot能成功pattern match ok

Search ROI2 match sample code
```C#=
searchRoi.Attach(parentImage);
searchRoi.SetPlacement(300, 150, 500, 300);
searchRoi.CropToImage();

// 只匹配 searchRoi 内部
Matcher.Match(searchRoi);
```

显示全部匹配结果 evision show result sample code
```C#=
for (uint i = 0; i < Matcher.NumPositions; i++)
{
    EMatchPosition result = Matcher.GetPosition(i);

    float width  = myRoi.Width * result.Scale;
    float height = myRoi.Height * result.Scale;

    float x = result.CenterX - width / 2f;
    float y = result.CenterY - height / 2f;

    Debug.WriteLine(
        $"结果 {i + 1}：" +
        $"Score={result.Score:F3}, " +
        $"X={x:F1}, " +
        $"Y={y:F1}, " +
        $"W={width:F1}, " +
        $"H={height:F1}, " +
        $"Angle={result.Angle:F2}°, " +
        $"Scale={result.Scale:F3}");
}
```


第1步：Matcher能成功

evision sample code
```c#=
// This section contains the variable declarations

using Euresys.Open_eVision_23_12;

using namespace std;
EMatcher EMatcher1 = new EMatcher(); // EMatcher instance
EImageC24 EC24Image1 = new EImageC24(); // EImageC24 instance
EROIC24 EC24Image1Roi1 = new EROIC24(); // EROIC24 instance


// This section contains the operations code

try
{
    EC24Image1.Load("C:\\Users\\Public\\Documents\\Euresys\\Open eVision 23.12\\Sample Images\\EasyMatch\\BOARD.JPG");
  // Attach the roi to its parent
    EC24Image1Roi1.Attach(EC24Image1);
    EC24Image1Roi1.SetPlacement(174, 375, 75, 49);
    EMatcher1.MaxScale = 1.00f;
    EMatcher1.MinScale = 1.00f;
    EMatcher1.LearnPattern(EC24Image1Roi1);
    EMatcher1.Save("C:\\Users\\Public\\Documents\\Euresys\\Open eVision 23.12\\Sample Images\\1.MCH");
    EMatcher1.MaxPositions = 10;
    EMatcher1.MinScore = 0.50f;
    EMatcher1.Match(EC24Image1);
}
catch(EException)
{
  // Insert exception handling code here
}

```



# 005 26.2.4 learn/match basic frame
---
https://chatgpt.com/s/cx_6a8c0549095c819182e002474d0304db 即时预览 PicROI挡住画面 debug

放checkbox做flag
```C#=
if (!checkBoxLiveViewROI1.Checked) return;
```
暂存核心代码
```C#=
string tempPath = Path.Combine(Path.GetTempPath(), "camera_frame.bmp");
```
Path.GetDirectoryName(filepath)` 会取出文件所在的资料夹路径。 
```
string folderPath = Path.GetDirectoryName(filepath);
```



---
重点- 
```
bitmap
```



# 004 evision rectangle drag ,resize, crop & show picture box 
---
重点- learn& match pattern 看easyMatch


```
注意pylon evision版本 dll容错
```
全部使用相同的 `zoom`、`pan`。Open eVision 官方也明确要求三者参数必须一致，而且 `pan` 是先套用、再进行缩放
pictureBox zoom debug
```c#=
PictureBox Zoom
├─ zoom = Min(PictureBox宽 / 图片宽,
│            PictureBox高 / 图片高)
│
├─ offsetX、offsetY = 图片居中的留白
│
└─ pan = offset / zoom
```
除错小技巧
```
 Debug.WriteLine($"{x} {y} {w} {h} ");
 Console.WriteLine($"{x} {y} {w} {h} ");
 solution -> class -> properties -> output type 要换 Console Application
```
code dialog
```C#=
//function
public static string SaveCroppedImage(EImageC24 finalImage)
{
        string savedFilePath = saveDialog.FileName;
        return savedFilePath;
    }
            
}
//function调用function
public static string Crop(string filepath,int x,int y,int w,int h)
{
    int cropX = x;
    int cropY = y;
    int cropWidth = w;
    int cropHeight = h;
    // 6. 保存独立裁切结果
    //finalImage.Save(@"D:\dev\opus-Viewer\assets\CroppedResult.bmp");
    return SaveCroppedImage(finalImage);
}
//mainform调用
string saveFilePath = ImageProcessing.Crop(currentImagePath,x,y,w,h);
picBoxROI.Image = Image.FromFile(saveFilePath);
```




重点
```
DrawFrame
= 畫出 EROIC24 邊框與控制點

HitTest
= 判斷滑鼠抓到哪個控制點

EDragHandle
= 儲存抓到的控制點種類

Drag
= 根據控制點移動或縮放 ROI

Invalidate / Redraw
= ROI 改變後要求畫面重新繪製
```
笔记一行文- 
```
画图工具
└─ EWindowsDrawAdapter
   └─ 把 Open eVision 图形画到 WinForms 画面

可被画出来的对象
├─ EBaseROI.DrawFrame
│  └─ 画 EROIC24 外框与控制点
├─ ERectangleShape.Draw
└─ ERectangleRegion.Draw

鼠标互动
├─ HitTest
│  └─ 判断鼠标碰到 ROI 哪个位置
├─ EDragHandle
│  └─ 保存 HitTest 的结果
└─ Drag
   └─ 根据 EDragHandle 移动或缩放 ROI

画面更新
└─ Redraw / PictureBox.Invalidate()
   └─ ROI 改变后要求画面重新绘制
```
core crop evision code
```
EROIBW8 myRoi = new EROIBW8();
// 绑定母图并设置初始位置
myRoi.Attach(parentImage, 1200, 1000, 500, 500);
```
resize or drag后才需要这功能 (combo set)
```
// 用户拖动或调整后，更新 ROI 
myRoi.SetPlacement(1500, 1200, 600, 600);
// 防止 ROI 超出母图
myRoi.CropToImage();
```
output
```
// 真正复制为独立图像
EImageBW8 croppedImage = new EImageBW8();
croppedImage.SetSize(myRoi.Width, myRoi.Height);
EasyImage.Copy(myRoi, croppedImage);
```
extra output 灰图 这句
```
// 对 ROI 做形态学梯度处理，将物体边缘强化，并把结果输出到 gradientImage
// 参数 1、1 代表使用 3×3 的矩形结构元素
EROIBW8 myRoi = new EROIBW8();
myRoi.Attach(parentImage, 100, 100, 500, 500);
myRoi.CropToImage();

EImageBW8 gradientImage = new EImageBW8(myRoi.Width, myRoi.Height);
EasyImage.MorphoGradientBox(
    myRoi,
    gradientImage,
    1,
    1);
    EImageBW8 backupImage = new EImageBW8(gradientImage.Width, gradientImage.Height);
    EasyImage.Copy(gradientImage, backupImage);
    
// gradientImage 已经是输出结果
gradientImage.Save(@"D:\Images\gradient.bmp");
```


# 003 evision sample code debug & code structure 重组
---
要记的重点- 
evision sample code 文件路径打开时
```
1- 安装.net 6.0, 8.0
2- 把路径改掉 Open_eVision_NetApi.dll不然报错 (用codex)
`.csproj`
<PropertyGroup>
  <OpeneVisionNetAssembly>D:/Open eVision 26.6/Bin/Open_eVision_NetApi.dll</OpeneVisionNetAssembly>
</PropertyGroup>
```
filepath 重点
```
PictureBox.Image       = 图片内容，不保证有路径
OpenFileDialog.FileName = 使用者选中的路径
currentImagePath        = 你自己保存的当前图片路径
EImageC24.Load(path)     = Open eVision 读取图片
EImageC24.Save(path)     = Open eVision 建立图片文件

```


# 002 ROI Crop & show in other Picturebox 
---
evision有这个function,add Open eVision pattern match function to project. 
要记的重点- 
```
nuget下载```NLog -Version 5.0.0

在 Visual Studio 中按以下步骤修改：
1. 右键解决方案中的 **recTest 项目**。
2. 选择 **属性**。
3. 打开 **生成** 页面。
4. 将顶部“配置”选择为 **所有配置**。
5. 把 **平台目标**从 `Any CPU` 改成 `x64`。
6. 如果有 **首选 32 位**，取消勾选。
7. 保存，然后执行：
生成 → 清理解决方案
生成 → 重新生成解决方案

```
笔记一行文- 
```
source image
crop image
output image

```
核心code
```C#=
using Euresys.Open_eVision;

class MainClass
{
    static void Main(string[] args)
    {
        try
        {
        //source
            EImageC24 imageC24 = new EImageC24();
            imageC24.Load("C:/Users/Public/Documents/Euresys/Open eVision 26.6/Sample Images/EasyMatch/BOARD.JPG");
		//roi crop x,y,width,height
            EROIC24 roiC24 = new EROIC24();
            roiC24.Attach(imageC24, 277, 138, 147, 86);
		//output
            EImageC24 outputImage = new EImageC24();
		    outputImage.SetSize(roiC24);
		    //EasyImage.MorphoGradientBox(roiC24, imgOut, 1, 1);
		    EasyImage.Copy(roiC24, outputImage);
        }
        catch (EException /*exception*/)
        {
            // Handle exceptions here
        }

        return;
    }
}
```






# 001 Rectangle ROI Control
---
https://share.google/aimode/g8s6d6Rnhnn0P9ei0 google rec test concept
https://chatgpt.com/share/6a8329ed-d000-83e8-9fb0-9ab3d158aada code review
所以你要做相機的 ROI 小紅框，核心通常就是：
```
Rectangle roiRectangle;
```
搭配：
```
Paint
MouseDown
MouseMove
MouseUp
```






# Day005
---
Today topic
---
1- pylon camera live display + control (picturebox)
2- 搜索、连接、断开相机  Start / Stop 实时显示 (button/strip)
3- width,height,exposure,gain,gamma (trackbar+label+numeric/ IntSliderUsercontrol)
4- pixel format (combobox)

Reference 
---
1- pylon sample link
	https://chatgpt.com/s/t_6a749e1e90648191ac23ccf815f7fa54

Testing & Excercise
---
1- IntSliderUserControl basic
2- label
3- TrackBar 
4- NumericUpDown
5- ComboBox
6- CheckBox
7- strip

Important Concept
---
1- listview basic
2- picturebox basic
3- menustrip / toolstrip basic

Extra Topic
---
1- auto detect usb camera list view

Comment
---
1- FPS,Exposure,Gain，gamma，ROI,control(camera parameter control)
2- Real-time Display,Real-time display with SW trigger, single frame capture(image acquisition control)
3- 影像丟到Picturebox上建議可用Invoke方式
4- 如有異常可用Try-Catch 抓取例外狀況(Exception) 並顯示在UI上,可避免程式崩潰, 以利後續分析



# Day004
---
Today topic
---
1- pylon sample code testing & controling (camera display & control)   ok
2- winform treeview    半ok
3- C# skill cs file 多份串联 concept & pratice    ok

Reference 
---
1- basler pylon 操作 
	https://youtu.be/D-pxOT573lg?si=5HU-1j_TFMLG1vK7
2- pylon all in one guide
	https://docs.baslerweb.com/pylonapi/pylon-deployment-guide

Testing & Excercise
---
1- pylon code sample function demo 相机对焦测试完成
2- CS winform 1，2互相调用完成
3- Visual Studio档案管理完成
4- 右键function (移动去定义，全部查找引用)完成
5- treeview 建立展开 完成

Important Concept
---
1- all pylon camera sample function 
2- Winform Visual Studio 小技巧提升
3- documentation参考和 Visual intellisense很重要
4- treeview .add(), expand(), addrange(), getto

Extra Topic
---
1- Enhance C# WinForm Coding skill

SOS for Solution
---
1- Backend skill Improvement的方法

Challenge
---
1- C# Winform pylon 知识量任然不足(物件导向function调用，camera 控制，winform 整合)
2- 高度依赖chatgpt

Tomorrow Topic
---
1- Demo Pylon Sample Code + 看 sdk manual 知识 了解相机控制知识
2- C# Winform做出camera live view 2.0 (camera+基本控制操作)

Comment
---
1- FPS,Exposure,Gain，gamma，ROI,control(camera parameter control)
2- Real-time Display,Real-time display with SW trigger, single frame capture(image acquisition control)
3- 影像丟到Picturebox上建議可用Invoke方式
4- 如有異常可用Try-Catch 抓取例外狀況(Exception) 並顯示在UI上,可避免程式崩潰, 以利後續分析



# day003
---
Today topic
---
1- winform camera realtime viewer + UI prototype
Reference 
---
1- chatgpt codex
2- pylon sdk sample
	file:///C:/Program%20Files/Basler/pylon/Documentation/Current/files/pylonapi/pylon-sdk-samples-manual.html
Testing & Excercise
---
1- normal visual operating + AI coding 
Important Concept
---
1- PylonLiveView  最重要，几乎完整对应你的界面需求

```
UpdateDeviceList
CameraFinder.Enumerate
OnImageGrabbed
ContinuousShot
Stop
DestroyCamera
OnConnectionLost
```

2- Grab_UsingGrabLoopThread 学习为什么不需要自己建立 while 抓图线程：
3- Grab_Strategies 基本 Live View 完成后，再学习 `OneByOne` 和 `LatestImages`：
4- ParametrizeCamera 最后才做你的 `nudExposure` 和 `nudGain`：
5- DeviceRemovalHandling 学习相机 USB 被拔掉后的处理

Extra Topic
---

SOS for Solution
---

Challenge
---
1- codex 环境配置聊天记录遗失

Tomorrow Topic
---
1- FPS,Exposure,Gain，gamma，ROI,control(camera parameter control)
2- Real-time Display,Real-time display with SW trigger, single frame capture(image acquisition control)







