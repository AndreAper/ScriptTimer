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
            this.label2 = new System.Windows.Forms.Label();
            this.nudWaitingPeriod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.chkBtnEnabled = new System.Windows.Forms.CheckBox();
            this.btnForce = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitingPeriod)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(133, 31);
            this.tbxUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(341, 25);
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
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // dtpTime
            // 
            this.dtpTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpTime.CustomFormat = "hh:MM:ss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(133, 91);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(106, 25);
            this.dtpTime.TabIndex = 2;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // nudWaitingPeriod
            // 
            this.nudWaitingPeriod.Location = new System.Drawing.Point(133, 151);
            this.nudWaitingPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudWaitingPeriod.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudWaitingPeriod.Name = "nudWaitingPeriod";
            this.nudWaitingPeriod.Size = new System.Drawing.Size(106, 25);
            this.nudWaitingPeriod.TabIndex = 6;
            this.nudWaitingPeriod.ValueChanged += new System.EventHandler(this.nudWaitingPeriod_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Waiting period (s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(133, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Define the url to open in the browser.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxUrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudWaitingPeriod, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbxLog, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 331);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(133, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Set the time to open the url in the browser.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(133, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "The time in seconds to wait until clsoing the browser.";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Log:";
            // 
            // lbxLog
            // 
            this.lbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.HorizontalScrollbar = true;
            this.lbxLog.ItemHeight = 17;
            this.lbxLog.Location = new System.Drawing.Point(483, 30);
            this.lbxLog.Name = "lbxLog";
            this.tableLayoutPanel1.SetRowSpan(this.lbxLog, 6);
            this.lbxLog.Size = new System.Drawing.Size(343, 293);
            this.lbxLog.TabIndex = 9;
            // 
            // chkBtnEnabled
            // 
            this.chkBtnEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBtnEnabled.BackColor = System.Drawing.Color.Crimson;
            this.chkBtnEnabled.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkBtnEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBtnEnabled.ForeColor = System.Drawing.Color.White;
            this.chkBtnEnabled.Location = new System.Drawing.Point(3, 3);
            this.chkBtnEnabled.Name = "chkBtnEnabled";
            this.chkBtnEnabled.Size = new System.Drawing.Size(100, 30);
            this.chkBtnEnabled.TabIndex = 3;
            this.chkBtnEnabled.Text = "Disabled";
            this.chkBtnEnabled.UseVisualStyleBackColor = false;
            this.chkBtnEnabled.CheckedChanged += new System.EventHandler(this.chkBtnEnabled_CheckedChanged);
            // 
            // btnForce
            // 
            this.btnForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForce.Location = new System.Drawing.Point(109, 3);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(100, 30);
            this.btnForce.TabIndex = 4;
            this.btnForce.Text = "Force";
            this.btnForce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForce.UseVisualStyleBackColor = true;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearLog);
            this.panel1.Controls.Add(this.btnForce);
            this.panel1.Controls.Add(this.chkBtnEnabled);
            this.panel1.Location = new System.Drawing.Point(130, 183);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 38);
            this.panel1.TabIndex = 10;
            // 
            // btnClearLog
            // 
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Location = new System.Drawing.Point(215, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(100, 30);
            this.btnClearLog.TabIndex = 4;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 331);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(845, 370);
            this.Name = "frmMain";
            this.Text = "ScriptTimer 1.2.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitingPeriod)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudWaitingPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.CheckBox chkBtnEnabled;
        private System.Windows.Forms.Button btnClearLog;
    }
}

