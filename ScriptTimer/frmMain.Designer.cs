namespace ScriptTimer
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.chkBtnEnabled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForce = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.nudWaitingPeriod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitingPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(109, 9);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(303, 20);
            this.tbxUrl.TabIndex = 0;
            this.tbxUrl.TextChanged += new System.EventHandler(this.tbxUrl_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // dtpTime
            // 
            this.dtpTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpTime.CustomFormat = "hh:MM:ss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(109, 35);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(91, 20);
            this.dtpTime.TabIndex = 2;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // chkBtnEnabled
            // 
            this.chkBtnEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBtnEnabled.AutoSize = true;
            this.chkBtnEnabled.BackColor = System.Drawing.Color.Crimson;
            this.chkBtnEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBtnEnabled.ForeColor = System.Drawing.Color.White;
            this.chkBtnEnabled.Location = new System.Drawing.Point(300, 35);
            this.chkBtnEnabled.Name = "chkBtnEnabled";
            this.chkBtnEnabled.Size = new System.Drawing.Size(58, 23);
            this.chkBtnEnabled.TabIndex = 3;
            this.chkBtnEnabled.Text = "Disabled";
            this.chkBtnEnabled.UseVisualStyleBackColor = false;
            this.chkBtnEnabled.CheckedChanged += new System.EventHandler(this.chkBtnEnabled_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // btnForce
            // 
            this.btnForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForce.Location = new System.Drawing.Point(364, 35);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(48, 23);
            this.btnForce.TabIndex = 4;
            this.btnForce.Text = "Force";
            this.btnForce.UseVisualStyleBackColor = true;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(64, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Last Run:";
            // 
            // nudWaitingPeriod
            // 
            this.nudWaitingPeriod.Location = new System.Drawing.Point(109, 61);
            this.nudWaitingPeriod.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudWaitingPeriod.Name = "nudWaitingPeriod";
            this.nudWaitingPeriod.Size = new System.Drawing.Size(91, 20);
            this.nudWaitingPeriod.TabIndex = 6;
            this.nudWaitingPeriod.ValueChanged += new System.EventHandler(this.nudWaitingPeriod_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Waiting period (s):";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 115);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudWaitingPeriod);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnForce);
            this.Controls.Add(this.chkBtnEnabled);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "ScriptTimer 1.1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitingPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.CheckBox chkBtnEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown nudWaitingPeriod;
        private System.Windows.Forms.Label label3;
    }
}

