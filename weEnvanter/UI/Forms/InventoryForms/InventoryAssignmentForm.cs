using System;
using System.Windows.Forms;
using weEnvanter.Services;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Forms.InventoryForms
{
    public partial class InventoryAssignmentForm : Form
    {
        private readonly IInventoryAssignmentService _inventoryAssignmentService;
        private readonly ISystemLogService _systemLogService;
        private InventoryAssignment _inventoryAssignment;
        private OperationType _operationType;

        public InventoryAssignmentForm()
        {
            InitializeComponent();
            _inventoryAssignmentService = Program.ServiceProvider.GetRequiredService<IInventoryAssignmentService>();
            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();
            LoadData();
        }

        private void LoadData()
        {
            // Load data from service
        }

        private bool ValidateForm()
        {
            // Implement form validation logic
            return true; // Placeholder return, actual implementation needed
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_operationType == OperationType.Add)
                    _inventoryAssignment = new InventoryAssignment() { IsActive = true };

                _inventoryAssignment.InventoryId = Convert.ToInt32(lookUp_Inventory.EditValue);
                _inventoryAssignment.EmployeeId = Convert.ToInt32(lookUp_Employee.EditValue);
                _inventoryAssignment.AssignmentDate = dateEdit_AssignmentDate.DateTime;
                _inventoryAssignment.ReturnDate = dateEdit_ReturnDate.DateTime;
                _inventoryAssignment.Notes = txt_Notes.Text;

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                if (_operationType == OperationType.Add)
                {
                    await _inventoryAssignmentService.AddAsync(_inventoryAssignment);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Zimmet Eklendi",
                        $"{userFullName} {now} tarihinde yeni bir zimmet kaydı ekledi.",
                        "InventoryAssignment",
                        _inventoryAssignment.Id.ToString(),
                        LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Zimmet başarıyla eklendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _inventoryAssignmentService.UpdateAsync(_inventoryAssignment);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Zimmet Güncellendi",
                        $"{userFullName} {now} tarihinde zimmet kaydını güncelledi.",
                        "InventoryAssignment",
                        _inventoryAssignment.Id.ToString(),
                        LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Zimmet başarıyla güncellendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Zimmet kaydedilirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridView_Assignment.GetFocusedRow() is InventoryAssignment selectedAssignment)
            {
                if (XtraMessageBox.Show("Seçili zimmeti silmek istediğinize emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        await _inventoryAssignmentService.DeleteAsync(selectedAssignment.Id);
                        string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                        string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        _systemLogService.LogActivity(
                            Program.CurrentUser?.Id,
                            "Zimmet Silindi",
                            $"{userFullName} {now} tarihinde zimmet kaydını sildi.",
                            "InventoryAssignment",
                            selectedAssignment.Id.ToString(),
                            LogType.Information.ToString()
                        );
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Zimmet silinirken bir hata oluştu: " + ex.Message, 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 