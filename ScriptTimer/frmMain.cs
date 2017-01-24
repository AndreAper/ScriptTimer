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
        private TimeSpan time;
        private string url;
        private decimal waitingPeriod;
        private Task scriptTask;

        private void ForceKillAllBrowserInstances()
        {
            try
            {
                if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate
                {
                    lbxLog.Items.Add(DateTime.Now.ToString() + " Begin find and terminate browser instances.");
                });

                Process[] procList = Process.GetProcessesByName("iexplore");

                if (procList.Length > 0)
                {
                    for (int i = 0; i < procList.Length; i++)
                    {
                        procList[i].CloseMainWindow();
                    }

                    procList = null;
                }
            }
            catch (Exception ex)
            {
                if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate
                {
                    lbxLog.Items.Add(DateTime.Now.ToString() + " " + ex.GetType().Name + ": " + ex.Message);
                });
            }
        }

        private async Task RunScriptAsync()
        {
            time = new TimeSpan(dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);

            if (url.Length != 0)
            {
                await Task.Run(() => ForceKillAllBrowserInstances());

                if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate {
                    lbxLog.Items.Add(DateTime.Now.ToString() + " Find and terminate browser instances completed.");
                    lbxLog.Items.Add(DateTime.Now.ToString() + " Start browser instance and run script.");
                });

                try
                {
                    Process p = new Process();
                    p.StartInfo.FileName = "iexplore.exe";
                    p.StartInfo.Arguments = url;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();

                    int ms = ((int)nudWaitingPeriod.Value * 1000);
                    await Task.Delay(ms);

                    p.CloseMainWindow();
                }
                catch (Exception ex)
                {
                    if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate
                    {
                        lbxLog.Items.Add(DateTime.Now.ToString() + " " + ex.GetType().Name + ": " + ex.Message);
                        btnForce.Enabled = true;
                    });
                }

                if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate {
                    lbxLog.Items.Add(DateTime.Now.ToString() + " Task completed successfull.");
                    lbxLog.Items.Add(String.Empty);
                    btnForce.Enabled = true;
                });               
            }
            else
            {
                if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate {
                    lbxLog.Items.Add(DateTime.Now.ToString() + " Error: No url entered!");
                    lbxLog.Items.Add(String.Empty);
                    btnForce.Enabled = true;
                });
            }
        }

        private void UpdateFrm()
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
            scriptTask = new Task(async () => await RunScriptAsync());

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

                btnForce.Enabled = false;
            }
            else
            {
                chkBtnEnabled.Text = "Disabled";
                chkBtnEnabled.BackColor = Color.Crimson;
                chkBtnEnabled.ForeColor = Color.White;

                btnForce.Enabled = true;
            }

            UpdateFrm();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan tsNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            if (TimeSpan.Compare(tsNow, time) == 0)
            {
                if (scriptTask.Status != TaskStatus.Running)
                {
                    lbxLog.Items.Add(DateTime.Now.ToString() + " Start new task.");

                    scriptTask = new Task(async () => await RunScriptAsync());
                    scriptTask.Start();
                }
                else
                {
                    lbxLog.Items.Add(DateTime.Now.ToString() + " Task canceled because another task is running.");
                }
            }
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            if (scriptTask.Status != TaskStatus.Running)
            {
                btnForce.Enabled = false;

                lbxLog.Items.Add(DateTime.Now.ToString() + " Start new task manually.");
                scriptTask = new Task(async () => await RunScriptAsync());
                scriptTask.Start();

            }
            else
            {
                lbxLog.Items.Add(DateTime.Now.ToString() + " Task canceled because another task is running.");
            }
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

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            lbxLog.Items.Clear();
        }
    }
}
