using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.UI.Forms.LoadingForms;
using weEnvanter.UI.Forms.MainForms;

namespace weEnvanter.UI.Forms.AuthForms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;

        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);

                string username = txt_Username.Text.Trim();
                string password = txt_Password.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    SplashScreenManager.CloseForm(false);
                    MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isValid = await _userService.ValidateCredentialsAsync(username, password);
                if (isValid)
                {
                    var user = await _userService.GetByUsernameAsync(username);
                    if (user != null)
                    {
                        Program.CurrentUser = new Business.DTOs.UserDto
                        {
                            Id = user.Id,
                            Username = user.Username,
                            Role = user.Role
                        };

                        DialogResult = DialogResult.OK;
                        Hide();
                        SplashScreenManager.CloseForm(false);
                        using (var mainForm = new MainForm())
                        {
                            mainForm.ShowDialog();
                        }

                        Close();
                    }
                }
                else
                {
                    SplashScreenManager.CloseForm(false);
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                MessageBox.Show($"Giriş işlemi sırasında bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                Application.Exit();
            }
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Submit.PerformClick();
            }
        }
    }
}