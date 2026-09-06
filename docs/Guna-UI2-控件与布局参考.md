# OpenUI：Guna UI2 控件与布局技术参考

更新：2026-09-06。本版对应当前 UI.Designer.cs，替代旧版参数说明。

## 1. 文件与依赖

- .NET Framework 4.8，Windows Forms。
- NuGet：Guna.UI2.WinForms 2.0.4.8。
- UI.cs：只保留构造函数及 InitializeComponent()。
- UI.Designer.cs：控件字段、实例化、属性、父子关系与 Dispose。
- UI.resx：原有文字资源；流程树改为 Designer 中的 TreeNode，旧流程文字资源保留。
- Program.cs：Application.Run(new UI())。MainForm 不承载此次界面。

## 2. 本次调整

| 区域 | 原来 | 当前 |
| --- | --- | --- |
| 三个流程列表 | Guna2TextBox 多行文字 | 原生 TreeView，真实 TreeNode，A 区包含子节点 |
| 测量结果 | 文字模拟表格 | Guna2DataGridView，两列、六条样例记录 |
| 托盘 | 有列但缺少数据行 | 明确 RowCount、RowTemplate.Height 和只读设置 |
| 开始／停止／暂停 | 长条圆角按钮 | Guna2CircleButton + 独立 Guna2HtmlLabel |
| Process Info | 固定坐标易遮挡 | TableLayoutPanel 双栏及内部行列布局 |
| 底部流程标题 | 混在文本中 | 独立 Guna2Button 标题栏 |
| DPI | 设计器保存为 192 DPI | 坐标换算至 96 DPI 基准 |

不是所有控件都来自 Guna：已检查当前 DLL，没有 TreeView；流程区使用 WinForms TreeView，布局使用 WinForms 容器。没有用参考截图充当界面。

## 3. 控件速查

| 控件 | 实例 | 主要设置 |
| --- | --- | --- |
| Guna2Panel | stationACard、centerCard、stationBCard | Dock=Fill，BorderRadius=0 |
| Guna2Panel | centerCamera、topCamera | 深灰相机占位，非实时影像 |
| Guna2Button | stationATitle、centerTitle、centerStationBTitle | 蓝色标题条，斜体 |
| Guna2Button | statusA1 等 | 状态文字，圆点是字符，尚非独立灯控件 |
| Guna2CircleButton | startButton、stopButton、pauseButton | 36×36，BorderThickness=1，白底、符号文字 |
| Guna2HtmlLabel | startCaption、stopCaption、pauseCaption | 独立操作说明 |
| Guna2HtmlLabel | totalTimeValue、rightTimeValue | 橙色时间，AutoSize=false，Dock=Fill |
| TreeView | stationAProcess、calibrationProcess、stationBProcess | Segoe UI 8，ItemHeight=22，ShowLines=false，HideSelection=false |
| Guna2DataGridView | measureItems | Measure Items / Result 两列，列宽 Fill，只读 |
| Guna2DataGridView | trayTop、trayBottom、bTrayTop、bTrayBottom | 蓝色网格，只读，无滚动条 |
| Guna2TextBox | programLog | Multiline=true、ReadOnly=true，绿色示例日志 |
| Guna2CheckBox | showMessageCheck | 自动运行提示开关，仅外观 |
| Guna2Button | emergencyStop | 红色 STOP，仍是圆角按钮，不是原图八角形 |
| Guna2BorderlessForm | borderlessForm | 无边框辅助 |
| Guna2ControlBox | closeControlBox 等 | 关闭／最大化／最小化 |
| TableLayoutPanel | rootLayout、bodyLayout、processSplit 等 | 分区与行列布局 |
| FlowLayoutPanel | transportButtons、feedButtons、状态区 | 横向排列，操作按钮区不换行 |

## 4. 布局参数

以下是 96 DPI 设计单位，不是所有显示器上的物理像素。

| 容器 | 设置 |
| --- | --- |
| rootLayout | 顶部 62，主体占剩余空间，底部 20 |
| bodyLayout | Station A / 中间区域 / 日志 = 24% / 46% / 30% |
| centerLayout | 四列 26% / 20% / 26% / 28%；行 28、48、69%、146、31% |
| visionLayout | 四列 26% / 20% / 26% / 28% |
| centerCameraLayout | 标题 30；其余两行各 50%，下半留白 |
| topCameraLayout | 标题 30；相机／结果表各占剩余高度 50% |
| trayLayout、bTrayLayout | 标题 30、标签 18、上盘 50%、标签 18、下盘 50% |
| centerBottomLayout | 左右 46% / 54%；标题 28，树控件填满余下空间 |
| processSplit | 左右 46% / 54% |
| processLeft | 两列 37% / 63%；五行 24、26、44、20、剩余 |
| processRight | 两列 25% / 75%；四行 24、26、26、剩余 |
| stationBLayout | 日志占剩余，Load Cell 区 94 |

Process Info 使用 Controls.Add(control, column, row) 和 SetColumnSpan，最终位置由容器决定：

    this.processLeft.Controls.Add(this.totalTimeLabel, 0, 1);
    this.processLeft.Controls.Add(this.totalTimeValue, 1, 1);
    this.totalTimeValue.Dock = DockStyle.Fill;
    this.totalTimeValue.Margin = new Padding(0, 2, 0, 2);

- Dock=Fill：填满单元格。
- Margin：控件外部间距；Padding：容器内部留白。
- SetColumnSpan：跨列。
- 百分比行分配扣除固定高度后的剩余空间。
- FlowLayoutPanel 内按钮仍有固定宽度，窄窗口可能裁切，不能认为所有尺寸均已自适应。

## 5. 托盘与结果表

| 实例 | 列数 × 行数 | 行高 |
| --- | --- | --- |
| stationATrayPreview | 6 × 1 | 18 |
| trayTop、trayBottom | 6 × 4 | 42 |
| bTrayTop、bTrayBottom | 10 × 10 | 17 |

这是本版配置，格数尚未完全匹配参考图。行高固定，窗口变化后可能留白或裁切；AutoSizeColumnsMode=Fill 只负责列宽。

    this.trayTop.ReadOnly = true;
    this.trayTop.AllowUserToAddRows = false;
    this.trayTop.RowTemplate.Height = 42;
    this.trayTop.RowCount = 4;
    this.trayTop.ScrollBars = ScrollBars.None;

先创建列，再设置 RowCount。仅设置 BackgroundColor 和 Columns 不会产生数据行。

measureItems 显示 Barcode、Laser B Max、Laser A Max、SOA0 Max、SOA1 Max、SOA2 Max；Result 暂为空。两列 Fill，行高 22，表头高 20，RowHeadersVisible=false。

这些是样例内容，未连接设备。正式项目动态行应由数据绑定层提供。设计器未必会持久保存未绑定的数据行，拖动保存后应检查。

## 6. 流程树

拖入 TreeView，通过属性窗口 Nodes 集合编辑器创建节点：

    this.stationAProcess.Nodes.AddRange(new TreeNode[] {
        new TreeNode("#54 - Get PD Value After Curing", new TreeNode[] {
            new TreeNode("#1 - Get PD Value [FINISH]"),
            new TreeNode("#2 - [Scan] L2 Line X")
        })
    });

只有有子节点的条目才显示展开按钮。当前不强制展开或选中，因此打开时不会自动复现截图中的蓝色选中行。原生展开图标与原图箭头仍不同。

如果必须全 Guna，需要另行确定树形控件方案，不能把文本框称为树控件。

## 7. 设计器模仿顺序

1. 添加 UI 窗体，确认 Designer.cs 与 resx 从属于 UI.cs。
2. 安装 Guna 包，确认工具箱出现 Guna2Panel、Guna2Button 等。
3. 放 rootLayout、headerLayout、bodyLayout 和 footerLabel。
4. 设置三栏百分比，再加入各区 Panel。
5. 配置中间四列，放相机、托盘和结果表。
6. 给托盘创建列，确认样例行配置。
7. 放 TreeView，用 Nodes 编辑器创建层级。
8. 放 processSplit，再配置 processLeft/processRight。
9. 放圆形按钮与旁边文字，不把操作名称塞进圆内。
10. 最后调字体、颜色、Margin、边框，先布局比例后像素。
11. 保存、重新构建，关闭并重开 Designer，检查能否往返保存。

InitializeComponent 不应调用自定义 Build()、工厂函数、循环或业务逻辑。控件需要字段、实例、Name 和明确父容器。

当前完成构建验证及窗体离屏实例化检查，尚未完成真实 Visual Studio 的拖动—保存—重开验证。编译通过不能代替设计器检查。

## 8. 颜色与窗体

| 用途 | RGB |
| --- | --- |
| 标题蓝 | 91,164,231 |
| 托盘蓝 | 96,147,225 |
| 网格线 | 190,214,239 |
| 相机底色 | 58,58,58 |
| 时间橙 | 255,176,0 |
| 操作蓝 | 85,165,230 |
| 急停红 | 235,15,42 |

窗体：FormBorderStyle=None，WindowState=Maximized，AutoScaleMode=Dpi，AutoScaleDimensions=96×96，ClientSize=2260×960，MinimumSize=1280×720。

Windows 200% 缩放可能使设计器再次保存为 192 DPI；不要只改 AutoScaleDimensions 而不换算几何尺寸。尚未完成多 DPI 实机测试。

## 9. 尚未完全对齐的部分

- 急停不是八角形；状态灯和工具图标部分使用字符。
- 托盘格数、动态行高及留白仍需校准。
- 树节点没有默认展开／选中，原生图标不同。
- 原图第二条 Cur. Proc. 状态行尚未补齐。
- 日志是绿色静态样例，内容和密度不同。
- 顶部固定列宽、字体及窄窗口裁切仍需视觉校准。
- 没有设备逻辑，按钮不执行设备动作。

本版是控件结构与布局改进，不是逐像素完成版。
