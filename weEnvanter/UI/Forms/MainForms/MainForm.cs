using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.UI.Forms.AuthForms;
using weEnvanter.UI.Forms.DashboardForms;
using weEnvanter.UI.Forms.DepartmentForms;
using weEnvanter.UI.Forms.EmployeeForms;
using weEnvanter.UI.Forms.InventoryCategoryForms;
using weEnvanter.UI.Forms.LoadingForms;
using weEnvanter.UI.Forms.MaintenanceForms;
using weEnvanter.UI.Forms.SettingForms;

namespace weEnvanter.UI.Forms.MainForms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IUserService _userService;
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        private readonly IMaintenanceService _maintenanceService;

        DashboardForm _dashboardForm;
        DepartmentListForm _departmentListForm;
        MaintenanceListForm _maintenanceListForm;
        InventoryCategoryListForm _inventoryCategoryListForm;
        EmployeeListForm _employeeListForm;
        public MainForm()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
            _departmentService = Program.ServiceProvider.GetRequiredService<IDepartmentService>();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();
            _maintenanceService = Program.ServiceProvider.GetService<IMaintenanceService>();

            InitializeUserInfo();
            InitializeEvents();
            InitializeDashboard();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void InitializeUserInfo()
        {
            if (Program.CurrentUser != null)
            {
                bar_UserInfo.Caption = $"Kullanıcı: {Program.CurrentUser.Username}";
                bar_ConnectionStatus.Caption = "Bağlantı: Aktif";
            }
        }
        private void InitializeDashboard()
        {
            if (!GeneralHelper.FormIsOpen("DepartmentListForm"))
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                _dashboardForm = new DashboardForm();
                _dashboardForm.MdiParent = this;
                _dashboardForm.Show();
                SplashScreenManager.CloseForm(false);
            }
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_dashboardForm];
        }
        private void InitializeEvents()
        {
            // Envanter İşlemleri
            btn_NewInventory.ItemClick += Btn_NewInventory_ItemClick;
            btn_InventoryList.ItemClick += Btn_InventoryList_ItemClick;

            // Bakım İşlemleri
            btn_NewMaintenance.ItemClick += Btn_NewMaintenance_ItemClick;
            btn_MaintenanceList.ItemClick += Btn_MaintenanceList_ItemClick;

        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            bar_Clock.Caption = $"Saat: {DateTime.Now:HH:mm:ss}";
        }

        #region Button Click Events

        private void Btn_NewInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Yeni Envanter formu açılacak");
        }

        private void Btn_InventoryList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Envanter Listesi formu açılacak");
        }

        private void Btn_NewEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Yeni Personel formu açılacak");
        }

        private void Btn_EmployeeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GeneralHelper.FormIsOpen("EmployeeListForm"))
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                _employeeListForm = new EmployeeListForm();
                _employeeListForm.MdiParent = this;
                _employeeListForm.Show();
                SplashScreenManager.CloseForm(false);
            }
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_employeeListForm];
        }

        private void Btn_NewMaintenance_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Yeni Bakım Kaydı formu açılacak");
        }

        private void Btn_MaintenanceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GeneralHelper.FormIsOpen("MaintenanceListForm"))
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                _maintenanceListForm = new MaintenanceListForm();
                _maintenanceListForm.MdiParent = this;
                _maintenanceListForm.Show();
                SplashScreenManager.CloseForm(false);
            }
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_maintenanceListForm];
        }
        private void btn_InventoryCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GeneralHelper.FormIsOpen("InventoryCategoryListForm"))
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                _inventoryCategoryListForm = new InventoryCategoryListForm();
                _inventoryCategoryListForm.MdiParent = this;
                _inventoryCategoryListForm.Show();
                SplashScreenManager.CloseForm(false);
            }
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_inventoryCategoryListForm];
        }

        private void btn_Departments_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GeneralHelper.FormIsOpen("DepartmentListForm"))
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                _departmentListForm = new DepartmentListForm();
                _departmentListForm.MdiParent = this;
                _departmentListForm.Show();
                SplashScreenManager.CloseForm(false);
            }
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_departmentListForm];
        }

        private void btn_Settings_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SettingsForm form = new SettingsForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        private void btn_ChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ChangePassForm form = new ChangePassForm(_userService, Program.CurrentUser.Id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        private void btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gridView_UpcomingCalibrations_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

        private void gridView_UpcomingMaintenances_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

        private void gridView_UpcomingExpirations_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

        private void gridView_LastAddedAssets_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

        private void gridViewLastAssignedAssets_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

        private void gridView_LastActions_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

       
    }
}