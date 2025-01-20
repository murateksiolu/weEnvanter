using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.UI.Forms.Auth;
using weEnvanter.UI.Forms.DepartmentForms;
using Microsoft.Extensions.DependencyInjection;

namespace weEnvanter.UI.Forms.MainForms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IUserService _userService;
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;

        public MainForm()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
            _departmentService = Program.ServiceProvider.GetRequiredService<IDepartmentService>();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();
            InitializeUserInfo();
            InitializeEvents();
            InitializeDashboard();
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

        }

        private void InitializeEvents()
        {
            // Envanter İşlemleri
            btn_NewInventory.ItemClick += Btn_NewInventory_ItemClick;
            btn_InventoryList.ItemClick += Btn_InventoryList_ItemClick;

            // Personel İşlemleri
            btn_NewEmployee.ItemClick += Btn_NewEmployee_ItemClick;
            btn_EmployeeList.ItemClick += Btn_EmployeeList_ItemClick;

            // Bakım İşlemleri
            btn_NewMaintenance.ItemClick += Btn_NewMaintenance_ItemClick;
            btn_MaintenanceList.ItemClick += Btn_MaintenanceList_ItemClick;

            // Tanımlamalar
            btn_InventoryCategories.ItemClick += Btn_Categories_ItemClick;
            btn_Departments.ItemClick += Btn_Departments_ItemClick;

            // Ayarlar
            btn_Settings.ItemClick += Btn_Settings_ItemClick;
            btn_ChangePassword.ItemClick += Btn_ChangePassword_ItemClick;
            btn_Exit.ItemClick += Btn_Exit_ItemClick;
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
            MessageBox.Show("Personel Listesi formu açılacak");
        }

        private void Btn_NewMaintenance_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Yeni Bakım Kaydı formu açılacak");
        }

        private void Btn_MaintenanceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Bakım Listesi formu açılacak");
        }

        private void Btn_Categories_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Kategoriler formu açılacak");
        }

        private void Btn_Departments_ItemClick(object sender, ItemClickEventArgs e)
        {
            using(var form = new DepartmentListForm(_departmentService, _employeeService))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    // İşlem başarılı
                }
            }
        }

        private void Btn_Settings_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Ayarlar formu açılacak");
        }

        private void Btn_ChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            var changePassForm = new ChangePassForm(_userService, Program.CurrentUser.Id);
            changePassForm.ShowDialog();
        }

        private void Btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
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