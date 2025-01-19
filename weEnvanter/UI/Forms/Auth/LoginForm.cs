using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using weEnvanter.Business.DTOs;
using weEnvanter.Business.Services;
using weEnvanter.UI.Forms.Main;

namespace weEnvanter.UI.Forms.Auth
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
                if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text))
                {
                    lbl_Warning.Text = "Kullanıcı adı ve şifre boş olamaz!";
                    lbl_Warning.Visible = true;
                    return;
                }

                var loginDto = new UserLoginDto
                {
                    Username = txt_Username.Text.Trim(),
                    Password = txt_Password.Text,
                    RememberMe = check_RememberMe.Checked
                };

                var user = await _userService.AuthenticateAsync(loginDto);

                if (user == null)
                {
                    lbl_Warning.Text = "Kullanıcı adı veya şifre hatalı!";
                    lbl_Warning.Visible = true;
                    return;
                }

                // Kullanıcı bilgilerini global olarak sakla
                Program.CurrentUser = user;

                // Ana formu aç
                var mainForm = new MainForm(_userService);
                this.Hide();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                lbl_Warning.Text = "Giriş işlemi sırasında bir hata oluştu!";
                lbl_Warning.Visible = true;
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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