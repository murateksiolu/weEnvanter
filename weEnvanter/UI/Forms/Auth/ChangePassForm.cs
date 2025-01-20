using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;

namespace weEnvanter.UI.Forms.Auth
{
    public partial class ChangePassForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;
        private readonly int _currentUserId; // Yeni field ekleyelim

        public ChangePassForm(IUserService userService, int currentUserId) // Constructor'ı güncelleyelim
        {
            InitializeComponent();
            _userService = userService;
            _currentUserId = currentUserId;
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Warning.Visible = false;

                if (string.IsNullOrEmpty(txt_CurrentPassword.Text) || 
                    string.IsNullOrEmpty(txt_NewPassword.Text) || 
                    string.IsNullOrEmpty(txt_NewPasswordConfirm.Text))
                {
                    lbl_Warning.Text = "Tüm alanları doldurunuz!";
                    lbl_Warning.Visible = true;
                    return;
                }

                if (txt_NewPassword.Text != txt_NewPasswordConfirm.Text)
                {
                    lbl_Warning.Text = "Yeni şifreler eşleşmiyor!";
                    lbl_Warning.Visible = true;
                    return;
                }

                if (txt_NewPassword.Text.Length < 6)
                {
                    lbl_Warning.Text = "Yeni şifre en az 6 karakter olmalıdır!";
                    lbl_Warning.Visible = true;
                    return;
                }

                var success = await _userService.ChangePasswordAsync(
                    _currentUserId,
                    txt_CurrentPassword.Text,
                    txt_NewPassword.Text);

                if (!success)
                {
                    lbl_Warning.Text = "Mevcut şifreniz hatalı!";
                    lbl_Warning.Visible = true;
                    return;
                }

                XtraMessageBox.Show("Şifreniz başarıyla değiştirildi!", "Başarılı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lbl_Warning.Text = "Şifre değiştirme işlemi sırasında bir hata oluştu!";
                lbl_Warning.Visible = true;
                MessageBox.Show($"Hata: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}