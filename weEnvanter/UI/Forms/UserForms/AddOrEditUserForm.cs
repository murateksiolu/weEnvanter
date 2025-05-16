using System;
using System.Windows.Forms;
using weEnvanter.Services;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.UserForms
{
    public partial class AddOrEditUserForm : Form
    {
        private readonly ISystemLogService _systemLogService;
        private readonly IUserService _userService;
        private readonly OperationType _operationType;
        private readonly int? _userId;
        private User _user;

        public AddOrEditUserForm(OperationType operationType, int? userId = null)
        {
            InitializeComponent();
            _operationType = operationType;
            _userId = userId;

            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();

            InitializeForm();
        }

        private void InitializeForm()
        {
            // Initialize form components
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
                    _user = new User() { IsActive = true };

                _user.FirstName = txt_FirstName.Text;
                _user.LastName = txt_LastName.Text;
                _user.Email = txt_Email.Text;
                _user.Username = txt_Username.Text;
                _user.IsActive = toggle_IsActive.IsOn;

                if (!string.IsNullOrEmpty(txt_Password.Text))
                    _user.Password = txt_Password.Text;

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                if (_operationType == OperationType.Add)
                {
                    await _userService.AddAsync(_user);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Kullanıcı Eklendi",
                        $"{userFullName} {now} tarihinde '{_user.FirstName} {_user.LastName}' isimli kullanıcıyı ekledi.",
                        "User",
                        _user.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _userService.UpdateAsync(_user);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Kullanıcı Güncellendi",
                        $"{userFullName} {now} tarihinde '{_user.FirstName} {_user.LastName}' isimli kullanıcıyı güncelledi.",
                        "User",
                        _user.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kullanıcı kaydedilirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 