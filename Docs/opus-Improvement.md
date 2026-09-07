
# Keywords
---
```C#=
UpdateImageZoom();
initializeROI()
```








# 001 26.2.6 openImage single/continuous shot tempfile 入口3合一改良计划
---
思路- input algorithm output拆分
解法- 把initialROI 打包出来 input/output保留

改良后 new initializeROI function
```C#=
public void initializeROI()
{
    // 建立默认 ROI，并限制尺寸不超过当前相机影像，避免小尺寸影像发生越界。
    int roiWidth = Math.Min((int)numWLearnRoi.Value, parentImage.Width);
    int roiHeight = Math.Min((int)numHLearnRoi.Value, parentImage.Height);
    // parentImage 更新后必须重新绑定 ROI，最后通知 PictureBox 重绘 ROI 框。
    learnRoi.Attach(parentImage, (int)numXLearnRoi.Value, (int)numYLearnRoi.Value, roiWidth, roiHeight);
    // 建立默认 ROI2，并限制尺寸不超过当前相机影像，避免小尺寸影像发生越界。
    int roiWidth2 = Math.Min((int)numWSearchRoi.Value, parentImage.Width);
    int roiHeight2 = Math.Min((int)numHSearchRoi.Value, parentImage.Height);
    // parentImage 更新后必须重新绑定 ROI，最后通知 PictureBox 重绘 ROI 框。
    searchRoi.Attach(parentImage);
    searchRoi.SetPlacement((int)numXSearchRoi.Value, (int)numYSearchRoi.Value, roiWidth2, roiHeight2);
    searchRoi.CropToImage();
    //Debug.WriteLine($"ROI Placement: X={myRoi.OrgX}, Y={myRoi.OrgY}, W={myRoi.Width}, H={myRoi.Height}");
    //Debug.WriteLine($"ROI2 Placement: X={myRoi2.OrgX}, Y={myRoi2.OrgY}, W={myRoi2.Width}, H={myRoi2.Height}");
}
```
改良后   single shot show grab result function
```C#=
      private void ShowGrabResult(IGrabResult grabResult, bool updateOpenVision = true)
      {
          Bitmap bitmap =
              new Bitmap(
                  grabResult.Width,
                  grabResult.Height,
                  PixelFormat.Format32bppRgb);

          BitmapData bitmapData =
              bitmap.LockBits(
                  new Rectangle(
                      0,
                      0,
                      bitmap.Width,
                      bitmap.Height),
                  ImageLockMode.WriteOnly,
                  bitmap.PixelFormat);

          _converter.OutputPixelFormat =
              PixelType.BGRA8packed;

          _converter.Convert(
              bitmapData.Scan0,
              bitmapData.Stride * bitmap.Height,
              grabResult);

          bitmap.UnlockBits(bitmapData);

          // 裁剪功能使用的是 Open eVision 的 parentImage，而不是 PictureBox 当前显示的 Bitmap。
          // 因此，相机取像完成后必须同步更新 parentImage，否则裁剪时仍会使用旧图片。
          //
          // 注意：这个“暂存 BMP 后再载入”的实现简单且适合单张拍摄；连续取像时会频繁
          // 写入硬盘。若后续需要优化连续取像，应改为在停止取像或冻结画面时才执行同步。
          //string tempPath = Path.Combine(Path.GetTempPath(), "camera_frame.bmp");
          //tempPath = Path.Combine(Path.GetTempPath(), "camera_frame.bmp");
          // Open eVision 可直接从图片文件载入，因此先保存当前相机帧，再更新裁剪来源。
          if (updateOpenVision)
          {
              tempPath = Path.Combine(Path.GetTempPath(), "camera_frame.bmp");
              bitmap.Save(tempPath, ImageFormat.Bmp);
              parentImage.Load(tempPath);
              lblImagePath.Text = tempPath;
              //algorithm initialize
              initializeROI();
          }

          // 释放旧图片
          if (picBoxCamera.Image != null)
          {
              picBoxCamera.Image.Dispose();
          }

          // 显示新图片
          picBoxCamera.Image = bitmap;
      }
```
改良前  single shot show grab result function
```C#=
tempPath = Path.Combine(Path.GetTempPath(), "camera_frame.bmp");
bitmap.Save(tempPath, ImageFormat.Bmp);
parentImage.Load(tempPath);
// 让 currentImagePath 永远代表 parentImage 当前内容。
currentImagePath = tempPath;
lblImagePath.Text = currentImagePath;
// 建立默认 ROI，并限制尺寸不超过当前相机影像，避免小尺寸影像发生越界。
int roiWidth = Math.Min((int)numWLearnRoi.Value, parentImage.Width);
int roiHeight = Math.Min((int)numHLearnRoi.Value, parentImage.Height);
// parentImage 更新后必须重新绑定 ROI，最后通知 PictureBox 重绘 ROI 框。
learnRoi.Attach(parentImage, (int)numXLearnRoi.Value, (int)numYLearnRoi.Value, roiWidth, roiHeight);
// 建立默认 ROI2，并限制尺寸不超过当前相机影像，避免小尺寸影像发生越界。
int roiWidth2 = Math.Min((int)numWSearchRoi.Value, parentImage.Width);
int roiHeight2 = Math.Min((int)numHSearchRoi.Value, parentImage.Height);
// parentImage 更新后必须重新绑定 ROI，最后通知 PictureBox 重绘 ROI 框。
//myRoi2.Attach(parentImage, 50, 300, roiWidth2, roiHeight2);
searchRoi.Attach(parentImage);
searchRoi.SetPlacement((int)numXSearchRoi.Value, (int)numYSearchRoi.Value, roiWidth2, roiHeight2);
searchRoi.CropToImage();
```
改良后   continuous shot  stop btn clicked
```C#=
       private void toolStripButtonStop_Click(object sender, EventArgs e)
       {
           #region Stop1
           //if (camera == null)
           //{
           //    return;
           //}
           //// 再停止相机抓取
           //if (camera.StreamGrabber.IsGrabbing)
           //{
           //    camera.StreamGrabber.Stop();
           //}

           //camera.StreamGrabber.ImageGrabbed -=
           //    OnImageGrabbed;
           #endregion
           #region for official
           try
           {
               // 先停止 Software Trigger 循环
               _swTriggerRunning = false;

               if (_swTriggerThread != null &&
                   _swTriggerThread != Thread.CurrentThread)
               {
                   _swTriggerThread.Join(300);
                   _swTriggerThread = null;
               }
               if (camera != null)
               {
                   camera.StreamGrabber.ImageGrabbed -= OnImageGrabbed;

                   if (camera.StreamGrabber.IsGrabbing)
                   {
                       camera.StreamGrabber.Stop();
                       // 把continuous shot last image存成bmp，方便裁剪
                       tempPath = Path.Combine(Path.GetTempPath(), "camera_frame.bmp");
                       picBoxCamera.Image.Save(tempPath, ImageFormat.Bmp);
                       //core loadfile code
                       parentImage.Load(tempPath);
                       //algorithm initialize
                       initializeROI();
                       //outut
                       lblImagePath.Text = tempPath;
                       picBoxCamera.Invalidate();
                   }
               }

             

           }
           catch (Exception ex)
           {
               Controller.ShowEx(ex);
           }
           finally
           {
               // Always allow Width and Height to be adjusted again.
               SetImageSizeControlsEnabled(true);
               //adjust shot button 
               SetShotControlsEnabled(true);
               toolStripButtonStop.Enabled = false;
           }
           #endregion
       }
```
改良前  continuous shot  stop btn clicked
```C#=
 // 把continuous shot last image存成bmp，方便裁剪
 tempPath = Path.Combine(
     Path.GetTempPath(),
     "camera_frame.bmp");
 picBoxCamera.Image.Save(tempPath, ImageFormat.Bmp);
 parentImage.Load(tempPath);
 //core 
 currentImagePath = tempPath;
 lblImagePath.Text = currentImagePath;
 // 建立默认 ROI，并限制尺寸不超过当前相机影像，避免小尺寸影像发生越界。
 int roiWidth = Math.Min((int)numWLearnRoi.Value, parentImage.Width);
 int roiHeight = Math.Min((int)numHLearnRoi.Value, parentImage.Height);
 // parentImage 更新后必须重新绑定 ROI，最后通知 PictureBox 重绘 ROI 框。
 learnRoi.Attach(parentImage, (int)numXLearnRoi.Value, (int)numYLearnRoi.Value, roiWidth, roiHeight);
 // 建立默认 ROI2，并限制尺寸不超过当前相机影像，避免小尺寸影像发生越界。
 int roiWidth2 = Math.Min((int)numWSearchRoi.Value, parentImage.Width);
 int roiHeight2 = Math.Min((int)numHSearchRoi.Value, parentImage.Height);
 // parentImage 更新后必须重新绑定 ROI，最后通知 PictureBox 重绘 ROI 框。
 searchRoi.Attach(parentImage);
 searchRoi.SetPlacement((int)numXSearchRoi.Value, (int)numYSearchRoi.Value, roiWidth2, roiHeight2);
 searchRoi.CropToImage();
 picBoxCamera.Invalidate();
 //Debug.WriteLine($"tempPath: {tempPath}");
```
改良后   openImage btnclick
```C#=
 private void toolStripBtnOpenImage_Click(object sender, EventArgs e)
{
    try
    {
        //input 
        currentImagePath = SettingFileServices.SelectImage();
        picBoxCamera.Image = Image.FromFile(currentImagePath);
        // 先载入原图，再将 ROI 依附到 parentImage。
        parentImage.Load(currentImagePath);
        //algorithm initialize
        initializeROI();
        //output
        lblImagePath.Text = currentImagePath;
        picBoxCamera.Invalidate();

    }
    catch (Exception exception)
    {
        Controller.ShowEx(exception);
    }
}
```
改良前   openImage btnclick
```C#=
filePath = SettingFileServices.SelectImage();
picBoxCamera.Image = Image.FromFile(filePath);
currentImagePath = filePath;
//Debug.WriteLine(currentImagePath);
lblImagePath.Text = currentImagePath;
// 先载入原图，再将 ROI 依附到 parentImage。
parentImage.Load(currentImagePath);
int roiWidth = Math.Min((int)numWLearnRoi.Value, parentImage.Width);
int roiHeight = Math.Min((int)numHLearnRoi.Value, parentImage.Height);
learnRoi.Attach(parentImage, (int)numXLearnRoi.Value, (int)numYLearnRoi.Value, roiWidth, roiHeight);
searchRoi.Attach(parentImage);
searchRoi.SetPlacement((int)numXSearchRoi.Value, (int)numYSearchRoi.Value, (int)numWSearchRoi.Value, (int)numHSearchRoi.Value);
searchRoi.CropToImage();
//Debug.WriteLine($"ROI Placement: X={myRoi.OrgX}, Y={myRoi.OrgY}, W={myRoi.Width}, H={myRoi.Height}");
//Debug.WriteLine($"ROI2 Placement: X={myRoi2.OrgX}, Y={myRoi2.OrgY}, W={myRoi2.Width}, H={myRoi2.Height}");

picBoxCamera.Invalidate();
```

