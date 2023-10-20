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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.identyfikatorSystemowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielImieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielWyroznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGastroKartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngastroKartaDataSet = new VendGastro.NgastroKartaDataSet();
            this.nGastroKartaTableAdapter = new VendGastro.NgastroKartaDataSetTableAdapters.NGastroKartaTableAdapter();
            this.groupBoxDb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGastroKartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngastroKartaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveDbConfig
            // 
            this.btnSaveDbConfig.Location = new System.Drawing.Point(6, 214);
            this.btnSaveDbConfig.Name = "btnSaveDbConfig";
            this.btnSaveDbConfig.Size = new System.Drawing.Size(259, 24);
            this.btnSaveDbConfig.TabIndex = 0;
            this.btnSaveDbConfig.Text = "Save Gastro configuration ";
            this.btnSaveDbConfig.UseVisualStyleBackColor = true;
            this.btnSaveDbConfig.Click += new System.EventHandler(this.btnSaveDbConfig_Click);
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(81, 52);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbName.TabIndex = 1;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(46, 29);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(29, 13);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "Host";
            // 
            // textBoxDbHost
            // 
            this.textBoxDbHost.Location = new System.Drawing.Point(81, 26);
            this.textBoxDbHost.Name = "textBoxDbHost";
            this.textBoxDbHost.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbHost.TabIndex = 3;
            // 
            // textBoxDbUser
            // 
            this.textBoxDbUser.Location = new System.Drawing.Point(81, 78);
            this.textBoxDbUser.Name = "textBoxDbUser";
            this.textBoxDbUser.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbUser.TabIndex = 4;
            // 
            // textBoxDbPass
            // 
            this.textBoxDbPass.Location = new System.Drawing.Point(81, 104);
            this.textBoxDbPass.Name = "textBoxDbPass";
            this.textBoxDbPass.PasswordChar = '*';
            this.textBoxDbPass.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pass";
            // 
            // btnCheckDb
            // 
            this.btnCheckDb.Location = new System.Drawing.Point(81, 158);
            this.btnCheckDb.Name = "btnCheckDb";
            this.btnCheckDb.Size = new System.Drawing.Size(180, 24);
            this.btnCheckDb.TabIndex = 11;
            this.btnCheckDb.Text = "Check";
            this.btnCheckDb.UseVisualStyleBackColor = true;
            this.btnCheckDb.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Parity bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stop bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Baud rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Com";
            // 
            // progressBarRs
            // 
            this.progressBarRs.Location = new System.Drawing.Point(86, 158);
            this.progressBarRs.Name = "progressBarRs";
            this.progressBarRs.Size = new System.Drawing.Size(178, 20);
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
            this.groupBoxDb.Location = new System.Drawing.Point(7, 68);
            this.groupBoxDb.Name = "groupBoxDb";
            this.groupBoxDb.Size = new System.Drawing.Size(271, 246);
            this.groupBoxDb.TabIndex = 24;
            this.groupBoxDb.TabStop = false;
            this.groupBoxDb.Text = "Database Gastro";
            // 
            // labelDbResult
            // 
            this.labelDbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDbResult.Location = new System.Drawing.Point(19, 132);
            this.labelDbResult.Name = "labelDbResult";
            this.labelDbResult.Size = new System.Drawing.Size(56, 20);
            this.labelDbResult.TabIndex = 26;
            this.labelDbResult.Text = "status";
            this.labelDbResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarDb
            // 
            this.progressBarDb.Location = new System.Drawing.Point(81, 132);
            this.progressBarDb.Name = "progressBarDb";
            this.progressBarDb.Size = new System.Drawing.Size(180, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(284, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 246);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232 Televend";
            // 
            // buttonRsClose
            // 
            this.buttonRsClose.Location = new System.Drawing.Point(173, 184);
            this.buttonRsClose.Name = "buttonRsClose";
            this.buttonRsClose.Size = new System.Drawing.Size(91, 24);
            this.buttonRsClose.TabIndex = 32;
            this.buttonRsClose.Text = "Close";
            this.buttonRsClose.UseVisualStyleBackColor = true;
            this.buttonRsClose.Click += new System.EventHandler(this.buttonRsClose_Click);
            // 
            // btnSaveRsConfig
            // 
            this.btnSaveRsConfig.Location = new System.Drawing.Point(6, 214);
            this.btnSaveRsConfig.Name = "btnSaveRsConfig";
            this.btnSaveRsConfig.Size = new System.Drawing.Size(258, 24);
            this.btnSaveRsConfig.TabIndex = 24;
            this.btnSaveRsConfig.Text = "Save Televend configuration";
            this.btnSaveRsConfig.UseVisualStyleBackColor = true;
            this.btnSaveRsConfig.Click += new System.EventHandler(this.btnSaveRsConfig_Click);
            // 
            // buttonRsOpen
            // 
            this.buttonRsOpen.Location = new System.Drawing.Point(86, 184);
            this.buttonRsOpen.Name = "buttonRsOpen";
            this.buttonRsOpen.Size = new System.Drawing.Size(81, 24);
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
            this.comboBoxParityBits.Location = new System.Drawing.Point(86, 129);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(178, 21);
            this.comboBoxParityBits.TabIndex = 30;
            this.comboBoxParityBits.Text = "None";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(86, 103);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(178, 21);
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
            this.comboBoxDataBits.Location = new System.Drawing.Point(86, 77);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(178, 21);
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(86, 52);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(178, 21);
            this.comboBoxBaudRate.TabIndex = 27;
            this.comboBoxBaudRate.Text = "115200";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(86, 25);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(178, 21);
            this.comboBoxCom.TabIndex = 26;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxRsDataOut
            // 
            this.textBoxRsDataOut.Location = new System.Drawing.Point(6, 32);
            this.textBoxRsDataOut.Multiline = true;
            this.textBoxRsDataOut.Name = "textBoxRsDataOut";
            this.textBoxRsDataOut.Size = new System.Drawing.Size(199, 67);
            this.textBoxRsDataOut.TabIndex = 26;
            // 
            // labelRsOut
            // 
            this.labelRsOut.AutoSize = true;
            this.labelRsOut.Location = new System.Drawing.Point(6, 16);
            this.labelRsOut.Name = "labelRsOut";
            this.labelRsOut.Size = new System.Drawing.Size(97, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(563, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 246);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RS Communications";
            // 
            // buttonRsClearDataIn
            // 
            this.buttonRsClearDataIn.Location = new System.Drawing.Point(107, 214);
            this.buttonRsClearDataIn.Name = "buttonRsClearDataIn";
            this.buttonRsClearDataIn.Size = new System.Drawing.Size(98, 24);
            this.buttonRsClearDataIn.TabIndex = 32;
            this.buttonRsClearDataIn.Text = "Clear Data";
            this.buttonRsClearDataIn.UseVisualStyleBackColor = true;
            this.buttonRsClearDataIn.Click += new System.EventHandler(this.buttonRsClearDataIn_Click);
            // 
            // buttonRsClearDataOut
            // 
            this.buttonRsClearDataOut.Location = new System.Drawing.Point(115, 105);
            this.buttonRsClearDataOut.Name = "buttonRsClearDataOut";
            this.buttonRsClearDataOut.Size = new System.Drawing.Size(90, 24);
            this.buttonRsClearDataOut.TabIndex = 30;
            this.buttonRsClearDataOut.Text = "Clear Data";
            this.buttonRsClearDataOut.UseVisualStyleBackColor = true;
            this.buttonRsClearDataOut.Click += new System.EventHandler(this.buttonRsClearData_Click);
            // 
            // textBoxRsDataIn
            // 
            this.textBoxRsDataIn.Location = new System.Drawing.Point(6, 152);
            this.textBoxRsDataIn.Multiline = true;
            this.textBoxRsDataIn.Name = "textBoxRsDataIn";
            this.textBoxRsDataIn.Size = new System.Drawing.Size(199, 59);
            this.textBoxRsDataIn.TabIndex = 31;
            // 
            // buttonRsSendData
            // 
            this.buttonRsSendData.Location = new System.Drawing.Point(6, 106);
            this.buttonRsSendData.Name = "buttonRsSendData";
            this.buttonRsSendData.Size = new System.Drawing.Size(103, 24);
            this.buttonRsSendData.TabIndex = 29;
            this.buttonRsSendData.Text = "Send RD data";
            this.buttonRsSendData.UseVisualStyleBackColor = true;
            this.buttonRsSendData.Click += new System.EventHandler(this.buttonRsSendData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
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
            this.copyright.Location = new System.Drawing.Point(240, 38);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(106, 13);
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 61);
            this.panel1.TabIndex = 33;
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
            this.dataGridView1.Location = new System.Drawing.Point(7, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 186);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VendGastro.Properties.Resources.pos;
            this.pictureBox2.Location = new System.Drawing.Point(171, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendGastro.Properties.Resources.televend_logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(220, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(375, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Televend-Gastro Connector v1.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(223, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Release 2023-10-20 by Grupa AMB IT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(636, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "dev contact: it@grupaamb.com";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(591, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 12);
            this.label13.TabIndex = 36;
            this.label13.Text = "it vending contact: marcin@martec24.com";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(594, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 12);
            this.label14.TabIndex = 37;
            this.label14.Text = "it gastro contact: michal.sudnik@4wise.pl";
            // 
            // identyfikatorSystemowyDataGridViewTextBoxColumn
            // 
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.DataPropertyName = "IdentyfikatorSystemowy";
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.HeaderText = "NrKarty";
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.Name = "identyfikatorSystemowyDataGridViewTextBoxColumn";
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielImieDataGridViewTextBoxColumn
            // 
            this.okazicielImieDataGridViewTextBoxColumn.DataPropertyName = "OkazicielImie";
            this.okazicielImieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.okazicielImieDataGridViewTextBoxColumn.Name = "okazicielImieDataGridViewTextBoxColumn";
            this.okazicielImieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielNazwiskoDataGridViewTextBoxColumn
            // 
            this.okazicielNazwiskoDataGridViewTextBoxColumn.DataPropertyName = "OkazicielNazwisko";
            this.okazicielNazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.okazicielNazwiskoDataGridViewTextBoxColumn.Name = "okazicielNazwiskoDataGridViewTextBoxColumn";
            this.okazicielNazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielIdentyfikatorDataGridViewTextBoxColumn
            // 
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.DataPropertyName = "OkazicielIdentyfikator";
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.Name = "okazicielIdentyfikatorDataGridViewTextBoxColumn";
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okazicielWyroznikDataGridViewTextBoxColumn
            // 
            this.okazicielWyroznikDataGridViewTextBoxColumn.DataPropertyName = "OkazicielWyroznik";
            this.okazicielWyroznikDataGridViewTextBoxColumn.HeaderText = "Wyroznik";
            this.okazicielWyroznikDataGridViewTextBoxColumn.Name = "okazicielWyroznikDataGridViewTextBoxColumn";
            this.okazicielWyroznikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGastroKartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngastroKartaDataSet)).EndInit();
            this.ResumeLayout(false);

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
    }
}

