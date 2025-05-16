using System;
using System.Windows.Forms;
using weEnvanter.Services;
using DevExpress.XtraEditors;

namespace weEnvanter.Forms.InventoryForms
{
    public partial class InventoryCategoryListForm : Form
    {
        private readonly IInventoryCategoryService _inventoryCategoryService;
        private readonly ISystemLogService _systemLogService;

        public InventoryCategoryListForm()
        {
            InitializeComponent();
            _inventoryCategoryService = Program.ServiceProvider.GetRequiredService<IInventoryCategoryService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            LoadData();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridView_Category.GetFocusedRow() is InventoryCategory selectedCategory)
            {
                if (XtraMessageBox.Show("Seçili envanter kategorisini silmek istediğinize emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        await _inventoryCategoryService.DeleteAsync(selectedCategory.Id);
                        string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                        string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        _systemLogService.LogActivity(
                            Program.CurrentUser?.Id,
                            "Envanter Kategorisi Silindi",
                            $"{userFullName} {now} tarihinde '{selectedCategory.Name}' isimli envanter kategorisini sildi.",
                            "InventoryCategory",
                            selectedCategory.Id.ToString(),
                            weEnvanter.Domain.Enums.LogType.Information.ToString()
                        );
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Envanter kategorisi silinirken bir hata oluştu: " + ex.Message, 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                _systemLogService.LogActivity(
                    Program.CurrentUser?.Id,
                    "Envanter Kategorisi Listesi Dışa Aktarıldı",
                    $"{userFullName} {now} tarihinde envanter kategorisi listesini dışa aktardı.",
                    "InventoryCategory",
                    null,
                    weEnvanter.Domain.Enums.LogType.Information.ToString()
                );
                // Export işlemi burada yapılacak
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Dışa aktarma sırasında bir hata oluştu: " + ex.Message, 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 