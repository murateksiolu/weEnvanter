using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.UsersForms
{
    public partial class AddOrEditUserForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;
        private readonly OperationType _operationType;
        private readonly int? _userId;
        private readonly Random _random = new Random();

        public AddOrEditUserForm(OperationType operationType, int? userId = null)
        {
            InitializeComponent();
            _operationType = operationType;
            _userId = userId;
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();

            InitializeForm();
            if (_operationType == OperationType.Update && _userId.HasValue)
            {
                LoadUserDataAsync();
            }
        }

        private void InitializeForm()
        {
            // Form başlığını ayarla
            this.Text = _operationType == OperationType.Add ? "Yeni Kullanıcı Ekle" : "Kullanıcı Düzenle";

            // Rol combobox'ını doldur
            cmb_Role.Properties.Items.AddRange(Enum.GetValues(typeof(UserRole)));

            // Event'leri ekle
            btn_GeneratePassword.Click += Btn_GeneratePassword_Click;
            btn_Save.Click += Btn_Save_Click;
            btn_Cancel.Click += Btn_Cancel_Click;
        }

        private void Btn_GeneratePassword_Click(object sender, EventArgs e)
        {
            string generatedPassword = GenerateSimplePassword();
            txt_Password.Text = generatedPassword;
            txt_PasswordConfirm.Text = generatedPassword;
        }

        private string GenerateSimplePassword()
        {
            // 100000 ile 999999 arasında rastgele bir sayı oluştur
            return _random.Next(100000, 1000000).ToString();
        }

        private async void LoadUserDataAsync()
        {
            try
            {
                var user = await _userService.GetByIdAsync(_userId.Value);
                if (user != null)
                {
                    txt_Username.Text = user.Username;
                    txt_FirstName.Text = user.FirstName;
                    txt_LastName.Text = user.LastName;
                    txt_Email.Text = user.Email;
                    txt_Phone.Text = user.Phone;
                    cmb_Role.SelectedItem = user.Role;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kullanıcı bilgileri yüklenirken bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            // Zorunlu alanların kontrolü
            if (string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                XtraMessageBox.Show("Kullanıcı adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Username.Focus();
                return false;
            }

            if (_operationType == OperationType.Add && string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                XtraMessageBox.Show("Şifre boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
                return false;
            }

            if (_operationType == OperationType.Add && txt_Password.Text != txt_PasswordConfirm.Text)
            {
                XtraMessageBox.Show("Şifreler eşleşmiyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_PasswordConfirm.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_FirstName.Text))
            {
                XtraMessageBox.Show("Ad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_FirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_LastName.Text))
            {
                XtraMessageBox.Show("Soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_LastName.Focus();
                return false;
            }

            if (cmb_Role.SelectedItem == null)
            {
                XtraMessageBox.Show("Kullanıcı rolü seçilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Role.Focus();
                return false;
            }

            // E-posta validasyonu (opsiyonel alan)
            if (!string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txt_Email.Text);
                    if (addr.Address != txt_Email.Text)
                    {
                        XtraMessageBox.Show("Geçerli bir e-posta adresi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_Email.Focus();
                        return false;
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Geçerli bir e-posta adresi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Email.Focus();
                    return false;
                }
            }

            return true;
        }

        private async void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                var user = new User
                {
                    Username = txt_Username.Text.Trim(),
                    FirstName = txt_FirstName.Text.Trim(),
                    LastName = txt_LastName.Text.Trim(),
                    Email = txt_Email.Text.Trim(),
                    Phone = txt_Phone.Text.Trim(),
                    Role = (UserRole)cmb_Role.SelectedItem
                };

                if (_operationType == OperationType.Add)
                {
                    user.Password = txt_Password.Text;
                    await _userService.AddAsync(user);
                    XtraMessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    user.Id = _userId.Value;
                    if (!string.IsNullOrWhiteSpace(txt_Password.Text))
                    {
                        await _userService.ResetPasswordAsync(_userId.Value, txt_Password.Text);
                    }
                    await _userService.UpdateAsync(user);
                    XtraMessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"İşlem sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}