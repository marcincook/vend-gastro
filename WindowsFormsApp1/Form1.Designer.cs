namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxDbHost = new System.Windows.Forms.TextBox();
            this.textBoxDbUser = new System.Windows.Forms.TextBox();
            this.textBoxDbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckDb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBarRs = new System.Windows.Forms.ProgressBar();
            this.groupBoxDb = new System.Windows.Forms.GroupBox();
            this.labelDbResult = new System.Windows.Forms.Label();
            this.progressBarDb = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRsClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRsOpen = new System.Windows.Forms.Button();
            this.comboBoxParityBits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxRsDataOut = new System.Windows.Forms.TextBox();
            this.labelRsOut = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRsClearDataOut = new System.Windows.Forms.Button();
            this.buttonRsSendData = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRsClearDataIn = new System.Windows.Forms.Button();
            this.textBoxRsDataIn = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxDb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(81, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Zapisz konfiguguracje bazy";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(81, 49);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(219, 20);
            this.textBoxDbName.TabIndex = 1;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(20, 27);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(55, 13);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "DB HOST";
            // 
            // textBoxDbHost
            // 
            this.textBoxDbHost.Location = new System.Drawing.Point(81, 23);
            this.textBoxDbHost.Name = "textBoxDbHost";
            this.textBoxDbHost.Size = new System.Drawing.Size(219, 20);
            this.textBoxDbHost.TabIndex = 3;
            // 
            // textBoxDbUser
            // 
            this.textBoxDbUser.Location = new System.Drawing.Point(81, 75);
            this.textBoxDbUser.Name = "textBoxDbUser";
            this.textBoxDbUser.Size = new System.Drawing.Size(219, 20);
            this.textBoxDbUser.TabIndex = 4;
            // 
            // textBoxDbPass
            // 
            this.textBoxDbPass.Location = new System.Drawing.Point(81, 101);
            this.textBoxDbPass.Name = "textBoxDbPass";
            this.textBoxDbPass.Size = new System.Drawing.Size(219, 20);
            this.textBoxDbPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DB NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DB USER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DB PASS";
            // 
            // btnCheckDb
            // 
            this.btnCheckDb.Location = new System.Drawing.Point(81, 220);
            this.btnCheckDb.Name = "btnCheckDb";
            this.btnCheckDb.Size = new System.Drawing.Size(219, 23);
            this.btnCheckDb.TabIndex = 11;
            this.btnCheckDb.Text = "Sprawdź połaczenie";
            this.btnCheckDb.UseVisualStyleBackColor = true;
            this.btnCheckDb.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "PARITY BITS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "STOP BITS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "DATA BITS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "BAUD RATE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "COM PORT";
            // 
            // progressBarRs
            // 
            this.progressBarRs.Location = new System.Drawing.Point(83, 194);
            this.progressBarRs.Name = "progressBarRs";
            this.progressBarRs.Size = new System.Drawing.Size(219, 23);
            this.progressBarRs.TabIndex = 23;
            // 
            // groupBoxDb
            // 
            this.groupBoxDb.Controls.Add(this.labelDbResult);
            this.groupBoxDb.Controls.Add(this.progressBarDb);
            this.groupBoxDb.Controls.Add(this.btnSave);
            this.groupBoxDb.Controls.Add(this.textBoxDbName);
            this.groupBoxDb.Controls.Add(this.labelHost);
            this.groupBoxDb.Controls.Add(this.textBoxDbHost);
            this.groupBoxDb.Controls.Add(this.textBoxDbUser);
            this.groupBoxDb.Controls.Add(this.textBoxDbPass);
            this.groupBoxDb.Controls.Add(this.label1);
            this.groupBoxDb.Controls.Add(this.label2);
            this.groupBoxDb.Controls.Add(this.label3);
            this.groupBoxDb.Controls.Add(this.btnCheckDb);
            this.groupBoxDb.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDb.Name = "groupBoxDb";
            this.groupBoxDb.Size = new System.Drawing.Size(306, 336);
            this.groupBoxDb.TabIndex = 24;
            this.groupBoxDb.TabStop = false;
            this.groupBoxDb.Text = "Baza danych";
            // 
            // labelDbResult
            // 
            this.labelDbResult.Location = new System.Drawing.Point(81, 258);
            this.labelDbResult.Name = "labelDbResult";
            this.labelDbResult.Size = new System.Drawing.Size(219, 57);
            this.labelDbResult.TabIndex = 26;
            this.labelDbResult.Text = "DB Result";
            // 
            // progressBarDb
            // 
            this.progressBarDb.Location = new System.Drawing.Point(81, 191);
            this.progressBarDb.Name = "progressBarDb";
            this.progressBarDb.Size = new System.Drawing.Size(219, 23);
            this.progressBarDb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDb.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRsClose);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonRsOpen);
            this.groupBox1.Controls.Add(this.comboBoxParityBits);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.progressBarRs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxStopBits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxDataBits);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxCom);
            this.groupBox1.Location = new System.Drawing.Point(324, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 293);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232 (Port COM)";
            // 
            // buttonRsClose
            // 
            this.buttonRsClose.Location = new System.Drawing.Point(195, 223);
            this.buttonRsClose.Name = "buttonRsClose";
            this.buttonRsClose.Size = new System.Drawing.Size(107, 23);
            this.buttonRsClose.TabIndex = 32;
            this.buttonRsClose.Text = "Close";
            this.buttonRsClose.UseVisualStyleBackColor = true;
            this.buttonRsClose.Click += new System.EventHandler(this.buttonRsClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Zapisz ustawienia COM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonRsOpen
            // 
            this.buttonRsOpen.Location = new System.Drawing.Point(82, 223);
            this.buttonRsOpen.Name = "buttonRsOpen";
            this.buttonRsOpen.Size = new System.Drawing.Size(109, 23);
            this.buttonRsOpen.TabIndex = 31;
            this.buttonRsOpen.Text = "Open";
            this.buttonRsOpen.UseVisualStyleBackColor = true;
            this.buttonRsOpen.Click += new System.EventHandler(this.buttonRsOpen_Click);
            // 
            // comboBoxParityBits
            // 
            this.comboBoxParityBits.FormattingEnabled = true;
            this.comboBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxParityBits.Location = new System.Drawing.Point(83, 130);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(218, 21);
            this.comboBoxParityBits.TabIndex = 30;
            this.comboBoxParityBits.Text = "None";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(83, 103);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(218, 21);
            this.comboBoxStopBits.TabIndex = 29;
            this.comboBoxStopBits.Text = "One";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(83, 76);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(218, 21);
            this.comboBoxDataBits.TabIndex = 28;
            this.comboBoxDataBits.Text = "8";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(83, 49);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(218, 21);
            this.comboBoxBaudRate.TabIndex = 27;
            this.comboBoxBaudRate.Text = "115200";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(83, 22);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(218, 21);
            this.comboBoxCom.TabIndex = 26;
            this.comboBoxCom.Text = "COM6";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxRsDataOut
            // 
            this.textBoxRsDataOut.Location = new System.Drawing.Point(6, 36);
            this.textBoxRsDataOut.Multiline = true;
            this.textBoxRsDataOut.Name = "textBoxRsDataOut";
            this.textBoxRsDataOut.Size = new System.Drawing.Size(237, 174);
            this.textBoxRsDataOut.TabIndex = 26;
            // 
            // labelRsOut
            // 
            this.labelRsOut.AutoSize = true;
            this.labelRsOut.Location = new System.Drawing.Point(3, 20);
            this.labelRsOut.Name = "labelRsOut";
            this.labelRsOut.Size = new System.Drawing.Size(97, 13);
            this.labelRsOut.TabIndex = 27;
            this.labelRsOut.Text = "Transmitter Controll";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRsClearDataOut);
            this.groupBox2.Controls.Add(this.buttonRsSendData);
            this.groupBox2.Controls.Add(this.textBoxRsDataOut);
            this.groupBox2.Controls.Add(this.labelRsOut);
            this.groupBox2.Location = new System.Drawing.Point(638, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 261);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RS Communications";
            // 
            // buttonRsClearDataOut
            // 
            this.buttonRsClearDataOut.Location = new System.Drawing.Point(168, 220);
            this.buttonRsClearDataOut.Name = "buttonRsClearDataOut";
            this.buttonRsClearDataOut.Size = new System.Drawing.Size(75, 23);
            this.buttonRsClearDataOut.TabIndex = 30;
            this.buttonRsClearDataOut.Text = "Clear Data";
            this.buttonRsClearDataOut.UseVisualStyleBackColor = true;
            this.buttonRsClearDataOut.Click += new System.EventHandler(this.buttonRsClearData_Click);
            // 
            // buttonRsSendData
            // 
            this.buttonRsSendData.Location = new System.Drawing.Point(6, 220);
            this.buttonRsSendData.Name = "buttonRsSendData";
            this.buttonRsSendData.Size = new System.Drawing.Size(127, 23);
            this.buttonRsSendData.TabIndex = 29;
            this.buttonRsSendData.Text = "Send RD data";
            this.buttonRsSendData.UseVisualStyleBackColor = true;
            this.buttonRsSendData.Click += new System.EventHandler(this.buttonRsSendData_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRsClearDataIn);
            this.groupBox3.Controls.Add(this.textBoxRsDataIn);
            this.groupBox3.Location = new System.Drawing.Point(639, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 231);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver Controll";
            // 
            // buttonRsClearDataIn
            // 
            this.buttonRsClearDataIn.Location = new System.Drawing.Point(168, 199);
            this.buttonRsClearDataIn.Name = "buttonRsClearDataIn";
            this.buttonRsClearDataIn.Size = new System.Drawing.Size(75, 23);
            this.buttonRsClearDataIn.TabIndex = 32;
            this.buttonRsClearDataIn.Text = "Clear Data";
            this.buttonRsClearDataIn.UseVisualStyleBackColor = true;
            this.buttonRsClearDataIn.Click += new System.EventHandler(this.buttonRsClearDataIn_Click);
            // 
            // textBoxRsDataIn
            // 
            this.textBoxRsDataIn.Location = new System.Drawing.Point(6, 19);
            this.textBoxRsDataIn.Multiline = true;
            this.textBoxRsDataIn.Name = "textBoxRsDataIn";
            this.textBoxRsDataIn.Size = new System.Drawing.Size(237, 174);
            this.textBoxRsDataIn.TabIndex = 31;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendGastro Connector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBoxDb.ResumeLayout(false);
            this.groupBoxDb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxDbHost;
        private System.Windows.Forms.TextBox textBoxDbUser;
        private System.Windows.Forms.TextBox textBoxDbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckDb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBarRs;
        private System.Windows.Forms.GroupBox groupBoxDb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarDb;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParityBits;
        private System.Windows.Forms.Button buttonRsOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonRsClose;
        private System.Windows.Forms.Label labelDbResult;
        private System.Windows.Forms.TextBox textBoxRsDataOut;
        private System.Windows.Forms.Label labelRsOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRsSendData;
        private System.Windows.Forms.Button buttonRsClearDataOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRsClearDataIn;
        private System.Windows.Forms.TextBox textBoxRsDataIn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

