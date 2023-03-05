namespace WindowMover.Forms
{
    partial class WindowHandlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowHandlerForm));
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.tbParentWindowClass = new System.Windows.Forms.TextBox();
            this.tbHandlerName = new System.Windows.Forms.TextBox();
            this.tbParentWindowTitle = new System.Windows.Forms.TextBox();
            this.tbPositionX = new System.Windows.Forms.TextBox();
            this.tbSizeX = new System.Windows.Forms.TextBox();
            this.tbPositionY = new System.Windows.Forms.TextBox();
            this.tbSizeY = new System.Windows.Forms.TextBox();
            this.chkSetPosition = new System.Windows.Forms.CheckBox();
            this.chkSetSize = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbHandler = new System.Windows.Forms.GroupBox();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.chkProcessName = new System.Windows.Forms.CheckBox();
            this.gbParent = new System.Windows.Forms.GroupBox();
            this.chkParentProcessName = new System.Windows.Forms.CheckBox();
            this.tbParentProcessName = new System.Windows.Forms.TextBox();
            this.chkParent = new System.Windows.Forms.CheckBox();
            this.lblParentProcessName = new System.Windows.Forms.Label();
            this.lblParentWindowTitle = new System.Windows.Forms.Label();
            this.chkParentWindowClass = new System.Windows.Forms.CheckBox();
            this.cbParentWindowTitle = new System.Windows.Forms.ComboBox();
            this.lblParentWindowClass = new System.Windows.Forms.Label();
            this.chkWindowClass = new System.Windows.Forms.CheckBox();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.cbWindowTitle = new System.Windows.Forms.ComboBox();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.tbWindowClass = new System.Windows.Forms.TextBox();
            this.tbWindowTitle = new System.Windows.Forms.TextBox();
            this.lblWindowClass = new System.Windows.Forms.Label();
            this.gbValues = new System.Windows.Forms.GroupBox();
            this.chkNonTopmost = new System.Windows.Forms.CheckBox();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.lblSizeSpacer = new System.Windows.Forms.Label();
            this.lblPositionSpacer = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.chkBorderless = new System.Windows.Forms.CheckBox();
            this.gbHandler.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.gbParent.SuspendLayout();
            this.gbValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Location = new System.Drawing.Point(6, 22);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(67, 13);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "Nazwa okna";
            // 
            // tbParentWindowClass
            // 
            this.tbParentWindowClass.Location = new System.Drawing.Point(109, 62);
            this.tbParentWindowClass.Name = "tbParentWindowClass";
            this.tbParentWindowClass.Size = new System.Drawing.Size(265, 20);
            this.tbParentWindowClass.TabIndex = 1;
            // 
            // tbHandlerName
            // 
            this.tbHandlerName.Location = new System.Drawing.Point(6, 19);
            this.tbHandlerName.Name = "tbHandlerName";
            this.tbHandlerName.Size = new System.Drawing.Size(471, 20);
            this.tbHandlerName.TabIndex = 2;
            // 
            // tbParentWindowTitle
            // 
            this.tbParentWindowTitle.Location = new System.Drawing.Point(109, 36);
            this.tbParentWindowTitle.Name = "tbParentWindowTitle";
            this.tbParentWindowTitle.Size = new System.Drawing.Size(265, 20);
            this.tbParentWindowTitle.TabIndex = 3;
            // 
            // tbPositionX
            // 
            this.tbPositionX.Location = new System.Drawing.Point(109, 19);
            this.tbPositionX.Name = "tbPositionX";
            this.tbPositionX.Size = new System.Drawing.Size(100, 20);
            this.tbPositionX.TabIndex = 4;
            // 
            // tbSizeX
            // 
            this.tbSizeX.Location = new System.Drawing.Point(109, 45);
            this.tbSizeX.Name = "tbSizeX";
            this.tbSizeX.Size = new System.Drawing.Size(100, 20);
            this.tbSizeX.TabIndex = 5;
            // 
            // tbPositionY
            // 
            this.tbPositionY.Location = new System.Drawing.Point(231, 19);
            this.tbPositionY.Name = "tbPositionY";
            this.tbPositionY.Size = new System.Drawing.Size(100, 20);
            this.tbPositionY.TabIndex = 6;
            // 
            // tbSizeY
            // 
            this.tbSizeY.Location = new System.Drawing.Point(231, 45);
            this.tbSizeY.Name = "tbSizeY";
            this.tbSizeY.Size = new System.Drawing.Size(100, 20);
            this.tbSizeY.TabIndex = 7;
            // 
            // chkSetPosition
            // 
            this.chkSetPosition.AutoSize = true;
            this.chkSetPosition.Location = new System.Drawing.Point(9, 21);
            this.chkSetPosition.Name = "chkSetPosition";
            this.chkSetPosition.Size = new System.Drawing.Size(94, 17);
            this.chkSetPosition.TabIndex = 8;
            this.chkSetPosition.Text = "Zmień pozycje";
            this.chkSetPosition.UseVisualStyleBackColor = true;
            // 
            // chkSetSize
            // 
            this.chkSetSize.AutoSize = true;
            this.chkSetSize.Location = new System.Drawing.Point(9, 47);
            this.chkSetSize.Name = "chkSetSize";
            this.chkSetSize.Size = new System.Drawing.Size(91, 17);
            this.chkSetSize.TabIndex = 9;
            this.chkSetSize.Text = "Zmień rozmiar";
            this.chkSetSize.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(501, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(501, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbHandler
            // 
            this.gbHandler.Controls.Add(this.tbHandlerName);
            this.gbHandler.Location = new System.Drawing.Point(12, 12);
            this.gbHandler.Name = "gbHandler";
            this.gbHandler.Size = new System.Drawing.Size(483, 49);
            this.gbHandler.TabIndex = 12;
            this.gbHandler.TabStop = false;
            this.gbHandler.Text = "Nazwa zaczepu";
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.chkProcessName);
            this.gbAttributes.Controls.Add(this.gbParent);
            this.gbAttributes.Controls.Add(this.chkWindowClass);
            this.gbAttributes.Controls.Add(this.lblProcessName);
            this.gbAttributes.Controls.Add(this.cbWindowTitle);
            this.gbAttributes.Controls.Add(this.tbProcessName);
            this.gbAttributes.Controls.Add(this.tbWindowClass);
            this.gbAttributes.Controls.Add(this.tbWindowTitle);
            this.gbAttributes.Controls.Add(this.lblWindowClass);
            this.gbAttributes.Controls.Add(this.lblWindowTitle);
            this.gbAttributes.Location = new System.Drawing.Point(12, 67);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(483, 238);
            this.gbAttributes.TabIndex = 13;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Szukaj po poniższych atrybutach";
            // 
            // chkProcessName
            // 
            this.chkProcessName.AutoSize = true;
            this.chkProcessName.Location = new System.Drawing.Point(394, 83);
            this.chkProcessName.Name = "chkProcessName";
            this.chkProcessName.Size = new System.Drawing.Size(75, 17);
            this.chkProcessName.TabIndex = 18;
            this.chkProcessName.Text = "Sprawdzaj";
            this.chkProcessName.UseVisualStyleBackColor = true;
            // 
            // gbParent
            // 
            this.gbParent.Controls.Add(this.chkParentProcessName);
            this.gbParent.Controls.Add(this.tbParentProcessName);
            this.gbParent.Controls.Add(this.chkParent);
            this.gbParent.Controls.Add(this.lblParentProcessName);
            this.gbParent.Controls.Add(this.lblParentWindowTitle);
            this.gbParent.Controls.Add(this.chkParentWindowClass);
            this.gbParent.Controls.Add(this.tbParentWindowClass);
            this.gbParent.Controls.Add(this.cbParentWindowTitle);
            this.gbParent.Controls.Add(this.tbParentWindowTitle);
            this.gbParent.Controls.Add(this.lblParentWindowClass);
            this.gbParent.Location = new System.Drawing.Point(7, 108);
            this.gbParent.Name = "gbParent";
            this.gbParent.Size = new System.Drawing.Size(468, 121);
            this.gbParent.TabIndex = 15;
            this.gbParent.TabStop = false;
            this.gbParent.Text = "Rodzic";
            // 
            // chkParentProcessName
            // 
            this.chkParentProcessName.AutoSize = true;
            this.chkParentProcessName.Location = new System.Drawing.Point(380, 90);
            this.chkParentProcessName.Name = "chkParentProcessName";
            this.chkParentProcessName.Size = new System.Drawing.Size(75, 17);
            this.chkParentProcessName.TabIndex = 20;
            this.chkParentProcessName.Text = "Sprawdzaj";
            this.chkParentProcessName.UseVisualStyleBackColor = true;
            // 
            // tbParentProcessName
            // 
            this.tbParentProcessName.Location = new System.Drawing.Point(109, 88);
            this.tbParentProcessName.Name = "tbParentProcessName";
            this.tbParentProcessName.Size = new System.Drawing.Size(265, 20);
            this.tbParentProcessName.TabIndex = 19;
            // 
            // chkParent
            // 
            this.chkParent.AutoSize = true;
            this.chkParent.Location = new System.Drawing.Point(6, 19);
            this.chkParent.Name = "chkParent";
            this.chkParent.Size = new System.Drawing.Size(142, 17);
            this.chkParent.TabIndex = 10;
            this.chkParent.Text = "Bierz pod uwagę rodzica";
            this.chkParent.UseVisualStyleBackColor = true;
            // 
            // lblParentProcessName
            // 
            this.lblParentProcessName.AutoSize = true;
            this.lblParentProcessName.Location = new System.Drawing.Point(6, 91);
            this.lblParentProcessName.Name = "lblParentProcessName";
            this.lblParentProcessName.Size = new System.Drawing.Size(81, 13);
            this.lblParentProcessName.TabIndex = 18;
            this.lblParentProcessName.Text = "Nazwa procesu";
            // 
            // lblParentWindowTitle
            // 
            this.lblParentWindowTitle.AutoSize = true;
            this.lblParentWindowTitle.Location = new System.Drawing.Point(6, 39);
            this.lblParentWindowTitle.Name = "lblParentWindowTitle";
            this.lblParentWindowTitle.Size = new System.Drawing.Size(67, 13);
            this.lblParentWindowTitle.TabIndex = 2;
            this.lblParentWindowTitle.Text = "Nazwa okna";
            // 
            // chkParentWindowClass
            // 
            this.chkParentWindowClass.AutoSize = true;
            this.chkParentWindowClass.Location = new System.Drawing.Point(380, 64);
            this.chkParentWindowClass.Name = "chkParentWindowClass";
            this.chkParentWindowClass.Size = new System.Drawing.Size(75, 17);
            this.chkParentWindowClass.TabIndex = 9;
            this.chkParentWindowClass.Text = "Sprawdzaj";
            this.chkParentWindowClass.UseVisualStyleBackColor = true;
            // 
            // cbParentWindowTitle
            // 
            this.cbParentWindowTitle.FormattingEnabled = true;
            this.cbParentWindowTitle.ItemHeight = 13;
            this.cbParentWindowTitle.Location = new System.Drawing.Point(380, 36);
            this.cbParentWindowTitle.Name = "cbParentWindowTitle";
            this.cbParentWindowTitle.Size = new System.Drawing.Size(82, 21);
            this.cbParentWindowTitle.TabIndex = 8;
            // 
            // lblParentWindowClass
            // 
            this.lblParentWindowClass.AutoSize = true;
            this.lblParentWindowClass.Location = new System.Drawing.Point(6, 65);
            this.lblParentWindowClass.Name = "lblParentWindowClass";
            this.lblParentWindowClass.Size = new System.Drawing.Size(60, 13);
            this.lblParentWindowClass.TabIndex = 3;
            this.lblParentWindowClass.Text = "Klasa okna";
            // 
            // chkWindowClass
            // 
            this.chkWindowClass.AutoSize = true;
            this.chkWindowClass.Location = new System.Drawing.Point(394, 51);
            this.chkWindowClass.Name = "chkWindowClass";
            this.chkWindowClass.Size = new System.Drawing.Size(75, 17);
            this.chkWindowClass.TabIndex = 7;
            this.chkWindowClass.Text = "Sprawdzaj";
            this.chkWindowClass.UseVisualStyleBackColor = true;
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(6, 84);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(81, 13);
            this.lblProcessName.TabIndex = 17;
            this.lblProcessName.Text = "Nazwa procesu";
            // 
            // cbWindowTitle
            // 
            this.cbWindowTitle.FormattingEnabled = true;
            this.cbWindowTitle.ItemHeight = 13;
            this.cbWindowTitle.Location = new System.Drawing.Point(394, 19);
            this.cbWindowTitle.Name = "cbWindowTitle";
            this.cbWindowTitle.Size = new System.Drawing.Size(83, 21);
            this.cbWindowTitle.TabIndex = 6;
            // 
            // tbProcessName
            // 
            this.tbProcessName.Location = new System.Drawing.Point(109, 81);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(279, 20);
            this.tbProcessName.TabIndex = 16;
            // 
            // tbWindowClass
            // 
            this.tbWindowClass.Location = new System.Drawing.Point(109, 50);
            this.tbWindowClass.Name = "tbWindowClass";
            this.tbWindowClass.Size = new System.Drawing.Size(279, 20);
            this.tbWindowClass.TabIndex = 5;
            // 
            // tbWindowTitle
            // 
            this.tbWindowTitle.Location = new System.Drawing.Point(109, 19);
            this.tbWindowTitle.Name = "tbWindowTitle";
            this.tbWindowTitle.Size = new System.Drawing.Size(279, 20);
            this.tbWindowTitle.TabIndex = 4;
            // 
            // lblWindowClass
            // 
            this.lblWindowClass.AutoSize = true;
            this.lblWindowClass.Location = new System.Drawing.Point(6, 52);
            this.lblWindowClass.Name = "lblWindowClass";
            this.lblWindowClass.Size = new System.Drawing.Size(60, 13);
            this.lblWindowClass.TabIndex = 1;
            this.lblWindowClass.Text = "Klasa okna";
            // 
            // gbValues
            // 
            this.gbValues.Controls.Add(this.chkBorderless);
            this.gbValues.Controls.Add(this.chkNonTopmost);
            this.gbValues.Controls.Add(this.chkAlwaysOnTop);
            this.gbValues.Controls.Add(this.lblSizeSpacer);
            this.gbValues.Controls.Add(this.lblPositionSpacer);
            this.gbValues.Controls.Add(this.tbPositionX);
            this.gbValues.Controls.Add(this.tbSizeX);
            this.gbValues.Controls.Add(this.tbPositionY);
            this.gbValues.Controls.Add(this.tbSizeY);
            this.gbValues.Controls.Add(this.chkSetPosition);
            this.gbValues.Controls.Add(this.chkSetSize);
            this.gbValues.Location = new System.Drawing.Point(12, 311);
            this.gbValues.Name = "gbValues";
            this.gbValues.Size = new System.Drawing.Size(483, 94);
            this.gbValues.TabIndex = 14;
            this.gbValues.TabStop = false;
            this.gbValues.Text = "Modyfikuj parametry okna";
            // 
            // chkNonTopmost
            // 
            this.chkNonTopmost.AutoSize = true;
            this.chkNonTopmost.Location = new System.Drawing.Point(354, 22);
            this.chkNonTopmost.Name = "chkNonTopmost";
            this.chkNonTopmost.Size = new System.Drawing.Size(117, 17);
            this.chkNonTopmost.TabIndex = 13;
            this.chkNonTopmost.Text = "Przesuń z wierzchu";
            this.chkNonTopmost.UseVisualStyleBackColor = true;
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(354, 47);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(123, 17);
            this.chkAlwaysOnTop.TabIndex = 12;
            this.chkAlwaysOnTop.Text = "Zawsze na wierzchu";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // lblSizeSpacer
            // 
            this.lblSizeSpacer.AutoSize = true;
            this.lblSizeSpacer.Location = new System.Drawing.Point(213, 48);
            this.lblSizeSpacer.Name = "lblSizeSpacer";
            this.lblSizeSpacer.Size = new System.Drawing.Size(12, 13);
            this.lblSizeSpacer.TabIndex = 11;
            this.lblSizeSpacer.Text = "x";
            // 
            // lblPositionSpacer
            // 
            this.lblPositionSpacer.AutoSize = true;
            this.lblPositionSpacer.Location = new System.Drawing.Point(215, 22);
            this.lblPositionSpacer.Name = "lblPositionSpacer";
            this.lblPositionSpacer.Size = new System.Drawing.Size(10, 13);
            this.lblPositionSpacer.TabIndex = 10;
            this.lblPositionSpacer.Text = ",";
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Image = global::WindowMover.Properties.Resources.Target;
            this.pictureBox.Location = new System.Drawing.Point(521, 70);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(32, 32);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chkBorderless
            // 
            this.chkBorderless.AutoSize = true;
            this.chkBorderless.Location = new System.Drawing.Point(9, 70);
            this.chkBorderless.Name = "chkBorderless";
            this.chkBorderless.Size = new System.Drawing.Size(79, 17);
            this.chkBorderless.TabIndex = 14;
            this.chkBorderless.Text = "Usuń ramki";
            this.chkBorderless.UseVisualStyleBackColor = true;
            // 
            // WindowHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 417);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.gbValues);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.gbHandler);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(603, 456);
            this.MinimumSize = new System.Drawing.Size(603, 436);
            this.Name = "WindowHandlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj nowy zaczep";
            this.gbHandler.ResumeLayout(false);
            this.gbHandler.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            this.gbParent.ResumeLayout(false);
            this.gbParent.PerformLayout();
            this.gbValues.ResumeLayout(false);
            this.gbValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.TextBox tbParentWindowClass;
        private System.Windows.Forms.TextBox tbHandlerName;
        private System.Windows.Forms.TextBox tbParentWindowTitle;
        private System.Windows.Forms.TextBox tbPositionX;
        private System.Windows.Forms.TextBox tbSizeX;
        private System.Windows.Forms.TextBox tbPositionY;
        private System.Windows.Forms.TextBox tbSizeY;
        private System.Windows.Forms.CheckBox chkSetPosition;
        private System.Windows.Forms.CheckBox chkSetSize;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbHandler;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.GroupBox gbParent;
        private System.Windows.Forms.CheckBox chkParent;
        private System.Windows.Forms.Label lblParentWindowTitle;
        private System.Windows.Forms.CheckBox chkParentWindowClass;
        private System.Windows.Forms.ComboBox cbParentWindowTitle;
        private System.Windows.Forms.Label lblParentWindowClass;
        private System.Windows.Forms.CheckBox chkWindowClass;
        private System.Windows.Forms.ComboBox cbWindowTitle;
        private System.Windows.Forms.TextBox tbWindowClass;
        private System.Windows.Forms.TextBox tbWindowTitle;
        private System.Windows.Forms.Label lblWindowClass;
        private System.Windows.Forms.GroupBox gbValues;
        private System.Windows.Forms.Label lblSizeSpacer;
        private System.Windows.Forms.Label lblPositionSpacer;
        private System.Windows.Forms.CheckBox chkProcessName;
        private System.Windows.Forms.CheckBox chkParentProcessName;
        private System.Windows.Forms.TextBox tbParentProcessName;
        private System.Windows.Forms.Label lblParentProcessName;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.TextBox tbProcessName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.CheckBox chkNonTopmost;
        private System.Windows.Forms.CheckBox chkBorderless;
    }
}