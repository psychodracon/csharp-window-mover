using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowMover.Classes;
using WindowMover.Classes.Managers;
using WindowMover.Forms;
using WindowMover.Properties;

namespace WindowMover
{
    class ProcessIcon : IDisposable
    {
        NotifyIcon notifyIcon;
        TimerManager timerManager;
        WindowManager windowManager;
        WindowHandlerManager windowHandlerManager;

        public ProcessIcon(WindowManager windowManager, WindowHandlerManager windowHandlerManager, TimerManager timerManager)
        {
            this.windowManager = windowManager;
            this.windowHandlerManager = windowHandlerManager;
            this.timerManager = timerManager;

            notifyIcon = new NotifyIcon();
        }

        public void Display()
        {
            notifyIcon.Icon = Resources.Tray;
            notifyIcon.Text = "Window Mover";
            notifyIcon.Visible = true;

            notifyIcon.ContextMenuStrip = new ContextMenus(windowManager, windowHandlerManager, timerManager).Create();
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}