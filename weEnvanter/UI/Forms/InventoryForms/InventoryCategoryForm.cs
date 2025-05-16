using System;
using System.Windows.Forms;
using weEnvanter.Services;
using weEnvanter.Domain.Entities;
using DevExpress.XtraMessageBox;

namespace weEnvanter.Forms.InventoryForms
{
    public partial class InventoryCategoryForm : Form
    {
        private readonly IInventoryCategoryService _inventoryCategoryService;
        private readonly ISystemLogService _systemLogService;
        private InventoryCategory _inventoryCategory;
        private OperationType _operationType;

        public InventoryCategoryForm()
        {
            InitializeComponent();
            _inventoryCategoryService = Program.ServiceProvider.GetRequiredService<IInventoryCategoryService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            LoadData();
        }

        private void LoadData()
        {
            // Implement the LoadData method to populate the grid and other controls
        }

        private bool ValidateForm()
        {
            // Implement the ValidateForm method to check if the form is valid
            return true; // Placeholder return, actual implementation needed
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_operationType == OperationType.Add)
                    _inventoryCategory = new InventoryCategory() { IsActive = true };

                _inventoryCategory.Name = txt_Name.Text;
                _inventoryCategory.CategoryCode = txt_CategoryCode.Text;
                _inventoryCategory.Description = txt_Description.Text;

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                if (_operationType == OperationType.Add)
                {
                    await _inventoryCategoryService.AddAsync(_inventoryCategory);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Kategori Eklendi",
                        $"{userFullName} {now} tarihinde '{_inventoryCategory.Name}' isimli kategoriyi ekledi.",
                        "InventoryCategory",
                        _inventoryCategory.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _inventoryCategoryService.UpdateAsync(_inventoryCategory);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Kategori Güncellendi",
                        $"{userFullName} {now} tarihinde '{_inventoryCategory.Name}' isimli kategoriyi güncelledi.",
                        "InventoryCategory",
                        _inventoryCategory.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kategori kaydedilirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridView_Category.GetFocusedRow() is InventoryCategory selectedCategory)
            {
                if (XtraMessageBox.Show("Seçili kategoriyi silmek istediğinize emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        await _inventoryCategoryService.DeleteAsync(selectedCategory.Id);
                        string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                        string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        _systemLogService.LogActivity(
                            Program.CurrentUser?.Id,
                            "Kategori Silindi",
                            $"{userFullName} {now} tarihinde '{selectedCategory.Name}' isimli kategoriyi sildi.",
                            "InventoryCategory",
                            selectedCategory.Id.ToString(),
                            weEnvanter.Domain.Enums.LogType.Information.ToString()
                        );
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Kategori silinirken bir hata oluştu: " + ex.Message, 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 