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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSaveDbConfig = new System.Windows.Forms.Button();
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
            this.btnSaveRsConfig = new System.Windows.Forms.Button();
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
            this.buttonRsClearDataIn = new System.Windows.Forms.Button();
            this.buttonRsClearDataOut = new System.Windows.Forms.Button();
            this.textBoxRsDataIn = new System.Windows.Forms.TextBox();
            this.buttonRsSendData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.copyright = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.identyfikatorSystemowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielImieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielWyroznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGastroKartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngastroKartaDataSet = new VendGastro.NgastroKartaDataSet();
            this.nGastroKartaTableAdapter = new VendGastro.NgastroKartaDataSetTableAdapters.NGastroKartaTableAdapter();
            this.btnDenit = new System.Windows.Forms.Button();
            this.SprawdzStatusTelevend = new System.Windows.Forms.Button();
            this.buttonGetPricingGroupForCard = new System.Windows.Forms.Button();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.groupBoxDb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGastroKartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngastroKartaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveDbConfig
            // 
            this.btnSaveDbConfig.Location = new System.Drawing.Point(12, 412);
            this.btnSaveDbConfig.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveDbConfig.Name = "btnSaveDbConfig";
            this.btnSaveDbConfig.Size = new System.Drawing.Size(518, 46);
            this.btnSaveDbConfig.TabIndex = 0;
            this.btnSaveDbConfig.Text = "Save Gastro configuration ";
            this.btnSaveDbConfig.UseVisualStyleBackColor = true;
            this.btnSaveDbConfig.Click += new System.EventHandler(this.btnSaveDbConfig_Click);
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(162, 100);
            this.textBoxDbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(356, 31);
            this.textBoxDbName.TabIndex = 1;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(92, 56);
            this.labelHost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(56, 25);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "Host";
            // 
            // textBoxDbHost
            // 
            this.textBoxDbHost.Location = new System.Drawing.Point(162, 50);
            this.textBoxDbHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDbHost.Name = "textBoxDbHost";
            this.textBoxDbHost.Size = new System.Drawing.Size(356, 31);
            this.textBoxDbHost.TabIndex = 3;
            // 
            // textBoxDbUser
            // 
            this.textBoxDbUser.Location = new System.Drawing.Point(162, 150);
            this.textBoxDbUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDbUser.Name = "textBoxDbUser";
            this.textBoxDbUser.Size = new System.Drawing.Size(356, 31);
            this.textBoxDbUser.TabIndex = 4;
            // 
            // textBoxDbPass
            // 
            this.textBoxDbPass.Location = new System.Drawing.Point(162, 200);
            this.textBoxDbPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDbPass.Name = "textBoxDbPass";
            this.textBoxDbPass.PasswordChar = '*';
            this.textBoxDbPass.Size = new System.Drawing.Size(356, 31);
            this.textBoxDbPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pass";
            // 
            // btnCheckDb
            // 
            this.btnCheckDb.Location = new System.Drawing.Point(162, 304);
            this.btnCheckDb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCheckDb.Name = "btnCheckDb";
            this.btnCheckDb.Size = new System.Drawing.Size(360, 46);
            this.btnCheckDb.TabIndex = 11;
            this.btnCheckDb.Text = "Check";
            this.btnCheckDb.UseVisualStyleBackColor = true;
            this.btnCheckDb.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Parity bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stop bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Baud rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Com";
            // 
            // progressBarRs
            // 
            this.progressBarRs.Location = new System.Drawing.Point(172, 304);
            this.progressBarRs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBarRs.Name = "progressBarRs";
            this.progressBarRs.Size = new System.Drawing.Size(356, 38);
            this.progressBarRs.TabIndex = 23;
            // 
            // groupBoxDb
            // 
            this.groupBoxDb.Controls.Add(this.labelDbResult);
            this.groupBoxDb.Controls.Add(this.progressBarDb);
            this.groupBoxDb.Controls.Add(this.btnSaveDbConfig);
            this.groupBoxDb.Controls.Add(this.textBoxDbName);
            this.groupBoxDb.Controls.Add(this.labelHost);
            this.groupBoxDb.Controls.Add(this.textBoxDbHost);
            this.groupBoxDb.Controls.Add(this.textBoxDbUser);
            this.groupBoxDb.Controls.Add(this.textBoxDbPass);
            this.groupBoxDb.Controls.Add(this.label1);
            this.groupBoxDb.Controls.Add(this.label2);
            this.groupBoxDb.Controls.Add(this.label3);
            this.groupBoxDb.Controls.Add(this.btnCheckDb);
            this.groupBoxDb.Location = new System.Drawing.Point(14, 131);
            this.groupBoxDb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDb.Name = "groupBoxDb";
            this.groupBoxDb.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDb.Size = new System.Drawing.Size(542, 473);
            this.groupBoxDb.TabIndex = 24;
            this.groupBoxDb.TabStop = false;
            this.groupBoxDb.Text = "Database Gastro";
            // 
            // labelDbResult
            // 
            this.labelDbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDbResult.Location = new System.Drawing.Point(38, 254);
            this.labelDbResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDbResult.Name = "labelDbResult";
            this.labelDbResult.Size = new System.Drawing.Size(112, 38);
            this.labelDbResult.TabIndex = 26;
            this.labelDbResult.Text = "status";
            this.labelDbResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarDb
            // 
            this.progressBarDb.Location = new System.Drawing.Point(162, 254);
            this.progressBarDb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBarDb.Name = "progressBarDb";
            this.progressBarDb.Size = new System.Drawing.Size(360, 38);
            this.progressBarDb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDb.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRsClose);
            this.groupBox1.Controls.Add(this.btnSaveRsConfig);
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
            this.groupBox1.Location = new System.Drawing.Point(568, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(546, 473);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232 Televend";
            // 
            // buttonRsClose
            // 
            this.buttonRsClose.Location = new System.Drawing.Point(346, 354);
            this.buttonRsClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRsClose.Name = "buttonRsClose";
            this.buttonRsClose.Size = new System.Drawing.Size(182, 46);
            this.buttonRsClose.TabIndex = 32;
            this.buttonRsClose.Text = "Close";
            this.buttonRsClose.UseVisualStyleBackColor = true;
            this.buttonRsClose.Click += new System.EventHandler(this.buttonRsClose_Click);
            // 
            // btnSaveRsConfig
            // 
            this.btnSaveRsConfig.Location = new System.Drawing.Point(12, 412);
            this.btnSaveRsConfig.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveRsConfig.Name = "btnSaveRsConfig";
            this.btnSaveRsConfig.Size = new System.Drawing.Size(516, 46);
            this.btnSaveRsConfig.TabIndex = 24;
            this.btnSaveRsConfig.Text = "Save Televend configuration";
            this.btnSaveRsConfig.UseVisualStyleBackColor = true;
            this.btnSaveRsConfig.Click += new System.EventHandler(this.btnSaveRsConfig_Click);
            // 
            // buttonRsOpen
            // 
            this.buttonRsOpen.Location = new System.Drawing.Point(172, 354);
            this.buttonRsOpen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRsOpen.Name = "buttonRsOpen";
            this.buttonRsOpen.Size = new System.Drawing.Size(162, 46);
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
            this.comboBoxParityBits.Location = new System.Drawing.Point(172, 248);
            this.comboBoxParityBits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(352, 33);
            this.comboBoxParityBits.TabIndex = 30;
            this.comboBoxParityBits.Text = "None";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(172, 198);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(352, 33);
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
            this.comboBoxDataBits.Location = new System.Drawing.Point(172, 148);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(352, 33);
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(172, 100);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(352, 33);
            this.comboBoxBaudRate.TabIndex = 27;
            this.comboBoxBaudRate.Text = "115200";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(172, 48);
            this.comboBoxCom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(352, 33);
            this.comboBoxCom.TabIndex = 26;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxRsDataOut
            // 
            this.textBoxRsDataOut.Location = new System.Drawing.Point(12, 62);
            this.textBoxRsDataOut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxRsDataOut.Multiline = true;
            this.textBoxRsDataOut.Name = "textBoxRsDataOut";
            this.textBoxRsDataOut.Size = new System.Drawing.Size(394, 125);
            this.textBoxRsDataOut.TabIndex = 26;
            // 
            // labelRsOut
            // 
            this.labelRsOut.AutoSize = true;
            this.labelRsOut.Location = new System.Drawing.Point(12, 31);
            this.labelRsOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRsOut.Name = "labelRsOut";
            this.labelRsOut.Size = new System.Drawing.Size(200, 25);
            this.labelRsOut.TabIndex = 27;
            this.labelRsOut.Text = "Transmitter Controll";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRsClearDataIn);
            this.groupBox2.Controls.Add(this.buttonRsClearDataOut);
            this.groupBox2.Controls.Add(this.textBoxRsDataIn);
            this.groupBox2.Controls.Add(this.buttonRsSendData);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxRsDataOut);
            this.groupBox2.Controls.Add(this.labelRsOut);
            this.groupBox2.Location = new System.Drawing.Point(1126, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(438, 473);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RS Communications";
            // 
            // buttonRsClearDataIn
            // 
            this.buttonRsClearDataIn.Location = new System.Drawing.Point(214, 412);
            this.buttonRsClearDataIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRsClearDataIn.Name = "buttonRsClearDataIn";
            this.buttonRsClearDataIn.Size = new System.Drawing.Size(196, 46);
            this.buttonRsClearDataIn.TabIndex = 32;
            this.buttonRsClearDataIn.Text = "Clear Data";
            this.buttonRsClearDataIn.UseVisualStyleBackColor = true;
            this.buttonRsClearDataIn.Click += new System.EventHandler(this.buttonRsClearDataIn_Click);
            // 
            // buttonRsClearDataOut
            // 
            this.buttonRsClearDataOut.Location = new System.Drawing.Point(230, 202);
            this.buttonRsClearDataOut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRsClearDataOut.Name = "buttonRsClearDataOut";
            this.buttonRsClearDataOut.Size = new System.Drawing.Size(180, 46);
            this.buttonRsClearDataOut.TabIndex = 30;
            this.buttonRsClearDataOut.Text = "Clear Data";
            this.buttonRsClearDataOut.UseVisualStyleBackColor = true;
            this.buttonRsClearDataOut.Click += new System.EventHandler(this.buttonRsClearData_Click);
            // 
            // textBoxRsDataIn
            // 
            this.textBoxRsDataIn.Location = new System.Drawing.Point(12, 292);
            this.textBoxRsDataIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxRsDataIn.Multiline = true;
            this.textBoxRsDataIn.Name = "textBoxRsDataIn";
            this.textBoxRsDataIn.Size = new System.Drawing.Size(394, 110);
            this.textBoxRsDataIn.TabIndex = 31;
            // 
            // buttonRsSendData
            // 
            this.buttonRsSendData.Location = new System.Drawing.Point(12, 204);
            this.buttonRsSendData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRsSendData.Name = "buttonRsSendData";
            this.buttonRsSendData.Size = new System.Drawing.Size(206, 46);
            this.buttonRsSendData.TabIndex = 29;
            this.buttonRsSendData.Text = "Send RD data";
            this.buttonRsSendData.UseVisualStyleBackColor = true;
            this.buttonRsSendData.Click += new System.EventHandler(this.buttonRsSendData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Receiver Controll";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.ForeColor = System.Drawing.SystemColors.Control;
            this.copyright.Location = new System.Drawing.Point(480, 73);
            this.copyright.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(215, 25);
            this.copyright.TabIndex = 31;
            this.copyright.Text = "Copyright GrupaAMB";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.copyright);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1562, 117);
            this.panel1.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(1188, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(338, 22);
            this.label14.TabIndex = 37;
            this.label14.Text = "it gastro contact: michal.sudnik@4wise.pl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(1182, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(343, 22);
            this.label13.TabIndex = 36;
            this.label13.Text = "it vending contact: marcin@martec24.com";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(1272, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "dev contact: it@grupaamb.com";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(446, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(316, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "Release 2023-10-20 by Grupa AMB IT";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(440, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(750, 44);
            this.label10.TabIndex = 33;
            this.label10.Text = "Televend-Gastro Connector v1.0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VendGastro.Properties.Resources.pos;
            this.pictureBox2.Location = new System.Drawing.Point(342, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendGastro.Properties.Resources.televend_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorSystemowyDataGridViewTextBoxColumn,
            this.okazicielImieDataGridViewTextBoxColumn,
            this.okazicielNazwiskoDataGridViewTextBoxColumn,
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn,
            this.okazicielWyroznikDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nGastroKartaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 797);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1550, 260);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // identyfikatorSystemowyDataGridViewTextBoxColumn
            // 
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.DataPropertyName = "IdentyfikatorSystemowy";
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.HeaderText = "NrKarty";
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.Name = "identyfikatorSystemowyDataGridViewTextBoxColumn";
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielImieDataGridViewTextBoxColumn
            // 
            this.okazicielImieDataGridViewTextBoxColumn.DataPropertyName = "OkazicielImie";
            this.okazicielImieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.okazicielImieDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.okazicielImieDataGridViewTextBoxColumn.Name = "okazicielImieDataGridViewTextBoxColumn";
            this.okazicielImieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielNazwiskoDataGridViewTextBoxColumn
            // 
            this.okazicielNazwiskoDataGridViewTextBoxColumn.DataPropertyName = "OkazicielNazwisko";
            this.okazicielNazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.okazicielNazwiskoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.okazicielNazwiskoDataGridViewTextBoxColumn.Name = "okazicielNazwiskoDataGridViewTextBoxColumn";
            this.okazicielNazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielIdentyfikatorDataGridViewTextBoxColumn
            // 
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.DataPropertyName = "OkazicielIdentyfikator";
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.Name = "okazicielIdentyfikatorDataGridViewTextBoxColumn";
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielWyroznikDataGridViewTextBoxColumn
            // 
            this.okazicielWyroznikDataGridViewTextBoxColumn.DataPropertyName = "OkazicielWyroznik";
            this.okazicielWyroznikDataGridViewTextBoxColumn.HeaderText = "Wyroznik";
            this.okazicielWyroznikDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.okazicielWyroznikDataGridViewTextBoxColumn.Name = "okazicielWyroznikDataGridViewTextBoxColumn";
            this.okazicielWyroznikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGastroKartaBindingSource
            // 
            this.nGastroKartaBindingSource.DataMember = "NGastroKarta";
            this.nGastroKartaBindingSource.DataSource = this.ngastroKartaDataSet;
            // 
            // ngastroKartaDataSet
            // 
            this.ngastroKartaDataSet.DataSetName = "NgastroKartaDataSet";
            this.ngastroKartaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nGastroKartaTableAdapter
            // 
            this.nGastroKartaTableAdapter.ClearBeforeFill = true;
            // 
            // btnDenit
            // 
            this.btnDenit.Location = new System.Drawing.Point(26, 627);
            this.btnDenit.Name = "btnDenit";
            this.btnDenit.Size = new System.Drawing.Size(367, 53);
            this.btnDenit.TabIndex = 33;
            this.btnDenit.Text = "Rozłącz z Televend";
            this.btnDenit.UseVisualStyleBackColor = true;
            this.btnDenit.Click += new System.EventHandler(this.btnDenit_Click);
            // 
            // SprawdzStatusTelevend
            // 
            this.SprawdzStatusTelevend.Location = new System.Drawing.Point(432, 627);
            this.SprawdzStatusTelevend.Name = "SprawdzStatusTelevend";
            this.SprawdzStatusTelevend.Size = new System.Drawing.Size(406, 53);
            this.SprawdzStatusTelevend.TabIndex = 35;
            this.SprawdzStatusTelevend.Text = "SprawdzStatusButton";
            this.SprawdzStatusTelevend.UseVisualStyleBackColor = true;
            this.SprawdzStatusTelevend.Click += new System.EventHandler(this.SprawdzStatusButton_Click);
            // 
            // buttonGetPricingGroupForCard
            // 
            this.buttonGetPricingGroupForCard.Location = new System.Drawing.Point(845, 688);
            this.buttonGetPricingGroupForCard.Name = "buttonGetPricingGroupForCard";
            this.buttonGetPricingGroupForCard.Size = new System.Drawing.Size(316, 70);
            this.buttonGetPricingGroupForCard.TabIndex = 36;
            this.buttonGetPricingGroupForCard.Text = "GetPricingGroup";
            this.buttonGetPricingGroupForCard.UseVisualStyleBackColor = true;
            this.buttonGetPricingGroupForCard.Click += new System.EventHandler(this.buttonGetPricingGroupForCard_Click);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(845, 627);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(310, 31);
            this.textBoxCardNumber.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1072);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.buttonGetPricingGroupForCard);
            this.Controls.Add(this.SprawdzStatusTelevend);
            this.Controls.Add(this.btnDenit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGastroKartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngastroKartaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDbConfig;
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
        private System.Windows.Forms.Button btnSaveRsConfig;
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
        private System.Windows.Forms.Button buttonRsClearDataIn;
        private System.Windows.Forms.TextBox textBoxRsDataIn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VendGastro.NgastroKartaDataSet ngastroKartaDataSet;
        private System.Windows.Forms.BindingSource nGastroKartaBindingSource;
        private VendGastro.NgastroKartaDataSetTableAdapters.NGastroKartaTableAdapter nGastroKartaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorSystemowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okazicielImieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okazicielNazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okazicielIdentyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okazicielWyroznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDenit;
        private System.Windows.Forms.Button SprawdzStatusTelevend;
        private System.Windows.Forms.Button buttonGetPricingGroupForCard;
        private System.Windows.Forms.TextBox textBoxCardNumber;
    }
}

