using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ScriptTimer
{
    public partial class frmMain : Form
    {
        TimeSpan time;
        string url;
        decimal waitingPeriod;

        async Task RunScript()
        {
            time = new TimeSpan(dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);

            if (url.Length != 0)
            {
                Process[] procList = Process.GetProcessesByName("iexplore.exe");

                if (procList.Length > 0)
                {
                    for (int i = 0; i < procList.Length; i++)
                    {
                        procList[i].Kill();
                    }
                }

                Process p = new Process();
                p.StartInfo.FileName = "iexplore.exe";
                p.StartInfo.Arguments = url;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                int ms = ((int)nudWaitingPeriod.Value * 1000);
                await Task.Delay(ms);

                p.Kill();

                if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate { lblStatus.Text = "Last Run: " + DateTime.Now.ToString(); });
                
            }
        }

        void UpdateFrm()
        {
            tbxUrl.Text = url;
            dtpTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, time.Hours, time.Minutes, time.Seconds);
            nudWaitingPeriod.Value = waitingPeriod;
        }

        public frmMain()
        {
            InitializeComponent();
            time = Properties.Settings.Default.Time;
            url = Properties.Settings.Default.Url;
            waitingPeriod = Properties.Settings.Default.WaitingPeriod;

            UpdateFrm();
        }

        private void chkBtnEnabled_CheckedChanged(object sender, EventArgs e)
        {
            tbxUrl.Enabled = !chkBtnEnabled.Checked;
            dtpTime.Enabled = !chkBtnEnabled.Checked;
            nudWaitingPeriod.Enabled = !chkBtnEnabled.Checked;
            timer.Enabled = chkBtnEnabled.Checked;

            if (chkBtnEnabled.Checked)
            {
                chkBtnEnabled.Text = "Enabled";
                chkBtnEnabled.BackColor = Color.GreenYellow;
                chkBtnEnabled.ForeColor = Color.Black;
            }
            else
            {
                chkBtnEnabled.Text = "Disabled";
                chkBtnEnabled.BackColor = Color.Crimson;
                chkBtnEnabled.ForeColor = Color.White;
            }

            UpdateFrm();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan tsNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            if (TimeSpan.Compare(tsNow, time) == 0)
            {
                Task.Run(() => RunScript());
            }
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            Task.Run(() => RunScript());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Time = time;
            Properties.Settings.Default.Url = url;
            Properties.Settings.Default.WaitingPeriod = waitingPeriod;
            Properties.Settings.Default.Save();
        }

        private void tbxUrl_TextChanged(object sender, EventArgs e)
        {
            url = tbxUrl.Text;
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            time = new TimeSpan(dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);
        }

        private void nudWaitingPeriod_ValueChanged(object sender, EventArgs e)
        {
            waitingPeriod = nudWaitingPeriod.Value;
        }
    }
}
