using DevExpress.XtraEditors;
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
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.MaintenanceForms
{
    public partial class AddOrEditMaintenanceForm : DevExpress.XtraEditors.XtraForm
    {
        public AddOrEditMaintenanceForm(IMaintenanceService maintenanceService, OperationType operationType,int id = 0 )
        {
            InitializeComponent();
        }
    }
}