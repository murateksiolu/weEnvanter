using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.Domain.Enums;
using weEnvanter.UI.Forms.AuthForms;
using weEnvanter.UI.Forms.DashboardForms;
using weEnvanter.UI.Forms.DepartmentForms;
using weEnvanter.UI.Forms.EmployeeForms;
using weEnvanter.UI.Forms.InventoryCategoryForms;
using weEnvanter.UI.Forms.InventoryForms;
using weEnvanter.UI.Forms.LoadingForms;
using weEnvanter.UI.Forms.MaintenanceForms;
using weEnvanter.UI.Forms.SettingForms;
using weEnvanter.UI.Forms.UsersForms;

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
        InventoryListForm _inventoryListForm;
        EmployeeListForm _employeeListForm;
        UserListForm _userListForm;
        public MainForm()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
            _departmentService = Program.ServiceProvider.GetRequiredService<IDepartmentService>();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();
            _maintenanceService = Program.ServiceProvider.GetService<IMaintenanceService>();

            InitializeUserInfo();
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
            if (!GeneralHelper.FormIsOpen("DashboardForm"))
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                _dashboardForm = new DashboardForm();
                _dashboardForm.MdiParent = this;
                _dashboardForm.Show();
                SplashScreenManager.CloseForm(false);
            }
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_dashboardForm];
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            bar_Clock.Caption = $"Saat: {DateTime.Now:HH:mm:ss}";
        }

        #region Button Click Events

        private void btn_Dashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeDashboard();
        }
        private void btn_NewInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            using(AddOrEditInventoryForm form = new AddOrEditInventoryForm(OperationType.Add))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        private void btn_InventoryList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GeneralHelper.FormIsOpen("InventoryListForm"))
            {
                try
                {
                    SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                    _inventoryListForm = new InventoryListForm();
                    _inventoryListForm.MdiParent = this;
                    _inventoryListForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Envanter listesi açılırken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    SplashScreenManager.CloseForm(false);
                }
            }
            if (_inventoryListForm != null && !_inventoryListForm.IsDisposed)
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_inventoryListForm];
            }
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
        private void btn_MaintenanceList_ItemClick(object sender, ItemClickEventArgs e)
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

        
        private void btn_NewMaintenance_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (AddOrEditMaintenanceForm form = new AddOrEditMaintenanceForm(OperationType.Add))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
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
        private void btn_UserList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GeneralHelper.FormIsOpen("UserListForm"))
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
                _userListForm = new UserListForm();
                _userListForm.MdiParent = this;
                _userListForm.Show();
                SplashScreenManager.CloseForm(false);
            }
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[_userListForm];
        }

        private void btn_AddNewUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (AddOrEditUserForm form = new AddOrEditUserForm(OperationType.Add))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
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
            using (ChangePassForm form = new ChangePassForm(Program.CurrentUser.Id))
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

       
    }
}