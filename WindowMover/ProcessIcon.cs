using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowMover.Properties;

namespace WindowMover
{
    class ProcessIcon : IDisposable
    {
        NotifyIcon notifyIcon;

        public ProcessIcon()
        {
            notifyIcon = new NotifyIcon();
        }

        public void Display()
        {		
            notifyIcon.Icon = Resources.Tray;
            notifyIcon.Text = "Window Mover";
            notifyIcon.Visible = true;

            notifyIcon.ContextMenuStrip = new ContextMenus().Create();
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}