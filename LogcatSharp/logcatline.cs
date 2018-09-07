using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogcatSharp
{
    class logcatLine
    {
        public string raw { get; internal set; }
        public string[] rawArray { get; internal set; }
        public string sDate { get; set; }
        public string sTime { get; set; }
        public string PID { get; set; }
        public string TID { get; set; }
        public string TYP { get; set; }
        public string TAG { get; set; }
        public string MSG { get; set; }

        public bool bValid { get; internal set; }
        public logcatLine(string d, string tim, string p, string t, string y, string a, string m)
        {
            sDate = d;
            sTime = tim;
            PID = p;
            TID = t;
            TYP = y;
            TAG = a;
            MSG = m;
            raw = sDate + " " + sTime + " " + PID + " " + TID + " " + TYP + " " + TAG + " " + MSG;
            rawArray = new string[] { sDate, sTime, PID, TID, TYP, TAG, MSG };
        }
        //  0     1             2     3    4 5                  6
        // "08-25 23:39:27.829  1457  1622 D WifiStateMachine:  ConnectModeState !CMD_INSTALL_PACKET_FILTER  rt=5002109/5002109 len=104"
        // date   time          PID   TID  type TAG [rest]
        public logcatLine(string sLine)
        {
            raw = sLine;
            String[] tokens = sLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            rawArray = tokens;
            if (tokens.Length < 5)
                bValid = false;
            else
                bValid = true;

            try
            {
                sDate = tokens[0];
                sTime = tokens[1];
                PID = tokens[2];
                TID = tokens[3];
                TYP = tokens[4];
                TAG = tokens[5];
                StringBuilder sb = new StringBuilder();
                for (int i = 6; i < tokens.Length; i++)
                    sb.Append(tokens[i] + " ");
                MSG = sb.ToString();
            }
            catch (Exception) { }
        }
    }
}
