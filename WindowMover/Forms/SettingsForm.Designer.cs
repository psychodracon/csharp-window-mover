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
            this.gbMonitorSettings = new System.Windows.Forms.GroupBox();
            this.nudContrastOffset = new System.Windows.Forms.NumericUpDown();
            this.nudBrightnessOffset = new System.Windows.Forms.NumericUpDown();
            this.chkOffset = new System.Windows.Forms.CheckBox();
            this.lblContrastOffset = new System.Windows.Forms.Label();
            this.lblBrightnessOffset = new System.Windows.Forms.Label();
            this.lblNight = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblContrastValueDay = new System.Windows.Forms.Label();
            this.lblBrightnessValueDay = new System.Windows.Forms.Label();
            this.tbContrastDay = new System.Windows.Forms.TrackBar();
            this.lblContrastDay = new System.Windows.Forms.Label();
            this.lblBirghtnessDay = new System.Windows.Forms.Label();
            this.tbBrightnessDay = new System.Windows.Forms.TrackBar();
            this.lblContrastValueNight = new System.Windows.Forms.Label();
            this.lblBrightnessValueNight = new System.Windows.Forms.Label();
            this.tbContrastNight = new System.Windows.Forms.TrackBar();
            this.lblContrastNight = new System.Windows.Forms.Label();
            this.lblBrightnessNight = new System.Windows.Forms.Label();
            this.tbBrightnessNight = new System.Windows.Forms.TrackBar();
            this.gbOthers = new System.Windows.Forms.GroupBox();
            this.chkWorkMode = new System.Windows.Forms.CheckBox();
            this.gbTimers = new System.Windows.Forms.GroupBox();
            this.lblSetPositionsMs = new System.Windows.Forms.Label();
            this.lblFullScreenMs = new System.Windows.Forms.Label();
            this.nudSetPositions = new System.Windows.Forms.NumericUpDown();
            this.nudFullScreen = new System.Windows.Forms.NumericUpDown();
            this.lblSetPositions = new System.Windows.Forms.Label();
            this.lblFullScreen = new System.Windows.Forms.Label();
            this.tlpHandlerList.SuspendLayout();
            this.tlpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVHandlers)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.tpHandlers.SuspendLayout();
            this.tpOthers.SuspendLayout();
            this.tlpOthersButtons.SuspendLayout();
            this.tlpOthers.SuspendLayout();
            this.gbMonitorSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrastOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightnessOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrastDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrastNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessNight)).BeginInit();
            this.gbOthers.SuspendLayout();
            this.gbTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFullScreen)).BeginInit();
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
            this.tlpOthers.Controls.Add(this.gbMonitorSettings, 0, 1);
            this.tlpOthers.Controls.Add(this.gbOthers, 0, 2);
            this.tlpOthers.Controls.Add(this.gbTimers, 0, 0);
            this.tlpOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOthers.Location = new System.Drawing.Point(0, 0);
            this.tlpOthers.Name = "tlpOthers";
            this.tlpOthers.Padding = new System.Windows.Forms.Padding(0, 0, 92, 0);
            this.tlpOthers.RowCount = 4;
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOthers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOthers.Size = new System.Drawing.Size(632, 404);
            this.tlpOthers.TabIndex = 0;
            // 
            // gbMonitorSettings
            // 
            this.gbMonitorSettings.AutoSize = true;
            this.gbMonitorSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbMonitorSettings.Controls.Add(this.nudContrastOffset);
            this.gbMonitorSettings.Controls.Add(this.nudBrightnessOffset);
            this.gbMonitorSettings.Controls.Add(this.chkOffset);
            this.gbMonitorSettings.Controls.Add(this.lblContrastOffset);
            this.gbMonitorSettings.Controls.Add(this.lblBrightnessOffset);
            this.gbMonitorSettings.Controls.Add(this.lblNight);
            this.gbMonitorSettings.Controls.Add(this.lblDay);
            this.gbMonitorSettings.Controls.Add(this.lblContrastValueDay);
            this.gbMonitorSettings.Controls.Add(this.lblBrightnessValueDay);
            this.gbMonitorSettings.Controls.Add(this.tbContrastDay);
            this.gbMonitorSettings.Controls.Add(this.lblContrastDay);
            this.gbMonitorSettings.Controls.Add(this.lblBirghtnessDay);
            this.gbMonitorSettings.Controls.Add(this.tbBrightnessDay);
            this.gbMonitorSettings.Controls.Add(this.lblContrastValueNight);
            this.gbMonitorSettings.Controls.Add(this.lblBrightnessValueNight);
            this.gbMonitorSettings.Controls.Add(this.tbContrastNight);
            this.gbMonitorSettings.Controls.Add(this.lblContrastNight);
            this.gbMonitorSettings.Controls.Add(this.lblBrightnessNight);
            this.gbMonitorSettings.Controls.Add(this.tbBrightnessNight);
            this.gbMonitorSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMonitorSettings.Location = new System.Drawing.Point(3, 85);
            this.gbMonitorSettings.Name = "gbMonitorSettings";
            this.gbMonitorSettings.Size = new System.Drawing.Size(534, 178);
            this.gbMonitorSettings.TabIndex = 3;
            this.gbMonitorSettings.TabStop = false;
            this.gbMonitorSettings.Text = "Ustawienia monitorów";
            this.gbMonitorSettings.Visible = false;
            // 
            // nudContrastOffset
            // 
            this.nudContrastOffset.Location = new System.Drawing.Point(357, 117);
            this.nudContrastOffset.Name = "nudContrastOffset";
            this.nudContrastOffset.Size = new System.Drawing.Size(113, 20);
            this.nudContrastOffset.TabIndex = 20;
            // 
            // nudBrightnessOffset
            // 
            this.nudBrightnessOffset.Location = new System.Drawing.Point(95, 117);
            this.nudBrightnessOffset.Name = "nudBrightnessOffset";
            this.nudBrightnessOffset.Size = new System.Drawing.Size(111, 20);
            this.nudBrightnessOffset.TabIndex = 19;
            // 
            // chkOffset
            // 
            this.chkOffset.AutoSize = true;
            this.chkOffset.Location = new System.Drawing.Point(9, 142);
            this.chkOffset.Name = "chkOffset";
            this.chkOffset.Size = new System.Drawing.Size(197, 17);
            this.chkOffset.TabIndex = 18;
            this.chkOffset.Text = "Użyj offsetu dla pierwszego monitora";
            this.chkOffset.UseVisualStyleBackColor = true;
            // 
            // lblContrastOffset
            // 
            this.lblContrastOffset.AutoSize = true;
            this.lblContrastOffset.Location = new System.Drawing.Point(268, 119);
            this.lblContrastOffset.Name = "lblContrastOffset";
            this.lblContrastOffset.Size = new System.Drawing.Size(83, 13);
            this.lblContrastOffset.TabIndex = 16;
            this.lblContrastOffset.Text = "Kontrast (Offset)";
            // 
            // lblBrightnessOffset
            // 
            this.lblBrightnessOffset.AutoSize = true;
            this.lblBrightnessOffset.Location = new System.Drawing.Point(6, 119);
            this.lblBrightnessOffset.Name = "lblBrightnessOffset";
            this.lblBrightnessOffset.Size = new System.Drawing.Size(83, 13);
            this.lblBrightnessOffset.TabIndex = 14;
            this.lblBrightnessOffset.Text = "Jasność (Offset)";
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.Location = new System.Drawing.Point(268, 21);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(27, 13);
            this.lblNight.TabIndex = 13;
            this.lblNight.Text = "Noc";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(6, 21);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(34, 13);
            this.lblDay.TabIndex = 12;
            this.lblDay.Text = "Dzień";
            // 
            // lblContrastValueDay
            // 
            this.lblContrastValueDay.AutoSize = true;
            this.lblContrastValueDay.Location = new System.Drawing.Point(214, 79);
            this.lblContrastValueDay.Name = "lblContrastValueDay";
            this.lblContrastValueDay.Size = new System.Drawing.Size(13, 13);
            this.lblContrastValueDay.TabIndex = 11;
            this.lblContrastValueDay.Text = "0";
            // 
            // lblBrightnessValueDay
            // 
            this.lblBrightnessValueDay.AutoSize = true;
            this.lblBrightnessValueDay.Location = new System.Drawing.Point(214, 47);
            this.lblBrightnessValueDay.Name = "lblBrightnessValueDay";
            this.lblBrightnessValueDay.Size = new System.Drawing.Size(13, 13);
            this.lblBrightnessValueDay.TabIndex = 10;
            this.lblBrightnessValueDay.Text = "0";
            // 
            // tbContrastDay
            // 
            this.tbContrastDay.LargeChange = 10;
            this.tbContrastDay.Location = new System.Drawing.Point(56, 79);
            this.tbContrastDay.Maximum = 100;
            this.tbContrastDay.Name = "tbContrastDay";
            this.tbContrastDay.Size = new System.Drawing.Size(150, 45);
            this.tbContrastDay.TabIndex = 9;
            this.tbContrastDay.TickFrequency = 5;
            this.tbContrastDay.ValueChanged += new System.EventHandler(this.tbContrastDay_ValueChanged);
            // 
            // lblContrastDay
            // 
            this.lblContrastDay.AutoSize = true;
            this.lblContrastDay.Location = new System.Drawing.Point(6, 79);
            this.lblContrastDay.Name = "lblContrastDay";
            this.lblContrastDay.Size = new System.Drawing.Size(46, 13);
            this.lblContrastDay.TabIndex = 8;
            this.lblContrastDay.Text = "Kontrast";
            // 
            // lblBirghtnessDay
            // 
            this.lblBirghtnessDay.AutoSize = true;
            this.lblBirghtnessDay.Location = new System.Drawing.Point(6, 47);
            this.lblBirghtnessDay.Name = "lblBirghtnessDay";
            this.lblBirghtnessDay.Size = new System.Drawing.Size(46, 13);
            this.lblBirghtnessDay.TabIndex = 7;
            this.lblBirghtnessDay.Text = "Jasność";
            // 
            // tbBrightnessDay
            // 
            this.tbBrightnessDay.LargeChange = 10;
            this.tbBrightnessDay.Location = new System.Drawing.Point(58, 47);
            this.tbBrightnessDay.Maximum = 100;
            this.tbBrightnessDay.Name = "tbBrightnessDay";
            this.tbBrightnessDay.Size = new System.Drawing.Size(150, 45);
            this.tbBrightnessDay.TabIndex = 6;
            this.tbBrightnessDay.TickFrequency = 5;
            this.tbBrightnessDay.ValueChanged += new System.EventHandler(this.tbBrightnessDay_ValueChanged);
            // 
            // lblContrastValueNight
            // 
            this.lblContrastValueNight.AutoSize = true;
            this.lblContrastValueNight.Location = new System.Drawing.Point(476, 79);
            this.lblContrastValueNight.Name = "lblContrastValueNight";
            this.lblContrastValueNight.Size = new System.Drawing.Size(13, 13);
            this.lblContrastValueNight.TabIndex = 5;
            this.lblContrastValueNight.Text = "0";
            // 
            // lblBrightnessValueNight
            // 
            this.lblBrightnessValueNight.AutoSize = true;
            this.lblBrightnessValueNight.Location = new System.Drawing.Point(476, 47);
            this.lblBrightnessValueNight.Name = "lblBrightnessValueNight";
            this.lblBrightnessValueNight.Size = new System.Drawing.Size(13, 13);
            this.lblBrightnessValueNight.TabIndex = 4;
            this.lblBrightnessValueNight.Text = "0";
            // 
            // tbContrastNight
            // 
            this.tbContrastNight.LargeChange = 10;
            this.tbContrastNight.Location = new System.Drawing.Point(320, 79);
            this.tbContrastNight.Maximum = 100;
            this.tbContrastNight.Name = "tbContrastNight";
            this.tbContrastNight.Size = new System.Drawing.Size(150, 45);
            this.tbContrastNight.TabIndex = 3;
            this.tbContrastNight.TickFrequency = 5;
            this.tbContrastNight.ValueChanged += new System.EventHandler(this.tbContrastNight_ValueChanged);
            // 
            // lblContrastNight
            // 
            this.lblContrastNight.AutoSize = true;
            this.lblContrastNight.Location = new System.Drawing.Point(268, 79);
            this.lblContrastNight.Name = "lblContrastNight";
            this.lblContrastNight.Size = new System.Drawing.Size(46, 13);
            this.lblContrastNight.TabIndex = 2;
            this.lblContrastNight.Text = "Kontrast";
            // 
            // lblBrightnessNight
            // 
            this.lblBrightnessNight.AutoSize = true;
            this.lblBrightnessNight.Location = new System.Drawing.Point(268, 47);
            this.lblBrightnessNight.Name = "lblBrightnessNight";
            this.lblBrightnessNight.Size = new System.Drawing.Size(46, 13);
            this.lblBrightnessNight.TabIndex = 1;
            this.lblBrightnessNight.Text = "Jasność";
            // 
            // tbBrightnessNight
            // 
            this.tbBrightnessNight.LargeChange = 10;
            this.tbBrightnessNight.Location = new System.Drawing.Point(320, 47);
            this.tbBrightnessNight.Maximum = 100;
            this.tbBrightnessNight.Name = "tbBrightnessNight";
            this.tbBrightnessNight.Size = new System.Drawing.Size(150, 45);
            this.tbBrightnessNight.TabIndex = 0;
            this.tbBrightnessNight.TickFrequency = 5;
            this.tbBrightnessNight.ValueChanged += new System.EventHandler(this.tbBrightnessNight_ValueChanged);
            // 
            // gbOthers
            // 
            this.gbOthers.AutoSize = true;
            this.gbOthers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbOthers.Controls.Add(this.chkWorkMode);
            this.gbOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOthers.Location = new System.Drawing.Point(3, 269);
            this.gbOthers.Name = "gbOthers";
            this.gbOthers.Size = new System.Drawing.Size(534, 55);
            this.gbOthers.TabIndex = 2;
            this.gbOthers.TabStop = false;
            this.gbOthers.Text = "Pozostałe";
            this.gbOthers.Visible = false;
            // 
            // chkWorkMode
            // 
            this.chkWorkMode.AutoSize = true;
            this.chkWorkMode.Location = new System.Drawing.Point(9, 19);
            this.chkWorkMode.Name = "chkWorkMode";
            this.chkWorkMode.Size = new System.Drawing.Size(266, 17);
            this.chkWorkMode.TabIndex = 1;
            this.chkWorkMode.Text = "Tryb pracy wyłącza również pozycjonowanie okien";
            this.chkWorkMode.UseVisualStyleBackColor = true;
            // 
            // gbTimers
            // 
            this.gbTimers.AutoSize = true;
            this.gbTimers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTimers.Controls.Add(this.lblSetPositionsMs);
            this.gbTimers.Controls.Add(this.lblFullScreenMs);
            this.gbTimers.Controls.Add(this.nudSetPositions);
            this.gbTimers.Controls.Add(this.nudFullScreen);
            this.gbTimers.Controls.Add(this.lblSetPositions);
            this.gbTimers.Controls.Add(this.lblFullScreen);
            this.gbTimers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTimers.Location = new System.Drawing.Point(3, 3);
            this.gbTimers.Name = "gbTimers";
            this.gbTimers.Size = new System.Drawing.Size(534, 76);
            this.gbTimers.TabIndex = 0;
            this.gbTimers.TabStop = false;
            this.gbTimers.Text = "Ustawienia minutników";
            // 
            // lblSetPositionsMs
            // 
            this.lblSetPositionsMs.AutoSize = true;
            this.lblSetPositionsMs.Location = new System.Drawing.Point(397, 21);
            this.lblSetPositionsMs.Name = "lblSetPositionsMs";
            this.lblSetPositionsMs.Size = new System.Drawing.Size(20, 13);
            this.lblSetPositionsMs.TabIndex = 5;
            this.lblSetPositionsMs.Text = "ms";
            // 
            // lblFullScreenMs
            // 
            this.lblFullScreenMs.AutoSize = true;
            this.lblFullScreenMs.Location = new System.Drawing.Point(397, 47);
            this.lblFullScreenMs.Name = "lblFullScreenMs";
            this.lblFullScreenMs.Size = new System.Drawing.Size(20, 13);
            this.lblFullScreenMs.TabIndex = 4;
            this.lblFullScreenMs.Text = "ms";
            this.lblFullScreenMs.Visible = false;
            // 
            // nudSetPositions
            // 
            this.nudSetPositions.Location = new System.Drawing.Point(271, 19);
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
            // nudFullScreen
            // 
            this.nudFullScreen.Location = new System.Drawing.Point(271, 45);
            this.nudFullScreen.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudFullScreen.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudFullScreen.Name = "nudFullScreen";
            this.nudFullScreen.Size = new System.Drawing.Size(120, 20);
            this.nudFullScreen.TabIndex = 2;
            this.nudFullScreen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudFullScreen.Visible = false;
            // 
            // lblSetPositions
            // 
            this.lblSetPositions.AutoSize = true;
            this.lblSetPositions.Location = new System.Drawing.Point(6, 21);
            this.lblSetPositions.Name = "lblSetPositions";
            this.lblSetPositions.Size = new System.Drawing.Size(200, 13);
            this.lblSetPositions.TabIndex = 1;
            this.lblSetPositions.Text = "Częstotliwość przywracania pozycji okien";
            // 
            // lblFullScreen
            // 
            this.lblFullScreen.AutoSize = true;
            this.lblFullScreen.Location = new System.Drawing.Point(6, 47);
            this.lblFullScreen.Name = "lblFullScreen";
            this.lblFullScreen.Size = new System.Drawing.Size(259, 13);
            this.lblFullScreen.TabIndex = 0;
            this.lblFullScreen.Text = "Częstotliwość wykrywania aplikacji pełnoekranowych";
            this.lblFullScreen.Visible = false;
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
            this.gbMonitorSettings.ResumeLayout(false);
            this.gbMonitorSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrastOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightnessOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrastDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrastNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessNight)).EndInit();
            this.gbOthers.ResumeLayout(false);
            this.gbOthers.PerformLayout();
            this.gbTimers.ResumeLayout(false);
            this.gbTimers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFullScreen)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudFullScreen;
        private System.Windows.Forms.Label lblSetPositions;
        private System.Windows.Forms.Label lblFullScreen;
        private System.Windows.Forms.Label lblSetPositionsMs;
        private System.Windows.Forms.Label lblFullScreenMs;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.DataGridView dgVHandlers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.TableLayoutPanel tlpOthersButtons;
        private System.Windows.Forms.GroupBox gbMonitorSettings;
        private System.Windows.Forms.TrackBar tbContrastNight;
        private System.Windows.Forms.Label lblContrastNight;
        private System.Windows.Forms.Label lblBrightnessNight;
        private System.Windows.Forms.TrackBar tbBrightnessNight;
        private System.Windows.Forms.GroupBox gbOthers;
        private System.Windows.Forms.CheckBox chkWorkMode;
        private System.Windows.Forms.Label lblContrastValueNight;
        private System.Windows.Forms.Label lblBrightnessValueNight;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblContrastValueDay;
        private System.Windows.Forms.Label lblBrightnessValueDay;
        private System.Windows.Forms.TrackBar tbContrastDay;
        private System.Windows.Forms.Label lblContrastDay;
        private System.Windows.Forms.Label lblBirghtnessDay;
        private System.Windows.Forms.TrackBar tbBrightnessDay;
        private System.Windows.Forms.CheckBox chkOffset;
        private System.Windows.Forms.Label lblContrastOffset;
        private System.Windows.Forms.Label lblBrightnessOffset;
        private System.Windows.Forms.NumericUpDown nudContrastOffset;
        private System.Windows.Forms.NumericUpDown nudBrightnessOffset;
    }
}