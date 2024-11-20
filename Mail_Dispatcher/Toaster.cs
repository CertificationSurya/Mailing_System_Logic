
namespace Mail_Dispatcher
{
    public enum NotificationType
    {
        Error,
        Info,
        Warn
    }

    public partial class Toaster
    {
        public static void ShowNotification(string title, string message, NotificationType type = NotificationType.Info)
        {
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.WinLogo, // Use a system icon or your own
                Visible = true,
                BalloonTipTitle = title,
                BalloonTipText = message,
            };

            if (type == NotificationType.Error) {  }

            switch (type)
            {
                case NotificationType.Info:
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Info; 
                    break;

                case NotificationType.Error:
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Error; 
                    break;

                case NotificationType.Warn:
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Warning; 
                    break;

            }

            notifyIcon.ShowBalloonTip(2000); // Show notification for 2 seconds
            // Dispose NotifyIcon when done
            notifyIcon.Dispose();
        }
    }


}
