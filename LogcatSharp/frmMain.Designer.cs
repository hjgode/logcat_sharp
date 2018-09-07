namespace LogcatSharp
{
	partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.textAdb = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.comboBoxPIDs = new System.Windows.Forms.ComboBox();
            this.comboBoxTIDs = new System.Windows.Forms.ComboBox();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxTAGs = new System.Windows.Forms.ComboBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_DoFilter = new System.Windows.Forms.CheckBox();
            this.checkBox_Invert = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxUseAsFilter = new System.Windows.Forms.CheckBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPackages = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textAdb
            // 
            this.textAdb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAdb.Location = new System.Drawing.Point(0, 25);
            this.textAdb.Multiline = true;
            this.textAdb.Name = "textAdb";
            this.textAdb.ReadOnly = true;
            this.textAdb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textAdb.Size = new System.Drawing.Size(694, 471);
            this.textAdb.TabIndex = 0;
            this.textAdb.WordWrap = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripSeparator2,
            this.toolStripButtonClear,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.btnPackages});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStart.Text = "Start";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Enabled = false;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonClear.Text = "Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(694, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // comboBoxPIDs
            // 
            this.comboBoxPIDs.FormattingEnabled = true;
            this.comboBoxPIDs.Location = new System.Drawing.Point(12, 25);
            this.comboBoxPIDs.Name = "comboBoxPIDs";
            this.comboBoxPIDs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPIDs.TabIndex = 3;
            this.comboBoxPIDs.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBoxPIDs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseClick);
            // 
            // comboBoxTIDs
            // 
            this.comboBoxTIDs.FormattingEnabled = true;
            this.comboBoxTIDs.Location = new System.Drawing.Point(139, 25);
            this.comboBoxTIDs.Name = "comboBoxTIDs";
            this.comboBoxTIDs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTIDs.TabIndex = 4;
            this.comboBoxTIDs.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBoxTIDs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseClick);
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(266, 25);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypes.TabIndex = 4;
            this.comboBoxTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBoxTypes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseClick);
            // 
            // comboBoxTAGs
            // 
            this.comboBoxTAGs.FormattingEnabled = true;
            this.comboBoxTAGs.Location = new System.Drawing.Point(393, 25);
            this.comboBoxTAGs.Name = "comboBoxTAGs";
            this.comboBoxTAGs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTAGs.TabIndex = 4;
            this.comboBoxTAGs.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBoxTAGs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseClick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(694, 25);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = ".*";
            // 
            // checkBox_DoFilter
            // 
            this.checkBox_DoFilter.AutoSize = true;
            this.checkBox_DoFilter.Location = new System.Drawing.Point(393, 52);
            this.checkBox_DoFilter.Name = "checkBox_DoFilter";
            this.checkBox_DoFilter.Size = new System.Drawing.Size(48, 17);
            this.checkBox_DoFilter.TabIndex = 7;
            this.checkBox_DoFilter.Text = "Filter";
            this.checkBox_DoFilter.UseVisualStyleBackColor = true;
            // 
            // checkBox_Invert
            // 
            this.checkBox_Invert.AutoSize = true;
            this.checkBox_Invert.Location = new System.Drawing.Point(447, 52);
            this.checkBox_Invert.Name = "checkBox_Invert";
            this.checkBox_Invert.Size = new System.Drawing.Size(53, 17);
            this.checkBox_Invert.TabIndex = 8;
            this.checkBox_Invert.Text = "Invert";
            this.checkBox_Invert.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "line count";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel2.Text = "RegEx result";
            // 
            // checkBoxUseAsFilter
            // 
            this.checkBoxUseAsFilter.AutoSize = true;
            this.checkBoxUseAsFilter.Location = new System.Drawing.Point(520, 27);
            this.checkBoxUseAsFilter.Name = "checkBoxUseAsFilter";
            this.checkBoxUseAsFilter.Size = new System.Drawing.Size(82, 17);
            this.checkBoxUseAsFilter.TabIndex = 10;
            this.checkBoxUseAsFilter.Text = "use as Filter";
            this.checkBoxUseAsFilter.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPackages
            // 
            this.btnPackages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPackages.Image = ((System.Drawing.Image)(resources.GetObject("btnPackages.Image")));
            this.btnPackages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(56, 22);
            this.btnPackages.Text = "Packages";
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 496);
            this.Controls.Add(this.checkBoxUseAsFilter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox_Invert);
            this.Controls.Add(this.checkBox_DoFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.comboBoxTAGs);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.comboBoxTIDs);
            this.Controls.Add(this.comboBoxPIDs);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.textAdb);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Logcat #";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textAdb;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonClear;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonStart;
		private System.Windows.Forms.ToolStripButton toolStripButtonStop;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ComboBox comboBoxPIDs;
        private System.Windows.Forms.ComboBox comboBoxTIDs;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.ComboBox comboBoxTAGs;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox_DoFilter;
        private System.Windows.Forms.CheckBox checkBox_Invert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.CheckBox checkBoxUseAsFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPackages;
    }
}

