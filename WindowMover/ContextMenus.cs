using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowMover.Properties;
using System.Drawing;
using WindowMover.Classes;

namespace WindowMover
{
    using Classes.Managers;

    class ContextMenus
    {
        bool isAboutLoaded = false;
        bool isSettingsLoaded = false;

        //bool isWorkModeChecked = false;
        //bool isNightModeChecked = false;
        bool isPositioningChecked = true;

        public ContextMenus()
        {
            Settings.Instance.Load();
            TimerManager.Mock();
        }

        private ToolStripMenuItem workModeItem;
        private ToolStripMenuItem nightModeItem;
        private ToolStripMenuItem positioningItem;
        private ToolStripMenuItem settingsItem;

        public ContextMenuStrip Create()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            //workModeItem = new ToolStripMenuItem();
            //workModeItem.CheckOnClick = true;
            //workModeItem.Checked = Settings.Instance.WorkMode;
            //workModeItem.Text = "Tryb pracy";
            //workModeItem.Click += new EventHandler(WorkMode_Click);
            //menu.Items.Add(workModeItem);

            //nightModeItem = new ToolStripMenuItem();
            //nightModeItem.CheckOnClick = true;
            //nightModeItem.Checked = Settings.Instance.NightMode;
            //nightModeItem.Text = "Tryb nocny";
            //nightModeItem.Click += new EventHandler(NightMode_Click);
            //menu.Items.Add(nightModeItem);

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

        //void WorkMode_Click(object sender, EventArgs e)
        //{
        //    isWorkModeChecked = (sender as ToolStripMenuItem).Checked;

        //    bool workModeIsAffectingPositioning = Settings.Instance.WorkModeAffectsPositioning;

        //    if (isWorkModeChecked)
        //    {
        //        TimerManager.DisableActiveWindowTimer();

        //        if (workModeIsAffectingPositioning)
        //        {
        //            TimerManager.DisableSetWindowPositionTimer();
        //            SetPositioningItemState(false);
        //        }
        //    }
        //    if (!isWorkModeChecked)
        //    {
        //        TimerManager.EnableActiveWindowTimer();

        //        if (workModeIsAffectingPositioning)
        //        {
        //            TimerManager.EnableSetWindowPositionTimer();
        //            SetPositioningItemState(true);
        //        }
        //    }

        //    Settings.Instance.WorkMode = ((sender as ToolStripMenuItem).Checked);

        //    Settings.Instance.Save();
        //}

        //void NightMode_Click(object sender, EventArgs e)
        //{
        //    isNightModeChecked = (sender as ToolStripMenuItem).Checked;
        //    Settings.Instance.NightMode = ((sender as ToolStripMenuItem).Checked);
        //    Settings.Instance.Save();

        //    ScreenManager.ChangeAllScreenBrithnessToDefault();
        //}
        void Positioning_Click(object sender, EventArgs e)
        {
            isPositioningChecked = (sender as ToolStripMenuItem).Checked;

            if (isPositioningChecked)
            {
                TimerManager.EnableActiveWindowTimer();
                TimerManager.EnableSetWindowPositionTimer();
            }
            if (!isPositioningChecked)
            {
                TimerManager.DisableSetWindowPositionTimer();
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