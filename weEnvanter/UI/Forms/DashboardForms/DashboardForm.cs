using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.Domain.Enums;
using weEnvanter.UI.Forms.EmployeeForms;
using weEnvanter.UI.Forms.InventoryForms;

namespace weEnvanter.UI.Forms.DashboardForms
{
    public partial class DashboardForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInventoryService _inventoryService;
        private readonly IEmployeeService _employeeService;
        private readonly IMaintenanceService _maintenanceService;
        private readonly ISystemLogService _systemLogService;
        private readonly Timer _refreshTimer;

        public DashboardForm()
        {
            InitializeComponent();

            // Servisleri enjekte et
            _inventoryService = Program.ServiceProvider.GetRequiredService<IInventoryService>();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();
            _maintenanceService = Program.ServiceProvider.GetRequiredService<IMaintenanceService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();

            //// Timer'ı ayarla
            //_refreshTimer = new Timer();
            //_refreshTimer.Interval = 30000; // 30 saniye
            //_refreshTimer.Tick += RefreshTimer_Tick;

            //Initialize();
            //_refreshTimer.Start();
        }

        private void Initialize()
        {
            // Label'ları doldur
            UpdateLabels();

            // Grid'leri doldur
            UpdateGrids();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            Initialize();
        }

        private void UpdateLabels()
        {
            // Aktif demirbaş sayısı
            lbl_ActiveInventoryCount.Text = _inventoryService.GetActiveInventoryCount().ToString();

            // Son kullanma tarihi yaklaşan demirbaş sayısı
            lbl_ExpirationDateUpcomingCount.Text = _inventoryService.GetUpcomingExpirationCount(30).ToString();

            // Kalibrasyon tarihi yaklaşan demirbaş sayısı
            lbl_CalibrationDateUpcomingCount.Text = _inventoryService.GetUpcomingCalibrationCount(30).ToString();

            // Bakım tarihi yaklaşan demirbaş sayısı
            lbl_MaintenanceDateUpcomingCount.Text = _maintenanceService.GetUpcomingMaintenanceCount(30).ToString();

            // Zimmetli demirbaş oranı
            var totalCount = _inventoryService.GetActiveInventoryCount();
            var assignedCount = _inventoryService.GetAssignedInventoryCount();
            var ratio = totalCount > 0 ? (double)assignedCount / totalCount * 100 : 0;
            lbl_EmbezzlementInventoryRatio.Text = $"%{ratio:F2}";

            // Toplam aktif çalışan sayısı
            lbl_TotalEmployeeCount.Text = _employeeService.GetActiveEmployeeCount().ToString();
        }

        private void UpdateGrids()
        {
            // Kalibrasyon tarihi yaklaşan demirbaşlar
            gridControl_UpcomingCalibrations.DataSource = _inventoryService.GetUpcomingCalibrations(30);

            // Bakım tarihi yaklaşan demirbaşlar
            gridControl_UpcomingMaintenances.DataSource = _maintenanceService.GetUpcomingMaintenances(30);

            // Son kullanma tarihi yaklaşan demirbaşlar
            gridControl_UpcomingExpirations.DataSource = _inventoryService.GetUpcomingExpirations(30);

            // Son eklenen demirbaşlar
            gridControl_LastAddedAssets.DataSource = _inventoryService.GetLastAddedInventories(5);

            // Son zimmetlenen demirbaşlar
            gridControl_LastAssignedAssets.DataSource = _inventoryService.GetLastAssignedInventories(5);

            // Son hareketler
            gridControl_LastActions.DataSource = _systemLogService.GetLastLogs(10);
        }

        private void btn_AddInventory_Click(object sender, EventArgs e)
        {
            using (var form = new AddOrEditInventoryForm(OperationType.Add))
            {
                form.ShowDialog();
                Initialize();
            }
        }

        private void btn_AssignInventoryToEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new AssignInventoryToEmployeeForm(0))
            {
                form.ShowDialog();
                Initialize();
            }
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new AddOrEditEmployeeForm(_employeeService, OperationType.Add))
            {
                form.ShowDialog();
                Initialize();
            }
        }

        private void btn_AddLocation_Click(object sender, EventArgs e)
        {
            // Boş bırakıldı
        }

        private void btn_StartCounting_Click(object sender, EventArgs e)
        {
            // Boş bırakıldı
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _refreshTimer.Stop();
            _refreshTimer.Dispose();
        }

        private void gridViewLastAssignedAssets_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gridView_UpcomingCalibrations_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

        private void gridView_LastAddedAssets_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }

        private void gridView_LastActions_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridControlHelper.CustomDrawEmptyForeground(sender, e);
        }
    }
}