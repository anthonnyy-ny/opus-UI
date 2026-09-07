
# Keywords
---
```C#=
public     → 所有人都可以用
private    → 只有当前类可以用
protected  → 当前类和子类可以用
internal → 只有当前项目能访问
static   → 属于类，使用类名调用
readonly → 声明时或构造函数赋值，之后不能重新指定
?        → 允许 null
get      → 读取
set      → 随时修改
init     → 只在建立对象时修改
=>       → 一行代码的简写
virtual → 父类允许修改
override → 子类实际修改
abstract class → 不能直接 new，只能被继承
abstract method → 只有定义，没有方法内容，子类必须 override 实现
ref → 把原变量传进去，不是传副本
```




# 009 show/hide Log messages 
---
善用if-else 做打开关闭split panel
toolboxs- button, splitcontainer, richtextBox
```C#=
private void toolStripButtonLog_Click(object sender, EventArgs e)
{
    try
    {
        if (splitContainerResultLog.Panel1Collapsed)
        {
            // 恢复 Panel1
            splitContainerResultLog.Panel1Collapsed = false;
            splitContainerResultLog.Panel2Collapsed = true;
            toolStripButtonLog.Text = "Show Log Messages";
        }
        else
        {
            // Panel2 覆盖全部
            splitContainerResultLog.Panel2Collapsed = false;
            splitContainerResultLog.Panel1Collapsed = true;
            toolStripButtonLog.Text = "Hide Log Messages";
        }
    }
    catch (Exception ex)
    {
        Controller.ShowEx(ex);
    }
}
```




# 008- pictureBox invoke方式呈现
---

- 参考
	1- https://chatgpt.com/share/6a794618-0060-83e8-8c08-7ad1d5f71d3f invoke basic
	2- https://app.diagrams.net/#G1rhK2GToFFF_uH1Hpf5UEehKX0BPGBSR7#%7B%22pageId%22%3A%2297eOF1cdOC_2erIVXwYH%22%7D invoke beginvoke invokeRequired 流程图
	
keywords- CRUD, image, sizemode, invoke, beginInvoke, InvokeRequired
- `Invoke`：等 UI 执行完再继续
- `BeginInvoke`：交给 UI 后，不等，直接继续
Invoke
```C#=
        private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    labelWidth.Text = "Hello World";
                }));
            });

            thread.Start();
        }
```
beginInvoke
```C#=
        private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            #region begin invoke
            Thread thread = new Thread(() =>
            {
                BeginInvoke(new Action(() =>
                {
                    labelWidth.Text = "Hello World";
                }));
            });

            thread.Start();
            #endregion
        }
```
Invoke Required
```C#=
private void UpdateUI()
{
    if (InvokeRequired)
    {
        Invoke(new Action(UpdateUI));
        return;
    }

    label1.Text = "Hello";
}
```
1st 
BeginInvoke+ pictureBox
```C#=
        private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            #region invoke+pictureBox
            try
            {
                // 在后台线程读取图片，避免耗时的文件 I/O 阻塞 UI 线程。
                Thread thread = new Thread(() =>
                {
                    Image image = Image.FromFile(@"D:\dev\opus-Viewer\assets\ChatGPT Image 2026年5月8日 22_35_200.png");
                    // PictureBox 属于 UI 线程；通过 UpdatePictureBox 安全地切回 UI 线程更新画面。
                    UpdatePictureBox(image);
                });
                thread.Start();
                // 后台工作启动后，读取完成会由 UpdatePictureBox 更新预览。
            }
            catch (Exception exception)
            {
                ShowException(exception);
            }
            #endregion
        }
```
UpdatePictureBox调用
```C#=

        /// <summary>
        /// 安全地将图片显示到 pictureBoxCamera；若由后台线程调用，会自动切换到 UI 线程。
        /// </summary>
        private void UpdatePictureBox(Image image)
        {
            if(InvokeRequired)
            {
                // WinForms 控件只能由创建它的 UI 线程存取；后台线程调用时 InvokeRequired 为 true。
                BeginInvoke(new Action<Image>(UpdatePictureBox), image);
                // 非同步排回 UI 消息队列，随后在 UI 线程再次执行本方法。
                //Invoke(
                //    new Action<Image>(UpdatePictureBox),
                //    image);
                
                return;
            }
            // 已位于 UI 线程，可直接替换预览图片，并以等比例缩放方式显示。
            pictureBoxCamera.Image = image;
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
        } 
```




# 007 try-catch
---
try catch exception的部分用messagebox.show（呈现）
```C#=
        private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            try
            {
                // 主动制造一个测试异常
                throw new InvalidOperationException("这是 ShowException 功能测试");
            }
            catch (Exception exception)
            {
                ShowException(exception);
            }
        }
```
```C#
        #region 重复性function
        private void ShowException(Exception exception)
        {
            MessageBox.Show("Exception caught:\n" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
```












# 006 checkbox    ez
---
思路- 勾选后通常搭配button clicked 触发功能
```C#=
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Auto Exposure is enabled. Please disable it to set manual exposure time.");
            }
        }
```


# 005 pictureBox  mid
---

1- https://chatgpt.com/share/6a796a2d-3760-83ee-8486-1279d3ebf0af pictureBox basic
keywords
```
CRUD
image
sizemode
```
PictureBoxOpenImage 载入图片
```C#=
        private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            #region pictureOpenImage
            try
            {
                
                pictureBoxCamera.Image = Image.FromFile(@"D:\dev\opus-Viewer\assets\ChatGPT Image 2026年5月8日 22_35_200.png");
                pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

```
OpenFileDialog 选择图片
keywords- 
1- OpenFileDialog 文件选择器
2- openFileDialog.FileName 选择后的路径 
3- Image.FromFile(...)读取图片
```C#=
private void toolStripButtonTest_Click(object sender, EventArgs e)
{
    #region OpenFileDialog 选择图片
    try
    {
        // 创建“打开文件”对话框
        OpenFileDialog openFileDialog = new OpenFileDialog();
        // 只显示常用的图片文件格式
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
        // 设置对话框打开时默认显示的文件夹
        openFileDialog.InitialDirectory = @"D:\dev\opus-Viewer\assets";

        // 显示对话框；用户选择文件并按下“打开”后才继续
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // 根据用户选择的完整文件路径加载图片
            pictureBoxCamera.Image = Image.FromFile(openFileDialog.FileName);
            // 等比例缩放图片，避免图片变形
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
    catch (Exception ex)
    {
        // 文件损坏、格式无效或无法读取时显示错误信息
        ShowException(ex);
    }
    #endregion
}
```
Read：读取 PictureBox 当前图片
```C#=
 private void toolStripButtonTest_Click(object sender, EventArgs e)
 {
     
     #region Read：读取 PictureBox 当前图片
     try
     {
         if (pictureBoxCamera.Image == null)
         {
             MessageBox.Show("目前没有图片");
             return;
         }

         int width = pictureBoxCamera.Image.Width;
         int height = pictureBoxCamera.Image.Height;

         MessageBox.Show(
             $"Width: {width}\nHeight: {height}");
     }
     catch (Exception ex)
     {
         ShowException(ex);
     }
     #endregion
 }
```
Update：修改 PictureBox
```C#=
     private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            #region Update：修改 PictureBox
            try
            {
                pictureBoxCamera.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
            #endregion
        }
```
Delete：删除 PictureBox 图片
`Dispose()` = 释放图片资源，`= null` = PictureBox 不再指向/显示这张图片。
```C#=
        private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            #region Delete：删除 PictureBox 图片
            try
            {
                if (pictureBoxCamera.Image != null)
                {
                    pictureBoxCamera.Image.Dispose();
                    pictureBoxCamera.Image = null;
                }
            }
            catch (Exception exception)
            {
                ShowException(exception);
            }
            #endregion
        }
```


# 004 listView    mid
---
 
- 自写程式参考
	1- https://www.youtube.com/watch?v=PAk31IekYj4&t=305s listview tutorial

listview basic 显示列表   
```C#=
     private void toolStripDropDownButton1_Click(object sender, EventArgs e)
     {
         listViewCamera.View = View.Details;
         listViewCamera.FullRowSelect = true;
         listViewCamera.GridLines = true;

         listViewCamera.Columns.Add("Camera Name", 150);
         listViewCamera.Columns.Add("Serial Number", 120);
         listViewCamera.Columns.Add("Status", 80);


         ListViewItem item = new ListViewItem("Basler Camera 1");
         item.SubItems.Add("123456789");
         item.SubItems.Add("在线");

         listViewCamera.Items.Add(item);
     }
```

# 003 trackBar     ez+
---
1- https://chatgpt.com/s/t_6a789d2b0a008191ac4e7eb65c323c9c chatgpt基本操作 numericUpdown trackbar同步

Minimum, Maximum, TickFrequency,SmallChange, LargeChange
	先记住最核心三个：
```
trackBar1.Minimum
trackBar1.Maximum
trackBar1.Value
```
加一个事件：
```
trackBar1_Scroll
```
trackbar basic
```C#=
    public partial class FormCameraLiveDisplay : Form
    {
        public FormCameraLiveDisplay()
        {
            InitializeComponent();

            trackBarWidth.Minimum = 0;
            trackBarWidth.Maximum = 100;
            trackBarWidth.Value = 50;
            trackBarWidth.TickFrequency = 10;
            trackBarWidth.SmallChange = 1;
            trackBarWidth.LargeChange = 10;

            numericUpDownWidth.Minimum = 0;
            numericUpDownWidth.Maximum = 100;
            numericUpDownWidth.Value = 50;
            numericUpDownWidth.Increment = 10;
        }
                private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            numericUpDownWidth.Value = trackBarWidth.Value;
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
	        //trackBarWidth.Value = (int)numericUpDownWidth.Value;
            numericUpDownWidth.Value = (int)trackBarWidth.Value;
        }
```
tips- 先初始化trackbar数值，然后trackbar numericUpDown 数值同步




# 002 最基本 trackbar+numericUpdown Connect
---

```C#=
 public partial class FormCameraLiveDisplay : Form
    {
        public FormCameraLiveDisplay()
        {
            InitializeComponent();

            trackBar2.Minimum = 0;
            trackBar2.Maximum = 100;
            trackBar2.Value = 50;
            trackBar2.TickFrequency = 10;
            trackBar2.SmallChange = 1;
            trackBar2.LargeChange = 10;

            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 100;
            numericUpDown2.Value = 50;
            numericUpDown2.Increment = 10;
        }
 
 
 private void numericUpDown2_ValueChanged(object sender, EventArgs e)
 {
     // 让 TrackBar 跟着 NumericUpDown
     trackBar2.Value = (int)numericUpDown2.Value;
     //numericUpDown2.Value = (int)trackBar2.Value;
 }

 private void trackBar2_Scroll(object sender, EventArgs e)
 {
     // TrackBar 的值传给 NumericUpDown
     numericUpDown2.Value = trackBar2.Value;
 }
```



# 001 最基本camera open picturebox live display
---

```C#=
private void button1_Click(object sender, EventArgs e)
{
    try
    {
        camera.Open();
        //MessageBox.Show("Camera count: " + CameraFinder.Enumerate().Count);
        // 自由出图，不使用 Trigger
        camera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.Off);
        // 相机抓到图片时，要执行这个 Function
        camera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
        // 开始连续抓图
        camera.StreamGrabber.Start(GrabStrategy.LatestImages, GrabLoop.ProvidedByStreamGrabber);
        MessageBox.Show("Camera opened and grabbing started.");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }

}

private void OnImageGrabbed(object sender, ImageGrabbedEventArgs e)
{
    // ImageGrabbed 不是 UI Thread
    // 所以先切回 UI Thread
    if (InvokeRequired)
    {
        BeginInvoke(
            new EventHandler<ImageGrabbedEventArgs>(OnImageGrabbed),
            sender,
            e.Clone()
        );

        return;
    }

    try
    {
        // 取得相机抓到的这一张影像
        IGrabResult grabResult = e.GrabResult;

        // 确认抓图成功
        if (!grabResult.GrabSucceeded)
            return;

        // 建立一个 Bitmap
        Bitmap bitmap = new Bitmap(
            grabResult.Width,
            grabResult.Height,
            PixelFormat.Format32bppRgb
        );

        // 锁定 Bitmap 内存
        BitmapData bmpData = bitmap.LockBits(
            new Rectangle(
                0,
                0,
                bitmap.Width,
                bitmap.Height
            ),
            ImageLockMode.ReadWrite,
            bitmap.PixelFormat
        );

        try
        {
            // 设置输出格式
            converter.OutputPixelFormat =
                PixelType.BGRA8packed;

            // Basler Image → Bitmap
            converter.Convert(
                bmpData.Scan0,
                bmpData.Stride * bitmap.Height,
                grabResult
            );
        }
        finally
        {
            // Bitmap 使用完内存后解除锁定
            bitmap.UnlockBits(bmpData);
        }

        // 保存旧图片
        Image oldImage = pictureBox1.Image;

        // 显示最新图片
        pictureBox1.Image = bitmap;

        // 释放旧图片
        if (oldImage != null)
        {
            oldImage.Dispose();
        }
    }
    finally
    {
        // 释放我们 Clone 出来的 GrabResult
        e.DisposeGrabResultIfClone();
    }
}
```


# 特效
---
渐进
```C#=
        public FormCameraLiveDisplay()
        {
            InitializeComponent();
            #region 特效
            ////MessageBox.Show("Welcome to the Camera Live Display!");
            //Opacity = 0;
            //timerSplash.Interval = 10;
            //timerSplash.Start();
            #endregion

        }
```
timer
```C#=
       #region 特效 function
       private void timerSplash_Tick(object sender, EventArgs e)
       {
           if (Opacity < 1)
           {
               Opacity += 0.05;
           }
           else
           {
               timerSplash.Stop();
           }
       }
       #endregion
```




# 小测试
---

1- delay 10s UI仍可运行 然后才messageshow
---

```C#=
private async void button1_Click(object sender, EventArgs e)
{
    await Task.Delay(3000);

    MessageBox.Show("完成");

}
```
tips- void要加async

2 mainform 上面版本时间 文字插入
---
keywords- File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location, new DateTime(2026, 12, 31
```C#=
//写法1 用变量
DateTime releaseDate = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location);
this.Text = $"OPUS Viewer v{version?.Major}.{version?.Minor}.{version?.Build}  Release Date: {releaseDate:yyyy/MM/dd HH:mm:ss}";
//写法2 最后程序修改时间
 this.Text = $"OPUS Viewer v{version?.Major}.{version?.Minor}.{version?.Build} Release Date: {File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location):yyyy/MM/dd tt hh:mm:ss}";
//写法3 当前时间
this.Text = $"OPUS Viewer v{version?.Major}.{version?.Minor}.{version?.Build} Release Date: {DateTime.Now:yyyy/MM/dd tt hh:mm:ss}";
//写法4 加入login level 和 license expiredate
this.Text = $"OPUS Viewer v{version?.Major}.{version?.Minor}.{version?.Build} Release Date: {File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location):yyyy/MM/dd tt hh:mm:ss} Login Level: Engineer License Expired Date: {new DateTime(2026, 12, 31):yyyy/MM/dd} ";
```



控件
```C#=
form + control
button
label
textbox
radio button
checkbox
combobox
groupbox
panel
tab control
list box + list control
listView
menustrip
progressBar
datagridView
panel+flowpanel+tablepanel
```
常用method
```C#=
messageBox.Show()
messageBox Control
multiple forms
show(), showDialog()
```

