namespace WiFiDoctor
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContinuosReconnetCont = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblInfoLastResult = new System.Windows.Forms.Label();
            this.lblInfoAddress = new System.Windows.Forms.Label();
            this.lblInfoReconnectCount = new System.Windows.Forms.Label();
            this.lblInfoCount = new System.Windows.Forms.Label();
            this.lblInfoInterval = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConnectName = new System.Windows.Forms.TextBox();
            this.chkJurnalingDisconnectOnly = new System.Windows.Forms.CheckBox();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.chkJurnaling = new System.Windows.Forms.CheckBox();
            this.btnAutoRun = new System.Windows.Forms.Button();
            this.btnDelAutoRun = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Verify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(466, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(386, 488);
            this.textBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "startstop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContinuosReconnetCont);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblInfoLastResult);
            this.groupBox1.Controls.Add(this.lblInfoAddress);
            this.groupBox1.Controls.Add(this.lblInfoReconnectCount);
            this.groupBox1.Controls.Add(this.lblInfoCount);
            this.groupBox1.Controls.Add(this.lblInfoInterval);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 221);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lblContinuosReconnetCont
            // 
            this.lblContinuosReconnetCont.AutoSize = true;
            this.lblContinuosReconnetCont.Location = new System.Drawing.Point(221, 114);
            this.lblContinuosReconnetCont.Name = "lblContinuosReconnetCont";
            this.lblContinuosReconnetCont.Size = new System.Drawing.Size(35, 13);
            this.lblContinuosReconnetCont.TabIndex = 11;
            this.lblContinuosReconnetCont.Text = "label9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Кол-во непрерывных переподключений";
            // 
            // lblInfoLastResult
            // 
            this.lblInfoLastResult.AutoSize = true;
            this.lblInfoLastResult.Location = new System.Drawing.Point(221, 166);
            this.lblInfoLastResult.Name = "lblInfoLastResult";
            this.lblInfoLastResult.Size = new System.Drawing.Size(41, 13);
            this.lblInfoLastResult.TabIndex = 9;
            this.lblInfoLastResult.Text = "label11";
            // 
            // lblInfoAddress
            // 
            this.lblInfoAddress.AutoSize = true;
            this.lblInfoAddress.Location = new System.Drawing.Point(221, 140);
            this.lblInfoAddress.Name = "lblInfoAddress";
            this.lblInfoAddress.Size = new System.Drawing.Size(41, 13);
            this.lblInfoAddress.TabIndex = 8;
            this.lblInfoAddress.Text = "label10";
            // 
            // lblInfoReconnectCount
            // 
            this.lblInfoReconnectCount.AutoSize = true;
            this.lblInfoReconnectCount.Location = new System.Drawing.Point(221, 88);
            this.lblInfoReconnectCount.Name = "lblInfoReconnectCount";
            this.lblInfoReconnectCount.Size = new System.Drawing.Size(35, 13);
            this.lblInfoReconnectCount.TabIndex = 7;
            this.lblInfoReconnectCount.Text = "label9";
            // 
            // lblInfoCount
            // 
            this.lblInfoCount.AutoSize = true;
            this.lblInfoCount.Location = new System.Drawing.Point(221, 62);
            this.lblInfoCount.Name = "lblInfoCount";
            this.lblInfoCount.Size = new System.Drawing.Size(35, 13);
            this.lblInfoCount.TabIndex = 6;
            this.lblInfoCount.Text = "label8";
            // 
            // lblInfoInterval
            // 
            this.lblInfoInterval.AutoSize = true;
            this.lblInfoInterval.Location = new System.Drawing.Point(221, 36);
            this.lblInfoInterval.Name = "lblInfoInterval";
            this.lblInfoInterval.Size = new System.Drawing.Size(35, 13);
            this.lblInfoInterval.TabIndex = 5;
            this.lblInfoInterval.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Кол-во проверок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Результат последней проверки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кол-во переподключений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Адрес проверки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Интервал проверки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelAutoRun);
            this.groupBox2.Controls.Add(this.btnAutoRun);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 248);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtConnectName);
            this.groupBox3.Controls.Add(this.chkJurnalingDisconnectOnly);
            this.groupBox3.Controls.Add(this.btnApplySettings);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAddress1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numInterval);
            this.groupBox3.Controls.Add(this.chkJurnaling);
            this.groupBox3.Location = new System.Drawing.Point(116, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 244);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maintain";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Имя соединения";
            // 
            // txtConnectName
            // 
            this.txtConnectName.Location = new System.Drawing.Point(7, 176);
            this.txtConnectName.Name = "txtConnectName";
            this.txtConnectName.Size = new System.Drawing.Size(120, 20);
            this.txtConnectName.TabIndex = 7;
            // 
            // chkJurnalingDisconnectOnly
            // 
            this.chkJurnalingDisconnectOnly.AutoSize = true;
            this.chkJurnalingDisconnectOnly.Location = new System.Drawing.Point(7, 54);
            this.chkJurnalingDisconnectOnly.Name = "chkJurnalingDisconnectOnly";
            this.chkJurnalingDisconnectOnly.Size = new System.Drawing.Size(215, 17);
            this.chkJurnalingDisconnectOnly.TabIndex = 6;
            this.chkJurnalingDisconnectOnly.Text = "Журналировать только дисконнекты";
            this.chkJurnalingDisconnectOnly.UseVisualStyleBackColor = true;
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Location = new System.Drawing.Point(7, 215);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(325, 23);
            this.btnApplySettings.TabIndex = 5;
            this.btnApplySettings.Text = "Применить";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Адрес проверки";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(6, 129);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(120, 20);
            this.txtAddress1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Интервал проверки";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(6, 83);
            this.numInterval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 20);
            this.numInterval.TabIndex = 1;
            // 
            // chkJurnaling
            // 
            this.chkJurnaling.AutoSize = true;
            this.chkJurnaling.Location = new System.Drawing.Point(6, 22);
            this.chkJurnaling.Name = "chkJurnaling";
            this.chkJurnaling.Size = new System.Drawing.Size(114, 17);
            this.chkJurnaling.TabIndex = 0;
            this.chkJurnaling.Text = "Журналирование";
            this.chkJurnaling.UseVisualStyleBackColor = true;
            // 
            // btnAutoRun
            // 
            this.btnAutoRun.Location = new System.Drawing.Point(6, 177);
            this.btnAutoRun.Name = "btnAutoRun";
            this.btnAutoRun.Size = new System.Drawing.Size(75, 23);
            this.btnAutoRun.TabIndex = 6;
            this.btnAutoRun.Text = "set auto run";
            this.btnAutoRun.UseVisualStyleBackColor = true;
            this.btnAutoRun.Click += new System.EventHandler(this.btnAutoRun_Click);
            // 
            // btnDelAutoRun
            // 
            this.btnDelAutoRun.Location = new System.Drawing.Point(9, 206);
            this.btnDelAutoRun.Name = "btnDelAutoRun";
            this.btnDelAutoRun.Size = new System.Drawing.Size(75, 23);
            this.btnDelAutoRun.TabIndex = 7;
            this.btnDelAutoRun.Text = "del auto run";
            this.btnDelAutoRun.UseVisualStyleBackColor = true;
            this.btnDelAutoRun.Click += new System.EventHandler(this.btnDelAutoRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfoLastResult;
        private System.Windows.Forms.Label lblInfoAddress;
        private System.Windows.Forms.Label lblInfoReconnectCount;
        private System.Windows.Forms.Label lblInfoCount;
        private System.Windows.Forms.Label lblInfoInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.CheckBox chkJurnaling;
        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.CheckBox chkJurnalingDisconnectOnly;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConnectName;
        private System.Windows.Forms.Label lblContinuosReconnetCont;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelAutoRun;
        private System.Windows.Forms.Button btnAutoRun;
    }
}

