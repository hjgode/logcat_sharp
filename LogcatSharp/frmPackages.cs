using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogcatSharp
{
    public partial class frmPackages : Form
    {
        List<package> packagesEnabled = new List<package>();
        List<package> packagesDisabled = new List<package>();
        List<package> packagesThirdParty = new List<package>();
        currentListTypes currentList = currentListTypes.none;

        public frmPackages()
        {
            InitializeComponent();
            contextMenuStrip1.Opening += new CancelEventHandler(cms_Opening);
        }

        void cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ListBox lb = (ListBox)contextMenuStrip1.SourceControl;
            if (lb.SelectedItems.Count == 0)
                return;
            foreach(var v in lb.SelectedItems)
            {
                System.Diagnostics.Debug.WriteLine("pm uninstall package " + ((package)v).name);
            }
            e.Cancel = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            packagesEnabled = new List<package>();
            packagesDisabled = new List<package>();
            packagesThirdParty = new List<package>();

            adb_class adb = new adb_class();
            adb.onAdbMessage += new adb_class.onAdbMessageHandler(onAdbMessage);
            adb.onAdbExit += new adb_class.onAdbExitHandler(onAdbExit);

            //adb.runCmd("shell pm list packages");

            currentList = currentListTypes.enabled;
            adb.runCmd("shell cmd package list packages -e");
            while (!adb.finished)
                ;

            currentList = currentListTypes.disabled;
            adb.runCmd("shell cmd package list packages -d");
            while (!adb.finished)
                ;

            currentList = currentListTypes.thirdparty;
            adb.runCmd("shell cmd package list packages -3");
            while (!adb.finished)
                ;
            textBox1.Text = adb.sConsole;

            listBoxEnabled.DataSource = null;
            listBoxDisabled.DataSource = null;
            listBoxThirdParty.DataSource = null;
            listBoxEnabled.DataSource = packagesEnabled;
            listBoxDisabled.DataSource = packagesDisabled;
            listBoxThirdParty.DataSource = packagesThirdParty;

        }

        void onAdbExit(adbExitArgs e)
        {
            if(this.InvokeRequired)
                this.Invoke(new Action<adbExitArgs>(onAdbExit), e);
            else
                textBox1.Text+="\nAdb exit with "+e.returncode.ToString();
        }
        void onAdbMessage(adbMessageArgs e) {
            if (e.msg != null && e.msg.Length > 0)
            {
                switch (currentList)
                {
                    case currentListTypes.enabled:
                        packagesEnabled.Add(new package(e.msg));
                        break;
                    case currentListTypes.disabled:
                        packagesDisabled.Add(new package(e.msg));
                        break;
                    case currentListTypes.thirdparty:
                        packagesThirdParty.Add(new package(e.msg));
                        break;
                }
            }           
        }

        enum currentListTypes : int
        {
            none,
            enabled,
            disabled,
            thirdparty
        }

        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListBox lb = (ListBox)sender;
                String s = lb.SelectedItem.ToString();
                contextMenuStrip1.Show(new Point(e.X, e.Y));
            }
        }

        private void uninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
