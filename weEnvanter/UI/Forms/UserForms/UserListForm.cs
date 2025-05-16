using System;
using System.Windows.Forms;
using weEnvanter.Services;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Forms.UserForms
{
    public partial class UserListForm : Form
    {
        private readonly IUserService _userService;
        private readonly ISystemLogService _systemLogService;

        public UserListForm()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            LoadData();
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
                            $"{userFullName} {now} tarihinde '{selectedUser.FirstName} {selectedUser.LastName}' isimli kullanıcıyı sildi.",
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