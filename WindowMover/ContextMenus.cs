using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowMover.Properties;
using System.Drawing;
using WindowMover.Classes;

namespace WindowMover
{
    using Classes.Managers;
    using WindowMover.Forms;

    class ContextMenus
    {
        bool isAboutLoaded = false;
        bool isSettingsLoaded = false;

        bool isPositioningChecked = true;

        SystemProcessHookForm systemProcessHookForm;

        public ContextMenus(SystemProcessHookForm systemProcessHookForm)
        {
            this.systemProcessHookForm = systemProcessHookForm;
        }

        private ToolStripMenuItem positioningItem;
        private ToolStripMenuItem settingsItem;

        public ContextMenuStrip Create()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            positioningItem = new ToolStripMenuItem();
            positioningItem.CheckOnClick = true;
            positioningItem.Checked = Settings.Instance.Positioning;
            positioningItem.Text = "Pozycjonuj";
            positioningItem.Click += new EventHandler(Positioning_Click);
            menu.Items.Add(positioningItem);

            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            settingsItem = new ToolStripMenuItem();
            settingsItem.Text = "Opcje";
            settingsItem.Click += new EventHandler(Settings_Click);
            menu.Items.Add(settingsItem);

            //item = new ToolStripMenuItem();
            //item.Text = "O programie";
            //item.Click += new EventHandler(About_Click);
            //menu.Items.Add(item);

            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            item = new ToolStripMenuItem();
            item.Text = "Wyjdź";
            item.Click += new System.EventHandler(Exit_Click);
            menu.Items.Add(item);

            return menu;
        }

        private void SetPositioningItemState(bool state)
        {
            positioningItem.Checked = state;
            isPositioningChecked = state;

            Settings.Instance.Positioning = state;

            Settings.Instance.Save();
        }

        void Positioning_Click(object sender, EventArgs e)
        {
            isPositioningChecked = (sender as ToolStripMenuItem).Checked;

            if (isPositioningChecked)
            {
                if (Settings.Instance.UseTimerToSetPositions)
                {
                    TimerManager.EnableSetWindowPositionTimer();
                }
                else
                {
                    systemProcessHookForm = new SystemProcessHookForm();
                    systemProcessHookForm.WindowEvent += (localSender, data) => Console.WriteLine(data);
                }
            }
            if (!isPositioningChecked)
            {
                if (Settings.Instance.UseTimerToSetPositions)
                {
                    TimerManager.DisableSetWindowPositionTimer();
                }
                else
                {
                    systemProcessHookForm.Dispose();
                }
            }

            Settings.Instance.Positioning = ((sender as ToolStripMenuItem).Checked);

            Settings.Instance.Save();
        }

        void Settings_Click(object sender, EventArgs e)
        {
            if (!isSettingsLoaded)
            {
                isSettingsLoaded = true;

                new Forms.SettingsForm().ShowDialog();

                isSettingsLoaded = false;
            }
        }

        void About_Click(object sender, EventArgs e)
        {
            if (!isAboutLoaded)
            {
                isAboutLoaded = true;

                new AboutForm().ShowDialog();

                isAboutLoaded = false;
            }
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Settings.Instance.Save();
            Application.Exit();
        }
    }
}