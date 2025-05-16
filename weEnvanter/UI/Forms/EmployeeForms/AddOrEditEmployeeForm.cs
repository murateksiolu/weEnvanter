using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using weEnvanter.Domain.Enums;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Domain.Entities;
using DevExpress.XtraEditors.DXErrorProvider;
using Microsoft.Extensions.DependencyInjection;

namespace weEnvanter.UI.Forms.EmployeeForms
{
    public partial class AddOrEditEmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly OperationType _operationType;
        private readonly int? _employeeId;
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly ISystemLogService _systemLogService;
        private Employee _employee;

        public AddOrEditEmployeeForm(OperationType operationType, int? employeeId = null)
        {
            InitializeComponent();
            _operationType = operationType;
            _employeeId = employeeId;

            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();
            _departmentService = Program.ServiceProvider.GetRequiredService<IDepartmentService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();

            InitializeForm();
            SetValidationRules();
        }

        private void InitializeForm()
        {
            // Form başlığını ayarla
            switch (_operationType)
            {
                case OperationType.Add:
                    Text = "Yeni Çalışan Ekle";
                    toggle_IsActive.IsOn = true;
                    dateEdit_HireDate.DateTime = DateTime.Now;
                    break;
                case OperationType.Update:
                    Text = "Çalışan Düzenle";
                    LoadEmployee(_employeeId.Value);
                    break;
                case OperationType.View:
                    Text = "Çalışan Detayları";
                    LoadEmployee(_employeeId.Value);
                    SetControlsReadOnly(true);
                    break;
            }

            // Departman listesini yükle
            LoadDepartments();
        }

        private void SetValidationRules()
        {
            // Ad validasyonu
            dxValidationProvider1.SetValidationRule(txt_FirstName,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Ad boş olamaz!"
                });

            // Soyad validasyonu
            dxValidationProvider1.SetValidationRule(txt_LastName,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Soyad boş olamaz!"
                });

            // Sicil No validasyonu
            dxValidationProvider1.SetValidationRule(txt_EmployeeNumber,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Sicil numarası boş olamaz!"
                });

            // Departman validasyonu
            dxValidationProvider1.SetValidationRule(lookUp_Department,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Departman seçilmelidir!"
                });
        }

        private async void LoadDepartments()
        {
            try
            {
                var departments = await _departmentService.GetActiveAsync();
                lookUp_Department.Properties.DataSource = departments;
                lookUp_Department.Properties.DisplayMember = "Name";
                lookUp_Department.Properties.ValueMember = "Id";

                // Kolon ayarlarını yap
                lookUp_Department.Properties.Columns.Clear();
                lookUp_Department.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentCode", "Departman Kodu"));
                lookUp_Department.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Departman Adı"));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Departman listesi yüklenirken bir hata oluştu.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadEmployee(int employeeId)
        {
            try
            {
                var employee = await _employeeService.GetByIdAsync(employeeId);
                if (employee != null)
                {
                    txt_FirstName.Text = employee.FirstName;
                    txt_LastName.Text = employee.LastName;
                    txt_EmployeeNumber.Text = employee.EmployeeNumber;
                    txt_Email.Text = employee.Email;
                    txt_Phone.Text = employee.Phone;
                    txt_Notes.Text = employee.Notes;
                    lookUp_Department.EditValue = employee.DepartmentId;
                    dateEdit_HireDate.DateTime = employee.HireDate;
                    toggle_IsActive.IsOn = employee.IsActive;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Çalışan bilgileri yüklenirken bir hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControlsReadOnly(bool isReadOnly)
        {
            txt_FirstName.ReadOnly = isReadOnly;
            txt_LastName.ReadOnly = isReadOnly;
            txt_EmployeeNumber.ReadOnly = isReadOnly;
            txt_Email.ReadOnly = isReadOnly;
            txt_Phone.ReadOnly = isReadOnly;
            txt_Notes.ReadOnly = isReadOnly;
            lookUp_Department.ReadOnly = isReadOnly;
            dateEdit_HireDate.ReadOnly = isReadOnly;
            toggle_IsActive.ReadOnly = isReadOnly;
            btn_Save.Visible = !isReadOnly;
        }

        private bool ValidateForm()
        {
            if (!dxValidationProvider1.Validate())
            {
                XtraMessageBox.Show("Lütfen zorunlu alanları doldurunuz!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_operationType == OperationType.Add)
                    _employee = new Employee() { IsActive = true };

                _employee.FirstName = txt_FirstName.Text;
                _employee.LastName = txt_LastName.Text;
                _employee.Email = txt_Email.Text;
                _employee.Phone = txt_Phone.Text;
                _employee.DepartmentId = Convert.ToInt32(lookUp_Department.EditValue);
                _employee.HireDate = dateEdit_HireDate.DateTime;
                _employee.IsActive = toggle_IsActive.IsOn;

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                if (_operationType == OperationType.Add)
                {
                    await _employeeService.AddAsync(_employee);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Çalışan Eklendi",
                        $"{userFullName} {now} tarihinde '{_employee.FirstName} {_employee.LastName}' isimli çalışanı ekledi.",
                        "Employee",
                        _employee.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Çalışan başarıyla eklendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _employeeService.UpdateAsync(_employee);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Çalışan Güncellendi",
                        $"{userFullName} {now} tarihinde '{_employee.FirstName} {_employee.LastName}' isimli çalışanı güncelledi.",
                        "Employee",
                        _employee.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Çalışan başarıyla güncellendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Çalışan kaydedilirken bir hata oluştu: " + ex.Message,
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