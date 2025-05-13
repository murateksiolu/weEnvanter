using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.UI.Forms.UsersForms
{
    public partial class AddOrEditUserForm : DevExpress.XtraEditors.XtraForm
    {
        public AddOrEditUserForm(OperationType operationType, int userId = 0)
        {
            InitializeComponent();
        }
    }
}