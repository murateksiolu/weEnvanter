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

namespace weEnvanter.UI.Forms.InventoryForms
{
    public partial class AddOrEditInventoryForm : DevExpress.XtraEditors.XtraForm
    {
        public AddOrEditInventoryForm(OperationType operationType,int? inventoryId = 0)
        {
            InitializeComponent();
        }
    }
}