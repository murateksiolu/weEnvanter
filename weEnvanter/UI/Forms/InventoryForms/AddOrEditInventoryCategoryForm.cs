using System;
using System.Windows.Forms;
using weEnvanter.Services;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.InventoryForms
{
    public partial class AddOrEditInventoryCategoryForm : Form
    {
        private readonly ISystemLogService _systemLogService;
        private readonly IInventoryCategoryService _inventoryCategoryService;
        private readonly OperationType _operationType;
        private readonly int? _categoryId;
        private InventoryCategory _category;

        public AddOrEditInventoryCategoryForm(OperationType operationType, int? categoryId = null)
        {
            InitializeComponent();
            _operationType = operationType;
            _categoryId = categoryId;

            _inventoryCategoryService = Program.ServiceProvider.GetRequiredService<IInventoryCategoryService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();

            InitializeForm();
        }

        private void InitializeForm()
        {
            if (_operationType == OperationType.Add)
            {
                Text = "Envanter Kategorisi Ekle";
                btn_Save.Text = "Ekle";
            }
            else
            {
                Text = "Envanter Kategorisi Güncelle";
                btn_Save.Text = "Güncelle";
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                XtraMessageBox.Show("Lütfen kategori adını girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    _category = new InventoryCategory() { IsActive = true };

                _category.Name = txt_Name.Text;
                _category.Description = txt_Description.Text;
                _category.IsActive = toggle_IsActive.IsOn;

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                if (_operationType == OperationType.Add)
                {
                    await _inventoryCategoryService.AddAsync(_category);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Envanter Kategorisi Eklendi",
                        $"{userFullName} {now} tarihinde '{_category.Name}' isimli envanter kategorisini ekledi.",
                        "InventoryCategory",
                        _category.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Envanter kategorisi başarıyla eklendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _inventoryCategoryService.UpdateAsync(_category);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Envanter Kategorisi Güncellendi",
                        $"{userFullName} {now} tarihinde '{_category.Name}' isimli envanter kategorisini güncelledi.",
                        "InventoryCategory",
                        _category.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Envanter kategorisi başarıyla güncellendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Envanter kategorisi kaydedilirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 