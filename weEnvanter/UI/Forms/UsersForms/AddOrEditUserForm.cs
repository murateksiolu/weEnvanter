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
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.UsersForms
{
    public partial class AddOrEditUserForm : DevExpress.XtraEditors.XtraForm
    {
        public AddOrEditUserForm(OperationType operationType, User user = null)
        {
            InitializeComponent();
        }
    }
}