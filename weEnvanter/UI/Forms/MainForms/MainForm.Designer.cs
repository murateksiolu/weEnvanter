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
            this.btn_EmployeeList = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MaintenanceList = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InventoryCategories = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Departments = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reports = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Settings = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Dashboard = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddUser = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddNewUser = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UserList = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.btn_EmployeeList,
            this.btn_NewMaintenance,
            this.btn_MaintenanceList,
            this.btn_InventoryCategories,
            this.btn_Departments,
            this.btn_Reports,
            this.btn_Settings,
            this.btn_ChangePassword,
            this.btn_Exit,
            this.barButtonItem1,
            this.btn_Dashboard,
            this.btn_AddUser,
            this.btn_AddNewUser,
            this.btn_UserList});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 22;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsExpandCollapseMenu.ShowQuickAccessToolbarItem = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage6,
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
            this.btn_NewInventory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_NewInventory.ImageOptions.SvgImage")));
            this.btn_NewInventory.Name = "btn_NewInventory";
            this.btn_NewInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NewInventory_ItemClick);
            // 
            // btn_InventoryList
            // 
            this.btn_InventoryList.Caption = "Envanter Listesi";
            this.btn_InventoryList.Id = 6;
            this.btn_InventoryList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_InventoryList.ImageOptions.SvgImage")));
            this.btn_InventoryList.Name = "btn_InventoryList";
            this.btn_InventoryList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_InventoryList_ItemClick);
            // 
            // btn_EmployeeList
            // 
            this.btn_EmployeeList.Caption = "Personel Listesi";
            this.btn_EmployeeList.Id = 8;
            this.btn_EmployeeList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_EmployeeList.ImageOptions.SvgImage")));
            this.btn_EmployeeList.Name = "btn_EmployeeList";
            this.btn_EmployeeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_EmployeeList_ItemClick);
            // 
            // btn_NewMaintenance
            // 
            this.btn_NewMaintenance.Caption = "Yeni Bakım Kaydı";
            this.btn_NewMaintenance.Id = 9;
            this.btn_NewMaintenance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_NewMaintenance.ImageOptions.SvgImage")));
            this.btn_NewMaintenance.Name = "btn_NewMaintenance";
            this.btn_NewMaintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NewMaintenance_ItemClick);
            // 
            // btn_MaintenanceList
            // 
            this.btn_MaintenanceList.Caption = "Bakım Listesi";
            this.btn_MaintenanceList.Id = 10;
            this.btn_MaintenanceList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_MaintenanceList.ImageOptions.SvgImage")));
            this.btn_MaintenanceList.Name = "btn_MaintenanceList";
            this.btn_MaintenanceList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MaintenanceList_ItemClick);
            // 
            // btn_InventoryCategories
            // 
            this.btn_InventoryCategories.Caption = "Demirbaş Kategorileri";
            this.btn_InventoryCategories.Id = 11;
            this.btn_InventoryCategories.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_InventoryCategories.ImageOptions.SvgImage")));
            this.btn_InventoryCategories.Name = "btn_InventoryCategories";
            this.btn_InventoryCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_InventoryCategories_ItemClick);
            // 
            // btn_Departments
            // 
            this.btn_Departments.Caption = "Departmanlar";
            this.btn_Departments.Id = 12;
            this.btn_Departments.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Departments.ImageOptions.SvgImage")));
            this.btn_Departments.Name = "btn_Departments";
            this.btn_Departments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Departments_ItemClick);
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
            this.btn_Settings.Enabled = false;
            this.btn_Settings.Id = 14;
            this.btn_Settings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Settings.ImageOptions.SvgImage")));
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Settings_ItemClick);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Caption = "Şifre Değiştir";
            this.btn_ChangePassword.Id = 15;
            this.btn_ChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ChangePassword.ImageOptions.SvgImage")));
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ChangePassword_ItemClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Caption = "Çıkış";
            this.btn_Exit.Id = 16;
            this.btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Exit.ImageOptions.SvgImage")));
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Exit_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yeni Personel";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Caption = "Dashboard";
            this.btn_Dashboard.Id = 18;
            this.btn_Dashboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dashboard.ImageOptions.SvgImage")));
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Dashboard_ItemClick);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Caption = "Kullanıcı Ekle";
            this.btn_AddUser.Id = 19;
            this.btn_AddUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddUser_ItemClick);
            // 
            // btn_AddNewUser
            // 
            this.btn_AddNewUser.Caption = "Kullanıcı Ekle";
            this.btn_AddNewUser.Id = 20;
            this.btn_AddNewUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddNewUser.ImageOptions.SvgImage")));
            this.btn_AddNewUser.Name = "btn_AddNewUser";
            this.btn_AddNewUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddNewUser_ItemClick);
            // 
            // btn_UserList
            // 
            this.btn_UserList.Caption = "Kullanıcı Listesi";
            this.btn_UserList.Id = 21;
            this.btn_UserList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_UserList.ImageOptions.SvgImage")));
            this.btn_UserList.Name = "btn_UserList";
            this.btn_UserList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_UserList_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_Dashboard);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NewMaintenance);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_AddUser);
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
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Kullanıcılar";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_AddNewUser);
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_UserList);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Kullanıcı Yönetimi";
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
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 854);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
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
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_Dashboard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btn_AddUser;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btn_AddNewUser;
        private DevExpress.XtraBars.BarButtonItem btn_UserList;
    }
}