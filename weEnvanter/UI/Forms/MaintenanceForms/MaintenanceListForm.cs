﻿using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;
using static weEnvanter.Core.Helpers.ToastNotificationHelper;

namespace weEnvanter.UI.Forms.MaintenanceForms
{
    public partial class MaintenanceListForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IMaintenanceService _maintenanceService;
        private readonly ToastNotificationsManager _toastNotificationsManager;

        public MaintenanceListForm()
        {
            InitializeComponent();
            _maintenanceService = Program.ServiceProvider.GetRequiredService<IMaintenanceService>();

            // Toast Notification Manager'ı başlat
            _toastNotificationsManager = ToastNotificationHelper.CreateManager(components);

            // This line of code is generated by Data Source Configuration Wizard
            pLinqServerModeSource2.Source = new weEnvanter.Data.WeEnvanterDbContext().Maintenances;
            GridControlHelper.SetGridViewSettings(gridView_Maintenances);
            BarManagerHelper.SetBarManagerSettings(barManager1);
        }
        private void gridView_Maintenances_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
            }
        }
        private void btn_RefreshDataSource_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                pLinqServerModeSource2.Source = new weEnvanter.Data.WeEnvanterDbContext().Maintenances;
                pLinqServerModeSource2.Reload();
                _toastNotificationsManager.ShowSuccess("Veriler başarıyla yenilendi.");
            }
            catch (Exception ex)
            {
                _toastNotificationsManager.ShowError("Veriler yenilenirken bir hata oluştu.");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btn_ExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Core.Helpers.ExportHelper.ExportToPdf(gridControl_Maintenances, "weEnvanter_BakımListesi");
        }

        private void btn_ExportXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Core.Helpers.ExportHelper.ExportToExcel(gridControl_Maintenances, "weEnvanter_BakımListesi");
        }
        private void btn_AddNewMaintenance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var addMaintenanceForm = new AddOrEditMaintenanceForm(OperationType.Add))
                {
                    if (addMaintenanceForm.ShowDialog() == DialogResult.OK)
                    {
                        pLinqServerModeSource2.Source = new weEnvanter.Data.WeEnvanterDbContext().Maintenances;
                        pLinqServerModeSource2.Reload();
                        _toastNotificationsManager.ShowSuccess("Bakım kaydı başarıyla eklendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                _toastNotificationsManager.ShowError("Bakım kaydı eklenirken bir hata oluştu.");
            }
        }

        private void bar_EditMaintenance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRow = gridView_Maintenances.GetFocusedRow() as Maintenance;
            if (selectedRow != null)
            {
                try
                {
                    using (var editForm = new AddOrEditMaintenanceForm(OperationType.Update, selectedRow.Id))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            pLinqServerModeSource2.Source = new weEnvanter.Data.WeEnvanterDbContext().Maintenances;
                            pLinqServerModeSource2.Reload();
                            _toastNotificationsManager.ShowSuccess("Bakım kaydı başarıyla güncellendi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    _toastNotificationsManager.ShowError("Bakım kaydı güncellenirken bir hata oluştu.");
                }
            }
        }

        private async void bar_DeleteMaintenance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRow = gridView_Maintenances.GetFocusedRow() as Maintenance;
            if (selectedRow != null)
            {
                try
                {
                    if (XtraMessageBox.Show("Seçili bakım kaydını silmek istediğinize emin misiniz?", "Silme Onayı",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _maintenanceService.DeleteAsync(selectedRow.Id);
                        pLinqServerModeSource2.Source = new weEnvanter.Data.WeEnvanterDbContext().Maintenances;
                        pLinqServerModeSource2.Reload();
                        _toastNotificationsManager.ShowSuccess("Bakım kaydı başarıyla silindi.");
                    }
                }
                catch (Exception ex)
                {
                    _toastNotificationsManager.ShowError("Silme işlemi sırasında bir hata oluştu.");
                }
            }
        }
    }
}