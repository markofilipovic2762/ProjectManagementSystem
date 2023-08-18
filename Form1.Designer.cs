using System;

namespace Test1
{
    partial class Test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.cbNumRecentFiles = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newButton = new System.Windows.Forms.Button();
            this.enddateBox = new System.Windows.Forms.DateTimePicker();
            this.startdateBox = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.maxnumberresultsBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.projecttypeCb = new System.Windows.Forms.ComboBox();
            this.enablenotificationsCheckbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderpathTb = new System.Windows.Forms.TextBox();
            this.descriptionTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxnumberresultsBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cbNumRecentFiles);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label9);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 510);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 535);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.White;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // cbNumRecentFiles
            // 
            this.cbNumRecentFiles.FormattingEnabled = true;
            this.cbNumRecentFiles.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNumRecentFiles.Location = new System.Drawing.Point(659, 84);
            this.cbNumRecentFiles.Name = "cbNumRecentFiles";
            this.cbNumRecentFiles.Size = new System.Drawing.Size(121, 21);
            this.cbNumRecentFiles.TabIndex = 4;
            this.cbNumRecentFiles.SelectedIndexChanged += new System.EventHandler(this.cbNumRecentFiles_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Set number of recent files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(342, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Project";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.enddateBox);
            this.panel1.Controls.Add(this.startdateBox);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.maxnumberresultsBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.projecttypeCb);
            this.panel1.Controls.Add(this.enablenotificationsCheckbox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.folderpathTb);
            this.panel1.Controls.Add(this.descriptionTb);
            this.panel1.Controls.Add(this.nameTb);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(234, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 437);
            this.panel1.TabIndex = 0;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.Navy;
            this.newButton.Location = new System.Drawing.Point(191, 402);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(73, 32);
            this.newButton.TabIndex = 18;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // enddateBox
            // 
            this.enddateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddateBox.Location = new System.Drawing.Point(96, 277);
            this.enddateBox.MinDate = this.startdateBox.Value;
            this.enddateBox.Name = "enddateBox";
            this.enddateBox.Size = new System.Drawing.Size(168, 20);
            this.enddateBox.TabIndex = 17;
            // 
            // startdateBox
            // 
            this.startdateBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdateBox.Location = new System.Drawing.Point(96, 228);
            this.startdateBox.MinDate = new System.DateTime(2023, 4, 3, 0, 0, 0, 0);
            this.startdateBox.Name = "startdateBox";
            this.startdateBox.RightToLeftLayout = true;
            this.startdateBox.Size = new System.Drawing.Size(168, 20);
            this.startdateBox.TabIndex = 16;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Navy;
            this.SaveButton.Location = new System.Drawing.Point(96, 402);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(77, 32);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // maxnumberresultsBox
            // 
            this.maxnumberresultsBox.Location = new System.Drawing.Point(230, 352);
            this.maxnumberresultsBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxnumberresultsBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxnumberresultsBox.Name = "maxnumberresultsBox";
            this.maxnumberresultsBox.Size = new System.Drawing.Size(34, 20);
            this.maxnumberresultsBox.TabIndex = 14;
            this.maxnumberresultsBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(93, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max number of results";
            // 
            // projecttypeCb
            // 
            this.projecttypeCb.FormattingEnabled = true;
            this.projecttypeCb.Items.AddRange(new object[] {
            "Simple",
            "Mixed",
            "Complex"});
            this.projecttypeCb.Location = new System.Drawing.Point(95, 317);
            this.projecttypeCb.Name = "projecttypeCb";
            this.projecttypeCb.Size = new System.Drawing.Size(168, 21);
            this.projecttypeCb.TabIndex = 12;
            // 
            // enablenotificationsCheckbox
            // 
            this.enablenotificationsCheckbox.AutoSize = true;
            this.enablenotificationsCheckbox.ForeColor = System.Drawing.Color.Black;
            this.enablenotificationsCheckbox.Location = new System.Drawing.Point(95, 379);
            this.enablenotificationsCheckbox.Name = "enablenotificationsCheckbox";
            this.enablenotificationsCheckbox.Size = new System.Drawing.Size(138, 17);
            this.enablenotificationsCheckbox.TabIndex = 11;
            this.enablenotificationsCheckbox.Text = "Enable notifications";
            this.enablenotificationsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(144, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Project type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(152, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "End date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(147, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(147, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Folder Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(122, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(163, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // folderpathTb
            // 
            this.folderpathTb.Location = new System.Drawing.Point(95, 173);
            this.folderpathTb.Name = "folderpathTb";
            this.folderpathTb.Size = new System.Drawing.Size(168, 20);
            this.folderpathTb.TabIndex = 2;
            // 
            // descriptionTb
            // 
            this.descriptionTb.Location = new System.Drawing.Point(95, 67);
            this.descriptionTb.Multiline = true;
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTb.Size = new System.Drawing.Size(168, 87);
            this.descriptionTb.TabIndex = 1;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(95, 24);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(168, 20);
            this.nameTb.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(69, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.FileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.recentProjectsToolStripMenuItem});
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(57, 22);
            this.FileButton.Text = "Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.recentProjectsToolStripMenuItem.Text = "Recent Projects";
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Test1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxnumberresultsBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox folderpathTb;
        public System.Windows.Forms.TextBox descriptionTb;
        public System.Windows.Forms.TextBox nameTb;
        public System.Windows.Forms.NumericUpDown maxnumberresultsBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox projecttypeCb;
        public System.Windows.Forms.CheckBox enablenotificationsCheckbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.DateTimePicker startdateBox;
        public System.Windows.Forms.DateTimePicker enddateBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNumRecentFiles;
    }
}

