using System;
using System.Windows.Forms;
using weEnvanter.Services;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Forms.UserForms
{
    public partial class UserForm : Form
    {
        private readonly IUserService _userService;
        private readonly ISystemLogService _systemLogService;
        private User _user;
        private OperationType _operationType;

        public UserForm()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            LoadData();
        }

        private void LoadData()
        {
            // Load data from service and populate the grid
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

                _user.Username = txt_Username.Text;
                _user.Email = txt_Email.Text;
                _user.FirstName = txt_FirstName.Text;
                _user.LastName = txt_LastName.Text;
                _user.Role = (UserRole)cmb_Role.SelectedItem;

                if (!string.IsNullOrEmpty(txt_Password.Text))
                    _user.Password = HashHelper.HashPassword(txt_Password.Text);

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                if (_operationType == OperationType.Add)
                {
                    await _userService.AddAsync(_user);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Kullanıcı Eklendi",
                        $"{userFullName} {now} tarihinde '{_user.Username}' isimli kullanıcıyı ekledi.",
                        "User",
                        _user.Id.ToString(),
                        LogType.Information.ToString()
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
                        $"{userFullName} {now} tarihinde '{_user.Username}' isimli kullanıcıyı güncelledi.",
                        "User",
                        _user.Id.ToString(),
                        LogType.Information.ToString()
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

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridView_User.GetFocusedRow() is User selectedUser)
            {
                if (XtraMessageBox.Show("Seçili kullanıcıyı silmek istediğinize emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        await _userService.DeleteAsync(selectedUser.Id);
                        string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                        string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        _systemLogService.LogActivity(
                            Program.CurrentUser?.Id,
                            "Kullanıcı Silindi",
                            $"{userFullName} {now} tarihinde '{selectedUser.Username}' isimli kullanıcıyı sildi.",
                            "User",
                            selectedUser.Id.ToString(),
                            LogType.Information.ToString()
                        );
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Kullanıcı silinirken bir hata oluştu: " + ex.Message, 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 