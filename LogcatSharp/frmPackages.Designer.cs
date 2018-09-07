namespace LogcatSharp
{
    partial class frmPackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackages));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEnabled = new System.Windows.Forms.ListBox();
            this.listBoxDisabled = new System.Windows.Forms.ListBox();
            this.listBoxThirdParty = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallKeepDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 257);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(692, 228);
            this.textBox1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxEnabled, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxDisabled, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxThirdParty, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 488);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enabled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disabled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "3rdParty";
            // 
            // listBoxEnabled
            // 
            this.listBoxEnabled.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEnabled.FormattingEnabled = true;
            this.listBoxEnabled.Location = new System.Drawing.Point(3, 23);
            this.listBoxEnabled.Name = "listBoxEnabled";
            this.listBoxEnabled.Size = new System.Drawing.Size(226, 228);
            this.listBoxEnabled.TabIndex = 2;
            this.listBoxEnabled.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseClick);
            // 
            // listBoxDisabled
            // 
            this.listBoxDisabled.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxDisabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDisabled.FormattingEnabled = true;
            this.listBoxDisabled.Location = new System.Drawing.Point(235, 23);
            this.listBoxDisabled.Name = "listBoxDisabled";
            this.listBoxDisabled.Size = new System.Drawing.Size(226, 228);
            this.listBoxDisabled.TabIndex = 3;
            // 
            // listBoxThirdParty
            // 
            this.listBoxThirdParty.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxThirdParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxThirdParty.FormattingEnabled = true;
            this.listBoxThirdParty.Location = new System.Drawing.Point(467, 23);
            this.listBoxThirdParty.Name = "listBoxThirdParty";
            this.listBoxThirdParty.Size = new System.Drawing.Size(228, 228);
            this.listBoxThirdParty.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallToolStripMenuItem,
            this.uninstallKeepDataToolStripMenuItem,
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 114);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // uninstallKeepDataToolStripMenuItem
            // 
            this.uninstallKeepDataToolStripMenuItem.Name = "uninstallKeepDataToolStripMenuItem";
            this.uninstallKeepDataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.uninstallKeepDataToolStripMenuItem.Text = "Uninstall (Keep data)";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPackages";
            this.Text = "frmPackages";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxEnabled;
        private System.Windows.Forms.ListBox listBoxDisabled;
        private System.Windows.Forms.ListBox listBoxThirdParty;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallKeepDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
    }
}