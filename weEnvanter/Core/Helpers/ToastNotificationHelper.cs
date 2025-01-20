using DevExpress.XtraBars.ToastNotifications;
using System.ComponentModel;

namespace weEnvanter.Core.Helpers
{
    public static class ToastNotificationHelper
    {
        public static ToastNotificationsManager CreateManager(IContainer components)
        {
            var manager = new ToastNotificationsManager(components);
            manager.ApplicationId = "weEnvanter";

            // Başarı bildirimi
            manager.Notifications.Add(new ToastNotification
            {
                ID = "Success",
                Body = "İşlem başarılı.",
                Template = ToastNotificationTemplate.ImageAndText01,
                Image = Properties.Resources.weEnvanter_icon
            });

            // Hata bildirimi
            manager.Notifications.Add(new ToastNotification
            {
                ID = "Error",
                Body = "Bir hata oluştu!",
                Template = ToastNotificationTemplate.ImageAndText01,
                Image = Properties.Resources.weEnvanter_icon
            });

            // Uyarı bildirimi
            manager.Notifications.Add(new ToastNotification
            {
                ID = "Warning",
                Body = "Uyarı!",
                Template = ToastNotificationTemplate.ImageAndText01,
                Image = Properties.Resources.weEnvanter_icon
            });

            return manager;
        }

        public static void ShowSuccess(this ToastNotificationsManager manager, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                var notification = manager.GetNotificationByID("Success");
                if (notification != null)
                {
                    notification.Body = message;
                }
            }
            manager.ShowNotification("Success");
        }

        public static void ShowError(this ToastNotificationsManager manager, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                var notification = manager.GetNotificationByID("Error");
                if (notification != null)
                {
                    notification.Body = message;
                }
            }
            manager.ShowNotification("Error");
        }

        public static void ShowWarning(this ToastNotificationsManager manager, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                var notification = manager.GetNotificationByID("Warning");
                if (notification != null)
                {
                    notification.Body = message;
                }
            }
            manager.ShowNotification("Warning");
        }
    }
} 