using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowMover.Classes;
using WindowMover.Classes.Managers;

namespace WindowMover.Forms
{
    public class SystemProcessHookForm : Form
    {
        private readonly int msgNotify;
        public delegate void EventHandler(object sender, string data);
        public event EventHandler WindowEvent;
        protected virtual void OnWindowEvent(string data)
        {
            var handler = WindowEvent;
            if (handler != null)
            {
                handler(this, data);
            }
        }

        public SystemProcessHookForm()
        {
            msgNotify = WinApiWrapper.RegisterWindowMessage("SHELLHOOK");
            WinApiWrapper.RegisterShellHookWindow(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == msgNotify)
            {
                switch ((WinApiWrapper.ShellEvents)m.WParam.ToInt32())
                {
                    case WinApiWrapper.ShellEvents.HSHELL_WINDOWCREATED:
                    case WinApiWrapper.ShellEvents.HSHELL_WINDOWACTIVATED:
                    case WinApiWrapper.ShellEvents.HSHELL_RUDEAPPACTIVATED:
                        Window window = WindowManager.GetWindowInfo(m.HWnd);
                        WindowHandlerManager.SetPosition(window);
                        break;
                }
            }
            base.WndProc(ref m);
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                WinApiWrapper.DeregisterShellHookWindow(this.Handle);
            }
            catch
            {
            }
            base.Dispose(disposing);
        }
    }
}
