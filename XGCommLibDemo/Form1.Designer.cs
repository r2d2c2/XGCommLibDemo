namespace XGCommLibDemo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.chkKeepAlive = new System.Windows.Forms.CheckBox();
            this.chkAliveStatus = new System.Windows.Forms.CheckBox();
            this.txtIpAddrPlc = new System.Windows.Forms.TextBox();
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.lblPlcIP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.btnReadData = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.txtAccessTime = new System.Windows.Forms.TextBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtScanTime = new System.Windows.Forms.TextBox();
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.chkUseErrorStop = new System.Windows.Forms.CheckBox();
            this.txtMaxTime = new System.Windows.Forms.TextBox();
            this.txtErrorCountCheck = new System.Windows.Forms.TextBox();
            this.txtErrorCountRead = new System.Windows.Forms.TextBox();
            this.txtErrorCountWrite = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.tmKeepAlive = new System.Windows.Forms.Timer(this.components);
            this.tmLibTest = new System.Windows.Forms.Timer(this.components);
            this.tmUpdateCtrl = new System.Windows.Forms.Timer(this.components);
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.chkUseData = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.chkKeepAlive);
            this.groupBox1.Controls.Add(this.chkAliveStatus);
            this.groupBox1.Controls.Add(this.txtIpAddrPlc);
            this.groupBox1.Controls.Add(this.txtPortNo);
            this.groupBox1.Controls.Add(this.lblPortNo);
            this.groupBox1.Controls.Add(this.lblPlcIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(523, 17);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(105, 24);
            this.btnOpenPort.TabIndex = 3;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // chkKeepAlive
            // 
            this.chkKeepAlive.AutoSize = true;
            this.chkKeepAlive.Location = new System.Drawing.Point(433, 20);
            this.chkKeepAlive.Name = "chkKeepAlive";
            this.chkKeepAlive.Size = new System.Drawing.Size(84, 16);
            this.chkKeepAlive.TabIndex = 2;
            this.chkKeepAlive.Text = "Keep Alive";
            this.chkKeepAlive.UseVisualStyleBackColor = true;
            this.chkKeepAlive.CheckedChanged += new System.EventHandler(this.chkKeepAlive_CheckedChanged);
            // 
            // chkAliveStatus
            // 
            this.chkAliveStatus.AutoSize = true;
            this.chkAliveStatus.Enabled = false;
            this.chkAliveStatus.Location = new System.Drawing.Point(412, 21);
            this.chkAliveStatus.Name = "chkAliveStatus";
            this.chkAliveStatus.Size = new System.Drawing.Size(15, 14);
            this.chkAliveStatus.TabIndex = 2;
            this.chkAliveStatus.UseVisualStyleBackColor = true;
            // 
            // txtIpAddrPlc
            // 
            this.txtIpAddrPlc.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtIpAddrPlc.Location = new System.Drawing.Point(68, 17);
            this.txtIpAddrPlc.Name = "txtIpAddrPlc";
            this.txtIpAddrPlc.Size = new System.Drawing.Size(157, 22);
            this.txtIpAddrPlc.TabIndex = 1;
            this.txtIpAddrPlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPortNo
            // 
            this.txtPortNo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPortNo.Location = new System.Drawing.Point(313, 17);
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Size = new System.Drawing.Size(78, 22);
            this.txtPortNo.TabIndex = 1;
            this.txtPortNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPortNo
            // 
            this.lblPortNo.AutoSize = true;
            this.lblPortNo.Location = new System.Drawing.Point(255, 22);
            this.lblPortNo.Name = "lblPortNo";
            this.lblPortNo.Size = new System.Drawing.Size(55, 12);
            this.lblPortNo.TabIndex = 0;
            this.lblPortNo.Text = "Port No :";
            // 
            // lblPlcIP
            // 
            this.lblPlcIP.AutoSize = true;
            this.lblPlcIP.Location = new System.Drawing.Point(11, 22);
            this.lblPlcIP.Name = "lblPlcIP";
            this.lblPlcIP.Size = new System.Drawing.Size(52, 12);
            this.lblPlcIP.TabIndex = 0;
            this.lblPlcIP.Text = "PLC IP :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWriteData);
            this.groupBox2.Controls.Add(this.txtSize);
            this.groupBox2.Controls.Add(this.chkUseData);
            this.groupBox2.Controls.Add(this.txtOffset);
            this.groupBox2.Controls.Add(this.btnReadData);
            this.groupBox2.Controls.Add(this.btnWriteData);
            this.groupBox2.Controls.Add(this.txtAccessTime);
            this.groupBox2.Controls.Add(this.cboDataType);
            this.groupBox2.Controls.Add(this.cboDeviceType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Write/Read";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSize.Location = new System.Drawing.Point(308, 47);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(83, 22);
            this.txtSize.TabIndex = 15;
            this.txtSize.Text = "0";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOffset
            // 
            this.txtOffset.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOffset.Location = new System.Drawing.Point(211, 47);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(83, 22);
            this.txtOffset.TabIndex = 15;
            this.txtOffset.Text = "0";
            this.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(523, 46);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(105, 24);
            this.btnReadData.TabIndex = 3;
            this.btnReadData.Text = "Read Byte Data";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(408, 46);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(105, 24);
            this.btnWriteData.TabIndex = 3;
            this.btnWriteData.Text = "Write Byte Data";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // txtAccessTime
            // 
            this.txtAccessTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAccessTime.Location = new System.Drawing.Point(523, 18);
            this.txtAccessTime.Name = "txtAccessTime";
            this.txtAccessTime.ReadOnly = true;
            this.txtAccessTime.Size = new System.Drawing.Size(71, 22);
            this.txtAccessTime.TabIndex = 1;
            this.txtAccessTime.Text = "-";
            this.txtAccessTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboDataType
            // 
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "Bit",
            "Byte",
            "Word"});
            this.cboDataType.Location = new System.Drawing.Point(112, 48);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(83, 21);
            this.cboDataType.TabIndex = 2;
            // 
            // cboDeviceType
            // 
            this.cboDeviceType.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboDeviceType.FormattingEnabled = true;
            this.cboDeviceType.Items.AddRange(new object[] {
            "M",
            "W",
            "R"});
            this.cboDeviceType.Location = new System.Drawing.Point(13, 48);
            this.cboDeviceType.Name = "cboDeviceType";
            this.cboDeviceType.Size = new System.Drawing.Size(83, 21);
            this.cboDeviceType.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtScanTime);
            this.groupBox4.Controls.Add(this.chkTest);
            this.groupBox4.Controls.Add(this.chkUseErrorStop);
            this.groupBox4.Controls.Add(this.txtMaxTime);
            this.groupBox4.Controls.Add(this.txtErrorCountCheck);
            this.groupBox4.Controls.Add(this.txtErrorCountRead);
            this.groupBox4.Controls.Add(this.txtErrorCountWrite);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(640, 81);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Auto Test";
            // 
            // txtScanTime
            // 
            this.txtScanTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScanTime.Location = new System.Drawing.Point(408, 44);
            this.txtScanTime.Name = "txtScanTime";
            this.txtScanTime.Size = new System.Drawing.Size(83, 22);
            this.txtScanTime.TabIndex = 15;
            this.txtScanTime.Text = "0";
            this.txtScanTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkTest
            // 
            this.chkTest.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTest.Location = new System.Drawing.Point(524, 43);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(105, 24);
            this.chkTest.TabIndex = 2;
            this.chkTest.Text = "Auto Test";
            this.chkTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTest.UseVisualStyleBackColor = true;
            this.chkTest.CheckedChanged += new System.EventHandler(this.chkTest_CheckedChanged);
            // 
            // chkUseErrorStop
            // 
            this.chkUseErrorStop.AutoSize = true;
            this.chkUseErrorStop.Location = new System.Drawing.Point(524, 21);
            this.chkUseErrorStop.Name = "chkUseErrorStop";
            this.chkUseErrorStop.Size = new System.Drawing.Size(106, 16);
            this.chkUseErrorStop.TabIndex = 2;
            this.chkUseErrorStop.Text = "Use Error Stop";
            this.chkUseErrorStop.UseVisualStyleBackColor = true;
            // 
            // txtMaxTime
            // 
            this.txtMaxTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMaxTime.Location = new System.Drawing.Point(310, 44);
            this.txtMaxTime.Name = "txtMaxTime";
            this.txtMaxTime.ReadOnly = true;
            this.txtMaxTime.Size = new System.Drawing.Size(83, 22);
            this.txtMaxTime.TabIndex = 15;
            this.txtMaxTime.Text = "-";
            this.txtMaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtErrorCountCheck
            // 
            this.txtErrorCountCheck.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtErrorCountCheck.Location = new System.Drawing.Point(211, 44);
            this.txtErrorCountCheck.Name = "txtErrorCountCheck";
            this.txtErrorCountCheck.ReadOnly = true;
            this.txtErrorCountCheck.Size = new System.Drawing.Size(83, 22);
            this.txtErrorCountCheck.TabIndex = 15;
            this.txtErrorCountCheck.Text = "-";
            this.txtErrorCountCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtErrorCountRead
            // 
            this.txtErrorCountRead.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtErrorCountRead.Location = new System.Drawing.Point(113, 44);
            this.txtErrorCountRead.Name = "txtErrorCountRead";
            this.txtErrorCountRead.ReadOnly = true;
            this.txtErrorCountRead.Size = new System.Drawing.Size(83, 22);
            this.txtErrorCountRead.TabIndex = 15;
            this.txtErrorCountRead.Text = "-";
            this.txtErrorCountRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtErrorCountWrite
            // 
            this.txtErrorCountWrite.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtErrorCountWrite.Location = new System.Drawing.Point(14, 44);
            this.txtErrorCountWrite.Name = "txtErrorCountWrite";
            this.txtErrorCountWrite.ReadOnly = true;
            this.txtErrorCountWrite.Size = new System.Drawing.Size(83, 22);
            this.txtErrorCountWrite.TabIndex = 15;
            this.txtErrorCountWrite.Text = "-";
            this.txtErrorCountWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(409, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "Test Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "Max Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "Check Error";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "Read Error";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "Write Error";
            // 
            // lstLog
            // 
            this.lstLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(12, 245);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(640, 334);
            this.lstLog.TabIndex = 15;
            this.lstLog.DoubleClick += new System.EventHandler(this.lstLog_DoubleClick);
            // 
            // tmKeepAlive
            // 
            this.tmKeepAlive.Interval = 1000;
            this.tmKeepAlive.Tick += new System.EventHandler(this.tmKeepAlive_Tick);
            // 
            // tmLibTest
            // 
            this.tmLibTest.Tick += new System.EventHandler(this.tmLibTest_Tick);
            // 
            // tmUpdateCtrl
            // 
            this.tmUpdateCtrl.Tick += new System.EventHandler(this.tmUpdateCtrl_Tick);
            // 
            // txtWriteData
            // 
            this.txtWriteData.Enabled = false;
            this.txtWriteData.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWriteData.Location = new System.Drawing.Point(430, 16);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(83, 22);
            this.txtWriteData.TabIndex = 15;
            this.txtWriteData.Text = "0";
            this.txtWriteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkUseData
            // 
            this.chkUseData.AutoSize = true;
            this.chkUseData.Location = new System.Drawing.Point(411, 20);
            this.chkUseData.Name = "chkUseData";
            this.chkUseData.Size = new System.Drawing.Size(15, 14);
            this.chkUseData.TabIndex = 2;
            this.chkUseData.UseVisualStyleBackColor = true;
            this.chkUseData.CheckedChanged += new System.EventHandler(this.chkUseData_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 586);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPortNo;
        private System.Windows.Forms.Label lblPortNo;
        private System.Windows.Forms.Label lblPlcIP;
        private System.Windows.Forms.TextBox txtIpAddrPlc;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.CheckBox chkKeepAlive;
        private System.Windows.Forms.CheckBox chkAliveStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboDeviceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccessTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtScanTime;
        private System.Windows.Forms.CheckBox chkUseErrorStop;
        private System.Windows.Forms.TextBox txtMaxTime;
        private System.Windows.Forms.TextBox txtErrorCountCheck;
        private System.Windows.Forms.TextBox txtErrorCountRead;
        private System.Windows.Forms.TextBox txtErrorCountWrite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.Timer tmKeepAlive;
        private System.Windows.Forms.Timer tmLibTest;
        private System.Windows.Forms.Timer tmUpdateCtrl;
        private System.Windows.Forms.TextBox txtWriteData;
        private System.Windows.Forms.CheckBox chkUseData;
    }
}

