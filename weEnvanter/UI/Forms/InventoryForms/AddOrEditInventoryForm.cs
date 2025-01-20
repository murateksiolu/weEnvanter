using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Core.Helpers;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.InventoryForms
{
    public partial class AddOrEditInventoryForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInventoryService _inventoryService;
        private readonly IInventoryCategoryService _inventoryCategoryService;
        private readonly OperationType _operationType;
        private readonly int? _inventoryId;
        private Inventory _inventory;

        public AddOrEditInventoryForm(OperationType operationType, int? inventoryId = null)
        {
            InitializeComponent();
            _operationType = operationType;
            _inventoryId = inventoryId;

            _inventoryService = Program.ServiceProvider.GetRequiredService<IInventoryService>();
            _inventoryCategoryService = Program.ServiceProvider.GetRequiredService<IInventoryCategoryService>();

            InitializeForm();
        }

        private async void InitializeForm()
        {
            // Kategori lookup'ını doldur
            var categories = await _inventoryCategoryService.GetAllAsync();
            lookUp_InventoryCategory.Properties.DataSource = categories;

            // Lookup sütunlarını ayarla
            lookUp_InventoryCategory.Properties.Columns.Clear();
            lookUp_InventoryCategory.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryCode", "Kod"));
            lookUp_InventoryCategory.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kategori Adı"));
            
            // Görüntülenecek metni ayarla (Kod - Ad şeklinde)
            lookUp_InventoryCategory.Properties.DisplayMember = "CategoryCode";
            lookUp_InventoryCategory.Properties.ValueMember = "Id";
            lookUp_InventoryCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            // Özel görüntüleme formatı
            lookUp_InventoryCategory.Properties.CustomDisplayText += (sender, e) =>
            {
                if (e.Value != null)
                {
                    var category = categories.FirstOrDefault(c => c.Id == (int)e.Value);
                    if (category != null)
                    {
                        e.DisplayText = $"{category.CategoryCode} - {category.Name}";
                    }
                }
            };

            // Status combobox'ı doldur
            cmb_Status.Properties.Items.AddRange(Enum.GetValues(typeof(InventoryStatus)));

            if (_operationType == OperationType.Update && _inventoryId.HasValue)
            {
                await LoadInventory();
            }
            else
            {
                cmb_Status.SelectedItem = InventoryStatus.Active;
            }
        }

        private async System.Threading.Tasks.Task LoadInventory()
        {
            try
            {
                _inventory = await _inventoryService.GetByIdAsync(_inventoryId.Value);
                if (_inventory != null)
                {
                    // Temel Bilgiler
                    txt_Name.Text = _inventory.Name;
                    txt_InventoryCode.Text = _inventory.InventoryCode;
                    txt_BarcodeNumber.Text = _inventory.BarcodeNumber;
                    txt_QRCode.Text = _inventory.QRCode;
                    lookUp_InventoryCategory.EditValue = _inventory.InventoryCategoryId;
                    cmb_Status.SelectedItem = _inventory.Status;

                    // Detay Bilgileri
                    txt_SerialNumber.Text = _inventory.SerialNumber;
                    txt_Brand.Text = _inventory.Brand;
                    txt_Model.Text = _inventory.Model;
                    txt_Location.Text = _inventory.Location;
                    txt_Description.Text = _inventory.Description;

                    // Fiyat ve Tarih Bilgileri
                    spin_PurchasePrice.EditValue = _inventory.PurchasePrice;
                    spin_CurrentValue.EditValue = _inventory.CurrentValue;
                    dateEdit_LastMaintenanceDate.EditValue = _inventory.LastMaintenanceDate;
                    dateEdit_NextMaintenanceDate.EditValue = _inventory.NextMaintenanceDate;
                    dateEdit_CalibrationDueDate.EditValue = _inventory.CalibrationDueDate;
                    dateEdit_WarrantyExpirationDate.EditValue = _inventory.WarrantyExpirationDate;
                    spin_CalibrationPeriod.EditValue = _inventory.CalibrationPeriod;
                    spin_MaintenancePeriod.EditValue = _inventory.MaintenancePeriod;
                    dateEdit_ExpirationDate.EditValue = _inventory.ExpirationDate;

                    // Tedarikçi Bilgileri
                    txt_Supplier.Text = _inventory.Supplier;
                    txt_SupplierPhone.Text = _inventory.SupplierPhone;
                    txt_SupplierEmail.Text = _inventory.SupplierEmail;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Demirbaş bilgileri yüklenirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_operationType == OperationType.Add)
                    _inventory = new Inventory();

                // Temel Bilgiler
                _inventory.Name = txt_Name.Text;
                _inventory.InventoryCode = txt_InventoryCode.Text;
                _inventory.BarcodeNumber = txt_BarcodeNumber.Text;
                _inventory.QRCode = txt_QRCode.Text;
                _inventory.InventoryCategoryId = Convert.ToInt32(lookUp_InventoryCategory.EditValue);
                _inventory.Status = (InventoryStatus)cmb_Status.SelectedItem;

                // Detay Bilgileri
                _inventory.SerialNumber = txt_SerialNumber.Text;
                _inventory.Brand = txt_Brand.Text;
                _inventory.Model = txt_Model.Text;
                _inventory.Location = txt_Location.Text;
                _inventory.Description = txt_Description.Text;

                // Fiyat ve Tarih Bilgileri
                _inventory.PurchasePrice = spin_PurchasePrice.EditValue as decimal?;
                _inventory.CurrentValue = spin_CurrentValue.EditValue as decimal?;
                _inventory.LastMaintenanceDate = dateEdit_LastMaintenanceDate.EditValue as DateTime?;
                _inventory.NextMaintenanceDate = dateEdit_NextMaintenanceDate.EditValue as DateTime?;
                _inventory.CalibrationDueDate = dateEdit_CalibrationDueDate.EditValue as DateTime?;
                _inventory.WarrantyExpirationDate = dateEdit_WarrantyExpirationDate.EditValue as DateTime?;
                _inventory.CalibrationPeriod = spin_CalibrationPeriod.EditValue as int?;
                _inventory.MaintenancePeriod = spin_MaintenancePeriod.EditValue as int?;
                _inventory.ExpirationDate = dateEdit_ExpirationDate.EditValue as DateTime?;

                // Tedarikçi Bilgileri
                _inventory.Supplier = txt_Supplier.Text;
                _inventory.SupplierPhone = txt_SupplierPhone.Text;
                _inventory.SupplierEmail = txt_SupplierEmail.Text;

                if (_operationType == OperationType.Add)
                {
                    await _inventoryService.AddAsync(_inventory);
                    XtraMessageBox.Show("Demirbaş başarıyla eklendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _inventoryService.UpdateAsync(_inventory);
                    XtraMessageBox.Show("Demirbaş başarıyla güncellendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                XtraMessageBox.Show("Demirbaş adı boş olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_InventoryCode.Text))
            {
                XtraMessageBox.Show("Demirbaş kodu boş olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lookUp_InventoryCategory.EditValue == null)
            {
                XtraMessageBox.Show("Kategori seçimi yapılmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_ReadBarcode_Click(object sender, EventArgs e)
        {
            // Barkod okuyucu implementasyonu
            XtraMessageBox.Show("Barkod okuyucu özelliği henüz implementa edilmedi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ReadQRCode_Click(object sender, EventArgs e)
        {
            // QR kod okuyucu implementasyonu
            XtraMessageBox.Show("QR kod okuyucu özelliği henüz implementa edilmedi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_PrintBarcode_Click(object sender, EventArgs e)
        {
            // Barkod yazdırma implementasyonu
            XtraMessageBox.Show("Barkod yazdırma özelliği henüz implementa edilmedi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_PrintQRCode_Click(object sender, EventArgs e)
        {
            // QR kod yazdırma implementasyonu
            XtraMessageBox.Show("QR kod yazdırma özelliği henüz implementa edilmedi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}