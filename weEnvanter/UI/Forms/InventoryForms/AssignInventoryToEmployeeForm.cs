using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.UI.Forms.InventoryForms
{
    public partial class AssignInventoryToEmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInventoryService _inventoryService;
        private readonly IEmployeeService _employeeService;
        private readonly ISystemLogService _systemLogService;
        private readonly Inventory _inventory;
        private readonly int _inventoryId;

        public AssignInventoryToEmployeeForm(int inventoryId)
        {
            InitializeComponent();
            _inventoryId = inventoryId;

            _inventoryService = Program.ServiceProvider.GetRequiredService<IInventoryService>();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();

            // Demirbaşı yükle
            _inventory = _inventoryService.GetById(inventoryId);
            if (_inventory == null)
            {
                XtraMessageBox.Show("Demirbaş bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeForm();
            LoadEmployees();
        }

        private void InitializeForm()
        {
            // Demirbaş bilgilerini doldur
            txt_InventoryName.Text = _inventory.Name;
            txt_InventoryCode.Text = _inventory.InventoryCode;
            txt_BarcodeNumber.Text = _inventory.BarcodeNumber;
            txt_SerialNumber.Text = _inventory.SerialNumber;
            txt_BrandModel.Text = $"{_inventory.Brand} {_inventory.Model}";

            // Varsayılan zimmet tarihi
            date_AssignDate.DateTime = DateTime.Now;

            // Salt okunur alanları ayarla
            txt_InventoryName.ReadOnly = true;
            txt_InventoryCode.ReadOnly = true;
            txt_BarcodeNumber.ReadOnly = true;
            txt_SerialNumber.ReadOnly = true;
            txt_BrandModel.ReadOnly = true;
        }

        private async void LoadEmployees()
        {
            try
            {
                var employees = await _employeeService.GetAllAsync();
                lookUp_Employee.Properties.DataSource = employees;
                
                // Lookup sütunlarını ayarla
                lookUp_Employee.Properties.Columns.Clear();
                lookUp_Employee.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeNumber", "Sicil No"));
                lookUp_Employee.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "Ad"));
                lookUp_Employee.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Soyad"));
                lookUp_Employee.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department.Name", "Departman"));

                lookUp_Employee.Properties.DisplayMember = "EmployeeNumber";
                lookUp_Employee.Properties.ValueMember = "Id";

                // Özel görüntüleme formatı
                lookUp_Employee.Properties.CustomDisplayText += (sender, e) =>
                {
                    if (e.Value != null)
                    {
                        var employee = employees.FirstOrDefault(c => c.Id == (int)e.Value);
                        if (employee != null)
                        {
                            e.DisplayText = $"{employee.EmployeeNumber} - {employee.FirstName} {employee.LastName}";
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Çalışanlar yüklenirken hata oluştu: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btn_Assign_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                var inventory = await _inventoryService.GetByIdAsync(_inventoryId);
                var employee = await _employeeService.GetByIdAsync(Convert.ToInt32(lookUp_Employee.EditValue));

                // InventoryAssignment kaydı oluştur
                var assignment = new InventoryAssignment
                {
                    InventoryId = inventory.Id,
                    EmployeeId = employee.Id,
                    AssignmentDate = date_AssignDate.DateTime,
                    Notes = txt_AssignNotes.Text,
                    IsActive = true,
                    CreatedBy = Program.CurrentUser?.Id,
                    CreatedDate = DateTime.Now,
                    AssignedById = Program.CurrentUser?.Id ?? 0
                };

                // Yeni zimmet kaydını ekle
                await _inventoryService.AddAssignmentAsync(assignment);

                // Envanteri güncelle
                inventory.AssignedEmployeeId = employee.Id;
                inventory.AssignmentDate = date_AssignDate.DateTime;
                inventory.Notes = txt_AssignNotes.Text;
                await _inventoryService.UpdateAsync(inventory);

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                _systemLogService.LogActivity(
                    Program.CurrentUser?.Id,
                    "Envanter Zimmetlendi",
                    $"{userFullName} {now} tarihinde '{inventory.Name}' isimli envanteri '{employee.FirstName} {employee.LastName}' isimli çalışana zimmetledi.",
                    "Inventory",
                    inventory.Id.ToString(),
                    weEnvanter.Domain.Enums.LogType.Information.ToString()
                );

                XtraMessageBox.Show("Envanter başarıyla zimmetlendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Envanter zimmetlenirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (lookUp_Employee.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir çalışan seçiniz.", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUp_Employee.Focus();
                return false;
            }

            if (date_AssignDate.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen zimmet tarihini seçiniz.", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                date_AssignDate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_AssignNotes.Text))
            {
                XtraMessageBox.Show("Lütfen zimmet notunu giriniz.", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_AssignNotes.Focus();
                return false;
            }

            return true;
        }
    }
}