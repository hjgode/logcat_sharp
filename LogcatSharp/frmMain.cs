using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace LogcatSharp
{
	public partial class frmMain : Form
	{
		string adbPath = string.Empty;
        long lineCount = 0;
        myColumns currentColumn = myColumns.none;
        string currentColumnFilter = "";

		public frmMain()
		{
			InitializeComponent();
		}

		Process adb = null;
		
		private void frmMain_Load(object sender, EventArgs e)
		{

			this.adbPath = Settings.GetPath();

			if (string.IsNullOrEmpty(adbPath) || !System.IO.File.Exists(adbPath))
			{
				frmAdbFinder faf = new frmAdbFinder();
				if (faf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					this.adbPath = faf.AdbPath;
					Settings.SavePath(faf.AdbPath);
				}
				else
				{
					MessageBox.Show(this, "Could not find adb.exe.  Please install the SDK and Emulator and try again!  Alternatively you can set the path manually adb-path.txt", "Failed to find adb.exe", MessageBoxButtons.OK);

					this.Close();
					Application.Exit();
				}
			}
            
		}

        BindingList<String> sPIDs = new BindingList<String>();
        BindingList<String> sTIDs = new BindingList<String>();
        BindingList<String> sTypes = new BindingList<String>();
        BindingList<String> sTAGs = new BindingList<String>();

        bool bAssignDone = false;
        void assignLists()
        {
            comboBoxPIDs.DataSource = sPIDs;
            comboBoxTIDs.DataSource = sTIDs;
            comboBoxTypes.DataSource = sTypes;
            comboBoxTAGs.DataSource = sTAGs;
            bAssignDone = true;
        }

        /// <summary>
        /// return true to add line to output
        /// </summary>
        /// <param name="sLine"></param>
        /// <returns></returns>
        bool processLine(String sLine)
        {
            if (!bAssignDone)
                assignLists();
            if (sLine == null)
                return false;
            if (sLine.Length == 0)
                return false;

            // "08-25 23:39:27.829  1457  1622 D WifiStateMachine:  ConnectModeState !CMD_INSTALL_PACKET_FILTER  rt=5002109/5002109 len=104"
            // date   time          PID   TID  type TAG [rest]
            logcatLine logCatLine = new logcatLine(sLine);

            //### update list entries
            //date  time PID TID Type TAG [rest is message]
            if (logCatLine.bValid)
            {
                if (!sPIDs.Contains(logCatLine.PID))
                {
                    sPIDs.Add(logCatLine.PID);
                }
                if (!sTIDs.Contains(logCatLine.TID))
                {
                    sTIDs.Add(logCatLine.TID);
                }
                if (!sTypes.Contains(logCatLine.TYP))
                {
                    sTypes.Add(logCatLine.TYP);
                }
                if (!sTAGs.Contains(logCatLine.TAG))
                {
                    sTAGs.Add(logCatLine.TAG);
                }
            }

            if (checkBox_DoFilter.Checked && !checkBoxUseAsFilter.Checked)
            {
                try
                {
                    Regex regex = new Regex(textBox1.Text);
                    Match m = Regex.Match(sLine, textBox1.Text, RegexOptions.Singleline);
                    setRegexResult(this, new StringMsgEventArgs("Regex valid"));
                    if (m.Success) //found at least one match
                    {
                        if (checkBox_Invert.Checked)
                            return false;
                        else
                            return true;
                    }
                    else {
                        if (checkBox_Invert.Checked)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ex) {
                    setRegexResult(this, new StringMsgEventArgs("Regex failed: " + ex.Message));
                }
            }


            if (checkBoxUseAsFilter.Checked)
            {
                if (!logCatLine.bValid)
                    return true; //allow output of undefined logcat line
                //filter by column
                if (logCatLine.rawArray[(int)currentColumn].Equals(currentColumnFilter))
                    return true;
                else
                    return false;
            }



            return true;
        }
        void clear()
		{
			if (adb == null || adb.HasExited)
			{
				try
				{
					adb = new Process();
					adb.StartInfo.UseShellExecute = false;
                    adb.StartInfo.FileName = this.adbPath;// @"C:\Program Files (x86)\Android\android-sdk-windows\platform-tools\adb.exe";//
					adb.StartInfo.Arguments = "logcat -c";
					adb.StartInfo.CreateNoWindow = true;
					adb.Start();
					adb.WaitForExit(1500);
				}
				catch (Exception ex){
                    System.Diagnostics.Debug.WriteLine("clear() exception: "+ex.Message);
                }
			}
		}

		void stop()
		{
			this.toolStripButtonStop.Enabled = false;
            if (adb != null)
                try
                {
                    adb.StandardInput.Write("\x03");
                }
                catch (Exception) { }
			if (adb != null && !adb.HasExited)
			{
				adb.Kill();
                adb = null;
			}

			this.toolStripButtonStart.Enabled = true;
            Application.DoEvents();
		}

		void start()
		{
			this.toolStripButtonStart.Enabled = false;

			if (adb != null)
				return;
            if (adb != null && !adb.HasExited)
                return;

			adb = new Process();
			adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.FileName = this.adbPath; //@"C:\Program Files (x86)\Android\android-sdk-windows\platform-tools\adb.exe";//
			adb.StartInfo.Arguments = "logcat -T 200";
			adb.StartInfo.RedirectStandardOutput = true;
			adb.StartInfo.RedirectStandardError = true;
            adb.StartInfo.RedirectStandardInput = true;
			adb.EnableRaisingEvents = true;
			adb.StartInfo.CreateNoWindow = true;
			adb.ErrorDataReceived += new DataReceivedEventHandler(adb_ErrorDataReceived);
			adb.OutputDataReceived += new DataReceivedEventHandler(adb_OutputDataReceived);
            adb.Exited += new EventHandler(adbProcess_Exited);

			try {
                var started = adb.Start();
                adb.BeginErrorReadLine();
			    adb.BeginOutputReadLine();
            }
			catch (Exception ex)
			{
				this.toolStripButtonStart.Enabled = true;
				this.toolStripButtonStop.Enabled = false;

				Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
			}


			this.toolStripButtonStop.Enabled = true;
            Application.DoEvents();
		}

        class toolstripButtonArgs : EventArgs
        {
            public ToolStripButton btn;
            public bool enable;
            public toolstripButtonArgs(ToolStripButton b, bool en)
            {
                btn = b;
                enable = en;
            }
        }
        void setButton(object sender, toolstripButtonArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action<object, toolstripButtonArgs>(setButton), sender, e);
            else
                e.btn.Enabled = e.enable;
        }
        // Handle Exited event and display process information.
        private void adbProcess_Exited(object sender, System.EventArgs e)
        {
            
            setButton(this, new toolstripButtonArgs(toolStripButtonClear, true));
            setButton(this, new toolstripButtonArgs(toolStripButtonStart, true));
            setButton(this, new toolstripButtonArgs(toolStripButtonStop, false));
            if (adb != null)
            {
                System.Diagnostics.Debug.WriteLine("Exit time:    {0}\r\n" + "Exit code:    {1}", adb.ExitTime, adb.ExitCode);
                adb.Dispose();
                adb = null;
            }
        }
        class StringMsgEventArgs : EventArgs
        {
            public string msg;
            public StringMsgEventArgs(string s)
            {
                msg = s;
            }
        }
        void setRegexResult(object sender, StringMsgEventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action<object, StringMsgEventArgs>(setRegexResult), sender, e);
            else
            {
                toolStripStatusLabel2.Text = e.msg;
            }
        }
		void adb_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
            if (this.InvokeRequired)
                this.Invoke(new Action<object, DataReceivedEventArgs>(adb_OutputDataReceived), sender, e);
            else
            {
                toolStripStatusLabel1.Text = (++lineCount).ToString();
                if (processLine(e.Data))
                    textAdb.AppendText(e.Data+Environment.NewLine);
            }
		}


		void adb_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
			if (this.InvokeRequired)
				this.Invoke(new Action<object, DataReceivedEventArgs>(adb_ErrorDataReceived), sender, e);
			else
				textAdb.AppendText(e.Data + Environment.NewLine);
		}

		private void toolStripButtonClear_Click(object sender, EventArgs e)
		{
			stop();
			clear();
			start();
            setButton(this, new toolstripButtonArgs(toolStripButtonStart, true));
		}

		//string filterData(string data)
		//{
		//	if (string.IsNullOrWhiteSpace(data))
		//		return string.Empty;

		//	if (!string.IsNullOrEmpty(this.toolStripTextBoxFilter.Text))
		//	{
		//		var pattern = !this.toolStripComboBoxFilterType.Text.Equals("Regex") ? this.toolStripTextBoxFilter.Text.Replace("*", ".*")
		//			: this.toolStripTextBoxFilter.Text;
		//		System.Text.RegularExpressions.Regex rx = new System.Text.RegularExpressions.Regex(pattern, System.Text.RegularExpressions.RegexOptions.Singleline | System.Text.RegularExpressions.RegexOptions.IgnoreCase);

		//		if (rx.IsMatch(data))
		//			return data.Trim() + Environment.NewLine;
		//		else
		//			return string.Empty;
		//	}

		//	return data.Trim() + Environment.NewLine;
		//}

		private void toolStripButtonStart_Click(object sender, EventArgs e)
		{
			start();
		}

		private void toolStripButtonStop_Click(object sender, EventArgs e)
		{
			stop();
		}

        enum myColumns:int
        {
            none=-1,
            Date=0,
            Time=1,
            PIDs=2,
            TIDs=3,
            Types=4,
            TAGs=5,
            MSG=6
        }
        private void comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            if (CB.Name.EndsWith("PIDs"))
                currentColumn = myColumns.PIDs;
            else if (CB.Name.EndsWith("TIDs"))
                currentColumn = myColumns.TIDs;
            else if (CB.Name.EndsWith("Types"))
                currentColumn = myColumns.Types;
            else if (CB.Name.EndsWith("TAGs"))
                currentColumn = myColumns.TAGs;
            else
            {
                currentColumn = myColumns.none;
                currentColumnFilter = "";
                System.Diagnostics.Debug.WriteLine("comboBox_MouseClick: no valid filter");
                return;
            }
            if (CB.SelectedItem != null)
            {
                currentColumnFilter = CB.SelectedItem.ToString();
                System.Diagnostics.Debug.WriteLine("comboBox_MouseClick: filter='" + currentColumnFilter + "', Column=" + currentColumn.ToString());
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_MouseClick(sender, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            frmPackages frm = new frmPackages();
            frm.Show();
        }
    }
}
