using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowMover.Classes.Managers
{
    using Properties;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;
    using HWND = IntPtr;

    public static class TimerManager
    {
        private static Timer setWindowPositionTimer = new Timer();

        public static void Mock()
        {

        }

        static TimerManager()
        {
            setWindowPositionTimer.Tick += SetWindowPositionTimer_Tick;

            if (Settings.Instance.Positioning)
            {
                TimerManager.EnableSetWindowPositionTimer();
            }
        }

        public static void RestartSetWindowPositionTimer()
        {
            DisableSetWindowPositionTimer();
            EnableSetWindowPositionTimer();
        }

        public static void EnableSetWindowPositionTimer()
        {
            if (Settings.Instance.TimerSetPositionTimeout > 0)
                setWindowPositionTimer.Interval = Settings.Instance.TimerSetPositionTimeout;
            else
                setWindowPositionTimer.Interval = 2500;

            setWindowPositionTimer.Enabled = true;
            setWindowPositionTimer.Start();
        }

        public static void DisableSetWindowPositionTimer()
        {
            setWindowPositionTimer.Enabled = false;
            setWindowPositionTimer.Dispose();
            setWindowPositionTimer.Stop();
            setWindowPositionTimer.Enabled = false;
        }

        private static void SetWindowPositionTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("PositioningTimer Tick");
            try
            {
                Classes.Managers.WindowManager.GetAllOpenedWindows();
                Classes.Managers.WindowHandlerManager.SetPositions();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
