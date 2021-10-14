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
        SystemProcessHookForm systemProcessHookForm;

        public ProcessIcon()
        {
            notifyIcon = new NotifyIcon();
            Settings.Instance.Load();

            if (Settings.Instance.UseTimerToSetPositions)
            {
                TimerManager.Mock();
            }
            else
            {
                systemProcessHookForm = new SystemProcessHookForm();
                systemProcessHookForm.WindowEvent += (sender, data) => Console.WriteLine(data);
            }
        }

        public void Display()
        {		
            notifyIcon.Icon = Resources.Tray;
            notifyIcon.Text = "Window Mover";
            notifyIcon.Visible = true;

            notifyIcon.ContextMenuStrip = new ContextMenus(systemProcessHookForm).Create();
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}