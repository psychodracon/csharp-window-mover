using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowMover.Classes.Managers
{
    public class TimerManager
    {
        private Timer setWindowPositionTimer = new Timer();
        private WindowManager windowManager;
        private WindowHandlerManager windowHandlerManager;

        BackgroundWorker worker = new BackgroundWorker();
        public TimerManager(WindowManager windowManager, WindowHandlerManager windowHandlerManager)
        {
            this.windowManager = windowManager;
            this.windowHandlerManager = windowHandlerManager;

            worker.DoWork += new DoWorkEventHandler(SetWindowPostionTimer_DoWork);
            setWindowPositionTimer.Tick += SetWindowPositionTimer_Tick;
            if (Settings.Instance.Positioning)
            {
                EnableSetWindowPositionTimer();
            }
        }

        public void RestartSetWindowPositionTimer()
        {
            DisableSetWindowPositionTimer();
            EnableSetWindowPositionTimer();
        }

        public void EnableSetWindowPositionTimer()
        {
            if (Settings.Instance.TimerSetPositionTimeout > 0)
                setWindowPositionTimer.Interval = Settings.Instance.TimerSetPositionTimeout;
            else
                setWindowPositionTimer.Interval = 2500;

            setWindowPositionTimer.Enabled = true;
            setWindowPositionTimer.Start();
        }

        public void DisableSetWindowPositionTimer()
        {
            setWindowPositionTimer.Enabled = false;
            setWindowPositionTimer.Dispose();
            setWindowPositionTimer.Stop();
            setWindowPositionTimer.Enabled = false;
        }

        private void SetWindowPositionTimer_Tick(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void SetWindowPostionTimer_DoWork(object sender, EventArgs e)
        {
            try
            {
                windowManager.GetAllProcesses();
                windowHandlerManager.SetPositions(windowManager);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
