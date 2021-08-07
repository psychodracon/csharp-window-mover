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
        private static Timer activeWindowTimer = new Timer();
        private static Timer setWindowPositionTimer = new Timer();

        public static void Mock()
        {

        }

        static TimerManager()
        {
            //activeWindowTimer.Tick += activeWindowTimer_Tick;
            setWindowPositionTimer.Tick += SetWindowPositionTimer_Tick;

            //if (!Settings.Instance.WorkMode)
            //{
            //    TimerManager.EnableActiveWindowTimer();
            //}

            if (Settings.Instance.Positioning)
            {
                TimerManager.EnableSetWindowPositionTimer();
            }

            //if (Settings.Instance.WorkModeAffectsPositioning && Settings.Instance.WorkMode)
            //{
            //    TimerManager.DisableSetWindowPositionTimer();
            //}
        }

        public static void RestartActiveWindowTimer()
        {
            DisableActiveWindowTimer();
            EnableActiveWindowTimer();
        }

        public static void RestartSetWindowPositionTimer()
        {
            DisableSetWindowPositionTimer();
            EnableSetWindowPositionTimer();
        }

        public static void EnableActiveWindowTimer()
        {
            if (Settings.Instance.TimerFullscreenDetectionTimeout > 0)
                activeWindowTimer.Interval = Settings.Instance.TimerFullscreenDetectionTimeout;
            else
                activeWindowTimer.Interval = 1500;

            activeWindowTimer.Enabled = true;
            activeWindowTimer.Start();
        }

        public static void DisableActiveWindowTimer()
        {
            activeWindowTimer.Stop();
            activeWindowTimer.Enabled = false;
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

        //private static void activeWindowTimer_Tick(object sender, EventArgs e)
        //{
        //    Console.WriteLine("PositioningTimer Tick");

        //    HWND activeWindow = WinApiWrapper.GetForegroundWindow();

        //    Screen screen = Screen.FromHandle(activeWindow);

        //    if (activeWindow != HWND.Zero)
        //    {
        //        Rectangle activeWindowRectangle = WindowManager.GetWindowRect(activeWindow);
        //        if (activeWindowRectangle != null)
        //        {
        //            Console.WriteLine(String.Format("Screen: {4}, X: {0}, Y: {1}, Width: {2}, Height: {3}", screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height, screen.DeviceName));

        //            Console.WriteLine(String.Format("Window on screen: {4}, X: {0}, Y: {1}, Width: {2}, Height: {3}", activeWindowRectangle.X, activeWindowRectangle.Y, activeWindowRectangle.Width, activeWindowRectangle.Height, screen.DeviceName));

        //            if (activeWindowRectangle.Width == screen.Bounds.Width && activeWindowRectangle.Height == screen.Bounds.Height)
        //            {
        //                Console.WriteLine("Fullscreen window detected");

        //                ScreenManager.ChangeScreenBrithness(screen, true);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Not fullscreen window detected");

        //                ScreenManager.ChangeScreenBrithness(screen, false);
        //            }
        //        }
        //    }
        //}
    }
}
