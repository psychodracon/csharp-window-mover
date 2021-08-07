using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowMover.Classes;
using WindowMover.Classes.Managers;
using WindowMover.Properties;

namespace WindowMover.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            
            this.nudSetPositions.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "TimerSetPositionTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudFullScreen.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "TimerFullscreenDetectionTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWorkMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Settings.Instance, "WorkModeAffectsPositioning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            this.tbBrightnessDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "DayMonitorBrightness", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbContrastDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "DayMonitorContrast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbBrightnessNight.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "NightMonitorBrightness", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbContrastNight.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "NightMonitorContrast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            this.nudBrightnessOffset.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "BrightnessOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudContrastOffset.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "ContrastOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkOffset.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Settings.Instance, "UseOffsetForFirstMonitor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            this.Location = Settings.Instance.WindowSettingsLocation;
            this.Size = Settings.Instance.WindowSettingsSize;

            this.Text = "Opcje";

            dgVHandlers.AllowDrop = false;
            dgVHandlers.MultiSelect = false;
            dgVHandlers.AutoGenerateColumns = false;
            dgVHandlers.DataSource = Classes.Managers.WindowHandlerManager.windowHandlers;

            dgVHandlers.AllowUserToResizeColumns = false;
            dgVHandlers.AllowUserToOrderColumns = false;

            dgVHandlers.Columns["clActive"].DataPropertyName = "handlerActive";
            //dgVHandlers.Columns["clActive"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgVHandlers.Columns["clName"].DataPropertyName = "handlerName";
            //dgVHandlers.Columns["clName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            nudBrightnessOffset.Minimum = -100;
            nudContrastOffset.Minimum = -100;
        }
        
        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            //Data Grid not showing at first time ugly fix
            this.settingsTabControl.SelectedIndex = 1;
            this.settingsTabControl.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Forms.WindowHandlerForm("Dodaj zaczep", Classes.EditorMode.New, null).ShowDialog();

            RefreshAndSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgVHandlers.CurrentRow != null)
            {
                new Forms.WindowHandlerForm("Edytuj zaczep", Classes.EditorMode.Edit, (Classes.WindowHandler)dgVHandlers.CurrentRow.DataBoundItem).ShowDialog();

                RefreshAndSave();
            }
            else
                return;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgVHandlers.CurrentRow == null)
                return;
            
            if (MessageBox.Show("Czy na pewno chesz usunąć zaczep?", "Usuń", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            else
            {
                if (dgVHandlers.CurrentRow != null)
                {
                    Classes.Managers.WindowHandlerManager.Remove((Classes.WindowHandler)dgVHandlers.CurrentRow.DataBoundItem);
                    RefreshAndSave();
                }
            }
        }

        private void RefreshAndSave()
        {
            dgVHandlers.DataSource = null;
            dgVHandlers.DataSource = Classes.Managers.WindowHandlerManager.windowHandlers;

            Classes.Managers.WindowHandlerManager.Save();
        }

        private void btnSetPosition_Click(object sender, EventArgs e)
        {
            Classes.Managers.WindowManager.GetAllOpenedWindows();
            Classes.Managers.WindowHandlerManager.SetPositions();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Instance.SettingsChanged())
            {
                if (MessageBox.Show("Ustawienia zostały zmienione, czy zapamiętać?", "Dracon`s Utils", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Settings.Instance.Save();
                }
                else
                {
                    Settings.Instance.Load();
                }
            }

            Settings.Instance.WindowSettingsLocation = this.Location;

            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Instance.WindowSettingsSize = this.Size;
            }
            else
            {
                Settings.Instance.WindowSettingsSize = this.RestoreBounds.Size;
            }

            Settings.Instance.Save();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Instance.Save();
        }

        private void dgVHandlers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            WindowHandlerManager.Save();
        }
  
        private void tbBrightnessDay_ValueChanged(object sender, EventArgs e)
        {
            this.lblBrightnessValueDay.Text = (sender as TrackBar).Value.ToString();
        }

        private void tbContrastDay_ValueChanged(object sender, EventArgs e)
        {
            this.lblContrastValueDay.Text = (sender as TrackBar).Value.ToString();
        }

        private void tbBrightnessNight_ValueChanged(object sender, EventArgs e)
        {
            this.lblBrightnessValueNight.Text = (sender as TrackBar).Value.ToString();
        }

        private void tbContrastNight_ValueChanged(object sender, EventArgs e)
        {
            this.lblContrastValueNight.Text = (sender as TrackBar).Value.ToString();
        }
    }
}
