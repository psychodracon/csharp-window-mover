// using Ninjacrab.PersistentWindows.Common;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowMover.Classes;
using WindowMover.Classes.Managers;

namespace WindowMover
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings.Instance.Load();

            WindowManager windowManager = new WindowManager();
            WindowHandlerManager windowHandlerManager = new WindowHandlerManager();
            AutomationManager automationManager = new AutomationManager(windowManager, windowHandlerManager);
            TimerManager timerManager = new TimerManager(windowManager, windowHandlerManager);

            automationManager.SubscribeToEvents();

            using (ProcessIcon processIcon = new ProcessIcon(windowManager, windowHandlerManager, timerManager))
            {
#if DEBUG
                AllocConsole();
#endif
                processIcon.Display();
                Application.Run();
            }
        }
#if DEBUG
        [DllImport("KERNEL32.DLL", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
#endif
    }
}