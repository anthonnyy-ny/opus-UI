using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace OpenUI
{
    partial class UI
    {
        private IContainer components = null;
        private Guna2BorderlessForm borderlessForm;
        private Guna2ControlBox closeControlBox;
        private Guna2ControlBox maximizeControlBox;
        private Guna2ControlBox minimizeControlBox;
        private TableLayoutPanel rootLayout;
        private TableLayoutPanel headerLayout;
        private FlowLayoutPanel identityLayout;
        private TableLayoutPanel bodyLayout;
        private FlowLayoutPanel menuLayout;
        private FlowLayoutPanel headerActions;
        private TableLayoutPanel logTabsLayout;
        private Guna2HtmlLabel brandLabel;
        private Guna2HtmlLabel modelLabel;
        private Guna2HtmlLabel versionLabel;
        private Guna2HtmlLabel loginLabel;
        private Guna2HtmlLabel menuLabel;
        private Guna2HtmlLabel systemLabel;
        private Guna2Button clearDispButton;
        private Guna2Button clearLoadButton;
        private Guna2Button openLogButton;
        private Guna2Button programLogTab;
        private Guna2Button otherInfoTab;
        private Guna2Panel stationACard;
        private Guna2Panel centerCard;
        private Guna2Panel stationBCard;
        private TableLayoutPanel stationALayout;
        private TableLayoutPanel centerLayout;
        private TableLayoutPanel stationBLayout;
        private Guna2Button stationATitle;
        private Guna2Button stationANote;
        private FlowLayoutPanel stationAStatus;
        private Guna2Button statusA1;
        private Guna2Button statusA2;
        private Guna2Button statusA3;
        private Guna2Button statusA4;
        private Guna2Button statusA5;
        private Guna2Button pdChartButton;
        private Guna2Button lensTrayButton;
        private TableLayoutPanel stationAPreviewLayout;
        private Guna2Panel pdPreview;
        private Guna2DataGridView stationATrayPreview;
        private Guna2Button stationAProcessHeader;
        private Guna2TextBox stationAProcess;
        private Guna2Button centerTitle;
        private Guna2Button laserValue;
        private Guna2Button centerStationBTitle;
        private Guna2Button centerStationBNote;
        private FlowLayoutPanel centerStatus;
        private Guna2Button centerStatus1;
        private Guna2Button centerStatus2;
        private Guna2Button centerStatus3;
        private Guna2Button centerStatus4;
        private TableLayoutPanel visionLayout;
        private TableLayoutPanel centerCameraLayout;
        private TableLayoutPanel topCameraLayout;
        private Guna2Button centerCameraHeader;
        private Guna2Panel centerCamera;
        private Guna2Button trayHeader;
        private TableLayoutPanel trayLayout;
        private Guna2DataGridView trayTop;
        private Guna2DataGridView trayBottom;
        private Guna2Button trayTopLabel;
        private Guna2Button trayBottomLabel;
        private Guna2Button topCameraHeader;
        private Guna2Panel topCamera;
        private Guna2TextBox measureItems;
        private TableLayoutPanel bTrayLayout;
        private Guna2Button bTrayHeader;
        private Guna2DataGridView bTrayTop;
        private Guna2DataGridView bTrayBottom;
        private Guna2Button bTrayTopLabel;
        private Guna2Button bTrayBottomLabel;
        private Guna2Panel processInfoPanel;
        private Guna2HtmlLabel processInfoTitle;
        private Guna2HtmlLabel totalTimeLabel;
        private Guna2HtmlLabel totalTimeValue;
        private Guna2HtmlLabel processInfoRightTitle;
        private Guna2HtmlLabel rightTimeLabel;
        private Guna2HtmlLabel rightTimeValue;
        private Guna2HtmlLabel currentFlowLabel;
        private Guna2HtmlLabel currentFlowValue;
        private Guna2HtmlLabel metricLabel;
        private Guna2CheckBox showMessageCheck;
        private Guna2Button stopFeedAButton;
        private Guna2Button stopFeedBButton;
        private Guna2Button startButton;
        private Guna2Button stopButton;
        private Guna2Button pauseButton;
        private TableLayoutPanel centerBottomLayout;
        private Guna2TextBox calibrationProcess;
        private Guna2TextBox stationBProcess;
        private Guna2HtmlLabel stationBTitle;
        private Guna2HtmlLabel stationBNote;
        private FlowLayoutPanel stationBStatus;
        private Guna2Button statusB1;
        private Guna2Button statusB2;
        private Guna2Button statusB3;
        private Guna2Button statusB4;
        private Guna2Button statusB5;
        private Guna2TextBox programLog;
        private TableLayoutPanel loadCellLayout;
        private Guna2Button loadCell1;
        private Guna2Button loadCell2;
        private Guna2Button loadCell3;
        private Guna2Button loadCell4;
        private Guna2Button emergencyStop;
        private Guna2HtmlLabel footerLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.closeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximizeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.identityLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.brandLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.modelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.versionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loginLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.headerActions = new System.Windows.Forms.FlowLayoutPanel();
            this.openLogButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearLoadButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearDispButton = new Guna.UI2.WinForms.Guna2Button();
            this.menuLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menuLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.systemLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logTabsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.programLogTab = new Guna.UI2.WinForms.Guna2Button();
            this.otherInfoTab = new Guna.UI2.WinForms.Guna2Button();
            this.bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.stationACard = new Guna.UI2.WinForms.Guna2Panel();
            this.stationALayout = new System.Windows.Forms.TableLayoutPanel();
            this.stationATitle = new Guna.UI2.WinForms.Guna2Button();
            this.stationANote = new Guna.UI2.WinForms.Guna2Button();
            this.stationAStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.statusA1 = new Guna.UI2.WinForms.Guna2Button();
            this.statusA2 = new Guna.UI2.WinForms.Guna2Button();
            this.statusA3 = new Guna.UI2.WinForms.Guna2Button();
            this.statusA4 = new Guna.UI2.WinForms.Guna2Button();
            this.statusA5 = new Guna.UI2.WinForms.Guna2Button();
            this.pdChartButton = new Guna.UI2.WinForms.Guna2Button();
            this.lensTrayButton = new Guna.UI2.WinForms.Guna2Button();
            this.stationAPreviewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pdPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.stationATrayPreview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationAProcessHeader = new Guna.UI2.WinForms.Guna2Button();
            this.stationAProcess = new Guna.UI2.WinForms.Guna2TextBox();
            this.centerCard = new Guna.UI2.WinForms.Guna2Panel();
            this.centerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.centerTitle = new Guna.UI2.WinForms.Guna2Button();
            this.laserValue = new Guna.UI2.WinForms.Guna2Button();
            this.centerStationBTitle = new Guna.UI2.WinForms.Guna2Button();
            this.centerStationBNote = new Guna.UI2.WinForms.Guna2Button();
            this.centerStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.centerStatus1 = new Guna.UI2.WinForms.Guna2Button();
            this.centerStatus2 = new Guna.UI2.WinForms.Guna2Button();
            this.centerStatus3 = new Guna.UI2.WinForms.Guna2Button();
            this.centerStatus4 = new Guna.UI2.WinForms.Guna2Button();
            this.stationBStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.statusB1 = new Guna.UI2.WinForms.Guna2Button();
            this.statusB2 = new Guna.UI2.WinForms.Guna2Button();
            this.statusB3 = new Guna.UI2.WinForms.Guna2Button();
            this.statusB4 = new Guna.UI2.WinForms.Guna2Button();
            this.statusB5 = new Guna.UI2.WinForms.Guna2Button();
            this.visionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.centerCameraLayout = new System.Windows.Forms.TableLayoutPanel();
            this.centerCameraHeader = new Guna.UI2.WinForms.Guna2Button();
            this.centerCamera = new Guna.UI2.WinForms.Guna2Panel();
            this.trayLayout = new System.Windows.Forms.TableLayoutPanel();
            this.trayHeader = new Guna.UI2.WinForms.Guna2Button();
            this.trayTopLabel = new Guna.UI2.WinForms.Guna2Button();
            this.trayTop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trayBottomLabel = new Guna.UI2.WinForms.Guna2Button();
            this.trayBottom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topCameraLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topCameraHeader = new Guna.UI2.WinForms.Guna2Button();
            this.topCamera = new Guna.UI2.WinForms.Guna2Panel();
            this.measureItems = new Guna.UI2.WinForms.Guna2TextBox();
            this.bTrayLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bTrayHeader = new Guna.UI2.WinForms.Guna2Button();
            this.bTrayTopLabel = new Guna.UI2.WinForms.Guna2Button();
            this.bTrayTop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTrayBottomLabel = new Guna.UI2.WinForms.Guna2Button();
            this.bTrayBottom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.processInfoTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalTimeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalTimeValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.processInfoRightTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rightTimeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rightTimeValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.currentFlowLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.currentFlowValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.metricLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.startButton = new Guna.UI2.WinForms.Guna2Button();
            this.stopButton = new Guna.UI2.WinForms.Guna2Button();
            this.pauseButton = new Guna.UI2.WinForms.Guna2Button();
            this.showMessageCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.stopFeedAButton = new Guna.UI2.WinForms.Guna2Button();
            this.stopFeedBButton = new Guna.UI2.WinForms.Guna2Button();
            this.centerBottomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.calibrationProcess = new Guna.UI2.WinForms.Guna2TextBox();
            this.stationBProcess = new Guna.UI2.WinForms.Guna2TextBox();
            this.stationBCard = new Guna.UI2.WinForms.Guna2Panel();
            this.stationBLayout = new System.Windows.Forms.TableLayoutPanel();
            this.programLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.loadCellLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loadCell1 = new Guna.UI2.WinForms.Guna2Button();
            this.loadCell2 = new Guna.UI2.WinForms.Guna2Button();
            this.loadCell3 = new Guna.UI2.WinForms.Guna2Button();
            this.loadCell4 = new Guna.UI2.WinForms.Guna2Button();
            this.emergencyStop = new Guna.UI2.WinForms.Guna2Button();
            this.footerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.stationBTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.stationBNote = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rootLayout.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.identityLayout.SuspendLayout();
            this.headerActions.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.logTabsLayout.SuspendLayout();
            this.bodyLayout.SuspendLayout();
            this.stationACard.SuspendLayout();
            this.stationALayout.SuspendLayout();
            this.stationAStatus.SuspendLayout();
            this.stationAPreviewLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationATrayPreview)).BeginInit();
            this.centerCard.SuspendLayout();
            this.centerLayout.SuspendLayout();
            this.centerStatus.SuspendLayout();
            this.stationBStatus.SuspendLayout();
            this.visionLayout.SuspendLayout();
            this.centerCameraLayout.SuspendLayout();
            this.trayLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayBottom)).BeginInit();
            this.topCameraLayout.SuspendLayout();
            this.bTrayLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bTrayTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrayBottom)).BeginInit();
            this.processInfoPanel.SuspendLayout();
            this.centerBottomLayout.SuspendLayout();
            this.stationBCard.SuspendLayout();
            this.stationBLayout.SuspendLayout();
            this.loadCellLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessForm
            // 
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // closeControlBox
            // 
            this.closeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(148)))));
            this.closeControlBox.IconColor = System.Drawing.Color.White;
            this.closeControlBox.Location = new System.Drawing.Point(1072, 0);
            this.closeControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.closeControlBox.Name = "closeControlBox";
            this.closeControlBox.Size = new System.Drawing.Size(68, 56);
            this.closeControlBox.TabIndex = 0;
            // 
            // maximizeControlBox
            // 
            this.maximizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximizeControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(148)))));
            this.maximizeControlBox.IconColor = System.Drawing.Color.White;
            this.maximizeControlBox.Location = new System.Drawing.Point(1004, 0);
            this.maximizeControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.maximizeControlBox.Name = "maximizeControlBox";
            this.maximizeControlBox.Size = new System.Drawing.Size(68, 56);
            this.maximizeControlBox.TabIndex = 1;
            // 
            // minimizeControlBox
            // 
            this.minimizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(148)))));
            this.minimizeControlBox.IconColor = System.Drawing.Color.White;
            this.minimizeControlBox.Location = new System.Drawing.Point(936, 0);
            this.minimizeControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeControlBox.Name = "minimizeControlBox";
            this.minimizeControlBox.Size = new System.Drawing.Size(68, 56);
            this.minimizeControlBox.TabIndex = 2;
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.Controls.Add(this.headerLayout, 0, 0);
            this.rootLayout.Controls.Add(this.bodyLayout, 0, 1);
            this.rootLayout.Controls.Add(this.footerLabel, 0, 2);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Margin = new System.Windows.Forms.Padding(0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.RowCount = 3;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rootLayout.Size = new System.Drawing.Size(2910, 1598);
            this.rootLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            this.headerLayout.ColumnCount = 3;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 950F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1140F));
            this.headerLayout.Controls.Add(this.identityLayout, 0, 0);
            this.headerLayout.Controls.Add(this.loginLabel, 1, 0);
            this.headerLayout.Controls.Add(this.headerActions, 2, 0);
            this.headerLayout.Controls.Add(this.menuLayout, 0, 1);
            this.headerLayout.Controls.Add(this.systemLabel, 1, 1);
            this.headerLayout.Controls.Add(this.logTabsLayout, 2, 1);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(6, 6);
            this.headerLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.Padding = new System.Windows.Forms.Padding(16, 8, 16, 4);
            this.headerLayout.RowCount = 2;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(2898, 112);
            this.headerLayout.TabIndex = 0;
            // 
            // identityLayout
            // 
            this.identityLayout.Controls.Add(this.brandLabel);
            this.identityLayout.Controls.Add(this.modelLabel);
            this.identityLayout.Controls.Add(this.versionLabel);
            this.identityLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.identityLayout.Location = new System.Drawing.Point(16, 8);
            this.identityLayout.Margin = new System.Windows.Forms.Padding(0);
            this.identityLayout.Name = "identityLayout";
            this.identityLayout.Size = new System.Drawing.Size(950, 68);
            this.identityLayout.TabIndex = 0;
            this.identityLayout.WrapContents = false;
            // 
            // brandLabel
            // 
            this.brandLabel.BackColor = System.Drawing.Color.Transparent;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.brandLabel.Location = new System.Drawing.Point(0, 2);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(0, 2, 20, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(185, 70);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "oToPUs";
            // 
            // modelLabel
            // 
            this.modelLabel.BackColor = System.Drawing.Color.Transparent;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.modelLabel.Location = new System.Drawing.Point(225, 18);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(20, 18, 24, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(143, 39);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Nova AA-2";
            // 
            // versionLabel
            // 
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.versionLabel.Location = new System.Drawing.Point(392, 8);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(322, 27);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Ver. 1.1.0.7   Release Date: 2026/8/31";
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginLabel.ForeColor = System.Drawing.Color.Maroon;
            this.loginLabel.Location = new System.Drawing.Point(972, 14);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(764, 56);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login Level : Operator<br>License expiration date : 12/31/2026";
            this.loginLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerActions
            // 
            this.headerActions.Controls.Add(this.closeControlBox);
            this.headerActions.Controls.Add(this.maximizeControlBox);
            this.headerActions.Controls.Add(this.minimizeControlBox);
            this.headerActions.Controls.Add(this.openLogButton);
            this.headerActions.Controls.Add(this.clearLoadButton);
            this.headerActions.Controls.Add(this.clearDispButton);
            this.headerActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.headerActions.Location = new System.Drawing.Point(1742, 8);
            this.headerActions.Margin = new System.Windows.Forms.Padding(0);
            this.headerActions.Name = "headerActions";
            this.headerActions.Size = new System.Drawing.Size(1140, 68);
            this.headerActions.TabIndex = 2;
            this.headerActions.WrapContents = false;
            // 
            // openLogButton
            // 
            this.openLogButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.openLogButton.BorderRadius = 3;
            this.openLogButton.BorderThickness = 1;
            this.openLogButton.FillColor = System.Drawing.Color.White;
            this.openLogButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.openLogButton.Location = new System.Drawing.Point(750, 10);
            this.openLogButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.openLogButton.Name = "openLogButton";
            this.openLogButton.Size = new System.Drawing.Size(180, 50);
            this.openLogButton.TabIndex = 3;
            this.openLogButton.Text = "Open log File";
            // 
            // clearLoadButton
            // 
            this.clearLoadButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.clearLoadButton.BorderRadius = 3;
            this.clearLoadButton.BorderThickness = 1;
            this.clearLoadButton.FillColor = System.Drawing.Color.White;
            this.clearLoadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearLoadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.clearLoadButton.Location = new System.Drawing.Point(402, 10);
            this.clearLoadButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.clearLoadButton.Name = "clearLoadButton";
            this.clearLoadButton.Size = new System.Drawing.Size(336, 50);
            this.clearLoadButton.TabIndex = 4;
            this.clearLoadButton.Text = "Clear Loadcell Running Status";
            // 
            // clearDispButton
            // 
            this.clearDispButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.clearDispButton.BorderRadius = 3;
            this.clearDispButton.BorderThickness = 1;
            this.clearDispButton.FillColor = System.Drawing.Color.White;
            this.clearDispButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearDispButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.clearDispButton.Location = new System.Drawing.Point(74, 10);
            this.clearDispButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.clearDispButton.Name = "clearDispButton";
            this.clearDispButton.Size = new System.Drawing.Size(316, 50);
            this.clearDispButton.TabIndex = 5;
            this.clearDispButton.Text = "Clear Disp. Running Status";
            // 
            // menuLayout
            // 
            this.menuLayout.Controls.Add(this.menuLabel);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.Location = new System.Drawing.Point(16, 76);
            this.menuLayout.Margin = new System.Windows.Forms.Padding(0);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Size = new System.Drawing.Size(950, 32);
            this.menuLayout.TabIndex = 3;
            this.menuLayout.WrapContents = false;
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuLabel.Location = new System.Drawing.Point(10, 14);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(10, 14, 0, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(401, 34);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "LOGIN       CONFIG       EDITOR       SHOW LOG";
            // 
            // systemLabel
            // 
            this.systemLabel.BackColor = System.Drawing.Color.Transparent;
            this.systemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.systemLabel.ForeColor = System.Drawing.Color.Gray;
            this.systemLabel.Location = new System.Drawing.Point(972, 82);
            this.systemLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.systemLabel.Name = "systemLabel";
            this.systemLabel.Size = new System.Drawing.Size(764, 20);
            this.systemLabel.TabIndex = 4;
            this.systemLabel.Text = "●  ●  ●      EMG       CDA       LEFT       RIGHT";
            this.systemLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logTabsLayout
            // 
            this.logTabsLayout.ColumnCount = 2;
            this.logTabsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logTabsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logTabsLayout.Controls.Add(this.programLogTab, 0, 0);
            this.logTabsLayout.Controls.Add(this.otherInfoTab, 1, 0);
            this.logTabsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTabsLayout.Location = new System.Drawing.Point(1748, 82);
            this.logTabsLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logTabsLayout.Name = "logTabsLayout";
            this.logTabsLayout.Size = new System.Drawing.Size(1128, 20);
            this.logTabsLayout.TabIndex = 5;
            // 
            // programLogTab
            // 
            this.programLogTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programLogTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.programLogTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.programLogTab.ForeColor = System.Drawing.Color.Black;
            this.programLogTab.Location = new System.Drawing.Point(6, 6);
            this.programLogTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.programLogTab.Name = "programLogTab";
            this.programLogTab.Size = new System.Drawing.Size(552, 90);
            this.programLogTab.TabIndex = 0;
            this.programLogTab.Text = "Program Log";
            // 
            // otherInfoTab
            // 
            this.otherInfoTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherInfoTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.otherInfoTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.otherInfoTab.ForeColor = System.Drawing.Color.Silver;
            this.otherInfoTab.Location = new System.Drawing.Point(570, 6);
            this.otherInfoTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.otherInfoTab.Name = "otherInfoTab";
            this.otherInfoTab.Size = new System.Drawing.Size(552, 90);
            this.otherInfoTab.TabIndex = 1;
            this.otherInfoTab.Text = "Other Information";
            // 
            // bodyLayout
            // 
            this.bodyLayout.ColumnCount = 3;
            this.bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.bodyLayout.Controls.Add(this.stationACard, 0, 0);
            this.bodyLayout.Controls.Add(this.centerCard, 1, 0);
            this.bodyLayout.Controls.Add(this.stationBCard, 2, 0);
            this.bodyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyLayout.Location = new System.Drawing.Point(6, 130);
            this.bodyLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bodyLayout.Name = "bodyLayout";
            this.bodyLayout.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.bodyLayout.Size = new System.Drawing.Size(2898, 1422);
            this.bodyLayout.TabIndex = 1;
            // 
            // stationACard
            // 
            this.stationACard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(215)))));
            this.stationACard.BorderRadius = 4;
            this.stationACard.BorderThickness = 1;
            this.stationACard.Controls.Add(this.stationALayout);
            this.stationACard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationACard.FillColor = System.Drawing.Color.White;
            this.stationACard.Location = new System.Drawing.Point(16, 0);
            this.stationACard.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.stationACard.Name = "stationACard";
            this.stationACard.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stationACard.Size = new System.Drawing.Size(677, 1422);
            this.stationACard.TabIndex = 0;
            // 
            // stationALayout
            // 
            this.stationALayout.ColumnCount = 2;
            this.stationALayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stationALayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stationALayout.Controls.Add(this.stationATitle, 0, 0);
            this.stationALayout.Controls.Add(this.stationANote, 1, 0);
            this.stationALayout.Controls.Add(this.stationAStatus, 0, 1);
            this.stationALayout.Controls.Add(this.pdChartButton, 0, 2);
            this.stationALayout.Controls.Add(this.lensTrayButton, 1, 2);
            this.stationALayout.Controls.Add(this.stationAPreviewLayout, 0, 3);
            this.stationALayout.Controls.Add(this.stationAProcessHeader, 0, 4);
            this.stationALayout.Controls.Add(this.stationAProcess, 0, 5);
            this.stationALayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationALayout.Location = new System.Drawing.Point(4, 4);
            this.stationALayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationALayout.Name = "stationALayout";
            this.stationALayout.RowCount = 6;
            this.stationALayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.stationALayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.stationALayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.stationALayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.stationALayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.stationALayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stationALayout.Size = new System.Drawing.Size(669, 1414);
            this.stationALayout.TabIndex = 0;
            // 
            // stationATitle
            // 
            this.stationATitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationATitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.stationATitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.stationATitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(112)))));
            this.stationATitle.Location = new System.Drawing.Point(6, 6);
            this.stationATitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationATitle.Name = "stationATitle";
            this.stationATitle.Size = new System.Drawing.Size(322, 44);
            this.stationATitle.TabIndex = 0;
            this.stationATitle.Text = "STATION A";
            // 
            // stationANote
            // 
            this.stationANote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationANote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.stationANote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.stationANote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.stationANote.Location = new System.Drawing.Point(340, 6);
            this.stationANote.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationANote.Name = "stationANote";
            this.stationANote.Size = new System.Drawing.Size(323, 44);
            this.stationANote.TabIndex = 1;
            this.stationANote.Text = "No iCSM";
            // 
            // stationAStatus
            // 
            this.stationALayout.SetColumnSpan(this.stationAStatus, 2);
            this.stationAStatus.Controls.Add(this.statusA1);
            this.stationAStatus.Controls.Add(this.statusA2);
            this.stationAStatus.Controls.Add(this.statusA3);
            this.stationAStatus.Controls.Add(this.statusA4);
            this.stationAStatus.Controls.Add(this.statusA5);
            this.stationAStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationAStatus.Location = new System.Drawing.Point(0, 56);
            this.stationAStatus.Margin = new System.Windows.Forms.Padding(0);
            this.stationAStatus.Name = "stationAStatus";
            this.stationAStatus.Size = new System.Drawing.Size(669, 96);
            this.stationAStatus.TabIndex = 2;
            // 
            // statusA1
            // 
            this.statusA1.DefaultAutoSize = true;
            this.statusA1.FillColor = System.Drawing.Color.Transparent;
            this.statusA1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusA1.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusA1.Location = new System.Drawing.Point(6, 6);
            this.statusA1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusA1.Name = "statusA1";
            this.statusA1.Size = new System.Drawing.Size(156, 37);
            this.statusA1.TabIndex = 0;
            this.statusA1.Text = "●  SS L1_LS L1";
            // 
            // statusA2
            // 
            this.statusA2.DefaultAutoSize = true;
            this.statusA2.FillColor = System.Drawing.Color.Transparent;
            this.statusA2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusA2.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusA2.Location = new System.Drawing.Point(174, 6);
            this.statusA2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusA2.Name = "statusA2";
            this.statusA2.Size = new System.Drawing.Size(168, 37);
            this.statusA2.TabIndex = 1;
            this.statusA2.Text = "●  Left Vacuum";
            // 
            // statusA3
            // 
            this.statusA3.DefaultAutoSize = true;
            this.statusA3.FillColor = System.Drawing.Color.Transparent;
            this.statusA3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusA3.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusA3.Location = new System.Drawing.Point(354, 6);
            this.statusA3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusA3.Name = "statusA3";
            this.statusA3.Size = new System.Drawing.Size(181, 37);
            this.statusA3.TabIndex = 2;
            this.statusA3.Text = "●  Right Vacuum";
            // 
            // statusA4
            // 
            this.statusA4.DefaultAutoSize = true;
            this.statusA4.FillColor = System.Drawing.Color.Transparent;
            this.statusA4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusA4.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusA4.Location = new System.Drawing.Point(6, 55);
            this.statusA4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusA4.Name = "statusA4";
            this.statusA4.Size = new System.Drawing.Size(168, 37);
            this.statusA4.TabIndex = 3;
            this.statusA4.Text = "●  Front Curing";
            // 
            // statusA5
            // 
            this.statusA5.DefaultAutoSize = true;
            this.statusA5.FillColor = System.Drawing.Color.Transparent;
            this.statusA5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusA5.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusA5.Location = new System.Drawing.Point(186, 55);
            this.statusA5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusA5.Name = "statusA5";
            this.statusA5.Size = new System.Drawing.Size(160, 37);
            this.statusA5.TabIndex = 4;
            this.statusA5.Text = "●  Rear Curing";
            // 
            // pdChartButton
            // 
            this.pdChartButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.pdChartButton.BorderRadius = 3;
            this.pdChartButton.BorderThickness = 1;
            this.pdChartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdChartButton.FillColor = System.Drawing.Color.White;
            this.pdChartButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pdChartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.pdChartButton.Location = new System.Drawing.Point(6, 158);
            this.pdChartButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pdChartButton.Name = "pdChartButton";
            this.pdChartButton.Size = new System.Drawing.Size(322, 48);
            this.pdChartButton.TabIndex = 3;
            this.pdChartButton.Text = "PD CHART       ▼";
            // 
            // lensTrayButton
            // 
            this.lensTrayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.lensTrayButton.BorderRadius = 3;
            this.lensTrayButton.BorderThickness = 1;
            this.lensTrayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lensTrayButton.FillColor = System.Drawing.Color.White;
            this.lensTrayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lensTrayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.lensTrayButton.Location = new System.Drawing.Point(340, 158);
            this.lensTrayButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lensTrayButton.Name = "lensTrayButton";
            this.lensTrayButton.Size = new System.Drawing.Size(323, 48);
            this.lensTrayButton.TabIndex = 4;
            this.lensTrayButton.Text = "A LENS TRAY       ↻";
            // 
            // stationAPreviewLayout
            // 
            this.stationAPreviewLayout.ColumnCount = 2;
            this.stationALayout.SetColumnSpan(this.stationAPreviewLayout, 2);
            this.stationAPreviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stationAPreviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stationAPreviewLayout.Controls.Add(this.pdPreview, 0, 0);
            this.stationAPreviewLayout.Controls.Add(this.stationATrayPreview, 1, 0);
            this.stationAPreviewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationAPreviewLayout.Location = new System.Drawing.Point(6, 218);
            this.stationAPreviewLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationAPreviewLayout.Name = "stationAPreviewLayout";
            this.stationAPreviewLayout.Size = new System.Drawing.Size(657, 56);
            this.stationAPreviewLayout.TabIndex = 5;
            // 
            // pdPreview
            // 
            this.pdPreview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.pdPreview.BorderThickness = 1;
            this.pdPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdPreview.FillColor = System.Drawing.Color.White;
            this.pdPreview.Location = new System.Drawing.Point(4, 4);
            this.pdPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdPreview.Name = "pdPreview";
            this.pdPreview.Size = new System.Drawing.Size(320, 304);
            this.pdPreview.TabIndex = 0;
            // 
            // stationATrayPreview
            // 
            this.stationATrayPreview.AllowUserToAddRows = false;
            this.stationATrayPreview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stationATrayPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stationATrayPreview.ColumnHeadersHeight = 15;
            this.stationATrayPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.stationATrayPreview.ColumnHeadersVisible = false;
            this.stationATrayPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stationATrayPreview.DefaultCellStyle = dataGridViewCellStyle2;
            this.stationATrayPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationATrayPreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.stationATrayPreview.Location = new System.Drawing.Point(334, 6);
            this.stationATrayPreview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationATrayPreview.Name = "stationATrayPreview";
            this.stationATrayPreview.RowHeadersVisible = false;
            this.stationATrayPreview.RowHeadersWidth = 82;
            this.stationATrayPreview.Size = new System.Drawing.Size(317, 300);
            this.stationATrayPreview.TabIndex = 1;
            this.stationATrayPreview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.stationATrayPreview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.stationATrayPreview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationATrayPreview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.stationATrayPreview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationATrayPreview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // stationAProcessHeader
            // 
            this.stationAProcessHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.stationAProcessHeader.BorderThickness = 1;
            this.stationALayout.SetColumnSpan(this.stationAProcessHeader, 2);
            this.stationAProcessHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationAProcessHeader.FillColor = System.Drawing.Color.White;
            this.stationAProcessHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.stationAProcessHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.stationAProcessHeader.Location = new System.Drawing.Point(6, 286);
            this.stationAProcessHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationAProcessHeader.Name = "stationAProcessHeader";
            this.stationAProcessHeader.Size = new System.Drawing.Size(657, 48);
            this.stationAProcessHeader.TabIndex = 6;
            this.stationAProcessHeader.Text = "↕   Station A Process  [Process Station A 20260713]";
            this.stationAProcessHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stationAProcess
            // 
            this.stationAProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(188)))), ((int)(((byte)(200)))));
            this.stationAProcess.BorderRadius = 3;
            this.stationALayout.SetColumnSpan(this.stationAProcess, 2);
            this.stationAProcess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stationAProcess.DefaultText = resources.GetString("stationAProcess.DefaultText");
            this.stationAProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationAProcess.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.stationAProcess.Location = new System.Drawing.Point(6, 346);
            this.stationAProcess.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationAProcess.Multiline = true;
            this.stationAProcess.Name = "stationAProcess";
            this.stationAProcess.PlaceholderText = "";
            this.stationAProcess.ReadOnly = true;
            this.stationAProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stationAProcess.SelectedText = "";
            this.stationAProcess.Size = new System.Drawing.Size(657, 1062);
            this.stationAProcess.TabIndex = 7;
            // 
            // centerCard
            // 
            this.centerCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(215)))));
            this.centerCard.BorderRadius = 4;
            this.centerCard.BorderThickness = 1;
            this.centerCard.Controls.Add(this.centerLayout);
            this.centerCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerCard.FillColor = System.Drawing.Color.White;
            this.centerCard.Location = new System.Drawing.Point(703, 0);
            this.centerCard.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.centerCard.Name = "centerCard";
            this.centerCard.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.centerCard.Size = new System.Drawing.Size(1308, 1422);
            this.centerCard.TabIndex = 1;
            // 
            // centerLayout
            // 
            this.centerLayout.ColumnCount = 4;
            this.centerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.centerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.centerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.centerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.centerLayout.Controls.Add(this.centerTitle, 0, 0);
            this.centerLayout.Controls.Add(this.laserValue, 1, 0);
            this.centerLayout.Controls.Add(this.centerStationBTitle, 2, 0);
            this.centerLayout.Controls.Add(this.centerStationBNote, 3, 0);
            this.centerLayout.Controls.Add(this.centerStatus, 0, 1);
            this.centerLayout.Controls.Add(this.stationBStatus, 2, 1);
            this.centerLayout.Controls.Add(this.visionLayout, 0, 2);
            this.centerLayout.Controls.Add(this.processInfoPanel, 0, 3);
            this.centerLayout.Controls.Add(this.centerBottomLayout, 0, 4);
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(4, 4);
            this.centerLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.RowCount = 5;
            this.centerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.centerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.centerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.centerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.centerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.centerLayout.Size = new System.Drawing.Size(1300, 1414);
            this.centerLayout.TabIndex = 0;
            // 
            // centerTitle
            // 
            this.centerTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.centerTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.centerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(112)))));
            this.centerTitle.Location = new System.Drawing.Point(6, 6);
            this.centerTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerTitle.Name = "centerTitle";
            this.centerTitle.Size = new System.Drawing.Size(326, 44);
            this.centerTitle.TabIndex = 0;
            this.centerTitle.Text = "CENTER";
            // 
            // laserValue
            // 
            this.laserValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laserValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.laserValue.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.laserValue.ForeColor = System.Drawing.Color.Green;
            this.laserValue.Location = new System.Drawing.Point(344, 6);
            this.laserValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.laserValue.Name = "laserValue";
            this.laserValue.Size = new System.Drawing.Size(222, 44);
            this.laserValue.TabIndex = 1;
            this.laserValue.Text = "Laser : 0.0000";
            this.laserValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // centerStationBTitle
            // 
            this.centerStationBTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerStationBTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.centerStationBTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.centerStationBTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(112)))));
            this.centerStationBTitle.Location = new System.Drawing.Point(578, 6);
            this.centerStationBTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerStationBTitle.Name = "centerStationBTitle";
            this.centerStationBTitle.Size = new System.Drawing.Size(326, 44);
            this.centerStationBTitle.TabIndex = 2;
            this.centerStationBTitle.Text = "STATION B";
            // 
            // centerStationBNote
            // 
            this.centerStationBNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerStationBNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.centerStationBNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.centerStationBNote.ForeColor = System.Drawing.Color.White;
            this.centerStationBNote.Location = new System.Drawing.Point(916, 6);
            this.centerStationBNote.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerStationBNote.Name = "centerStationBNote";
            this.centerStationBNote.Size = new System.Drawing.Size(378, 44);
            this.centerStationBNote.TabIndex = 3;
            this.centerStationBNote.Text = "No iCSM";
            // 
            // centerStatus
            // 
            this.centerLayout.SetColumnSpan(this.centerStatus, 2);
            this.centerStatus.Controls.Add(this.centerStatus1);
            this.centerStatus.Controls.Add(this.centerStatus2);
            this.centerStatus.Controls.Add(this.centerStatus3);
            this.centerStatus.Controls.Add(this.centerStatus4);
            this.centerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerStatus.Location = new System.Drawing.Point(0, 56);
            this.centerStatus.Margin = new System.Windows.Forms.Padding(0);
            this.centerStatus.Name = "centerStatus";
            this.centerStatus.Size = new System.Drawing.Size(572, 96);
            this.centerStatus.TabIndex = 4;
            // 
            // centerStatus1
            // 
            this.centerStatus1.DefaultAutoSize = true;
            this.centerStatus1.FillColor = System.Drawing.Color.Transparent;
            this.centerStatus1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.centerStatus1.ForeColor = System.Drawing.Color.LimeGreen;
            this.centerStatus1.Location = new System.Drawing.Point(6, 6);
            this.centerStatus1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerStatus1.Name = "centerStatus1";
            this.centerStatus1.Size = new System.Drawing.Size(181, 37);
            this.centerStatus1.TabIndex = 0;
            this.centerStatus1.Text = "●  Gripper Down";
            // 
            // centerStatus2
            // 
            this.centerStatus2.DefaultAutoSize = true;
            this.centerStatus2.FillColor = System.Drawing.Color.Transparent;
            this.centerStatus2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.centerStatus2.ForeColor = System.Drawing.Color.LimeGreen;
            this.centerStatus2.Location = new System.Drawing.Point(199, 6);
            this.centerStatus2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerStatus2.Name = "centerStatus2";
            this.centerStatus2.Size = new System.Drawing.Size(176, 37);
            this.centerStatus2.TabIndex = 1;
            this.centerStatus2.Text = "●  Gripper Close";
            // 
            // centerStatus3
            // 
            this.centerStatus3.DefaultAutoSize = true;
            this.centerStatus3.FillColor = System.Drawing.Color.Transparent;
            this.centerStatus3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.centerStatus3.ForeColor = System.Drawing.Color.LimeGreen;
            this.centerStatus3.Location = new System.Drawing.Point(6, 55);
            this.centerStatus3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerStatus3.Name = "centerStatus3";
            this.centerStatus3.Size = new System.Drawing.Size(202, 37);
            this.centerStatus3.TabIndex = 2;
            this.centerStatus3.Text = "●  A Stage Vacuum";
            // 
            // centerStatus4
            // 
            this.centerStatus4.DefaultAutoSize = true;
            this.centerStatus4.FillColor = System.Drawing.Color.Transparent;
            this.centerStatus4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.centerStatus4.ForeColor = System.Drawing.Color.LimeGreen;
            this.centerStatus4.Location = new System.Drawing.Point(220, 55);
            this.centerStatus4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerStatus4.Name = "centerStatus4";
            this.centerStatus4.Size = new System.Drawing.Size(201, 37);
            this.centerStatus4.TabIndex = 3;
            this.centerStatus4.Text = "●  B Stage Vacuum";
            // 
            // stationBStatus
            // 
            this.centerLayout.SetColumnSpan(this.stationBStatus, 2);
            this.stationBStatus.Controls.Add(this.statusB1);
            this.stationBStatus.Controls.Add(this.statusB2);
            this.stationBStatus.Controls.Add(this.statusB3);
            this.stationBStatus.Controls.Add(this.statusB4);
            this.stationBStatus.Controls.Add(this.statusB5);
            this.stationBStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationBStatus.Location = new System.Drawing.Point(572, 56);
            this.stationBStatus.Margin = new System.Windows.Forms.Padding(0);
            this.stationBStatus.Name = "stationBStatus";
            this.stationBStatus.Size = new System.Drawing.Size(728, 96);
            this.stationBStatus.TabIndex = 5;
            // 
            // statusB1
            // 
            this.statusB1.DefaultAutoSize = true;
            this.statusB1.FillColor = System.Drawing.Color.Transparent;
            this.statusB1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusB1.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusB1.Location = new System.Drawing.Point(6, 6);
            this.statusB1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusB1.Name = "statusB1";
            this.statusB1.Size = new System.Drawing.Size(104, 37);
            this.statusB1.TabIndex = 0;
            this.statusB1.Text = "●  SS_L2";
            // 
            // statusB2
            // 
            this.statusB2.DefaultAutoSize = true;
            this.statusB2.FillColor = System.Drawing.Color.Transparent;
            this.statusB2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusB2.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusB2.Location = new System.Drawing.Point(122, 6);
            this.statusB2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusB2.Name = "statusB2";
            this.statusB2.Size = new System.Drawing.Size(103, 37);
            this.statusB2.TabIndex = 1;
            this.statusB2.Text = "●  LS_L2";
            // 
            // statusB3
            // 
            this.statusB3.DefaultAutoSize = true;
            this.statusB3.FillColor = System.Drawing.Color.Transparent;
            this.statusB3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusB3.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusB3.Location = new System.Drawing.Point(237, 6);
            this.statusB3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusB3.Name = "statusB3";
            this.statusB3.Size = new System.Drawing.Size(168, 37);
            this.statusB3.TabIndex = 2;
            this.statusB3.Text = "●  Left Vacuum";
            // 
            // statusB4
            // 
            this.statusB4.DefaultAutoSize = true;
            this.statusB4.FillColor = System.Drawing.Color.Transparent;
            this.statusB4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusB4.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusB4.Location = new System.Drawing.Point(417, 6);
            this.statusB4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusB4.Name = "statusB4";
            this.statusB4.Size = new System.Drawing.Size(181, 37);
            this.statusB4.TabIndex = 3;
            this.statusB4.Text = "●  Right Vacuum";
            // 
            // statusB5
            // 
            this.statusB5.DefaultAutoSize = true;
            this.statusB5.FillColor = System.Drawing.Color.Transparent;
            this.statusB5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.statusB5.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusB5.Location = new System.Drawing.Point(6, 55);
            this.statusB5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.statusB5.Name = "statusB5";
            this.statusB5.Size = new System.Drawing.Size(168, 37);
            this.statusB5.TabIndex = 4;
            this.statusB5.Text = "●  Front Curing";
            // 
            // visionLayout
            // 
            this.visionLayout.ColumnCount = 4;
            this.centerLayout.SetColumnSpan(this.visionLayout, 4);
            this.visionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.visionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.visionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.visionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.visionLayout.Controls.Add(this.centerCameraLayout, 0, 0);
            this.visionLayout.Controls.Add(this.trayLayout, 1, 0);
            this.visionLayout.Controls.Add(this.topCameraLayout, 2, 0);
            this.visionLayout.Controls.Add(this.bTrayLayout, 3, 0);
            this.visionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visionLayout.Location = new System.Drawing.Point(6, 158);
            this.visionLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.visionLayout.Name = "visionLayout";
            this.visionLayout.Size = new System.Drawing.Size(1288, 614);
            this.visionLayout.TabIndex = 6;
            // 
            // centerCameraLayout
            // 
            this.centerCameraLayout.Controls.Add(this.centerCameraHeader, 0, 0);
            this.centerCameraLayout.Controls.Add(this.centerCamera, 0, 1);
            this.centerCameraLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerCameraLayout.Location = new System.Drawing.Point(6, 6);
            this.centerCameraLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerCameraLayout.Name = "centerCameraLayout";
            this.centerCameraLayout.RowCount = 2;
            this.centerCameraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.centerCameraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerCameraLayout.Size = new System.Drawing.Size(322, 602);
            this.centerCameraLayout.TabIndex = 0;
            // 
            // centerCameraHeader
            // 
            this.centerCameraHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.centerCameraHeader.BorderThickness = 1;
            this.centerCameraHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.centerCameraHeader.FillColor = System.Drawing.Color.White;
            this.centerCameraHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.centerCameraHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.centerCameraHeader.Location = new System.Drawing.Point(6, 6);
            this.centerCameraHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerCameraHeader.Name = "centerCameraHeader";
            this.centerCameraHeader.Size = new System.Drawing.Size(404, 58);
            this.centerCameraHeader.TabIndex = 0;
            this.centerCameraHeader.Text = "CENTER CAMERA       ▼";
            // 
            // centerCamera
            // 
            this.centerCamera.BorderRadius = 4;
            this.centerCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerCamera.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.centerCamera.Location = new System.Drawing.Point(8, 78);
            this.centerCamera.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.centerCamera.Name = "centerCamera";
            this.centerCamera.Size = new System.Drawing.Size(400, 516);
            this.centerCamera.TabIndex = 1;
            // 
            // trayLayout
            // 
            this.trayLayout.Controls.Add(this.trayHeader, 0, 0);
            this.trayLayout.Controls.Add(this.trayTopLabel, 0, 1);
            this.trayLayout.Controls.Add(this.trayTop, 0, 2);
            this.trayLayout.Controls.Add(this.trayBottomLabel, 0, 3);
            this.trayLayout.Controls.Add(this.trayBottom, 0, 4);
            this.trayLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trayLayout.Location = new System.Drawing.Point(340, 6);
            this.trayLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trayLayout.Name = "trayLayout";
            this.trayLayout.RowCount = 5;
            this.trayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.trayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.trayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.trayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.trayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.trayLayout.Size = new System.Drawing.Size(219, 602);
            this.trayLayout.TabIndex = 1;
            // 
            // trayHeader
            // 
            this.trayHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.trayHeader.BorderThickness = 1;
            this.trayHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trayHeader.FillColor = System.Drawing.Color.White;
            this.trayHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trayHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.trayHeader.Location = new System.Drawing.Point(6, 6);
            this.trayHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trayHeader.Name = "trayHeader";
            this.trayHeader.Size = new System.Drawing.Size(480, 58);
            this.trayHeader.TabIndex = 0;
            this.trayHeader.Text = "iCSM TRAY       ↻";
            // 
            // trayTopLabel
            // 
            this.trayTopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trayTopLabel.FillColor = System.Drawing.Color.White;
            this.trayTopLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.trayTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.trayTopLabel.Location = new System.Drawing.Point(6, 76);
            this.trayTopLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trayTopLabel.Name = "trayTopLabel";
            this.trayTopLabel.Size = new System.Drawing.Size(480, 24);
            this.trayTopLabel.TabIndex = 1;
            this.trayTopLabel.Text = "iCSM TOP";
            // 
            // trayTop
            // 
            this.trayTop.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayTop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.trayTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayTop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trayTop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.trayTop.ColumnHeadersHeight = 15;
            this.trayTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.trayTop.ColumnHeadersVisible = false;
            this.trayTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trayTop.DefaultCellStyle = dataGridViewCellStyle5;
            this.trayTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trayTop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.trayTop.Location = new System.Drawing.Point(6, 112);
            this.trayTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trayTop.Name = "trayTop";
            this.trayTop.RowHeadersVisible = false;
            this.trayTop.RowHeadersWidth = 82;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayTop.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.trayTop.Size = new System.Drawing.Size(480, 218);
            this.trayTop.TabIndex = 2;
            this.trayTop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayTop.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayTop.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.trayTop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trayTop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayTop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.trayTop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trayTop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // trayBottomLabel
            // 
            this.trayBottomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trayBottomLabel.FillColor = System.Drawing.Color.White;
            this.trayBottomLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.trayBottomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.trayBottomLabel.Location = new System.Drawing.Point(6, 342);
            this.trayBottomLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trayBottomLabel.Name = "trayBottomLabel";
            this.trayBottomLabel.Size = new System.Drawing.Size(480, 24);
            this.trayBottomLabel.TabIndex = 3;
            this.trayBottomLabel.Text = "iCSM BOTTOM";
            // 
            // trayBottom
            // 
            this.trayBottom.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayBottom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.trayBottom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayBottom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trayBottom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.trayBottom.ColumnHeadersHeight = 15;
            this.trayBottom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.trayBottom.ColumnHeadersVisible = false;
            this.trayBottom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trayBottom.DefaultCellStyle = dataGridViewCellStyle9;
            this.trayBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trayBottom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.trayBottom.Location = new System.Drawing.Point(6, 378);
            this.trayBottom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trayBottom.Name = "trayBottom";
            this.trayBottom.RowHeadersVisible = false;
            this.trayBottom.RowHeadersWidth = 82;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayBottom.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.trayBottom.Size = new System.Drawing.Size(480, 218);
            this.trayBottom.TabIndex = 4;
            this.trayBottom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayBottom.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayBottom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.trayBottom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trayBottom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.trayBottom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.trayBottom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trayBottom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // topCameraLayout
            // 
            this.topCameraLayout.Controls.Add(this.topCameraHeader, 0, 0);
            this.topCameraLayout.Controls.Add(this.topCamera, 0, 1);
            this.topCameraLayout.Controls.Add(this.measureItems, 0, 2);
            this.topCameraLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topCameraLayout.Location = new System.Drawing.Point(571, 6);
            this.topCameraLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.topCameraLayout.Name = "topCameraLayout";
            this.topCameraLayout.RowCount = 3;
            this.topCameraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.topCameraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.topCameraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.topCameraLayout.Size = new System.Drawing.Size(322, 602);
            this.topCameraLayout.TabIndex = 2;
            // 
            // topCameraHeader
            // 
            this.topCameraHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.topCameraHeader.BorderThickness = 1;
            this.topCameraHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.topCameraHeader.FillColor = System.Drawing.Color.White;
            this.topCameraHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.topCameraHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.topCameraHeader.Location = new System.Drawing.Point(6, 6);
            this.topCameraHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.topCameraHeader.Name = "topCameraHeader";
            this.topCameraHeader.Size = new System.Drawing.Size(636, 58);
            this.topCameraHeader.TabIndex = 0;
            this.topCameraHeader.Text = "TOP VISION CAMERA       ▼";
            // 
            // topCamera
            // 
            this.topCamera.BorderRadius = 4;
            this.topCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topCamera.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.topCamera.Location = new System.Drawing.Point(8, 78);
            this.topCamera.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.topCamera.Name = "topCamera";
            this.topCamera.Size = new System.Drawing.Size(632, 292);
            this.topCamera.TabIndex = 1;
            // 
            // measureItems
            // 
            this.measureItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(188)))), ((int)(((byte)(200)))));
            this.measureItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.measureItems.DefaultText = "Measure Items                 Result\r\nBarcode\r\nLaser B Max\r\nLaser A Max\r\nSOA0 Max" +
    "\r\nSOA1 Max\r\nSOA2 Max";
            this.measureItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.measureItems.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.measureItems.Location = new System.Drawing.Point(5, 479);
            this.measureItems.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.measureItems.Multiline = true;
            this.measureItems.Name = "measureItems";
            this.measureItems.PlaceholderText = "";
            this.measureItems.ReadOnly = true;
            this.measureItems.SelectedText = "";
            this.measureItems.Size = new System.Drawing.Size(638, 118);
            this.measureItems.TabIndex = 2;
            // 
            // bTrayLayout
            // 
            this.bTrayLayout.Controls.Add(this.bTrayHeader, 0, 0);
            this.bTrayLayout.Controls.Add(this.bTrayTopLabel, 0, 1);
            this.bTrayLayout.Controls.Add(this.bTrayTop, 0, 2);
            this.bTrayLayout.Controls.Add(this.bTrayBottomLabel, 0, 3);
            this.bTrayLayout.Controls.Add(this.bTrayBottom, 0, 4);
            this.bTrayLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTrayLayout.Location = new System.Drawing.Point(905, 6);
            this.bTrayLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bTrayLayout.Name = "bTrayLayout";
            this.bTrayLayout.RowCount = 5;
            this.bTrayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.bTrayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.bTrayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bTrayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.bTrayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bTrayLayout.Size = new System.Drawing.Size(377, 602);
            this.bTrayLayout.TabIndex = 3;
            // 
            // bTrayHeader
            // 
            this.bTrayHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.bTrayHeader.BorderThickness = 1;
            this.bTrayHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTrayHeader.FillColor = System.Drawing.Color.White;
            this.bTrayHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bTrayHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.bTrayHeader.Location = new System.Drawing.Point(6, 6);
            this.bTrayHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bTrayHeader.Name = "bTrayHeader";
            this.bTrayHeader.Size = new System.Drawing.Size(480, 58);
            this.bTrayHeader.TabIndex = 0;
            this.bTrayHeader.Text = "B LENS TRAY       ↻";
            // 
            // bTrayTopLabel
            // 
            this.bTrayTopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTrayTopLabel.FillColor = System.Drawing.Color.White;
            this.bTrayTopLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.bTrayTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(85)))), ((int)(((byte)(45)))));
            this.bTrayTopLabel.Location = new System.Drawing.Point(6, 76);
            this.bTrayTopLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bTrayTopLabel.Name = "bTrayTopLabel";
            this.bTrayTopLabel.Size = new System.Drawing.Size(480, 24);
            this.bTrayTopLabel.TabIndex = 1;
            this.bTrayTopLabel.Text = "SS L2";
            // 
            // bTrayTop
            // 
            this.bTrayTop.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayTop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bTrayTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayTop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bTrayTop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bTrayTop.ColumnHeadersHeight = 15;
            this.bTrayTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bTrayTop.ColumnHeadersVisible = false;
            this.bTrayTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bTrayTop.DefaultCellStyle = dataGridViewCellStyle13;
            this.bTrayTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTrayTop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.bTrayTop.Location = new System.Drawing.Point(6, 112);
            this.bTrayTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bTrayTop.Name = "bTrayTop";
            this.bTrayTop.RowHeadersVisible = false;
            this.bTrayTop.RowHeadersWidth = 82;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayTop.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.bTrayTop.Size = new System.Drawing.Size(480, 218);
            this.bTrayTop.TabIndex = 2;
            this.bTrayTop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayTop.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayTop.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.bTrayTop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTrayTop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayTop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.bTrayTop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTrayTop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // bTrayBottomLabel
            // 
            this.bTrayBottomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTrayBottomLabel.FillColor = System.Drawing.Color.White;
            this.bTrayBottomLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.bTrayBottomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(85)))), ((int)(((byte)(45)))));
            this.bTrayBottomLabel.Location = new System.Drawing.Point(6, 342);
            this.bTrayBottomLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bTrayBottomLabel.Name = "bTrayBottomLabel";
            this.bTrayBottomLabel.Size = new System.Drawing.Size(480, 24);
            this.bTrayBottomLabel.TabIndex = 3;
            this.bTrayBottomLabel.Text = "LS L2";
            // 
            // bTrayBottom
            // 
            this.bTrayBottom.AllowUserToAddRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayBottom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.bTrayBottom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayBottom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bTrayBottom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.bTrayBottom.ColumnHeadersHeight = 15;
            this.bTrayBottom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bTrayBottom.ColumnHeadersVisible = false;
            this.bTrayBottom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bTrayBottom.DefaultCellStyle = dataGridViewCellStyle17;
            this.bTrayBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTrayBottom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.bTrayBottom.Location = new System.Drawing.Point(6, 378);
            this.bTrayBottom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bTrayBottom.Name = "bTrayBottom";
            this.bTrayBottom.RowHeadersVisible = false;
            this.bTrayBottom.RowHeadersWidth = 82;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayBottom.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.bTrayBottom.Size = new System.Drawing.Size(480, 218);
            this.bTrayBottom.TabIndex = 4;
            this.bTrayBottom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayBottom.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayBottom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(239)))));
            this.bTrayBottom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTrayBottom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            this.bTrayBottom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.bTrayBottom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTrayBottom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(225)))));
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // processInfoPanel
            // 
            this.processInfoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(205)))), ((int)(((byte)(215)))));
            this.processInfoPanel.BorderThickness = 1;
            this.centerLayout.SetColumnSpan(this.processInfoPanel, 4);
            this.processInfoPanel.Controls.Add(this.processInfoTitle);
            this.processInfoPanel.Controls.Add(this.totalTimeLabel);
            this.processInfoPanel.Controls.Add(this.totalTimeValue);
            this.processInfoPanel.Controls.Add(this.processInfoRightTitle);
            this.processInfoPanel.Controls.Add(this.rightTimeLabel);
            this.processInfoPanel.Controls.Add(this.rightTimeValue);
            this.processInfoPanel.Controls.Add(this.currentFlowLabel);
            this.processInfoPanel.Controls.Add(this.currentFlowValue);
            this.processInfoPanel.Controls.Add(this.metricLabel);
            this.processInfoPanel.Controls.Add(this.startButton);
            this.processInfoPanel.Controls.Add(this.stopButton);
            this.processInfoPanel.Controls.Add(this.pauseButton);
            this.processInfoPanel.Controls.Add(this.showMessageCheck);
            this.processInfoPanel.Controls.Add(this.stopFeedAButton);
            this.processInfoPanel.Controls.Add(this.stopFeedBButton);
            this.processInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processInfoPanel.FillColor = System.Drawing.Color.White;
            this.processInfoPanel.Location = new System.Drawing.Point(6, 784);
            this.processInfoPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.processInfoPanel.Name = "processInfoPanel";
            this.processInfoPanel.Size = new System.Drawing.Size(1288, 240);
            this.processInfoPanel.TabIndex = 7;
            // 
            // processInfoTitle
            // 
            this.processInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.processInfoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.processInfoTitle.Location = new System.Drawing.Point(16, 14);
            this.processInfoTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.processInfoTitle.Name = "processInfoTitle";
            this.processInfoTitle.Size = new System.Drawing.Size(200, 42);
            this.processInfoTitle.TabIndex = 0;
            this.processInfoTitle.Text = "PROCESS INFO.";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.totalTimeLabel.Location = new System.Drawing.Point(16, 68);
            this.totalTimeLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(216, 34);
            this.totalTimeLabel.TabIndex = 1;
            this.totalTimeLabel.Text = "Auto Run Proc. Time";
            // 
            // totalTimeValue
            // 
            this.totalTimeValue.AutoSize = false;
            this.totalTimeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.totalTimeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.totalTimeValue.Location = new System.Drawing.Point(250, 64);
            this.totalTimeValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.totalTimeValue.Name = "totalTimeValue";
            this.totalTimeValue.Size = new System.Drawing.Size(390, 48);
            this.totalTimeValue.TabIndex = 2;
            this.totalTimeValue.Text = "000.00 sec.";
            this.totalTimeValue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // processInfoRightTitle
            // 
            this.processInfoRightTitle.BackColor = System.Drawing.Color.Transparent;
            this.processInfoRightTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.processInfoRightTitle.Location = new System.Drawing.Point(660, 14);
            this.processInfoRightTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.processInfoRightTitle.Name = "processInfoRightTitle";
            this.processInfoRightTitle.Size = new System.Drawing.Size(200, 42);
            this.processInfoRightTitle.TabIndex = 3;
            this.processInfoRightTitle.Text = "PROCESS INFO.";
            // 
            // rightTimeLabel
            // 
            this.rightTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.rightTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.rightTimeLabel.Location = new System.Drawing.Point(660, 68);
            this.rightTimeLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rightTimeLabel.Name = "rightTimeLabel";
            this.rightTimeLabel.Size = new System.Drawing.Size(173, 34);
            this.rightTimeLabel.TabIndex = 4;
            this.rightTimeLabel.Text = "Total Proc. Time";
            // 
            // rightTimeValue
            // 
            this.rightTimeValue.AutoSize = false;
            this.rightTimeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.rightTimeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.rightTimeValue.Location = new System.Drawing.Point(870, 64);
            this.rightTimeValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rightTimeValue.Name = "rightTimeValue";
            this.rightTimeValue.Size = new System.Drawing.Size(400, 48);
            this.rightTimeValue.TabIndex = 5;
            this.rightTimeValue.Text = "000.00 sec.";
            this.rightTimeValue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentFlowLabel
            // 
            this.currentFlowLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentFlowLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.currentFlowLabel.Location = new System.Drawing.Point(660, 122);
            this.currentFlowLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentFlowLabel.Name = "currentFlowLabel";
            this.currentFlowLabel.Size = new System.Drawing.Size(87, 32);
            this.currentFlowLabel.TabIndex = 6;
            this.currentFlowLabel.Text = "Cur. Flow";
            // 
            // currentFlowValue
            // 
            this.currentFlowValue.AutoSize = false;
            this.currentFlowValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.currentFlowValue.Location = new System.Drawing.Point(800, 118);
            this.currentFlowValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentFlowValue.Name = "currentFlowValue";
            this.currentFlowValue.Size = new System.Drawing.Size(470, 44);
            this.currentFlowValue.TabIndex = 7;
            this.currentFlowValue.Text = "Process Name";
            this.currentFlowValue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metricLabel
            // 
            this.metricLabel.BackColor = System.Drawing.Color.Transparent;
            this.metricLabel.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.metricLabel.ForeColor = System.Drawing.Color.Red;
            this.metricLabel.Location = new System.Drawing.Point(660, 184);
            this.metricLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metricLabel.Name = "metricLabel";
            this.metricLabel.Size = new System.Drawing.Size(352, 32);
            this.metricLabel.TabIndex = 8;
            this.metricLabel.Text = "Socket :  0.00       SOA :  0.00       Laser :  0.00";
            // 
            // startButton
            // 
            this.startButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(165)))), ((int)(((byte)(230)))));
            this.startButton.BorderRadius = 16;
            this.startButton.BorderThickness = 1;
            this.startButton.FillColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(165)))), ((int)(((byte)(230)))));
            this.startButton.Location = new System.Drawing.Point(16, 144);
            this.startButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(190, 68);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "▶  START";
            // 
            // stopButton
            // 
            this.stopButton.BorderColor = System.Drawing.Color.Gray;
            this.stopButton.BorderRadius = 16;
            this.stopButton.BorderThickness = 1;
            this.stopButton.FillColor = System.Drawing.Color.White;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.stopButton.ForeColor = System.Drawing.Color.Gray;
            this.stopButton.Location = new System.Drawing.Point(220, 144);
            this.stopButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(190, 68);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "■  STOP";
            // 
            // pauseButton
            // 
            this.pauseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(165)))), ((int)(((byte)(230)))));
            this.pauseButton.BorderRadius = 16;
            this.pauseButton.BorderThickness = 1;
            this.pauseButton.FillColor = System.Drawing.Color.White;
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.pauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(165)))), ((int)(((byte)(230)))));
            this.pauseButton.Location = new System.Drawing.Point(424, 144);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(190, 68);
            this.pauseButton.TabIndex = 11;
            this.pauseButton.Text = "Ⅱ  PAUSE";
            // 
            // showMessageCheck
            // 
            this.showMessageCheck.CheckedState.BorderRadius = 0;
            this.showMessageCheck.CheckedState.BorderThickness = 0;
            this.showMessageCheck.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.showMessageCheck.Location = new System.Drawing.Point(16, 216);
            this.showMessageCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.showMessageCheck.Name = "showMessageCheck";
            this.showMessageCheck.Size = new System.Drawing.Size(208, 48);
            this.showMessageCheck.TabIndex = 12;
            this.showMessageCheck.Text = "Show Message When Start Station On Auto Run";
            this.showMessageCheck.UncheckedState.BorderRadius = 0;
            this.showMessageCheck.UncheckedState.BorderThickness = 0;
            // 
            // stopFeedAButton
            // 
            this.stopFeedAButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.stopFeedAButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.stopFeedAButton.ForeColor = System.Drawing.Color.Gray;
            this.stopFeedAButton.Location = new System.Drawing.Point(370, 212);
            this.stopFeedAButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stopFeedAButton.Name = "stopFeedAButton";
            this.stopFeedAButton.Size = new System.Drawing.Size(350, 40);
            this.stopFeedAButton.TabIndex = 13;
            this.stopFeedAButton.Text = "STOP FEEDING STATION A";
            // 
            // stopFeedBButton
            // 
            this.stopFeedBButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.stopFeedBButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.stopFeedBButton.ForeColor = System.Drawing.Color.Gray;
            this.stopFeedBButton.Location = new System.Drawing.Point(730, 212);
            this.stopFeedBButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stopFeedBButton.Name = "stopFeedBButton";
            this.stopFeedBButton.Size = new System.Drawing.Size(350, 40);
            this.stopFeedBButton.TabIndex = 14;
            this.stopFeedBButton.Text = "STOP FEEDING STATION B";
            // 
            // centerBottomLayout
            // 
            this.centerBottomLayout.ColumnCount = 2;
            this.centerLayout.SetColumnSpan(this.centerBottomLayout, 4);
            this.centerBottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.centerBottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.centerBottomLayout.Controls.Add(this.calibrationProcess, 0, 0);
            this.centerBottomLayout.Controls.Add(this.stationBProcess, 1, 0);
            this.centerBottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerBottomLayout.Location = new System.Drawing.Point(6, 1036);
            this.centerBottomLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.centerBottomLayout.Name = "centerBottomLayout";
            this.centerBottomLayout.Size = new System.Drawing.Size(1288, 372);
            this.centerBottomLayout.TabIndex = 8;
            // 
            // calibrationProcess
            // 
            this.calibrationProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.calibrationProcess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calibrationProcess.DefaultText = resources.GetString("calibrationProcess.DefaultText");
            this.calibrationProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calibrationProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calibrationProcess.Location = new System.Drawing.Point(12, 12);
            this.calibrationProcess.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.calibrationProcess.Multiline = true;
            this.calibrationProcess.Name = "calibrationProcess";
            this.calibrationProcess.PlaceholderText = "";
            this.calibrationProcess.ReadOnly = true;
            this.calibrationProcess.SelectedText = "";
            this.calibrationProcess.Size = new System.Drawing.Size(568, 348);
            this.calibrationProcess.TabIndex = 0;
            // 
            // stationBProcess
            // 
            this.stationBProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.stationBProcess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stationBProcess.DefaultText = "STATION B PROCESS  [ATLAS L2 30-07-2026]\r\n#1 - Start Process\r\n#2 - Block pin heig" +
    "ht measurement\r\n#3 - Servo on\r\n#4 - Reset AA Counter\r\n#5 - Set Laser B Config\r\n#" +
    "6 - Vision Align Laser B iCSM";
            this.stationBProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationBProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stationBProcess.Location = new System.Drawing.Point(604, 12);
            this.stationBProcess.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.stationBProcess.Multiline = true;
            this.stationBProcess.Name = "stationBProcess";
            this.stationBProcess.PlaceholderText = "";
            this.stationBProcess.ReadOnly = true;
            this.stationBProcess.SelectedText = "";
            this.stationBProcess.Size = new System.Drawing.Size(672, 348);
            this.stationBProcess.TabIndex = 1;
            // 
            // stationBCard
            // 
            this.stationBCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(215)))));
            this.stationBCard.BorderRadius = 4;
            this.stationBCard.BorderThickness = 1;
            this.stationBCard.Controls.Add(this.stationBLayout);
            this.stationBCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationBCard.FillColor = System.Drawing.Color.White;
            this.stationBCard.Location = new System.Drawing.Point(2021, 0);
            this.stationBCard.Margin = new System.Windows.Forms.Padding(0);
            this.stationBCard.Name = "stationBCard";
            this.stationBCard.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stationBCard.Size = new System.Drawing.Size(861, 1422);
            this.stationBCard.TabIndex = 2;
            // 
            // stationBLayout
            // 
            this.stationBLayout.ColumnCount = 1;
            this.stationBLayout.Controls.Add(this.programLog, 0, 0);
            this.stationBLayout.Controls.Add(this.loadCellLayout, 0, 1);
            this.stationBLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationBLayout.Location = new System.Drawing.Point(4, 4);
            this.stationBLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stationBLayout.Name = "stationBLayout";
            this.stationBLayout.RowCount = 2;
            this.stationBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stationBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.stationBLayout.Size = new System.Drawing.Size(853, 1414);
            this.stationBLayout.TabIndex = 0;
            // 
            // programLog
            // 
            this.programLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(188)))), ((int)(((byte)(200)))));
            this.programLog.BorderRadius = 4;
            this.programLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.programLog.DefaultText = resources.GetString("programLog.DefaultText");
            this.programLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programLog.Font = new System.Drawing.Font("Consolas", 7.3F);
            this.programLog.ForeColor = System.Drawing.Color.Green;
            this.programLog.Location = new System.Drawing.Point(5, 4);
            this.programLog.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.programLog.Multiline = true;
            this.programLog.Name = "programLog";
            this.programLog.PlaceholderText = "";
            this.programLog.ReadOnly = true;
            this.programLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programLog.SelectedText = "";
            this.programLog.Size = new System.Drawing.Size(843, 1218);
            this.programLog.TabIndex = 0;
            // 
            // loadCellLayout
            // 
            this.loadCellLayout.ColumnCount = 4;
            this.loadCellLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.loadCellLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.loadCellLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.loadCellLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.loadCellLayout.Controls.Add(this.loadCell1, 0, 0);
            this.loadCellLayout.Controls.Add(this.loadCell2, 1, 0);
            this.loadCellLayout.Controls.Add(this.loadCell3, 2, 0);
            this.loadCellLayout.Controls.Add(this.loadCell4, 0, 1);
            this.loadCellLayout.Controls.Add(this.emergencyStop, 3, 0);
            this.loadCellLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCellLayout.Location = new System.Drawing.Point(6, 1232);
            this.loadCellLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadCellLayout.Name = "loadCellLayout";
            this.loadCellLayout.RowCount = 2;
            this.loadCellLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadCellLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadCellLayout.Size = new System.Drawing.Size(841, 176);
            this.loadCellLayout.TabIndex = 1;
            // 
            // loadCell1
            // 
            this.loadCell1.BorderRadius = 3;
            this.loadCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCell1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.loadCell1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.loadCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loadCell1.Location = new System.Drawing.Point(6, 6);
            this.loadCell1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadCell1.Name = "loadCell1";
            this.loadCell1.Size = new System.Drawing.Size(215, 76);
            this.loadCell1.TabIndex = 0;
            this.loadCell1.Text = "Load Cell: 000.000";
            // 
            // loadCell2
            // 
            this.loadCell2.BorderRadius = 3;
            this.loadCell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCell2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.loadCell2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.loadCell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loadCell2.Location = new System.Drawing.Point(233, 6);
            this.loadCell2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadCell2.Name = "loadCell2";
            this.loadCell2.Size = new System.Drawing.Size(215, 76);
            this.loadCell2.TabIndex = 1;
            this.loadCell2.Text = "Load Cell: Disable.";
            // 
            // loadCell3
            // 
            this.loadCell3.BorderRadius = 3;
            this.loadCell3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCell3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.loadCell3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.loadCell3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loadCell3.Location = new System.Drawing.Point(460, 6);
            this.loadCell3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadCell3.Name = "loadCell3";
            this.loadCell3.Size = new System.Drawing.Size(215, 76);
            this.loadCell3.TabIndex = 2;
            this.loadCell3.Text = "Load Cell: 000.000";
            // 
            // loadCell4
            // 
            this.loadCell4.BorderRadius = 3;
            this.loadCell4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCell4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.loadCell4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.loadCell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loadCell4.Location = new System.Drawing.Point(6, 94);
            this.loadCell4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadCell4.Name = "loadCell4";
            this.loadCell4.Size = new System.Drawing.Size(215, 76);
            this.loadCell4.TabIndex = 3;
            this.loadCell4.Text = "Load Cell: 000.000";
            // 
            // emergencyStop
            // 
            this.emergencyStop.BorderRadius = 8;
            this.emergencyStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emergencyStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(15)))), ((int)(((byte)(42)))));
            this.emergencyStop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.emergencyStop.ForeColor = System.Drawing.Color.White;
            this.emergencyStop.Location = new System.Drawing.Point(691, 10);
            this.emergencyStop.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.emergencyStop.Name = "emergencyStop";
            this.loadCellLayout.SetRowSpan(this.emergencyStop, 2);
            this.emergencyStop.Size = new System.Drawing.Size(140, 156);
            this.emergencyStop.TabIndex = 4;
            this.emergencyStop.Text = "STOP";
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = false;
            this.footerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.footerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.footerLabel.Location = new System.Drawing.Point(6, 1564);
            this.footerLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(2898, 28);
            this.footerLabel.TabIndex = 2;
            this.footerLabel.Text = "Copyright © 2024 Octopus Technology Ltd. All rights reserved";
            this.footerLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stationBTitle
            // 
            this.stationBTitle.AutoSize = false;
            this.stationBTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.stationBTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationBTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.stationBTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(112)))));
            this.stationBTitle.Location = new System.Drawing.Point(0, 0);
            this.stationBTitle.Name = "stationBTitle";
            this.stationBTitle.Size = new System.Drawing.Size(111, 26);
            this.stationBTitle.TabIndex = 0;
            this.stationBTitle.Text = "STATION B";
            this.stationBTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stationBNote
            // 
            this.stationBNote.AutoSize = false;
            this.stationBNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.stationBNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationBNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.stationBNote.Location = new System.Drawing.Point(0, 0);
            this.stationBNote.Name = "stationBNote";
            this.stationBNote.Size = new System.Drawing.Size(87, 26);
            this.stationBNote.TabIndex = 0;
            this.stationBNote.Text = "No iCSM";
            this.stationBNote.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(717, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(183, 26);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2910, 1598);
            this.Controls.Add(this.rootLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(2560, 1440);
            this.Name = "UI";
            this.Text = "TopUs Nova AA-2 - Equipment Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.rootLayout.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.identityLayout.ResumeLayout(false);
            this.identityLayout.PerformLayout();
            this.headerActions.ResumeLayout(false);
            this.menuLayout.ResumeLayout(false);
            this.menuLayout.PerformLayout();
            this.logTabsLayout.ResumeLayout(false);
            this.bodyLayout.ResumeLayout(false);
            this.stationACard.ResumeLayout(false);
            this.stationALayout.ResumeLayout(false);
            this.stationAStatus.ResumeLayout(false);
            this.stationAStatus.PerformLayout();
            this.stationAPreviewLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationATrayPreview)).EndInit();
            this.centerCard.ResumeLayout(false);
            this.centerLayout.ResumeLayout(false);
            this.centerStatus.ResumeLayout(false);
            this.centerStatus.PerformLayout();
            this.stationBStatus.ResumeLayout(false);
            this.stationBStatus.PerformLayout();
            this.visionLayout.ResumeLayout(false);
            this.centerCameraLayout.ResumeLayout(false);
            this.trayLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trayTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayBottom)).EndInit();
            this.topCameraLayout.ResumeLayout(false);
            this.bTrayLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bTrayTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrayBottom)).EndInit();
            this.processInfoPanel.ResumeLayout(false);
            this.processInfoPanel.PerformLayout();
            this.centerBottomLayout.ResumeLayout(false);
            this.stationBCard.ResumeLayout(false);
            this.stationBLayout.ResumeLayout(false);
            this.loadCellLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private Guna2HtmlLabel guna2HtmlLabel1;
    }
}
