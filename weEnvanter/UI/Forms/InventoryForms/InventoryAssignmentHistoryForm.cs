using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Core;
using weEnvanter.Core.Helpers;
using weEnvanter.Business.Services;
using weEnvanter.Business.DTOs;

namespace weEnvanter.UI.Forms.InventoryForms
{
    public partial class InventoryAssignmentHistoryForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInventoryService _inventoryService;
        private readonly IInventoryAssignmentService _assignmentService;
        private readonly IEmployeeService _employeeService;
        private readonly int _inventoryId;

        public InventoryAssignmentHistoryForm(int inventoryId)
        {
            InitializeComponent();
            _inventoryId = inventoryId;

            // Servisleri DI container'dan al
            _inventoryService = Program.ServiceProvider.GetRequiredService<IInventoryService>();
            _assignmentService = Program.ServiceProvider.GetRequiredService<IInventoryAssignmentService>();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();

            GridControlHelper.SetGridViewSettings(gridView_AssignmentHistory);
            BarManagerHelper.SetBarManagerSettings(barManager1);

            InitializeForm();
            LoadAssignmentHistory();
        }

        private void InitializeForm()
        {
            // Demirbaş bilgilerini yükle
            var inventory = _inventoryService.GetById(_inventoryId);
            if (inventory == null)
            {
                XtraMessageBox.Show("Demirbaş bulunamadı!", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Form başlığını güncelle
            this.Text = $"Zimmet Geçmişi - {inventory.Name} ({inventory.InventoryCode})";

            // Grid ayarlarını yap
            gridView_AssignmentHistory.OptionsView.ShowGroupPanel = false;
            gridView_AssignmentHistory.OptionsBehavior.Editable = false;
            gridView_AssignmentHistory.OptionsSelection.EnableAppearanceFocusedCell = false;
        }

        private async void LoadAssignmentHistory()
        {
            try
            {
                var assignments = await _assignmentService.GetInventoryAssignmentHistoryAsync(_inventoryId);
                gridControl_AssignmentHistory.DataSource = assignments;

                // Grid kolonlarını düzenle
                gridView_AssignmentHistory.Columns["Id"].Visible = false;

                gridView_AssignmentHistory.Columns["AssignmentDate"].Caption = "Zimmet Tarihi";
                gridView_AssignmentHistory.Columns["EmployeeName"].Caption = "Çalışan";
                gridView_AssignmentHistory.Columns["EmployeeNumber"].Caption = "Sicil No";
                gridView_AssignmentHistory.Columns["DepartmentName"].Caption = "Departman";
                gridView_AssignmentHistory.Columns["Notes"].Caption = "Notlar";
                gridView_AssignmentHistory.Columns["IsActive"].Caption = "Aktif";
                gridView_AssignmentHistory.Columns["AssignedByUserName"].Caption = "Zimmetleyen";
                gridView_AssignmentHistory.Columns["CreatedDate"].Caption = "Kayıt Tarihi";
                gridView_AssignmentHistory.Columns["CreatedBy"].Caption = "Kaydeden";

                // Tarih formatlarını ayarla
                gridView_AssignmentHistory.Columns["AssignmentDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView_AssignmentHistory.Columns["AssignmentDate"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
                gridView_AssignmentHistory.Columns["CreatedDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView_AssignmentHistory.Columns["CreatedDate"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";

                // Kolon genişliklerini otomatik ayarla
                gridView_AssignmentHistory.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Zimmet geçmişi yüklenirken hata oluştu: {ex.Message}", 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Core.Helpers.ExportHelper.ExportToPdf(gridControl_AssignmentHistory, "Zimmet_Gecmisi");
        }

        private void btn_ExportXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Core.Helpers.ExportHelper.ExportToExcel(gridControl_AssignmentHistory, "Zimmet_Gecmisi");
        }
    }
}