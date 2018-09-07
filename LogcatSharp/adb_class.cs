using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace LogcatSharp
{
    class adb_class
    {
        string adbPath = string.Empty;
        Process adb = null;
        Object lockObject=new object();
        Queue<string> resultString = new Queue<string>();
        public bool finished = false;
        public string sConsole
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                lock (lockObject)
                {
                    foreach (string s in resultString)
                        sb.Append(s);
                }
                return sb.ToString();
            }
        }

        public adb_class(){
			this.adbPath = Settings.GetPath();
        }

        public bool runCmd(string sCmd)
        {
            finished = false;
            bool bRet = false;
            adb = new Process();
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.FileName = this.adbPath;// @"C:\Program Files (x86)\Android\android-sdk-windows\platform-tools\adb.exe";//
            adb.StartInfo.Arguments = sCmd;
            adb.StartInfo.CreateNoWindow = true;

            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.RedirectStandardError = true;
            adb.StartInfo.RedirectStandardInput = true;

            adb.EnableRaisingEvents = true;

            adb.ErrorDataReceived += new DataReceivedEventHandler(adb_ErrorDataReceived);
            adb.OutputDataReceived += new DataReceivedEventHandler(adb_OutputDataReceived);
            adb.Exited += new EventHandler(adbProcess_Exited);

            bRet = true;
            try
            {
                var started = adb.Start();
                adb.BeginErrorReadLine();
                adb.BeginOutputReadLine();
                adb.WaitForExit(1500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);                
            }
            return bRet;
        }
        void adb_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            raiseAdbMessage(e.Data);
            lock (lockObject) { 
               resultString.Enqueue(e.Data + Environment.NewLine);
            }
        }

        void adb_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock (lockObject)
            {
                resultString.Enqueue(e.Data + Environment.NewLine);
            }
        }
        private void adbProcess_Exited(object sender, System.EventArgs e)
        {
            int ExitCode = -99;
            if (adb != null)
            {
                try
                {
                    ExitCode = adb.ExitCode;
                    System.Diagnostics.Debug.WriteLine("Exit time:    {0}\r\n" + "Exit code:    {1}", adb.ExitTime, adb.ExitCode);
                    adb.Dispose();
                    adb = null;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    finished = true;
                    raiseExit(ExitCode);
                }
            }
        }

        public delegate void onAdbExitHandler(adbExitArgs e);
        public event onAdbExitHandler onAdbExit;
        protected virtual void raiseExit(int code)
        {
            if (onAdbExit != null)
                onAdbExit(new adbExitArgs(code));
        }

        public delegate void onAdbMessageHandler(adbMessageArgs e);
        public event onAdbMessageHandler onAdbMessage;
        protected virtual void raiseAdbMessage(string m)
        {
            if (onAdbMessage != null)
                onAdbMessage(new adbMessageArgs(m));
        }
    }

    public class adbExitArgs : EventArgs
    {
        public int returncode;
        public adbExitArgs(int i)
        {
            returncode = i;
        }
    }
    public class adbMessageArgs : EventArgs
    {
        public string msg;
        public int result;
        public adbMessageArgs(string m, int i)
        {
            msg = m;
            result = i;
        }
        public adbMessageArgs(string m)
        {
            msg = m;
        }
    }
}
