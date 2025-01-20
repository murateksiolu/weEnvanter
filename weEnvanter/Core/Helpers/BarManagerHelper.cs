using DevExpress.XtraBars;

namespace weEnvanter.Core.Helpers
{
    public static class BarManagerHelper
    {
        public static void SetBarManagerSettings(BarManager barManager)
        {
            barManager.AllowCustomization = false;
            barManager.AllowQuickCustomization = false;
            barManager.AllowMoveBarOnToolbar = false;

        }
    }
}
