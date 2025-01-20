using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weEnvanter.Core.Helpers
{
    public static class GeneralHelper
    {
        public static bool FormIsOpen(string formName)
        {
            bool result = false;

            FormCollection formCollection = Application.OpenForms;

            foreach (Form form in formCollection)
            {
                if (form.Name == formName)
                    result = true;
            }

            return result;
        }
    }
}
