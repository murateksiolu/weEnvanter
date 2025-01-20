using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.UI.Forms.InventoryForms
{
    public partial class AssignInventoryToEmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInventoryService _inventoryService;
        private readonly IEmployeeService _employeeService;

        public AssignInventoryToEmployeeForm(int inventoryId)
        {
            InitializeComponent();

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var employees = _employeeService.GetAllAsync().Result;
            // Çalışanları lookup'a yükle
            // lookUpEdit_Employee.Properties.DataSource = employees;
            // lookUpEdit_Employee.Properties.DisplayMember = "FullName";
            // lookUpEdit_Employee.Properties.ValueMember = "Id";
        }
    }
}