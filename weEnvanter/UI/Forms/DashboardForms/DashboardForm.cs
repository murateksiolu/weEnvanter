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

            // Timer'ı ayarla
            _refreshTimer = new Timer();
            _refreshTimer.Interval = 30000; // 30 saniye
            _refreshTimer.Tick += RefreshTimer_Tick;

            InitializeAsync();
            _refreshTimer.Start();
        }

        private async Task InitializeAsync()
        {
            await UpdateLabelsAsync();
            await UpdateGridsAsync();
        }

        private async Task UpdateLabelsAsync()
        {
            // Tüm servis çağrılarını sıralı olarak yap
            var activeInventory = await _inventoryService.GetActiveInventoryCountAsync();
            var expiration = await _inventoryService.GetUpcomingExpirationCountAsync(30);
            var calibration = await _inventoryService.GetUpcomingCalibrationCountAsync(30);
            var maintenance = await _maintenanceService.GetUpcomingMaintenanceCountAsync(30);
            var assignedCount = await _inventoryService.GetAssignedInventoryCountAsync();
            var employeeCount = await _employeeService.GetActiveEmployeeCountAsync();

            // Sonuçları UI thread'inde güncelle
            this.Invoke((MethodInvoker)delegate
            {
                lbl_ActiveInventoryCount.Text = activeInventory.ToString();
                lbl_ExpirationDateUpcomingCount.Text = expiration.ToString();
                lbl_CalibrationDateUpcomingCount.Text = calibration.ToString();
                lbl_MaintenanceDateUpcomingCount.Text = maintenance.ToString();

                var totalCount = activeInventory;
                var ratio = totalCount > 0 ? (double)assignedCount / totalCount * 100 : 0;
                lbl_EmbezzlementInventoryRatio.Text = $"%{ratio:F2}";

                lbl_TotalEmployeeCount.Text = employeeCount.ToString();
            });
        }

        private async Task UpdateGridsAsync()
        {
            // Tüm grid güncellemelerini sıralı olarak yap
            var calibrations = await _inventoryService.GetUpcomingCalibrationsAsync(30);
            var maintenances = await _maintenanceService.GetUpcomingMaintenancesAsync(30);
            var expirations = await _inventoryService.GetUpcomingExpirationsAsync(30);
            var lastAdded = await _inventoryService.GetLastAddedInventoriesAsync(5);
            var lastAssigned = await _inventoryService.GetLastAssignedInventoriesAsync(5);
            var lastActions = await _systemLogService.GetLastLogsAsync(10);

            // Sonuçları UI thread'inde güncelle
            this.Invoke((MethodInvoker)delegate
            {
                gridControl_UpcomingCalibrations.DataSource = calibrations;
                gridControl_UpcomingMaintenances.DataSource = maintenances;
                gridControl_UpcomingExpirations.DataSource = expirations;
                gridControl_LastAddedAssets.DataSource = lastAdded;
                gridControl_LastAssignedAssets.DataSource = lastAssigned;
                gridControl_LastActions.DataSource = lastActions;

                // Kolon görünürlüklerini ayarla
                SetGridColumnVisibility();
            });
        }

        private void SetGridColumnVisibility()
        {
            // Yaklaşan Kalibrasyonlar
            var viewCal = gridControl_UpcomingCalibrations.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (viewCal != null)
            {
                foreach (var col in viewCal.Columns)
                    ((DevExpress.XtraGrid.Columns.GridColumn)col).Visible = false;
                SetVisible(viewCal, "Inventory.Name");
                SetVisible(viewCal, "CalibrationDate");
                SetVisible(viewCal, "Description");
                viewCal.BestFitColumns();
            }
            // Yaklaşan Bakımlar
            var viewMain = gridControl_UpcomingMaintenances.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (viewMain != null)
            {
                foreach (var col in viewMain.Columns)
                    ((DevExpress.XtraGrid.Columns.GridColumn)col).Visible = false;
                SetVisible(viewMain, "Inventory.Name");
                SetVisible(viewMain, "StartDate");
                SetVisible(viewMain, "MaintenanceType");
                SetVisible(viewMain, "Description");
                SetVisible(viewMain, "Status");
                viewMain.BestFitColumns();
            }
            // Yaklaşan Son Kullanma
            var viewExp = gridControl_UpcomingExpirations.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (viewExp != null)
            {
                foreach (var col in viewExp.Columns)
                    ((DevExpress.XtraGrid.Columns.GridColumn)col).Visible = false;
                SetVisible(viewExp, "Inventory.Name");
                SetVisible(viewExp, "ExpirationDate");
                SetVisible(viewExp, "Description");
                viewExp.BestFitColumns();
            }
            // Son Eklenen Demirbaşlar
            var viewLastAdd = gridControl_LastAddedAssets.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (viewLastAdd != null)
            {
                foreach (var col in viewLastAdd.Columns)
                    ((DevExpress.XtraGrid.Columns.GridColumn)col).Visible = false;
                SetVisible(viewLastAdd, "Name");
                SetVisible(viewLastAdd, "CreatedDate");
                SetVisible(viewLastAdd, "Category.Name");
                SetVisible(viewLastAdd, "Description");
                viewLastAdd.BestFitColumns();
            }
            // Son Zimmetlenenler
            var viewLastAssign = gridControl_LastAssignedAssets.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (viewLastAssign != null)
            {
                foreach (var col in viewLastAssign.Columns)
                    ((DevExpress.XtraGrid.Columns.GridColumn)col).Visible = false;
                SetVisible(viewLastAssign, "Name");
                SetVisible(viewLastAssign, "AssignedTo");
                SetVisible(viewLastAssign, "AssignmentDate");
                SetVisible(viewLastAssign, "Description");
                viewLastAssign.BestFitColumns();
            }
            // Son İşlemler
            var viewLastAct = gridControl_LastActions.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (viewLastAct != null)
            {
                foreach (var col in viewLastAct.Columns)
                    ((DevExpress.XtraGrid.Columns.GridColumn)col).Visible = false;
                SetVisible(viewLastAct, "LogDate");
                SetVisible(viewLastAct, "UserName");
                SetVisible(viewLastAct, "Action");
                SetVisible(viewLastAct, "Description");
                viewLastAct.BestFitColumns();
            }
        }

        private void SetVisible(DevExpress.XtraGrid.Views.Grid.GridView view, string fieldName)
        {
            var col = view.Columns[fieldName];
            if (col != null)
                col.Visible = true;
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
            using (var form = new AddOrEditEmployeeForm(OperationType.Add))
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