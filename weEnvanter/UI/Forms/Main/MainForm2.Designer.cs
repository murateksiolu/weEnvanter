namespace weEnvanter.UI.Forms.Main
{
    partial class MainForm2
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
            this.btn_Categories = new DevExpress.XtraBars.BarButtonItem();
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
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.btn_Categories,
            this.btn_Departments,
            this.btn_Reports,
            this.btn_Settings,
            this.btn_ChangePassword,
            this.btn_Exit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbon.Size = new System.Drawing.Size(1024, 170);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // btn_Categories
            // 
            this.btn_Categories.Caption = "Kategoriler";
            this.btn_Categories.Id = 11;
            this.btn_Categories.Name = "btn_Categories";
            // 
            // btn_Departments
            // 
            this.btn_Departments.Caption = "Departmanlar";
            this.btn_Departments.Id = 12;
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
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Categories);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 520);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1024, 31);
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Interval = 1000;
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // tileControl1
            // 
            this.tileControl1.Location = new System.Drawing.Point(12, 176);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(200, 165);
            this.tileControl1.TabIndex = 2;
            this.tileControl1.Text = "tileControl1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 551);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "weEnvanter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_Categories;
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
        private DevExpress.XtraEditors.TileControl tileControl1;
    }
}