using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using weEnvanter.Domain.Enums;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Domain.Entities;
using DevExpress.XtraEditors.DXErrorProvider;

namespace weEnvanter.UI.Forms.InventoryCategoryForms
{
    public partial class AddOrEditInventoryCategoryForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly OperationType _operationType;
        private readonly int? _categoryId;
        private readonly IInventoryCategoryService _inventoryCategoryService;

        public AddOrEditInventoryCategoryForm(IInventoryCategoryService inventoryCategoryService, OperationType operationType, int? categoryId = null)
        {
            InitializeComponent();
            _inventoryCategoryService = inventoryCategoryService;
            _operationType = operationType;
            _categoryId = categoryId;

            InitializeForm();
            SetValidationRules();
        }

        private void InitializeForm()
        {
            // Form başlığını ayarla
            switch (_operationType)
            {
                case OperationType.Add:
                    Text = "Yeni Kategori Ekle";
                    toggle_IsActive.IsOn = true;
                    break;
                case OperationType.Update:
                    Text = "Kategori Düzenle";
                    LoadCategory(_categoryId.Value);
                    break;
                case OperationType.View:
                    Text = "Kategori Detayları";
                    LoadCategory(_categoryId.Value);
                    SetControlsReadOnly(true);
                    break;
            }
        }

        private void SetValidationRules()
        {
            // Kategori Kodu validasyonu
            dxValidationProvider1.SetValidationRule(txt_CategoryCode,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Kategori kodu boş olamaz!"
                });

            // Kategori Adı validasyonu
            dxValidationProvider1.SetValidationRule(txt_Name,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Kategori adı boş olamaz!"
                });
        }

        private async void LoadCategory(int categoryId)
        {
            try
            {
                var category = await _inventoryCategoryService.GetByIdAsync(categoryId);
                if (category != null)
                {
                    txt_CategoryCode.Text = category.CategoryCode;
                    txt_Name.Text = category.Name;
                    txt_Description.Text = category.Description;
                    toggle_IsActive.IsOn = category.IsActive;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kategori bilgileri yüklenirken bir hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControlsReadOnly(bool isReadOnly)
        {
            txt_CategoryCode.ReadOnly = isReadOnly;
            txt_Name.ReadOnly = isReadOnly;
            txt_Description.ReadOnly = isReadOnly;
            toggle_IsActive.ReadOnly = isReadOnly;
            btn_Save.Visible = !isReadOnly;
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                {
                    XtraMessageBox.Show("Lütfen zorunlu alanları doldurunuz!",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_operationType == OperationType.Update && _categoryId.HasValue)
                {
                    var existingCategory = await _inventoryCategoryService.GetByIdAsync(_categoryId.Value);
                    if (existingCategory != null)
                    {
                        existingCategory.CategoryCode = txt_CategoryCode.Text.Trim();
                        existingCategory.Name = txt_Name.Text.Trim();
                        existingCategory.Description = txt_Description.Text.Trim();
                        existingCategory.IsActive = toggle_IsActive.IsOn;

                        await _inventoryCategoryService.UpdateAsync(existingCategory);
                        XtraMessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    var newCategory = new InventoryCategory
                    {
                        CategoryCode = txt_CategoryCode.Text.Trim(),
                        Name = txt_Name.Text.Trim(),
                        Description = txt_Description.Text.Trim(),
                        IsActive = toggle_IsActive.IsOn
                    };

                    await _inventoryCategoryService.AddAsync(newCategory);
                    XtraMessageBox.Show("Kategori başarıyla eklendi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kaydetme işlemi sırasında bir hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}