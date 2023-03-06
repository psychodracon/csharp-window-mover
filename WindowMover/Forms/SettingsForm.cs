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
        private WindowManager windowManager;
        private WindowHandlerManager windowHandlerManager;

        public SettingsForm(WindowManager windowManager, WindowHandlerManager windowHandlerManager)
        {
            this.windowManager = windowManager;
            this.windowHandlerManager = windowHandlerManager;

            InitializeComponent();
            
            this.nudSetPositions.DataBindings.Add(new System.Windows.Forms.Binding("Value", Settings.Instance, "TimerSetPositionTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = Settings.Instance.WindowSettingsLocation;
            this.Size = Settings.Instance.WindowSettingsSize;

            this.Text = "Opcje";

            dgVHandlers.AllowDrop = false;
            dgVHandlers.MultiSelect = false;
            dgVHandlers.AutoGenerateColumns = false;
            dgVHandlers.DataSource = windowHandlerManager.GetWindowHandlers();

            dgVHandlers.AllowUserToResizeColumns = false;
            dgVHandlers.AllowUserToOrderColumns = false;

            dgVHandlers.Columns["clActive"].DataPropertyName = "handlerActive";
            dgVHandlers.Columns["clName"].DataPropertyName = "handlerName";
        }
        
        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            //Data Grid not showing at first time ugly fix
            this.settingsTabControl.SelectedIndex = 1;
            this.settingsTabControl.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Forms.WindowHandlerForm(windowManager, windowHandlerManager, "Dodaj zaczep", Classes.EditorMode.New, null).ShowDialog();

            RefreshAndSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgVHandlers.CurrentRow != null)
            {
                new Forms.WindowHandlerForm(windowManager, windowHandlerManager, "Edytuj zaczep", Classes.EditorMode.Edit, (Classes.WindowHandler)dgVHandlers.CurrentRow.DataBoundItem).ShowDialog();

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
                    windowHandlerManager.Remove((Classes.WindowHandler)dgVHandlers.CurrentRow.DataBoundItem);
                    RefreshAndSave();
                }
            }
        }

        private void RefreshAndSave()
        {
            dgVHandlers.DataSource = null;
            dgVHandlers.DataSource = windowHandlerManager.GetWindowHandlers();

            windowHandlerManager.Save();
        }

        private void btnSetPosition_Click(object sender, EventArgs e)
        {
            windowHandlerManager.SetPositions(windowManager);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Instance.GetSettingsChanged())
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
            Settings.Instance.SetSettingsChanged(false);
        }

        private void dgVHandlers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            windowHandlerManager.Save();
        }
    }
}
