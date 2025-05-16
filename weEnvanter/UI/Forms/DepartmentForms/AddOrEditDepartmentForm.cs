using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using weEnvanter.Domain.Enums;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Domain.Entities;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace weEnvanter.UI.Forms.DepartmentForms
{
    public partial class AddOrEditDepartmentForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly OperationType _operationType;
        private readonly int? _departmentId;
        private readonly IDepartmentService _departmentService;
        private readonly ISystemLogService _systemLogService;
        private Department _department;

        public AddOrEditDepartmentForm(IDepartmentService departmentService, OperationType operationType, int? departmentId = null)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _operationType = operationType;
            _departmentId = departmentId;

            _systemLogService = Program.ServiceProvider.GetRequiredService<ISystemLogService>();

            InitializeForm();
            SetValidationRules();
        }

        private void InitializeForm()
        {
            // Form başlığını ayarla
            switch (_operationType)
            {
                case OperationType.Add:
                    Text = "Yeni Departman Ekle";
                    toggle_IsActive.IsOn = true;
                    break;
                case OperationType.Update:
                    Text = "Departman Düzenle";
                    LoadDepartment(_departmentId.Value);
                    break;
                case OperationType.View:
                    Text = "Departman Detayları";
                    LoadDepartment(_departmentId.Value);
                    SetControlsReadOnly(true);
                    break;
            }

            // Üst departman listesini yükle
            LoadParentDepartments();
        }

        private void SetValidationRules()
        {
            // Departman Adı validasyonu
            dxValidationProvider1.SetValidationRule(txt_DepartmentName,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Departman adı boş olamaz!"
                });

            // Departman Kodu validasyonu
            dxValidationProvider1.SetValidationRule(txt_DepartmentCode,
                new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = "Departman kodu boş olamaz!"
                });
        }

        private void SetControlsReadOnly(bool isReadOnly)
        {
            txt_DepartmentName.Properties.ReadOnly = isReadOnly;
            txt_DepartmentCode.Properties.ReadOnly = isReadOnly;
            lookUp_ParentDepartment.Properties.ReadOnly = isReadOnly;
            txt_Description.Properties.ReadOnly = isReadOnly;
            toggle_IsActive.Properties.ReadOnly = isReadOnly;

            btn_Save.Visible = !isReadOnly;
            btn_Cancel.Visible = !isReadOnly;
        }

        private async void LoadParentDepartments()
        {
            try
            {
                var departments = await _departmentService.GetActiveAsync();
                if (_operationType == OperationType.Update && _departmentId.HasValue)
                {
                    // Kendisini üst departman listesinden çıkar
                    departments = departments.Where(d => d.Id != _departmentId.Value).ToList();
                }

                lookUp_ParentDepartment.Properties.DataSource = departments;
                lookUp_ParentDepartment.Properties.DisplayMember = "Name";
                lookUp_ParentDepartment.Properties.ValueMember = "Id";

                // Kolon ayarlarını güncelle
                lookUp_ParentDepartment.Properties.PopulateColumns();
                lookUp_ParentDepartment.Properties.Columns.Clear();
                
                // Id kolonunu gizli olarak ekle
                var idColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id");
                idColumn.Visible = false;
                lookUp_ParentDepartment.Properties.Columns.Add(idColumn);

                // Görünür kolonları ekle
                lookUp_ParentDepartment.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentCode", "Departman Kodu"));
                lookUp_ParentDepartment.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Departman Adı"));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Üst departman listesi yüklenirken bir hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadDepartment(int departmentId)
        {
            try
            {
                var department = await _departmentService.GetByIdAsync(departmentId);
                if (department != null)
                {
                    txt_DepartmentName.Text = department.Name;
                    txt_DepartmentCode.Text = department.DepartmentCode;
                    lookUp_ParentDepartment.EditValue = department.ParentDepartmentId;
                    txt_Description.Text = department.Description;
                    toggle_IsActive.IsOn = department.IsActive;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Departman bilgileri yüklenirken bir hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_operationType == OperationType.Add)
                    _department = new Department() { IsActive = true };

                _department.Name = txt_DepartmentName.Text;
                _department.DepartmentCode = txt_DepartmentCode.Text;
                _department.ParentDepartmentId = lookUp_ParentDepartment.EditValue as int?;
                _department.Description = txt_Description.Text;
                _department.IsActive = toggle_IsActive.IsOn;

                string userFullName = Program.CurrentUser != null ? $"{Program.CurrentUser.FirstName} {Program.CurrentUser.LastName}" : "Bilinmeyen Kullanıcı";
                string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                if (_operationType == OperationType.Add)
                {
                    await _departmentService.AddAsync(_department);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Departman Eklendi",
                        $"{userFullName} {now} tarihinde '{_department.Name}' isimli departmanı ekledi.",
                        "Department",
                        _department.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Departman başarıyla eklendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _departmentService.UpdateAsync(_department);
                    _systemLogService.LogActivity(
                        Program.CurrentUser?.Id,
                        "Departman Güncellendi",
                        $"{userFullName} {now} tarihinde '{_department.Name}' isimli departmanı güncelledi.",
                        "Department",
                        _department.Id.ToString(),
                        weEnvanter.Domain.Enums.LogType.Information.ToString()
                    );
                    XtraMessageBox.Show("Departman başarıyla güncellendi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Departman kaydedilirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txt_DepartmentCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Departman kodunu otomatik büyük harfe çevir
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private bool ValidateForm()
        {
            if (!dxValidationProvider1.Validate())
                return false;

            // Departman kodu benzersiz mi kontrol et
            if (_operationType == OperationType.Add || 
                (_operationType == OperationType.Update && txt_DepartmentCode.IsModified))
            {
                bool isUnique = _departmentService.IsDepartmentCodeUniqueAsync(txt_DepartmentCode.Text).Result;
                if (!isUnique)
                {
                    XtraMessageBox.Show("Bu departman kodu zaten kullanılıyor.",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
    }
}