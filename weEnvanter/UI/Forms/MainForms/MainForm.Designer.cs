using DevExpress.XtraEditors;

namespace weEnvanter.UI.Forms.MainForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bar_UserInfo = new DevExpress.XtraBars.BarStaticItem();
            this.bar_Clock = new DevExpress.XtraBars.BarStaticItem();
            this.bar_ConnectionStatus = new DevExpress.XtraBars.BarStaticItem();
            this.btn_NewInventory = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InventoryList = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btn_EmployeeList = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MaintenanceList = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InventoryCategories = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Departments = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reports = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Settings = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl12 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl11 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl10 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_UpcomingCalibrations = new DevExpress.XtraGrid.GridControl();
            this.gridView_UpcomingCalibrations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_UpcomingMaintenances = new DevExpress.XtraGrid.GridControl();
            this.gridView_UpcomingMaintenances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl99 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_UpcomingExpirations = new DevExpress.XtraGrid.GridControl();
            this.gridView_UpcomingExpirations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_LastActions = new DevExpress.XtraGrid.GridControl();
            this.gridView_LastActions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_LastAddedAssets = new DevExpress.XtraGrid.GridControl();
            this.gridView_LastAddedAssets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_LastAssignedAssets = new DevExpress.XtraGrid.GridControl();
            this.gridViewLastAssignedAssets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl12)).BeginInit();
            this.groupControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).BeginInit();
            this.groupControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).BeginInit();
            this.groupControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_UpcomingCalibrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_UpcomingCalibrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_UpcomingMaintenances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_UpcomingMaintenances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl99)).BeginInit();
            this.groupControl99.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_UpcomingExpirations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_UpcomingExpirations)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LastActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LastActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LastAddedAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LastAddedAssets)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LastAssignedAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLastAssignedAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bar_UserInfo,
            this.bar_Clock,
            this.bar_ConnectionStatus,
            this.btn_NewInventory,
            this.btn_InventoryList,
            this.btn_NewEmployee,
            this.btn_EmployeeList,
            this.btn_NewMaintenance,
            this.btn_MaintenanceList,
            this.btn_InventoryCategories,
            this.btn_Departments,
            this.btn_Reports,
            this.btn_Settings,
            this.btn_ChangePassword,
            this.btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsExpandCollapseMenu.ShowQuickAccessToolbarItem = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Inplace;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(993, 170);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bar_UserInfo
            // 
            this.bar_UserInfo.Caption = "Kullanıcı: ";
            this.bar_UserInfo.Id = 1;
            this.bar_UserInfo.Name = "bar_UserInfo";
            // 
            // bar_Clock
            // 
            this.bar_Clock.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bar_Clock.Caption = "Saat: ";
            this.bar_Clock.Id = 2;
            this.bar_Clock.Name = "bar_Clock";
            // 
            // bar_ConnectionStatus
            // 
            this.bar_ConnectionStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bar_ConnectionStatus.Caption = "Bağlantı: ";
            this.bar_ConnectionStatus.Id = 3;
            this.bar_ConnectionStatus.Name = "bar_ConnectionStatus";
            // 
            // btn_NewInventory
            // 
            this.btn_NewInventory.Caption = "Yeni Envanter";
            this.btn_NewInventory.Id = 5;
            this.btn_NewInventory.Name = "btn_NewInventory";
            // 
            // btn_InventoryList
            // 
            this.btn_InventoryList.Caption = "Envanter Listesi";
            this.btn_InventoryList.Id = 6;
            this.btn_InventoryList.Name = "btn_InventoryList";
            // 
            // btn_NewEmployee
            // 
            this.btn_NewEmployee.Caption = "Yeni Personel";
            this.btn_NewEmployee.Id = 7;
            this.btn_NewEmployee.Name = "btn_NewEmployee";
            // 
            // btn_EmployeeList
            // 
            this.btn_EmployeeList.Caption = "Personel Listesi";
            this.btn_EmployeeList.Id = 8;
            this.btn_EmployeeList.Name = "btn_EmployeeList";
            // 
            // btn_NewMaintenance
            // 
            this.btn_NewMaintenance.Caption = "Yeni Bakım Kaydı";
            this.btn_NewMaintenance.Id = 9;
            this.btn_NewMaintenance.Name = "btn_NewMaintenance";
            // 
            // btn_MaintenanceList
            // 
            this.btn_MaintenanceList.Caption = "Bakım Listesi";
            this.btn_MaintenanceList.Id = 10;
            this.btn_MaintenanceList.Name = "btn_MaintenanceList";
            // 
            // btn_InventoryCategories
            // 
            this.btn_InventoryCategories.Caption = "Demirbaş Kategorileri";
            this.btn_InventoryCategories.Id = 11;
            this.btn_InventoryCategories.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Categories.ImageOptions.SvgImage")));
            this.btn_InventoryCategories.Name = "btn_InventoryCategories";
            // 
            // btn_Departments
            // 
            this.btn_Departments.Caption = "Departmanlar";
            this.btn_Departments.Id = 12;
            this.btn_Departments.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Departments.ImageOptions.SvgImage")));
            this.btn_Departments.Name = "btn_Departments";
            // 
            // btn_Reports
            // 
            this.btn_Reports.Caption = "Raporlar";
            this.btn_Reports.Id = 13;
            this.btn_Reports.Name = "btn_Reports";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Caption = "Ayarlar";
            this.btn_Settings.Id = 14;
            this.btn_Settings.Name = "btn_Settings";
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Caption = "Şifre Değiştir";
            this.btn_ChangePassword.Id = 15;
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Caption = "Çıkış";
            this.btn_Exit.Id = 16;
            this.btn_Exit.Name = "btn_Exit";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_NewInventory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_InventoryList);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Envanter İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NewEmployee);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NewMaintenance);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hızlı İşlemler";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Personel";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_NewEmployee);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_EmployeeList);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Personel İşlemleri";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Bakım/Onarım";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_NewMaintenance);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_MaintenanceList);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Bakım İşlemleri";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Tanımlamalar";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_InventoryCategories);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Departments);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tanımlama İşlemleri";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Ayarlar";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_Settings);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_ChangePassword);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_Exit);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bar_UserInfo);
            this.ribbonStatusBar.ItemLinks.Add(this.bar_Clock);
            this.ribbonStatusBar.ItemLinks.Add(this.bar_ConnectionStatus);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 823);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(993, 31);
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Interval = 1000;
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.labelControl2);
            this.groupControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl7.Location = new System.Drawing.Point(3, 3);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(155, 132);
            this.groupControl7.TabIndex = 0;
            this.groupControl7.Text = "Aktif Demirbaş";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(2, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(151, 108);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "0";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 6;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.Controls.Add(this.groupControl12, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupControl11, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupControl10, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupControl9, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupControl8, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupControl7, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(12, 176);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(969, 138);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // groupControl12
            // 
            this.groupControl12.Controls.Add(this.labelControl6);
            this.groupControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl12.Location = new System.Drawing.Point(808, 3);
            this.groupControl12.Name = "groupControl12";
            this.groupControl12.Size = new System.Drawing.Size(158, 132);
            this.groupControl12.TabIndex = 5;
            this.groupControl12.Text = "Toplam Çalışan";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(2, 22);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(154, 108);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "0";
            // 
            // groupControl11
            // 
            this.groupControl11.Controls.Add(this.labelControl5);
            this.groupControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl11.Location = new System.Drawing.Point(647, 3);
            this.groupControl11.Name = "groupControl11";
            this.groupControl11.Size = new System.Drawing.Size(155, 132);
            this.groupControl11.TabIndex = 4;
            this.groupControl11.Text = "Zimmetli Demirbaş Oranı";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(2, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(151, 108);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "0";
            // 
            // groupControl10
            // 
            this.groupControl10.Controls.Add(this.labelControl4);
            this.groupControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl10.Location = new System.Drawing.Point(486, 3);
            this.groupControl10.Name = "groupControl10";
            this.groupControl10.Size = new System.Drawing.Size(155, 132);
            this.groupControl10.TabIndex = 3;
            this.groupControl10.Text = "Kalibrasyon Bekleyen";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(2, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(151, 108);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "0";
            // 
            // groupControl9
            // 
            this.groupControl9.Controls.Add(this.labelControl3);
            this.groupControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl9.Location = new System.Drawing.Point(325, 3);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(155, 132);
            this.groupControl9.TabIndex = 2;
            this.groupControl9.Text = "Kalibrasyonu Yaklaşan";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(2, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(151, 108);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "0";
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.labelControl1);
            this.groupControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl8.Location = new System.Drawing.Point(164, 3);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(155, 132);
            this.groupControl8.TabIndex = 1;
            this.groupControl8.Text = "SKT Yaklaşan";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(2, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 108);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "0";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.tableLayoutPanel8);
            this.groupControl1.Location = new System.Drawing.Point(12, 320);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(969, 85);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Hızlı İşlemler";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.simpleButton5, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.simpleButton4, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.simpleButton3, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.simpleButton1, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 22);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(965, 61);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton5.Location = new System.Drawing.Point(775, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(187, 55);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Hızlı Sayım Başlat";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton4.Location = new System.Drawing.Point(582, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(187, 55);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Lokasyon Ekle";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton3.Location = new System.Drawing.Point(389, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(187, 55);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Çalışan Ekle";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Location = new System.Drawing.Point(196, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(187, 55);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Demirbaş Atama";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(187, 55);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Demirbaş Ekle";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_UpcomingCalibrations);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(315, 191);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Yaklaşan Kalibrasyon Tarihleri";
            // 
            // gridControl_UpcomingCalibrations
            // 
            this.gridControl_UpcomingCalibrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_UpcomingCalibrations.Location = new System.Drawing.Point(2, 22);
            this.gridControl_UpcomingCalibrations.MainView = this.gridView_UpcomingCalibrations;
            this.gridControl_UpcomingCalibrations.MenuManager = this.ribbon;
            this.gridControl_UpcomingCalibrations.Name = "gridControl_UpcomingCalibrations";
            this.gridControl_UpcomingCalibrations.Size = new System.Drawing.Size(311, 167);
            this.gridControl_UpcomingCalibrations.TabIndex = 0;
            this.gridControl_UpcomingCalibrations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_UpcomingCalibrations});
            // 
            // gridView_UpcomingCalibrations
            // 
            this.gridView_UpcomingCalibrations.GridControl = this.gridControl_UpcomingCalibrations;
            this.gridView_UpcomingCalibrations.Name = "gridView_UpcomingCalibrations";
            this.gridView_UpcomingCalibrations.OptionsView.ShowGroupPanel = false;
            this.gridView_UpcomingCalibrations.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView_UpcomingCalibrations_CustomDrawEmptyForeground);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl_UpcomingMaintenances);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(324, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(315, 191);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Yaklaşan Bakım Tarihleri";
            // 
            // gridControl_UpcomingMaintenances
            // 
            this.gridControl_UpcomingMaintenances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_UpcomingMaintenances.Location = new System.Drawing.Point(2, 22);
            this.gridControl_UpcomingMaintenances.MainView = this.gridView_UpcomingMaintenances;
            this.gridControl_UpcomingMaintenances.MenuManager = this.ribbon;
            this.gridControl_UpcomingMaintenances.Name = "gridControl_UpcomingMaintenances";
            this.gridControl_UpcomingMaintenances.Size = new System.Drawing.Size(311, 167);
            this.gridControl_UpcomingMaintenances.TabIndex = 0;
            this.gridControl_UpcomingMaintenances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_UpcomingMaintenances});
            // 
            // gridView_UpcomingMaintenances
            // 
            this.gridView_UpcomingMaintenances.GridControl = this.gridControl_UpcomingMaintenances;
            this.gridView_UpcomingMaintenances.Name = "gridView_UpcomingMaintenances";
            this.gridView_UpcomingMaintenances.OptionsView.ShowGroupPanel = false;
            this.gridView_UpcomingMaintenances.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView_UpcomingMaintenances_CustomDrawEmptyForeground);
            // 
            // groupControl99
            // 
            this.groupControl99.Controls.Add(this.gridControl_UpcomingExpirations);
            this.groupControl99.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl99.Location = new System.Drawing.Point(645, 3);
            this.groupControl99.Name = "groupControl99";
            this.groupControl99.Size = new System.Drawing.Size(317, 191);
            this.groupControl99.TabIndex = 11;
            this.groupControl99.Text = "Yaklaşan SKT Tarihleri";
            // 
            // gridControl_UpcomingExpirations
            // 
            this.gridControl_UpcomingExpirations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_UpcomingExpirations.Location = new System.Drawing.Point(2, 22);
            this.gridControl_UpcomingExpirations.MainView = this.gridView_UpcomingExpirations;
            this.gridControl_UpcomingExpirations.MenuManager = this.ribbon;
            this.gridControl_UpcomingExpirations.Name = "gridControl_UpcomingExpirations";
            this.gridControl_UpcomingExpirations.Size = new System.Drawing.Size(313, 167);
            this.gridControl_UpcomingExpirations.TabIndex = 0;
            this.gridControl_UpcomingExpirations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_UpcomingExpirations});
            // 
            // gridView_UpcomingExpirations
            // 
            this.gridView_UpcomingExpirations.GridControl = this.gridControl_UpcomingExpirations;
            this.gridView_UpcomingExpirations.Name = "gridView_UpcomingExpirations";
            this.gridView_UpcomingExpirations.OptionsView.ShowGroupPanel = false;
            this.gridView_UpcomingExpirations.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView_UpcomingExpirations_CustomDrawEmptyForeground);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.groupControl99, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.groupControl3, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(15, 411);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(965, 197);
            this.tableLayoutPanel9.TabIndex = 12;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.gridControl_LastActions);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(486, 3);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(478, 197);
            this.groupControl5.TabIndex = 13;
            this.groupControl5.Text = "Son Hareketler";
            // 
            // gridControl_LastActions
            // 
            this.gridControl_LastActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LastActions.Location = new System.Drawing.Point(2, 22);
            this.gridControl_LastActions.MainView = this.gridView_LastActions;
            this.gridControl_LastActions.MenuManager = this.ribbon;
            this.gridControl_LastActions.Name = "gridControl_LastActions";
            this.gridControl_LastActions.Size = new System.Drawing.Size(474, 173);
            this.gridControl_LastActions.TabIndex = 0;
            this.gridControl_LastActions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_LastActions});
            // 
            // gridView_LastActions
            // 
            this.gridView_LastActions.GridControl = this.gridControl_LastActions;
            this.gridView_LastActions.Name = "gridView_LastActions";
            this.gridView_LastActions.OptionsView.ShowGroupPanel = false;
            this.gridView_LastActions.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView_LastActions_CustomDrawEmptyForeground);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 22);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(473, 173);
            this.xtraTabControl1.TabIndex = 14;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl_LastAddedAssets);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(339, 171);
            this.xtraTabPage1.Text = "Son Eklenen Demirbaşlar";
            // 
            // gridControl_LastAddedAssets
            // 
            this.gridControl_LastAddedAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LastAddedAssets.Location = new System.Drawing.Point(0, 0);
            this.gridControl_LastAddedAssets.MainView = this.gridView_LastAddedAssets;
            this.gridControl_LastAddedAssets.MenuManager = this.ribbon;
            this.gridControl_LastAddedAssets.Name = "gridControl_LastAddedAssets";
            this.gridControl_LastAddedAssets.Size = new System.Drawing.Size(339, 171);
            this.gridControl_LastAddedAssets.TabIndex = 0;
            this.gridControl_LastAddedAssets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_LastAddedAssets});
            // 
            // gridView_LastAddedAssets
            // 
            this.gridView_LastAddedAssets.GridControl = this.gridControl_LastAddedAssets;
            this.gridView_LastAddedAssets.Name = "gridView_LastAddedAssets";
            this.gridView_LastAddedAssets.OptionsView.ShowGroupPanel = false;
            this.gridView_LastAddedAssets.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView_LastAddedAssets_CustomDrawEmptyForeground);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl_LastAssignedAssets);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(339, 171);
            this.xtraTabPage2.Text = "Son Atanan Demirbaşlar";
            // 
            // gridControl_LastAssignedAssets
            // 
            this.gridControl_LastAssignedAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LastAssignedAssets.Location = new System.Drawing.Point(0, 0);
            this.gridControl_LastAssignedAssets.MainView = this.gridViewLastAssignedAssets;
            this.gridControl_LastAssignedAssets.MenuManager = this.ribbon;
            this.gridControl_LastAssignedAssets.Name = "gridControl_LastAssignedAssets";
            this.gridControl_LastAssignedAssets.Size = new System.Drawing.Size(339, 171);
            this.gridControl_LastAssignedAssets.TabIndex = 0;
            this.gridControl_LastAssignedAssets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLastAssignedAssets});
            // 
            // gridViewLastAssignedAssets
            // 
            this.gridViewLastAssignedAssets.GridControl = this.gridControl_LastAssignedAssets;
            this.gridViewLastAssignedAssets.Name = "gridViewLastAssignedAssets";
            this.gridViewLastAssignedAssets.OptionsView.ShowGroupPanel = false;
            this.gridViewLastAssignedAssets.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridViewLastAssignedAssets_CustomDrawEmptyForeground);
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.xtraTabControl1);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl6.Location = new System.Drawing.Point(3, 3);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(477, 197);
            this.groupControl6.TabIndex = 15;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.groupControl6, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.groupControl5, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(14, 614);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(967, 203);
            this.tableLayoutPanel10.TabIndex = 16;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 854);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::weEnvanter.Properties.Resources.weEnvanter_icon;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "weEnvanter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl12)).EndInit();
            this.groupControl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).EndInit();
            this.groupControl11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).EndInit();
            this.groupControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_UpcomingCalibrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_UpcomingCalibrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_UpcomingMaintenances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_UpcomingMaintenances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl99)).EndInit();
            this.groupControl99.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_UpcomingExpirations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_UpcomingExpirations)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LastActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LastActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LastAddedAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LastAddedAssets)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LastAssignedAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLastAssignedAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bar_UserInfo;
        private DevExpress.XtraBars.BarStaticItem bar_Clock;
        private DevExpress.XtraBars.BarStaticItem bar_ConnectionStatus;
        private System.Windows.Forms.Timer timer_Clock;
        private DevExpress.XtraBars.BarButtonItem btn_NewInventory;
        private DevExpress.XtraBars.BarButtonItem btn_InventoryList;
        private DevExpress.XtraBars.BarButtonItem btn_NewEmployee;
        private DevExpress.XtraBars.BarButtonItem btn_EmployeeList;
        private DevExpress.XtraBars.BarButtonItem btn_NewMaintenance;
        private DevExpress.XtraBars.BarButtonItem btn_MaintenanceList;
        private DevExpress.XtraBars.BarButtonItem btn_InventoryCategories;
        private DevExpress.XtraBars.BarButtonItem btn_Departments;
        private DevExpress.XtraBars.BarButtonItem btn_Reports;
        private DevExpress.XtraBars.BarButtonItem btn_Settings;
        private DevExpress.XtraBars.BarButtonItem btn_ChangePassword;
        private DevExpress.XtraBars.BarButtonItem btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_UpcomingCalibrations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_UpcomingCalibrations;
        private GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControl_UpcomingMaintenances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_UpcomingMaintenances;
        private GroupControl groupControl99;
        private DevExpress.XtraGrid.GridControl gridControl_UpcomingExpirations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_UpcomingExpirations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl gridControl_LastActions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_LastActions;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private GroupControl groupControl6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private DevExpress.XtraGrid.GridControl gridControl_LastAddedAssets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_LastAddedAssets;
        private DevExpress.XtraGrid.GridControl gridControl_LastAssignedAssets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLastAssignedAssets;
        private GroupControl groupControl7;
        private GroupControl groupControl12;
        private LabelControl labelControl6;
        private GroupControl groupControl11;
        private LabelControl labelControl5;
        private GroupControl groupControl10;
        private LabelControl labelControl4;
        private GroupControl groupControl9;
        private LabelControl labelControl3;
        private GroupControl groupControl8;
        private LabelControl labelControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}