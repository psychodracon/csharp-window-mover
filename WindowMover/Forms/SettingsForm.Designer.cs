namespace WindowMover.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tlpHandlerList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpList = new System.Windows.Forms.TableLayoutPanel();
            this.dgVHandlers = new System.Windows.Forms.DataGridView();
            this.clActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSetPosition = new System.Windows.Forms.Button();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.tpHandlers = new System.Windows.Forms.TabPage();
            this.tpOthers = new System.Windows.Forms.TabPage();
            this.tlpOthersButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.tlpOthers = new System.Windows.Forms.TableLayoutPanel();
            this.gbTimers = new System.Windows.Forms.GroupBox();
            this.lblSetPositionsMs = new System.Windows.Forms.Label();
            this.nudSetPositions = new System.Windows.Forms.NumericUpDown();
            this.lblSetPositions = new System.Windows.Forms.Label();
            this.tlpHandlerList.SuspendLayout();
            this.tlpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVHandlers)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.tpHandlers.SuspendLayout();
            this.tpOthers.SuspendLayout();
            this.tlpOthersButtons.SuspendLayout();
            this.tlpOthers.SuspendLayout();
            this.gbTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHandlerList
            // 
            this.tlpHandlerList.BackColor = System.Drawing.Color.Transparent;
            this.tlpHandlerList.ColumnCount = 1;
            this.tlpHandlerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHandlerList.Controls.Add(this.tlpList, 0, 1);
            this.tlpHandlerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHandlerList.Location = new System.Drawing.Point(3, 3);
            this.tlpHandlerList.Name = "tlpHandlerList";
            this.tlpHandlerList.Padding = new System.Windows.Forms.Padding(0, 0, 88, 0);
            this.tlpHandlerList.RowCount = 2;
            this.tlpHandlerList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHandlerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHandlerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHandlerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHandlerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHandlerList.Size = new System.Drawing.Size(626, 398);
            this.tlpHandlerList.TabIndex = 8;
            // 
            // tlpList
            // 
            this.tlpList.ColumnCount = 1;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpList.Controls.Add(this.dgVHandlers, 0, 0);
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.Location = new System.Drawing.Point(3, 3);
            this.tlpList.Name = "tlpList";
            this.tlpList.RowCount = 1;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tlpList.Size = new System.Drawing.Size(532, 392);
            this.tlpList.TabIndex = 7;
            // 
            // dgVHandlers
            // 
            this.dgVHandlers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgVHandlers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVHandlers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgVHandlers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVHandlers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clActive,
            this.clName});
            this.dgVHandlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVHandlers.GridColor = System.Drawing.SystemColors.Window;
            this.dgVHandlers.Location = new System.Drawing.Point(3, 3);
            this.dgVHandlers.Name = "dgVHandlers";
            this.dgVHandlers.Size = new System.Drawing.Size(526, 386);
            this.dgVHandlers.TabIndex = 2;
            this.dgVHandlers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVHandlers_CellValueChanged);
            // 
            // clActive
            // 
            this.clActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clActive.FillWeight = 31.47208F;
            this.clActive.HeaderText = "Aktywny";
            this.clActive.Name = "clActive";
            this.clActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clName
            // 
            this.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clName.FillWeight = 168.5279F;
            this.clName.HeaderText = "Nazwa";
            this.clName.Name = "clName";
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tlpButtons.Controls.Add(this.btnEdit, 0, 1);
            this.tlpButtons.Controls.Add(this.btnRemove, 0, 2);
            this.tlpButtons.Controls.Add(this.btnSetPosition, 0, 5);
            this.tlpButtons.Location = new System.Drawing.Point(543, 6);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 6;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.Size = new System.Drawing.Size(81, 141);
            this.tlpButtons.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(3, 61);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSetPosition
            // 
            this.btnSetPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPosition.Location = new System.Drawing.Point(3, 115);
            this.btnSetPosition.Name = "btnSetPosition";
            this.btnSetPosition.Size = new System.Drawing.Size(75, 23);
            this.btnSetPosition.TabIndex = 5;
            this.btnSetPosition.Text = "Pozycjonuj";
            this.btnSetPosition.Click += new System.EventHandler(this.btnSetPosition_Click);
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.tpHandlers);
            this.settingsTabControl.Controls.Add(this.tpOthers);
            this.settingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(640, 430);
            this.settingsTabControl.TabIndex = 9;
            // 
            // tpHandlers
            // 
            this.tpHandlers.Controls.Add(this.tlpButtons);
            this.tpHandlers.Controls.Add(this.tlpHandlerList);
            this.tpHandlers.Location = new System.Drawing.Point(4, 22);
            this.tpHandlers.Name = "tpHandlers";
            this.tpHandlers.Padding = new System.Windows.Forms.Padding(3);
            this.tpHandlers.Size = new System.Drawing.Size(632, 404);
            this.tpHandlers.TabIndex = 0;
            this.tpHandlers.Text = "Lista zaczepów";
            // 
            // tpOthers
            // 
            this.tpOthers.Controls.Add(this.tlpOthersButtons);
            this.tpOthers.Controls.Add(this.tlpOthers);
            this.tpOthers.Location = new System.Drawing.Point(4, 22);
            this.tpOthers.Name = "tpOthers";
            this.tpOthers.Size = new System.Drawing.Size(632, 404);
            this.tpOthers.TabIndex = 1;
            this.tpOthers.Text = "Pozostałe";
            // 
            // tlpOthersButtons
            // 
            this.tlpOthersButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpOthersButtons.AutoSize = true;
            this.tlpOthersButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOthersButtons.ColumnCount = 1;
            this.tlpOthersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOthersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOthersButtons.Controls.Add(this.btnSaveSettings, 0, 0);
            this.tlpOthersButtons.Location = new System.Drawing.Point(543, 6);
            this.tlpOthersButtons.Name = "tlpOthersButtons";
            this.tlpOthersButtons.RowCount = 1;
            this.tlpOthersButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOthersButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpOthersButtons.Size = new System.Drawing.Size(81, 29);
            this.tlpOthersButtons.TabIndex = 3;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Zastosuj";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // tlpOthers
            // 
            this.tlpOthers.AutoSize = true;
            this.tlpOthers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOthers.ColumnCount = 1;
            this.tlpOthers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOthers.Controls.Add(this.gbTimers, 0, 0);
            this.tlpOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOthers.Location = new System.Drawing.Point(0, 0);
            this.tlpOthers.Name = "tlpOthers";
            this.tlpOthers.Padding = new System.Windows.Forms.Padding(0, 0, 92, 0);
            this.tlpOthers.RowCount = 4;
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOthers.Size = new System.Drawing.Size(632, 404);
            this.tlpOthers.TabIndex = 0;
            // 
            // gbTimers
            // 
            this.gbTimers.AutoSize = true;
            this.gbTimers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTimers.Controls.Add(this.lblSetPositionsMs);
            this.gbTimers.Controls.Add(this.nudSetPositions);
            this.gbTimers.Controls.Add(this.lblSetPositions);
            this.gbTimers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTimers.Location = new System.Drawing.Point(3, 3);
            this.gbTimers.Name = "gbTimers";
            this.gbTimers.Size = new System.Drawing.Size(534, 49);
            this.gbTimers.TabIndex = 0;
            this.gbTimers.TabStop = false;
            this.gbTimers.Text = "Ustawienia minutników";
            // 
            // lblSetPositionsMs
            // 
            this.lblSetPositionsMs.AutoSize = true;
            this.lblSetPositionsMs.Location = new System.Drawing.Point(397, 19);
            this.lblSetPositionsMs.Name = "lblSetPositionsMs";
            this.lblSetPositionsMs.Size = new System.Drawing.Size(20, 13);
            this.lblSetPositionsMs.TabIndex = 5;
            this.lblSetPositionsMs.Text = "ms";
            // 
            // nudSetPositions
            // 
            this.nudSetPositions.Location = new System.Drawing.Point(271, 17);
            this.nudSetPositions.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudSetPositions.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSetPositions.Name = "nudSetPositions";
            this.nudSetPositions.Size = new System.Drawing.Size(120, 20);
            this.nudSetPositions.TabIndex = 3;
            this.nudSetPositions.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblSetPositions
            // 
            this.lblSetPositions.AutoSize = true;
            this.lblSetPositions.Location = new System.Drawing.Point(6, 19);
            this.lblSetPositions.Name = "lblSetPositions";
            this.lblSetPositions.Size = new System.Drawing.Size(200, 13);
            this.lblSetPositions.TabIndex = 1;
            this.lblSetPositions.Text = "Częstotliwość przywracania pozycji okien";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(640, 430);
            this.Controls.Add(this.settingsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(656, 469);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ustawienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.tlpHandlerList.ResumeLayout(false);
            this.tlpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVHandlers)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.settingsTabControl.ResumeLayout(false);
            this.tpHandlers.ResumeLayout(false);
            this.tpHandlers.PerformLayout();
            this.tpOthers.ResumeLayout(false);
            this.tpOthers.PerformLayout();
            this.tlpOthersButtons.ResumeLayout(false);
            this.tlpOthers.ResumeLayout(false);
            this.tlpOthers.PerformLayout();
            this.gbTimers.ResumeLayout(false);
            this.gbTimers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tlpHandlerList;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSetPosition;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage tpHandlers;
        private System.Windows.Forms.TabPage tpOthers;
        private System.Windows.Forms.TableLayoutPanel tlpOthers;
        private System.Windows.Forms.GroupBox gbTimers;
        private System.Windows.Forms.NumericUpDown nudSetPositions;
        private System.Windows.Forms.Label lblSetPositions;
        private System.Windows.Forms.Label lblSetPositionsMs;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.DataGridView dgVHandlers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.TableLayoutPanel tlpOthersButtons;
    }
}