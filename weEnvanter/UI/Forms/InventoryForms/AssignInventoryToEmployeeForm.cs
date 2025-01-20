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
        private readonly Inventory _inventory;

        public AssignInventoryToEmployeeForm(int inventoryId)
        {
            InitializeComponent();
            _inventoryService = Program.ServiceProvider.GetRequiredService<IInventoryService>();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();

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

        private async void btn_Assign_Click(object sender, EventArgs e)
        {
            try
            {
                if (lookUp_Employee.EditValue == null)
                {
                    XtraMessageBox.Show("Lütfen bir çalışan seçin!", "Uyarı", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Demirbaşı güncelle
                _inventory.AssignedEmployeeId = (int)lookUp_Employee.EditValue;
                _inventory.AssignmentDate = date_AssignDate.DateTime;
                _inventory.AssignmentNotes = txt_AssignNotes.Text;

                // Zimmet geçmişi için yeni kayıt oluştur
                var assignment = new InventoryAssignment
                {
                    InventoryId = _inventory.Id,
                    EmployeeId = (int)lookUp_Employee.EditValue,
                    AssignmentDate = date_AssignDate.DateTime,
                    Notes = txt_AssignNotes.Text,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    AssignedById = Program.CurrentUser.Id
                };

                // Önce demirbaşı güncelle
                await _inventoryService.UpdateAsync(_inventory);
                
                // Sonra zimmet kaydını ekle
                await _inventoryService.AddAssignmentAsync(assignment);

                XtraMessageBox.Show("Demirbaş başarıyla zimmetlendi!", "Bilgi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Zimmetleme işlemi sırasında hata oluştu: {ex.Message}", 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}