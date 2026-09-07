
# Keywords
---
```C#=
IsNullOrEmpty      → 检查 null 或 ""
IsNullOrWhiteSpace → 检查 null、"" 或只有空白
```



# 05 config selectImage function
---
InspectionSettings.cs
```C#=
public static string SelectImage()
{
    // 使用 using 確保對象在使用後正確釋放記憶體
    using (OpenFileDialog openDialog = new OpenFileDialog())
    {
        openDialog.Title = "請選擇要開啟的圖片";
        openDialog.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有檔案 (*.*)|*.*";
        openDialog.Multiselect = false;

        string path = @"D:\dev\opus-Viewer\assets";
        openDialog.InitialDirectory = Directory.Exists(path)
            ? path
            : Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        if (openDialog.ShowDialog() == DialogResult.OK)
        {
            return openDialog.FileName;//完整路径
        }
    }
    return string.Empty;

}

```
MainForm.cs
```C#=
private void toolStripBtnOpenImage_Click(object sender, EventArgs e)
{
            try
            {
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

            }
            catch (Exception exception)
            {
                Controller.ShowEx(exception);
            }

        
    
}
```



# 04 config selectXML function
---
InspectionSettings.cs
```C#=
public static string SelectXml()
{
    using (OpenFileDialog openDialog = new OpenFileDialog())
    {
        openDialog.Title = "选择设定文件";
        openDialog.Filter = "XML 文件 (*.xml)|*.xml|所有文件 (*.*)|*.*";
        openDialog.Multiselect = false;

        if(openDialog.ShowDialog() == DialogResult.OK)
        {
            return openDialog.FileName;//完整路径
        }
    }
    return string.Empty;
    
}

```
MainForm.cs
```C#=
private void ToolStripMenuItemXml_Click(object sender, EventArgs e)
{
    try
    {
        if (camera == null || !camera.IsOpen) { MessageBox.Show("Please connect camera first."); return; }

        filePath = SettingFileServices.SelectXml();
        //core loadfile code
        InspectionSettings settings = SettingFileServices.LoadXml(filePath);
        // 建议先验证三个值全部合法，再修改 UI
        ValidateSettings(settings);
        WriteControls(settings);

        MessageBox.Show("参数读取并套用成功。", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
        picBoxCamera.Invalidate();

    }
    catch (Exception ex)
    {
        Controller.ShowEx(ex);
    }
}
```



# 03 config save/load file扩展 evision
---
```
InspectionSettings.cs
    全部参数定义

SettingFileServices.cs
    SaveXMl() 
    LoadXML()

MainForm.cs
    void ReadControls() 读取xml  
    void WriteControls() xml写入UI
    SaveCurrentSettings()
    LoadCurrentSettings()
    Save/Open 按钮事件 触发save/load
```
https://chatgpt.com/s/cx_6a94f7041a108191b394ab2f17d0db95
inspectionSettings.cs
```C#=
using System;
using System.Xml.Serialization;

namespace opus_1._0_beta
{
    [XmlRoot("InspectionSettings")]
    public class InspectionSettings
    {

        //camera
        [XmlElement("Width")]
        public decimal Width { get; set; }
        [XmlElement("Height")]
        public decimal Height { get; set; }
        [XmlElement("Exposure")]
        public decimal Exposure { get; set; }
        [XmlElement("Gain")]
        public decimal Gain { get; set; }
        [XmlElement("Gamma")]
        public decimal Gamma { get; set; }
 
        //pattern learnROi
        public int PatternXLearnRoi { get; set; }
        public int PatternYLearnRoi { get; set; }
        public int PatternWidthLearnRoi { get; set; }
        public int PatternHeightLearnRoi { get; set; }

        //pattern searchROi
        public int PatternXSearchRoi { get; set; }
        public int PatternYSearchRoi { get; set; }
        public int PatternWidthSearchRoi { get; set; }
        public int PatternHeightSearchRoi { get; set; }

        //pattern Match
        public decimal MinScore { get; set; }
        public int MaxOccurrences { get; set; }

        public decimal MinAngle { get; set; }
        public decimal MaxAngle { get; set; }

        public decimal MinScale { get; set; }
        public decimal MaxScale{ get; set; }

    }


}
```
SettingFileServices.cs
```C#=
 public static InspectionSettings LoadFile(string filePath)
 {
     XmlSerializer serializer = new XmlSerializer(typeof(InspectionSettings));
     InspectionSettings settings;
     using (StreamReader reader =
            new StreamReader(filePath))
     {
         settings = serializer.Deserialize(reader) as InspectionSettings;
     }

     if (settings == null)
     {
         throw new InvalidDataException("无法读取相机配置。");
     }

     return settings;
 }
 
 public static void SaveAsFile(InspectionSettings settings)
{
        using (SaveFileDialog saveDialog = new SaveFileDialog())
        {
            saveDialog.Title = "保存相机参数";
            saveDialog.Filter = "XML 文件 (*.xml)|*.xml";
            saveDialog.DefaultExt = "xml";
            saveDialog.AddExtension = true;
            saveDialog.FileName = "InspectionSettings.xml";

        if (saveDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
            XmlSerializer serializer = new XmlSerializer(typeof(InspectionSettings));

            // 避免产生 xmlns:xsi 和 xmlns:xsd
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();

            namespaces.Add("", "");

            using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
            {
                serializer.Serialize(writer, settings, namespaces);
            }

            MessageBox.Show(
                "XML 保存成功",
                "Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
}
```
mainform.cs
```C#=
private void WriteControls(InspectionSettings settings)
{
    numWidthCamera.Value = settings.Width;
    numHeightCamera.Value = settings.Height;
    numExposureCamera.Value = settings.Exposure;
    numGainCamera.Value = settings.Gain;
    numGammaCamera.Value = settings.Gamma;

    numXLearnRoi.Value = settings.PatternXLearnRoi;
    numYLearnRoi.Value = settings.PatternYLearnRoi;
    numWLearnRoi.Value = settings.PatternWidthLearnRoi;
    numHLearnRoi.Value = settings.PatternHeightLearnRoi;

    numXSearchRoi.Value = settings.PatternXSearchRoi;
    numYSearchRoi.Value = settings.PatternYSearchRoi;
    numWSearchRoi.Value = settings.PatternWidthSearchRoi;
    numHSearchRoi.Value = settings.PatternHeightSearchRoi;

    numMinScore.Value = settings.MinScore;
    numMaxOccurrences.Value = settings.MaxOccurrences;
    numMinAngle.Value = settings.MinAngle;
    numMaxAngle.Value = settings.MaxAngle;
    numMinScale.Value = settings.MinScale;
    numMaxScale.Value = settings.MaxScale;
}
private InspectionSettings ReadControls()
{
    return new InspectionSettings
    {
        Width = numWidthCamera.Value,
        Height = numHeightCamera.Value,
        Exposure = numExposureCamera.Value,
        Gain = numGainCamera.Value,
        Gamma = numGammaCamera.Value,

        PatternXLearnRoi = (int)numXLearnRoi.Value,
        PatternYLearnRoi = (int)numYLearnRoi.Value,
        PatternWidthLearnRoi = (int)numWLearnRoi.Value,
        PatternHeightLearnRoi = (int)numHLearnRoi.Value,

        PatternXSearchRoi = (int)numXSearchRoi.Value,
        PatternYSearchRoi = (int)numYSearchRoi.Value,
        PatternWidthSearchRoi = (int)numWSearchRoi.Value,
        PatternHeightSearchRoi = (int)numHSearchRoi.Value,

        MinScore = numMinScore.Value,
        MaxOccurrences = (int)numMaxOccurrences.Value,
        MinAngle = numMinAngle.Value,
        MaxAngle = numMaxAngle.Value,
        MinScale = numMinScale.Value,
        MaxScale = numMaxScale.Value
    };
}
        private void toolStripBtnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                #region settings
                //InspectionSettings settings = new InspectionSettings
                //{
                //    Width = numWidthCamera.Value,
                //    Height = numHeightCamera.Value,
                //    Exposure = numExposureCamera.Value,
                //    Gain = numGainCamera.Value,
                //    Gamma = numGammaCamera.Value,

                //    learnPatternX = (int)numXLearnRoi.Value,
                //    learnPatternY = (int)numYLearnRoi.Value,
                //    learnPatternWidth = (int)numWLearnRoi.Value,
                //    learnPatternHeight = (int)numHLearnRoi.Value,

                //    MinScore = numMinScore.Value,
                //    MaxOccurrences = (int)numMaxOccurrences.Value,

                //    MinAngle = numMinAngle.Value,
                //    MaxAngle = numMaxAngle.Value,

                //    MinScale = numMinScale.Value,
                //    MaxScale = numMaxScale.Value
                //};
                #endregion
                SettingFileServices.SaveXml(ReadControls());
            }
            catch (Exception ex)
            {
                Controller.ShowEx(ex);
            }
        }
        private void ToolStripMenuItemOpenFile_Click(object sender, EventArgs e)
{
    try
    {
        if (camera == null || !camera.IsOpen) { MessageBox.Show("Please connect camera first."); return; }

        using (OpenFileDialog openDialog = new OpenFileDialog())
        {
            openDialog.Title = "读取相机参数";
            openDialog.Filter = "XML 文件 (*.xml)|*.xml";

            if (openDialog.ShowDialog() != DialogResult.OK) { return; }
            //core loadfile code
            InspectionSettings settings = SettingFileServices.LoadXml(openDialog.FileName);
            // 建议先验证三个值全部合法，再修改 UI
            ValidateSettings(settings);
            WriteControls(settings);
            MessageBox.Show("参数读取并套用成功。", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            picBoxCamera.Invalidate();
        }
    }
    catch (Exception ex)
    {
        Controller.ShowEx(ex);
    }
}
```








# 002 Enchance XML large file Save/Load
---
https://share.google/aimode/2wt9WWWVnaGTyIVEZ save/load google learn
codex://threads/01a013e1-e0b7-7963-bc36-bd3214c87d43   xml修改秘诀

keywords- XmlSerialization，savefiledialog, openfiledialog
```C#=
你的项目 (YourProject)
│
├── 📁 Models (专门放数据结构的文件夹)
│    └── 📄 AppConfig.cs       <-- 【第 1 步】的配置类（纯粹存参数结构）
│
├── 📁 Services (或者 Utils, 放工具类的文件夹)
│    └── 📄 ConfigManager.cs   <-- 【第 2 步】的管理器（纯粹负责 Save/Load 逻辑）
│
└── 📄 MainForm.cs             <-- 【第 3 步】你的主软件界面/主程序

```
https://chatgpt.com/share/6a846f27-bd84-83ee-b4b0-d61dedb18223  xmL解说
```C#=
MainForm UI
    │
    │ 收集需要保存的参数
    ▼
CameraSettings
    ├── 常用固定参数
    │   ├── Exposure
    │   ├── Gain
    │   ├── Gamma
    │   └── Width / Height
    │
    └── ExtraParameters
        ├── Name + Value
        ├── Name + Value
        └── 可增加很多笔
    │
    ▼
XmlSerializer
    │
    ▼
config.xml
```












# 001- 設定檔(Exposure Time, Gain, Gamma 等參數可儲存至XML, 可Save/Load
---
save
---
先写死数据看codex修代码，看draw.io
- 参考
	1- https://chatgpt.com/share/6a7e7e33-208c-83ee-95b2-8d3166fcccc9 实做

tips- dialog XML，canerasetting, xml序列化 
load
---
先写死数据看codex修代码，看draw.io
- 参考
	1- https://chatgpt.com/share/6a7e7e33-208c-83ee-95b2-8d3166fcccc9 实做

tips- dialog XML，camerasetting, xml反序列化 

按 Open File
    ↓
选择 XML
    ↓
XElement.Load()
    ↓
XmlStructure.Read()
    ↓
写入 NumericUpDown
    ↓
触发 ValueChanged
    ↓
自动写入相机