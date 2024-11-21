
//namespace Mail_Dispatcher
//{
//    public enum NotificationType
//    {
//        Error,
//        Info,
//        Warn
//    }

//    public partial class Toaster
//    {
//        // Make the notifyIcon thread-safe and nullable
//        private static readonly object _lockObject = new object();
//        private static NotifyIcon _notifyIcon;

//        // Ensure only one NotifyIcon is created
//        private static NotifyIcon GetOrCreateNotifyIcon()
//        {
//            lock (_lockObject)
//            {
//                if (_notifyIcon == null)
//                {
//                    _notifyIcon = new NotifyIcon
//                    {
//                        Icon = SystemIcons.WinLogo,
//                        Visible = true
//                    };
//                }
//                return _notifyIcon;
//            }
//        }

//        public static void ShowNotification(string title, string message, NotificationType type = NotificationType.Info)
//        {
//            //// Use the thread-safe method to get or create NotifyIcon
//            //_notifyIcon = GetOrCreateNotifyIcon();

//            if (_notifyIcon != null)
//            {
//                _notifyIcon = null;
//            }
//            _notifyIcon = GetOrCreateNotifyIcon();

//            // Set notification properties
//            _notifyIcon.BalloonTipTitle = title;
//            _notifyIcon.BalloonTipText = message;

//            // Set icon based on notification type
//            switch (type)
//            {
//                case NotificationType.Info:
//                    _notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
//                    break;
//                case NotificationType.Error:
//                    _notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
//                    break;
//                case NotificationType.Warn:
//                    _notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;
//                    break;
//            }

//            // Show the new notification
//            _notifyIcon.ShowBalloonTip(2000);
//        }

//        // Optional: Method to clean up the NotifyIcon when your application closes
//        public static void CleanUp()
//        {
//            lock (_lockObject)
//            {
//                if (_notifyIcon != null)
//                {
//                    _notifyIcon.Dispose();
//                    _notifyIcon = null;
//                }
//            }
//        }
//    }
//}


namespace Mail_Dispatcher
{
    public enum NotificationType
    {
        Error,
        Info,
        Warn
    }

    public sealed class Toaster
    {
        // Singleton instance
        private static readonly Lazy<Toaster> _instance =
            new Lazy<Toaster>(() => new Toaster(), LazyThreadSafetyMode.ExecutionAndPublication);

        // Static method to access the singleton instance
        public static Toaster Instance => _instance.Value;

        // Private NotifyIcon instance
        private NotifyIcon _notifyIcon;

        // Private lock object for thread safety
        private readonly object _lockObject = new object();

        // Private constructor to prevent external instantiation
        private Toaster()
        {
            InitializeNotifyIcon();
        }

        // Initialize NotifyIcon
        private NotifyIcon InitializeNotifyIcon()
        {
            lock (_lockObject)
            {
                return _notifyIcon ??  new NotifyIcon
                    {
                        Icon = SystemIcons.WinLogo,
                        Visible = true
                    };
            }
        }

        // Show notification method
        public void ShowNotification(string title, string message, NotificationType type = NotificationType.Info)
        {
            lock (_lockObject)
            {
                try
                {
                    //// Ensure NotifyIcon exists
                    if (_notifyIcon != null)
                    {
                        _notifyIcon.Visible = false;
                        _notifyIcon.Visible = true;
                    }
                    else{
                        _notifyIcon = InitializeNotifyIcon();
                    }

                    // Set notification properties
                    _notifyIcon.BalloonTipTitle = title;
                    _notifyIcon.BalloonTipText = message;

                    // Set icon based on notification type
                    switch (type)
                    {
                        case NotificationType.Info:
                            _notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                            break;
                        case NotificationType.Error:
                            _notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                            break;
                        case NotificationType.Warn:
                            _notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;
                            break;
                    }

                    // Show the new notification
                    _notifyIcon.ShowBalloonTip(2000);
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                    System.Diagnostics.Debug.WriteLine($"Notification error: {ex.Message}");
                }
            }
        }

        // Cleanup method
        public void CleanUp()
        {
            lock (_lockObject)
            {
                if (_notifyIcon != null)
                {
                    _notifyIcon.Dispose();
                    _notifyIcon = null;
                }
            }
        }

        // Destructor to ensure cleanup
        ~Toaster()
        {
            CleanUp();
        }
    }
}