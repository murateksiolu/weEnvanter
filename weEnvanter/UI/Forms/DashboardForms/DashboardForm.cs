using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.Domain.Enums;
using weEnvanter.UI.Forms.EmployeeForms;
using weEnvanter.UI.Forms.InventoryForms;
using System.Threading.Tasks;

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

            InitializeAsync();
            //_refreshTimer.Start();
        }

        private async Task InitializeAsync()
        {
            // Label'ları ve Grid'leri paralel olarak güncelle
            await Task.WhenAll(
                UpdateLabelsAsync(),
                UpdateGridsAsync()
            );
        }

        private async Task UpdateLabelsAsync()
        {
            // Tüm servis çağrılarını paralel olarak yap
            var activeInventoryTask = _inventoryService.GetActiveInventoryCountAsync();
            var expirationTask = _inventoryService.GetUpcomingExpirationCountAsync(30);
            var calibrationTask = _inventoryService.GetUpcomingCalibrationCountAsync(30);
            var maintenanceTask = _maintenanceService.GetUpcomingMaintenanceCountAsync(30);
            var assignedCountTask = _inventoryService.GetAssignedInventoryCountAsync();
            var employeeCountTask = _employeeService.GetActiveEmployeeCountAsync();

            await Task.WhenAll(
                activeInventoryTask,
                expirationTask,
                calibrationTask,
                maintenanceTask,
                assignedCountTask,
                employeeCountTask
            );

            // Sonuçları UI thread'inde güncelle
            this.Invoke((MethodInvoker)delegate
            {
                lbl_ActiveInventoryCount.Text = activeInventoryTask.Result.ToString();
                lbl_ExpirationDateUpcomingCount.Text = expirationTask.Result.ToString();
                lbl_CalibrationDateUpcomingCount.Text = calibrationTask.Result.ToString();
                lbl_MaintenanceDateUpcomingCount.Text = maintenanceTask.Result.ToString();

                var totalCount = activeInventoryTask.Result;
                var assignedCount = assignedCountTask.Result;
                var ratio = totalCount > 0 ? (double)assignedCount / totalCount * 100 : 0;
                lbl_EmbezzlementInventoryRatio.Text = $"%{ratio:F2}";

                lbl_TotalEmployeeCount.Text = employeeCountTask.Result.ToString();
            });
        }

        private async Task UpdateGridsAsync()
        {
            // Tüm grid güncellemelerini paralel olarak yap
            var calibrationsTask = _inventoryService.GetUpcomingCalibrationsAsync(30);
            var maintenancesTask = _maintenanceService.GetUpcomingMaintenancesAsync(30);
            var expirationsTask = _inventoryService.GetUpcomingExpirationsAsync(30);
            var lastAddedTask = _inventoryService.GetLastAddedInventoriesAsync(5);
            var lastAssignedTask = _inventoryService.GetLastAssignedInventoriesAsync(5);
            var lastActionsTask = _systemLogService.GetLastLogsAsync(10);

            await Task.WhenAll(
                calibrationsTask,
                maintenancesTask,
                expirationsTask,
                lastAddedTask,
                lastAssignedTask,
                lastActionsTask
            );

            // Sonuçları UI thread'inde güncelle
            this.Invoke((MethodInvoker)delegate
            {
                gridControl_UpcomingCalibrations.DataSource = calibrationsTask.Result;
                gridControl_UpcomingMaintenances.DataSource = maintenancesTask.Result;
                gridControl_UpcomingExpirations.DataSource = expirationsTask.Result;
                gridControl_LastAddedAssets.DataSource = lastAddedTask.Result;
                gridControl_LastAssignedAssets.DataSource = lastAssignedTask.Result;
                gridControl_LastActions.DataSource = lastActionsTask.Result;
            });
        }

        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            await InitializeAsync();
        }

        private async void btn_AddInventory_Click(object sender, EventArgs e)
        {
            using (var form = new AddOrEditInventoryForm(OperationType.Add))
            {
                form.ShowDialog();
                await InitializeAsync();
            }
        }

        private async void btn_AssignInventoryToEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new AssignInventoryToEmployeeForm(0))
            {
                form.ShowDialog();
                await InitializeAsync();
            }
        }

        private async void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new AddOrEditEmployeeForm(_employeeService, OperationType.Add))
            {
                form.ShowDialog();
                await InitializeAsync();
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
            if(_refreshTimer != null)
            {
            _refreshTimer.Stop();
            _refreshTimer.Dispose();
            }
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