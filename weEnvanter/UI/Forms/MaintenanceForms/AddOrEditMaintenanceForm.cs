using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.MaintenanceForms
{
    public partial class AddOrEditMaintenanceForm : XtraForm
    {
        private readonly IMaintenanceService _maintenanceService;
        private readonly IInventoryService _inventoryService;
        private readonly ISystemLogService _systemLogService;
        private readonly OperationType _operationType;
        private readonly int? _maintenanceId;
        private Maintenance _maintenance;

        public AddOrEditMaintenanceForm(OperationType operationType, int? maintenanceId = null)
        {
            InitializeComponent();
            _operationType = operationType;
            _maintenanceId = maintenanceId;
            _maintenanceService = Program.ServiceProvider.GetRequiredService<IMaintenanceService>();
            _inventoryService = Program.ServiceProvider.GetRequiredService<IInventoryService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            this.Load += AddOrEditMaintenanceForm_Load;
            btn_Cancel.Click += Btn_Cancel_Click;
            btn_Save.Click += Btn_Save_Click;
        }

        private async void AddOrEditMaintenanceForm_Load(object sender, EventArgs e)
        {
            await FillComboBoxesAsync();
            if (_operationType == OperationType.Update && _maintenanceId.HasValue)
            {
                await LoadMaintenanceDataAsync(_maintenanceId.Value);
                this.Text = "Bakım Kaydı Düzenle";
            }
            else
            {
                this.Text = "Bakım Kaydı Ekle";
            }
        }

        private async Task FillComboBoxesAsync()
        {
            // Demirbaş listesi
            var inventories = await _inventoryService.GetAllAsync();
            cmb_Inventory.Properties.DataSource = inventories;
            cmb_Inventory.Properties.DisplayMember = "Name";
            cmb_Inventory.Properties.ValueMember = "Id";

            // Bakım tipi
            cmb_MaintenanceType.Properties.Items.AddRange(Enum.GetValues(typeof(MaintenanceType)));

            // Bakım durumu
            cmb_Status.Properties.Items.AddRange(Enum.GetValues(typeof(MaintenanceStatus)));
        }

        private async Task LoadMaintenanceDataAsync(int maintenanceId)
        {
            var maintenance = await _maintenanceService.GetByIdAsync(maintenanceId);
            if (maintenance == null)
            {
                XtraMessageBox.Show("Bakım kaydı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            cmb_Inventory.EditValue = maintenance.InventoryId;
            txt_Description.Text = maintenance.Description;
            cmb_MaintenanceType.EditValue = maintenance.MaintenanceType;
            date_StartDate.EditValue = maintenance.StartDate;
            date_EndDate.EditValue = maintenance.EndDate;
            date_NextMaintenanceDate.EditValue = maintenance.NextMaintenanceDate;
            cmb_Status.EditValue = maintenance.Status;
            txt_Cost.Text = maintenance.Cost?.ToString();
            txt_PerformedBy.Text = maintenance.PerformedBy;
            txt_CompanyName.Text = maintenance.CompanyName;
            txt_ContactPerson.Text = maintenance.ContactPerson;
            txt_ContactPhone.Text = maintenance.ContactPhone;
            txt_InvoiceNumber.Text = maintenance.InvoiceNumber;
            txt_ReplacedParts.Text = maintenance.ReplacedParts;
            txt_Recommendations.Text = maintenance.Recommendations;
            txt_FailureDescription.Text = maintenance.FailureDescription;
            txt_Resolution.Text = maintenance.Resolution;
            spn_WarrantyPeriod.Value = maintenance.WarrantyPeriodInDays ?? 0;
            chk_IsUnderWarranty.Checked = maintenance.IsUnderWarranty;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (cmb_Inventory.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir demirbaş seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Inventory.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Description.Text))
            {
                XtraMessageBox.Show("Bakım açıklaması boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Description.Focus();
                return false;
            }
            if (cmb_MaintenanceType.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bakım tipi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_MaintenanceType.Focus();
                return false;
            }
            if (date_StartDate.EditValue == null)
            {
                XtraMessageBox.Show("Başlangıç tarihi boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                date_StartDate.Focus();
                return false;
            }
            if (cmb_Status.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bakım durumu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Status.Focus();
                return false;
            }
            return true;
        }

        private async void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_operationType == OperationType.Add)
                    _maintenance = new Maintenance() { IsActive = true };

                _maintenance.InventoryId = Convert.ToInt32(cmb_Inventory.EditValue);
                _maintenance.MaintenanceType = (MaintenanceType)cmb_MaintenanceType.EditValue;
                _maintenance.StartDate = Convert.ToDateTime(date_StartDate.EditValue);
                _maintenance.EndDate = date_EndDate.EditValue as DateTime?;
                _maintenance.NextMaintenanceDate = date_NextMaintenanceDate.EditValue as DateTime?;
                _maintenance.Status = (MaintenanceStatus)cmb_Status.EditValue;
                _maintenance.Cost = decimal.TryParse(txt_Cost.Text, out var cost) ? (decimal?)cost : null;
                _maintenance.PerformedBy = txt_PerformedBy.Text.Trim();
                _maintenance.CompanyName = txt_CompanyName.Text.Trim();
                _maintenance.ContactPerson = txt_ContactPerson.Text.Trim();
                _maintenance.ContactPhone = txt_ContactPhone.Text.Trim();
                _maintenance.InvoiceNumber = txt_InvoiceNumber.Text.Trim();
                _maintenance.ReplacedParts = txt_ReplacedParts.Text.Trim();
                _maintenance.Recommendations = txt_Recommendations.Text.Trim();
                _maintenance.FailureDescription = txt_FailureDescription.Text.Trim();
                _maintenance.Resolution = txt_Resolution.Text.Trim();
                _maintenance.WarrantyPeriodInDays = (int?)spn_WarrantyPeriod.Value;
                _maintenance.IsUnderWarranty = chk_IsUnderWarranty.Checked;

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                string inventoryName = cmb_Inventory.Text;

                if (_operationType == OperationType.Add)
                {
                    await _maintenanceService.AddAsync(_maintenance);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Bakım Eklendi",
                        $"{userFullName} {now} tarihinde '{inventoryName}' için bakım ekledi.",
                        "Maintenance",
                        _maintenance.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Bakım kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _maintenance.Id = _maintenanceId.Value;
                    await _maintenanceService.UpdateAsync(_maintenance);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Bakım Güncellendi",
                        $"{userFullName} {now} tarihinde '{inventoryName}' için bakım kaydını güncelledi.",
                        "Maintenance",
                        _maintenance.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Bakım kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Bakım kaydedilirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}