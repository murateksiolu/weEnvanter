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
        private readonly ISystemLogService _systemLogService;

        public MaintenanceListForm()
        {
            InitializeComponent();
            _maintenanceService = Program.ServiceProvider.GetRequiredService<IMaintenanceService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            LoadData();

            // Toast Notification Manager'ı başlat
            _toastNotificationsManager = ToastNotificationHelper.CreateManager(components);

            GridControlHelper.SetGridViewSettings(gridView_Maintenances);
            BarManagerHelper.SetBarManagerSettings(barManager1);
        }
        private void LoadData()
        {
            // This line of code is generated by Data Source Configuration Wizard
            pLinqServerModeSource2.Source = new weEnvanter.Data.WeEnvanterDbContext().Maintenances;
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
            try
            {
                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                _systemLogService.LogActivity(
                    Program.CurrentUser?.Id,
                    "Bakım Listesi PDF Dışa Aktarıldı",
                    $"{userFullName} {now} tarihinde bakım listesini PDF olarak dışa aktardı.",
                    "Maintenance",
                    null,
                    weEnvanter.Domain.Enums.LogType.Information.ToString()
                );
                Core.Helpers.ExportHelper.ExportToPdf(gridControl_Maintenances, "weEnvanter_BakımListesi");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("PDF dışa aktarma sırasında bir hata oluştu: " + ex.Message, 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                _systemLogService.LogActivity(
                    Program.CurrentUser?.Id,
                    "Bakım Listesi Excel Dışa Aktarıldı",
                    $"{userFullName} {now} tarihinde bakım listesini Excel olarak dışa aktardı.",
                    "Maintenance",
                    null,
                    weEnvanter.Domain.Enums.LogType.Information.ToString()
                );
                Core.Helpers.ExportHelper.ExportToExcel(gridControl_Maintenances, "weEnvanter_BakımListesi");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Excel dışa aktarma sırasında bir hata oluştu: " + ex.Message, 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                        string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        _systemLogService.LogActivity(
                            Program.CurrentUser?.Id,
                            "Bakım Silindi",
                            $"{userFullName} {now} tarihinde '{selectedRow.Description}' açıklamalı bakımı sildi.",
                            "Maintenance",
                            selectedRow.Id.ToString(),
                            weEnvanter.Domain.Enums.LogType.Information.ToString()
                        );
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