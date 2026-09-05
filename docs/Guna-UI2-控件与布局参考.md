# OpenUI：Guna UI2 控件与布局技术参考

更新日期：2026-09-06  
依据：当前项目源码。本文记录实际实现，示例用于学习和复用，不代表已逐像素还原参考图。

## 1. 项目与文件分工

| 项目 | 当前设置 |
| --- | --- |
| 应用类型 | C# Windows Forms |
| 目标框架 | .NET Framework 4.8 |
| 控件包 | Guna.UI2.WinForms 2.0.4.8 |
| 命名空间 | OpenUI |
| 启动窗体 | UI |
| 程序入口 | Program.cs 中 Application.Run(new UI()) |

源码位置（相对项目根目录）：

| 文件 | 职责 | 自己修改时 |
| --- | --- | --- |
| OpenUI/UI.cs | 窗体类、构造函数 | 将来写事件处理和业务逻辑 |
| OpenUI/UI.Designer.cs | 控件字段、初始化、属性、父子关系、Dispose | 优先通过设计器修改 |
| OpenUI/UI.resx | 窗体资源 | 图片、图标等资源交给资源管理器维护 |
| OpenUI/Program.cs | 启动应用 | 指向要展示的窗体 |
| OpenUI/OpenUI.csproj | 框架、依赖、文件关联 | 保留 Designer 和 resx 的 DependentUpon |
| OpenUI/packages.config | NuGet 包版本 | 当前固定为 2.0.4.8 |

UI.cs 保持如下结构：

```csharp
using System.Windows.Forms;

namespace OpenUI
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
    }
}
```

UI.Designer.cs 中使用相同命名空间和 partial class UI。两个文件在编译时合并成同一个类，不是两个窗体。

项目关联应为：

```xml
<Compile Include="UI.cs">
  <SubType>Form</SubType>
</Compile>
<Compile Include="UI.Designer.cs">
  <DependentUpon>UI.cs</DependentUpon>
</Compile>
<EmbeddedResource Include="UI.resx">
  <DependentUpon>UI.cs</DependentUpon>
</EmbeddedResource>
```

## 2. 控件快速索引

| 类型 | 当前实例举例 | 用途与关键设置 |
| --- | --- | --- |
| Guna2Panel | stationACard、centerCard、stationBCard | 分区容器；Dock、FillColor、BorderThickness、Padding |
| Guna2Panel | centerCamera、topCamera | 深灰色相机占位区域；目前没有图像采集功能 |
| Guna2Panel | pdPreview、processInfoPanel | PD 图表占位、运行信息容器 |
| Guna2Button | stationATitle、centerTitle、centerStationBTitle | 蓝色站点标题条；文字、填色、字号 |
| Guna2Button | centerCameraHeader、trayHeader、bTrayHeader | 分区标题、下拉/刷新外观 |
| Guna2Button | statusA1…5、centerStatus1…4、statusB1…5 | 用绿色圆点文字模拟状态；没有设备状态绑定 |
| Guna2Button | startButton、stopButton、pauseButton | 启停按钮外观；目前未接设备操作 |
| Guna2Button | loadCell1…4、emergencyStop | 数值卡片与 STOP 外观；不是安全急停实现 |
| Guna2Button | programLogTab、otherInfoTab | 标签页外观；并非真正的 TabControl |
| Guna2HtmlLabel | brandLabel、loginLabel、metricLabel | 品牌、登录信息、数值说明 |
| Guna2TextBox | stationAProcess、calibrationProcess、stationBProcess | 只读多行流程示例 |
| Guna2TextBox | programLog、measureItems | 日志示例、测量项目文本 |
| Guna2DataGridView | trayTop、trayBottom | iCSM 蓝色托盘网格 |
| Guna2DataGridView | bTrayTop、bTrayBottom | B Lens 蓝色托盘网格 |
| Guna2DataGridView | stationATrayPreview | Station A 灰色托盘预览 |
| Guna2CheckBox | showMessageCheck | 显示提示选项的外观 |
| Guna2BorderlessForm | borderlessForm | 无边框窗体组件，位于设计器组件托盘 |
| Guna2ControlBox | close/maximize/minimizeControlBox | 关闭、最大化、最小化 |
| TableLayoutPanel | rootLayout、bodyLayout、visionLayout 等 | WinForms 标准表格布局容器 |
| FlowLayoutPanel | identityLayout、headerActions、stationAStatus 等 | WinForms 标准流式排列容器 |

可见界面主要使用 Guna UI2；表格和流式布局使用 WinForms 原生容器。布局容器负责排版，内部 Guna 控件负责外观。

## 3. 布局层级：先搭容器，再放控件

```text
UI
└─ rootLayout
   ├─ headerLayout：品牌、版本、登录、菜单、窗口按钮、日志标签
   ├─ bodyLayout
   │  ├─ stationACard → stationALayout
   │  │  ├─ Station A 标题与状态
   │  │  ├─ PD / A Lens Tray 标题与预览
   │  │  └─ Station A Process 标题与流程文本
   │  ├─ centerCard → centerLayout
   │  │  ├─ Center / Station B 标题与状态
   │  │  ├─ visionLayout
   │  │  │  ├─ centerCameraLayout
   │  │  │  ├─ trayLayout
   │  │  │  ├─ topCameraLayout
   │  │  │  └─ bTrayLayout
   │  │  ├─ processInfoPanel
   │  │  └─ centerBottomLayout：Calibration / Station B Process
   │  └─ stationBCard → stationBLayout：日志与 Load Cell
   └─ footerLabel
```

注意：stationBCard、stationBLayout 名字沿用早期实现，目前实际承载的是右侧日志区域。Station B 的站点标题和状态已经放在中间区域。查找控件应同时看父子关系，不只看名字。

### 当前布局比例

| 容器 | 列设置 | 行设置（从上到下） |
| --- | --- | --- |
| rootLayout | 1 列 | 62 固定；剩余高度；20 固定 |
| bodyLayout | 24% / 46% / 30% | 主体一行 |
| headerLayout | 475 固定 / 剩余 / 570 固定 | 34 固定；剩余 |
| stationALayout | 50% / 50% | 28、48、30、34、30 固定；剩余 |
| centerLayout | 26% / 18% / 26% / 30% | 28、48 固定；62%；126 固定；38% |
| visionLayout | 26% / 18% / 26% / 30% | 四组视觉区域 |
| centerCameraLayout | 1 列 | 标题 35；画面占剩余 |
| topCameraLayout | 1 列 | 标题 35；画面 58%；测量区 42% |
| trayLayout / bTrayLayout | 1 列 | 35、18 固定；50%；18 固定；50% |
| centerBottomLayout | 46% / 54% | 两个流程区 |
| stationBLayout | 1 列 | 日志占剩余；底部 94 固定 |
| loadCellLayout | 27% / 27% / 27% / 19% | 50% / 50% |

表中的固定值是代码中的设计尺寸，不能直接等同于所有显示器上的物理像素。百分比行是在扣除固定行高度之后分配剩余空间。

### Dock、Anchor、Margin、Padding 的区别

| 属性 | 含义 | 模仿时怎么设 |
| --- | --- | --- |
| Dock = Fill | 占满父容器分配的区域 | 卡片、流程文本框、托盘网格 |
| Dock = Top / Bottom | 停靠到父容器顶部/底部 | 标题或固定底部内容 |
| Anchor | 父容器变大时，维持到指定边的距离 | 自由定位按钮或数值标签 |
| Margin | 控件外侧与邻居/单元格边缘的间距 | 表格内常用 0～4 |
| Padding | 容器内部留白 | 卡片内常用 2～8 |
| Location / Size | 相对父容器的坐标与尺寸 | 当前 Process Info 使用此方式 |

一个 TableLayoutPanel 单元格尽量只放一个直接子控件。需要“标题 + 画面 + 表格”时，先在该单元格放一个嵌套 TableLayoutPanel，再将三者分别放到不同的行。多个控件加入同一单元格可能被自动移位，之前相机标题错列就是此类问题。

跨列区域使用 ColumnSpan；例如 visionLayout 在 centerLayout 中跨 4 列。设计器中可选中控件，在属性窗格设置 ColumnSpan，而不是通过拉宽硬撑。

## 4. 常用 Guna 属性与本项目参数

### 4.1 Guna2Panel：区域与相机占位

| 用途 | FillColor | 边框与圆角 |
| --- | --- | --- |
| 卡片 | White | 边框 RGB(199,207,215)，厚度 1，圆角 4 |
| 相机 | RGB(58,58,58) | 圆角 4，外边距 4 |
| Process Info | White | 边框 RGB(195,205,215)，厚度 1 |

Guna2Panel 的主体颜色用 FillColor。BackColor 与 FillColor 不是同一概念，仿制色块时应优先检查 FillColor。

目前相机面板只是纯色控件。将来显示实时画面，需要另外接入图像显示与采集逻辑。

### 4.2 Guna2Button：按钮、标题和状态块

| 场景 | 设置 |
| --- | --- |
| 站点标题 | FillColor=RGB(91,164,231)，ForeColor=RGB(0,65,112)，Segoe UI 13 Italic，BorderRadius=0 |
| 灰色说明 | FillColor=RGB(234,234,234)，字号约 9，Italic |
| 分区标题 | 白底、蓝色/灰色文字、BorderThickness=1 |
| Start / Pause | 白底，RGB(85,165,230) 文字及边框，95×34，BorderRadius=16 |
| Stop | 白底、灰色字和边框，其余同上 |
| Load Cell | RGB(231,231,231) 底色，字号 8 Bold，BorderRadius=3 |
| STOP 外观 | RGB(235,15,42) 底色，白字，字号 10 Bold，BorderRadius=8 |
| 状态按钮 | Text 含“●”，透明填色、LimeGreen 字色、字号 7 Bold、AutoSize=true |

状态按钮的绿色是静态示例。它不会根据真空、伺服或设备通讯自动改变。

示例：在设计器拖入 Guna2Button，设置 (Name)=startButton，再配置：

```csharp
this.startButton.Text = "▶  START";
this.startButton.Size = new Size(95, 34);
this.startButton.FillColor = Color.White;
this.startButton.ForeColor = Color.FromArgb(85, 165, 230);
this.startButton.BorderColor = Color.FromArgb(85, 165, 230);
this.startButton.BorderThickness = 1;
this.startButton.BorderRadius = 16;
this.startButton.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
```

这段展示的是 Designer 的属性形式。模仿时优先在属性窗口填写，不必直接粘贴进 Designer。

### 4.3 Guna2HtmlLabel：文本、数值与背景条

关键属性：Text、Font、ForeColor、BackColor、AutoSize、TextAlignment、Size。

- 文本自然长度：AutoSize=true。
- 固定大小的数值条：AutoSize=false，并设置 Size。
- 本项目计时背景：RGB(255,176,0)，字号 9 Italic，TextAlignment=MiddleRight。
- 登录信息用 HTML 的 <br> 换行；普通多行文本框使用换行字符。
- HtmlLabel 的对齐属性是 TextAlignment；Guna2Button 使用 TextAlign，类型为 HorizontalAlignment，不能混用。

当前紧凑托盘标题已经改用 Guna2Button。之前渲染中 HtmlLabel 有文字裁切现象，模仿时应为文字留足高度，并在实际 DPI 下检查。

### 4.4 Guna2TextBox：流程、日志与测量文本

| 控件 | 关键设置 |
| --- | --- |
| stationAProcess | Multiline=true，ReadOnly=true，ScrollBars=Vertical，字号 8 |
| programLog | Multiline=true，ReadOnly=true，ScrollBars=Vertical，Consolas 7.3，绿色文字 |
| calibrationProcess / stationBProcess | Multiline=true，ReadOnly=true，蓝色边框 |
| measureItems | 多行只读，字号约 7.5，显示项目名称与 Result 示例 |

```csharp
this.programLog.Multiline = true;
this.programLog.ReadOnly = true;
this.programLog.ScrollBars = ScrollBars.Vertical;
this.programLog.FillColor = Color.White;
this.programLog.ForeColor = Color.Green;
this.programLog.Font = new Font("Consolas", 7.3F);
this.programLog.Dock = DockStyle.Fill;
```

限制：流程区是文本模拟，不是真正的可展开树；测量区也不是可绑定的结果表。日志使用统一字色，当前没有逐行错误着色。若要真实的树节点、结果数据绑定或彩色日志，需要单独实现相应功能。

### 4.5 Guna2DataGridView：托盘网格

| 实例 | 列数 × 行数 |
| --- | --- |
| stationATrayPreview | 6 × 1 |
| trayTop、trayBottom | 6 × 6 |
| bTrayTop、bTrayBottom | 10 × 7 |

蓝色托盘的关键配置：

```csharp
this.trayTop.Dock = DockStyle.Fill;
this.trayTop.BackgroundColor = Color.FromArgb(96, 147, 225);
this.trayTop.ColumnHeadersVisible = false;
this.trayTop.RowHeadersVisible = false;
this.trayTop.AllowUserToAddRows = false;
this.trayTop.ColumnCount = 6;
this.trayTop.RowCount = 6;
this.trayTop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
this.trayTop.CellBorderStyle = DataGridViewCellBorderStyle.Single;
this.trayTop.GridColor = Color.FromArgb(190, 214, 239);
this.trayTop.DefaultCellStyle.BackColor = Color.FromArgb(96, 147, 225);
this.trayTop.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 147, 225);
this.trayTop.RowsDefaultCellStyle.BackColor = Color.FromArgb(96, 147, 225);
this.trayTop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(96, 147, 225);
```

BackgroundColor 只影响空白区域，单元格颜色要通过 CellStyle 设置。交替行和选中行颜色也要覆盖，否则仍可能出现浅紫色条带。

AutoSizeColumnsMode=Fill 只负责列宽，不会自动让所有行均分表格高度。若要求整张托盘均匀铺满，需要另设行高；这属于后续布局处理。当前托盘也未统一设为 ReadOnly，若只用于展示，建议补上 ReadOnly=true 并禁止用户调整行列。

在设计器中需要可编辑的列时，可以通过“编辑列”建立具名列；样例数据行与业务数据应在运行时加载。

### 4.6 无边框窗体和窗口按钮

当前窗体参数：

```csharp
this.FormBorderStyle = FormBorderStyle.None;
this.WindowState = FormWindowState.Maximized;
this.ClientSize = new Size(1586, 799);
this.MinimumSize = new Size(1280, 720);
this.AutoScaleDimensions = new SizeF(96F, 96F);
this.AutoScaleMode = AutoScaleMode.Dpi;
```

Guna2BorderlessForm 是非可视组件，需要关联窗体：

```csharp
this.borderlessForm = new Guna2BorderlessForm(this.components);
this.borderlessForm.ContainerControl = this;
this.borderlessForm.BorderRadius = 0;
this.borderlessForm.ResizeForm = true;
this.borderlessForm.TransparentWhileDrag = true;
```

Guna2ControlBox 的枚举完整名称：

```csharp
this.minimizeControlBox.ControlBoxType =
    Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
this.maximizeControlBox.ControlBoxType =
    Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
```

关闭按钮当前使用默认类型。headerActions 是 RightToLeft，先添加的控件出现在右边，因此先添加关闭、再最大化、再最小化。

## 5. 自己从空白窗体模仿的顺序

1. 建立 Windows Forms 窗体 UI，安装项目使用的 Guna.UI2.WinForms 包。
2. 打开 UI.cs 的“查看设计器”，确认工具箱中可选取 Guna 控件。
3. 放入 rootLayout，设 Dock=Fill，建立顶部、主体、底部三行。
4. 主体放 bodyLayout，建立 24% / 46% / 30% 三列。
5. 三列分别放 Guna2Panel，设 Dock=Fill，再将内部布局容器放入面板。
6. 先完成站点标题与状态栏，再建立视觉区域的四列布局。
7. 每个相机/托盘单元格中放嵌套布局，按行分开标题、标签、画面。
8. 放入流程文本框、Process Info 控件、日志与 Load Cell。
9. 用 (Name) 给每个控件起独立名字；Text 是界面文字，不是代码名称。
10. 最后设置字体、颜色、圆角、间距与窗口按钮。
11. 保存、编译、重新打开设计器，再测试不同窗口大小与 DPI。

想移动表格内控件，应调整所在行列或父容器。若 Dock=Fill，直接拖控件边缘通常不能获得自由定位效果。需要自由排布时，在单元格内放 Panel，再在 Panel 内设置 Location。

## 6. Designer 代码的标准形态与排错

字段声明、实例化、命名、设置属性、加入父容器应成套出现：

```csharp
private Guna.UI2.WinForms.Guna2Button stationATitle;

// InitializeComponent 内：
this.stationATitle = new Guna.UI2.WinForms.Guna2Button();
this.stationATitle.Name = "stationATitle";
this.stationATitle.Text = "STATION A";
this.stationATitle.Dock = System.Windows.Forms.DockStyle.Fill;
this.stationALayout.Controls.Add(this.stationATitle, 0, 0);
```

本项目恢复后统一补充了 this. 字段引用和 Name。它们有助于明确成员关系，但不能保证所有设计器问题都由此解决。

| 症状 | 排查顺序 |
| --- | --- |
| unknown name stationATitle | 检查字段存在、类型正确、实例化早于使用、partial 类与命名空间一致、文件已纳入编译 |
| Form.Build not found | InitializeComponent 中不应调用自定义 Build 工厂来创建整个界面 |
| InitializeComponent 重复 | 检查 UI.cs 与 UI.Designer.cs 是否各定义了一份 |
| UI.cs 没有设计器入口 | 检查 SubType=Form、窗体继承 Form、Designer 的 DependentUpon |
| 打开的是空白窗体 | 检查 Program.cs 是否 Application.Run(new UI()) |
| 多个控件自动错位 | 检查是否加入同一表格单元格、RowCount/ColumnCount 与跨行跨列配置 |
| 文字裁切或 STOP 换行 | 检查控件实际尺寸、Margin、字体与 DPI |
| 编译通过但设计器打不开 | 编译与设计器反序列化是不同检查；保存文件、重新编译、关闭并重开设计器后读取具体错误 |

业务事件代码放在 UI.cs；不要在 InitializeComponent 中加入文件读取、设备连接或复杂计算。设计器可能在编辑时执行控件初始化。

## 7. 当前版本需要注意的限制

- 这是 UI 原型，启停、送料、状态灯、日志和测量数据未接设备。
- Process Info 使用固定坐标。例如左侧计时条为 (125,32)、195×24，右侧为 (435,32)、200×24；其余空间随外部容器变化，内部坐标不会自动按比例变化。
- showMessageCheck 与送料按钮位于接近的底部区域，可能挤压；模仿时建议用两列表格和独立行重新分配。
- headerLayout 两侧固定宽度合计 1045，较窄窗口下留给中间栏的空间有限。
- DPI 模式已设置，但不能据此宣称完成 200% 缩放适配。需要在实际显示器上检查字体、标题高度、按钮和最小窗口尺寸。
- Guna2Button 被用作部分标题和状态文字，可能出现按钮的悬停/焦点效果；若要求纯显示，需要进一步设置状态样式或选择标签控件。
- 当前代码仍含未加入显示层级的 stationBTitle、stationBNote 字段；显示中的 Station B 标题是 centerStationBTitle。
- 最后一次代码调整已编译通过，但没有在 Visual Studio 中完成设计器打开、拖动、保存、重开这一整套验收。

## 8. 常用配色速查

| 用途 | RGB |
| --- | --- |
| 站点标题蓝 | 91, 164, 231 |
| 托盘蓝 | 96, 147, 225 |
| 网格线 | 190, 214, 239 |
| 相机深灰 | 58, 58, 58 |
| 普通灰底 | 234, 234, 234 |
| Load Cell 灰底 | 231, 231, 231 |
| 计时橙色 | 255, 176, 0 |
| 急停红色 | 235, 15, 42 |
| 深蓝文字 | 0, 65, 112 |
| 标题灰蓝字 | 70, 92, 110 |

查阅源码时可搜索上表实例名，例如 startButton、trayTop、centerLayout。这样能直接找到字段、初始化和实际属性设置，方便逐项模仿。

