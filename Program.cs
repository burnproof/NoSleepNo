using System;
using System.Windows.Forms;
using System.Configuration;

namespace NoSleepNo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyCustomApplicationContext());
        }
    }


    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon TrayIcon;
        public static bool Enabled = true;
        private static System.Timers.Timer aTimer;
        private MenuItem[] MenusS = new MenuItem[2];
        private int pollRate = Convert.ToInt32(ConfigurationManager.AppSettings["pollRate"]);
        private static string Button = ConfigurationManager.AppSettings["Button"];

        public MyCustomApplicationContext()
        {
            MenusS[0] = new MenuItem("Enabled", Enable);
            MenusS[0].Checked = Enabled;
            MenusS[1] = new MenuItem("Exit", Exit);
            
            // Initialize Tray Icon
            TrayIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.Icon1,
                ContextMenu = new ContextMenu(MenusS),
                Visible = true
            };

            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = pollRate;
            aTimer.Elapsed += OnTimedEvent; // Hook up the Elapsed event for the timer. 
            aTimer.AutoReset = true; // Have the timer fire repeated events (true is the default)
            aTimer.Enabled = true; // Start the timer
        }

        void Enable(object sender, EventArgs e)
        {
            Enabled = (!Enabled);
            MenusS[0].Checked = Enabled;
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            TrayIcon.Visible = false;

            Application.Exit();
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (Enabled) {
                SendKeys.SendWait(Button);
            }   
        }
    }
}
