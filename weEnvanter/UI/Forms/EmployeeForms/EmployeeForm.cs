using System;
using System.Windows.Forms;
using weEnvanter.Services;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Forms.EmployeeForms
{
    public partial class EmployeeForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly ISystemLogService _systemLogService;
        private OperationType _operationType;
        private Employee _employee;

        public EmployeeForm()
        {
            InitializeComponent();
            _employeeService = Program.ServiceProvider.GetRequiredService<IEmployeeService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            LoadData();
        }

        private void LoadData()
        {
            // Load data from service
        }

        private bool ValidateForm()
        {
            // Implement form validation logic
            return true; // Placeholder return, actual implementation needed
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
                _employee.Department = txt_Department.Text;
                _employee.Position = txt_Position.Text;

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
                        LogType.Information.ToString()
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
                        LogType.Information.ToString()
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

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridView_Employee.GetFocusedRow() is Employee selectedEmployee)
            {
                if (XtraMessageBox.Show("Seçili çalışanı silmek istediğinize emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        await _employeeService.DeleteAsync(selectedEmployee.Id);
                        string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                        string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        _systemLogService.LogActivity(
                            Program.CurrentUser?.Id,
                            "Çalışan Silindi",
                            $"{userFullName} {now} tarihinde '{selectedEmployee.FirstName} {selectedEmployee.LastName}' isimli çalışanı sildi.",
                            "Employee",
                            selectedEmployee.Id.ToString(),
                            LogType.Information.ToString()
                        );
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Çalışan silinirken bir hata oluştu: " + ex.Message, 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 