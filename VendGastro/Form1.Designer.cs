﻿namespace WindowsFormsApp1
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
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxDb = new System.Windows.Forms.GroupBox();
            this.labelDbResult = new System.Windows.Forms.Label();
            this.progressBarDb = new System.Windows.Forms.ProgressBar();
            this.btnSaveRsConfig = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.copyright = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnTelevendDenit = new System.Windows.Forms.Button();
            this.btnTelevendStatus = new System.Windows.Forms.Button();
            this.btnTelevendGetPricingGroup = new System.Windows.Forms.Button();
            this.textBoxComNumber = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.progressBarRs = new System.Windows.Forms.ProgressBar();
            this.btnTelevendInit = new System.Windows.Forms.Button();
            this.groupBoxTelevend = new System.Windows.Forms.GroupBox();
            this.textBoxTelevendAmount = new System.Windows.Forms.TextBox();
            this.labelSaldoText = new System.Windows.Forms.Label();
            this.btnTelevendRequest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.labelSaldoValue = new System.Windows.Forms.Label();
            this.labelNumerKarty = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.labelDoplataText = new System.Windows.Forms.Label();
            this.labelDoplataValue = new System.Windows.Forms.Label();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelTextBoxCredit = new System.Windows.Forms.Label();
            this.labelTextBoxTelevendAmount = new System.Windows.Forms.Label();
            this.labelTextBoxCardNumber = new System.Windows.Forms.Label();
            this.textBoxDTRachunekID = new System.Windows.Forms.TextBox();
            this.labelDTRachunekIDText = new System.Windows.Forms.Label();
            this.labelKartaID = new System.Windows.Forms.Label();
            this.textBoxKartaID = new System.Windows.Forms.TextBox();
            this.groupBoxDb.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGastroKartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngastroKartaDataSet)).BeginInit();
            this.groupBoxTelevend.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveDbConfig
            // 
            this.btnSaveDbConfig.Location = new System.Drawing.Point(13, 130);
            this.btnSaveDbConfig.Name = "btnSaveDbConfig";
            this.btnSaveDbConfig.Size = new System.Drawing.Size(248, 24);
            this.btnSaveDbConfig.TabIndex = 0;
            this.btnSaveDbConfig.Text = "Zapisz  konfigurację bazy";
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
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa bazy";
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
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasło";
            // 
            // btnCheckDb
            // 
            this.btnCheckDb.Location = new System.Drawing.Point(81, 216);
            this.btnCheckDb.Name = "btnCheckDb";
            this.btnCheckDb.Size = new System.Drawing.Size(180, 24);
            this.btnCheckDb.TabIndex = 11;
            this.btnCheckDb.Text = "Sprawdź połączenie do bazy";
            this.btnCheckDb.UseVisualStyleBackColor = true;
            this.btnCheckDb.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Numer Com";
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
            this.groupBoxDb.Location = new System.Drawing.Point(8, 116);
            this.groupBoxDb.Name = "groupBoxDb";
            this.groupBoxDb.Size = new System.Drawing.Size(271, 246);
            this.groupBoxDb.TabIndex = 24;
            this.groupBoxDb.TabStop = false;
            this.groupBoxDb.Text = "Baza Gastro";
            // 
            // labelDbResult
            // 
            this.labelDbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDbResult.Location = new System.Drawing.Point(19, 190);
            this.labelDbResult.Name = "labelDbResult";
            this.labelDbResult.Size = new System.Drawing.Size(56, 20);
            this.labelDbResult.TabIndex = 26;
            this.labelDbResult.Text = "status";
            this.labelDbResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarDb
            // 
            this.progressBarDb.Location = new System.Drawing.Point(81, 190);
            this.progressBarDb.Name = "progressBarDb";
            this.progressBarDb.Size = new System.Drawing.Size(180, 20);
            this.progressBarDb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDb.TabIndex = 25;
            // 
            // btnSaveRsConfig
            // 
            this.btnSaveRsConfig.Location = new System.Drawing.Point(6, 51);
            this.btnSaveRsConfig.Name = "btnSaveRsConfig";
            this.btnSaveRsConfig.Size = new System.Drawing.Size(226, 24);
            this.btnSaveRsConfig.TabIndex = 24;
            this.btnSaveRsConfig.Text = "Zapisz konfigurację Televend";
            this.btnSaveRsConfig.UseVisualStyleBackColor = true;
            this.btnSaveRsConfig.Click += new System.EventHandler(this.btnSaveRsConfig_Click);
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
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.copyright);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 61);
            this.panel1.TabIndex = 33;
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
            this.dataGridView1.Location = new System.Drawing.Point(8, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(775, 190);
            this.dataGridView1.TabIndex = 34;
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
            // btnTelevendDenit
            // 
            this.btnTelevendDenit.Location = new System.Drawing.Point(6, 160);
            this.btnTelevendDenit.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendDenit.Name = "btnTelevendDenit";
            this.btnTelevendDenit.Size = new System.Drawing.Size(225, 28);
            this.btnTelevendDenit.TabIndex = 33;
            this.btnTelevendDenit.Text = "Rozłącz z Televend";
            this.btnTelevendDenit.UseVisualStyleBackColor = true;
            this.btnTelevendDenit.Click += new System.EventHandler(this.btnTelevendDenit_Click);
            // 
            // btnTelevendStatus
            // 
            this.btnTelevendStatus.Location = new System.Drawing.Point(6, 92);
            this.btnTelevendStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendStatus.Name = "btnTelevendStatus";
            this.btnTelevendStatus.Size = new System.Drawing.Size(226, 28);
            this.btnTelevendStatus.TabIndex = 35;
            this.btnTelevendStatus.Text = "Televend Status";
            this.btnTelevendStatus.UseVisualStyleBackColor = true;
            this.btnTelevendStatus.Click += new System.EventHandler(this.btnTelevendStatus_Click);
            // 
            // btnTelevendGetPricingGroup
            // 
            this.btnTelevendGetPricingGroup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTelevendGetPricingGroup.FlatAppearance.BorderSize = 0;
            this.btnTelevendGetPricingGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelevendGetPricingGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTelevendGetPricingGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTelevendGetPricingGroup.Location = new System.Drawing.Point(0, 0);
            this.btnTelevendGetPricingGroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendGetPricingGroup.Name = "btnTelevendGetPricingGroup";
            this.btnTelevendGetPricingGroup.Size = new System.Drawing.Size(165, 45);
            this.btnTelevendGetPricingGroup.TabIndex = 36;
            this.btnTelevendGetPricingGroup.Text = "Pobierz kartę";
            this.btnTelevendGetPricingGroup.UseVisualStyleBackColor = false;
            this.btnTelevendGetPricingGroup.Click += new System.EventHandler(this.btnTelevendGetPricingGroup_Click);
            // 
            // textBoxComNumber
            // 
            this.textBoxComNumber.Location = new System.Drawing.Point(75, 26);
            this.textBoxComNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxComNumber.Name = "textBoxComNumber";
            this.textBoxComNumber.Size = new System.Drawing.Size(157, 20);
            this.textBoxComNumber.TabIndex = 38;
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCardNumber.Location = new System.Drawing.Point(547, 164);
            this.textBoxCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(157, 27);
            this.textBoxCardNumber.TabIndex = 37;
            // 
            // progressBarRs
            // 
            this.progressBarRs.Location = new System.Drawing.Point(75, 203);
            this.progressBarRs.Name = "progressBarRs";
            this.progressBarRs.Size = new System.Drawing.Size(156, 20);
            this.progressBarRs.TabIndex = 23;
            // 
            // btnTelevendInit
            // 
            this.btnTelevendInit.Location = new System.Drawing.Point(6, 128);
            this.btnTelevendInit.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendInit.Name = "btnTelevendInit";
            this.btnTelevendInit.Size = new System.Drawing.Size(225, 28);
            this.btnTelevendInit.TabIndex = 39;
            this.btnTelevendInit.Text = "Połącz z Televend";
            this.btnTelevendInit.UseVisualStyleBackColor = true;
            this.btnTelevendInit.Click += new System.EventHandler(this.btnTelevendInit_Click);
            // 
            // groupBoxTelevend
            // 
            this.groupBoxTelevend.Controls.Add(this.textBoxComNumber);
            this.groupBoxTelevend.Controls.Add(this.btnTelevendInit);
            this.groupBoxTelevend.Controls.Add(this.label9);
            this.groupBoxTelevend.Controls.Add(this.btnTelevendDenit);
            this.groupBoxTelevend.Controls.Add(this.progressBarRs);
            this.groupBoxTelevend.Controls.Add(this.btnSaveRsConfig);
            this.groupBoxTelevend.Controls.Add(this.btnTelevendStatus);
            this.groupBoxTelevend.Location = new System.Drawing.Point(285, 116);
            this.groupBoxTelevend.Name = "groupBoxTelevend";
            this.groupBoxTelevend.Size = new System.Drawing.Size(237, 246);
            this.groupBoxTelevend.TabIndex = 40;
            this.groupBoxTelevend.TabStop = false;
            this.groupBoxTelevend.Text = "TelevendBox";
            // 
            // textBoxTelevendAmount
            // 
            this.textBoxTelevendAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTelevendAmount.Location = new System.Drawing.Point(711, 116);
            this.textBoxTelevendAmount.Name = "textBoxTelevendAmount";
            this.textBoxTelevendAmount.Size = new System.Drawing.Size(158, 27);
            this.textBoxTelevendAmount.TabIndex = 41;
            // 
            // labelSaldoText
            // 
            this.labelSaldoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaldoText.AutoSize = true;
            this.labelSaldoText.Location = new System.Drawing.Point(433, 4);
            this.labelSaldoText.Name = "labelSaldoText";
            this.labelSaldoText.Size = new System.Drawing.Size(82, 13);
            this.labelSaldoText.TabIndex = 42;
            this.labelSaldoText.Text = "Saldo Televend";
            // 
            // btnTelevendRequest
            // 
            this.btnTelevendRequest.BackColor = System.Drawing.Color.Red;
            this.btnTelevendRequest.FlatAppearance.BorderSize = 0;
            this.btnTelevendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelevendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTelevendRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTelevendRequest.Location = new System.Drawing.Point(794, 0);
            this.btnTelevendRequest.Name = "btnTelevendRequest";
            this.btnTelevendRequest.Size = new System.Drawing.Size(232, 45);
            this.btnTelevendRequest.TabIndex = 43;
            this.btnTelevendRequest.Text = "Televend 0,00 zł";
            this.btnTelevendRequest.UseVisualStyleBackColor = false;
            this.btnTelevendRequest.Click += new System.EventHandler(this.btnTelevendRequest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Numer karty";
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCredit.Location = new System.Drawing.Point(547, 116);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(158, 27);
            this.textBoxCredit.TabIndex = 45;
            // 
            // labelSaldoValue
            // 
            this.labelSaldoValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaldoValue.AutoSize = true;
            this.labelSaldoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSaldoValue.Location = new System.Drawing.Point(395, 19);
            this.labelSaldoValue.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelSaldoValue.Name = "labelSaldoValue";
            this.labelSaldoValue.Size = new System.Drawing.Size(120, 20);
            this.labelSaldoValue.TabIndex = 46;
            this.labelSaldoValue.Text = "0,00";
            this.labelSaldoValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNumerKarty
            // 
            this.labelNumerKarty.AutoSize = true;
            this.labelNumerKarty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumerKarty.Location = new System.Drawing.Point(170, 19);
            this.labelNumerKarty.MinimumSize = new System.Drawing.Size(200, 0);
            this.labelNumerKarty.Name = "labelNumerKarty";
            this.labelNumerKarty.Size = new System.Drawing.Size(200, 18);
            this.labelNumerKarty.TabIndex = 47;
            this.labelNumerKarty.Text = "0";
            this.labelNumerKarty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalValue.Location = new System.Drawing.Point(530, 19);
            this.labelTotalValue.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalValue.Size = new System.Drawing.Size(120, 20);
            this.labelTotalValue.TabIndex = 49;
            this.labelTotalValue.Text = "0,00";
            this.labelTotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDoplataText
            // 
            this.labelDoplataText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoplataText.AutoSize = true;
            this.labelDoplataText.Location = new System.Drawing.Point(701, 4);
            this.labelDoplataText.Name = "labelDoplataText";
            this.labelDoplataText.Size = new System.Drawing.Size(80, 13);
            this.labelDoplataText.TabIndex = 48;
            this.labelDoplataText.Text = "Gotówka/Karta";
            // 
            // labelDoplataValue
            // 
            this.labelDoplataValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoplataValue.AutoSize = true;
            this.labelDoplataValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDoplataValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoplataValue.Location = new System.Drawing.Point(652, 19);
            this.labelDoplataValue.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelDoplataValue.Name = "labelDoplataValue";
            this.labelDoplataValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDoplataValue.Size = new System.Drawing.Size(120, 20);
            this.labelDoplataValue.TabIndex = 51;
            this.labelDoplataValue.Text = "0,00";
            this.labelDoplataValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalText
            // 
            this.labelTotalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Location = new System.Drawing.Point(557, 4);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(93, 13);
            this.labelTotalText.TabIndex = 50;
            this.labelTotalText.Text = "Rachunek w POS";
            // 
            // labelTextBoxCredit
            // 
            this.labelTextBoxCredit.AutoSize = true;
            this.labelTextBoxCredit.Location = new System.Drawing.Point(547, 98);
            this.labelTextBoxCredit.Name = "labelTextBoxCredit";
            this.labelTextBoxCredit.Size = new System.Drawing.Size(34, 13);
            this.labelTextBoxCredit.TabIndex = 52;
            this.labelTextBoxCredit.Text = "Credit";
            // 
            // labelTextBoxTelevendAmount
            // 
            this.labelTextBoxTelevendAmount.AutoSize = true;
            this.labelTextBoxTelevendAmount.Location = new System.Drawing.Point(711, 97);
            this.labelTextBoxTelevendAmount.Name = "labelTextBoxTelevendAmount";
            this.labelTextBoxTelevendAmount.Size = new System.Drawing.Size(91, 13);
            this.labelTextBoxTelevendAmount.TabIndex = 53;
            this.labelTextBoxTelevendAmount.Text = "Televend Amount";
            // 
            // labelTextBoxCardNumber
            // 
            this.labelTextBoxCardNumber.AutoSize = true;
            this.labelTextBoxCardNumber.Location = new System.Drawing.Point(547, 149);
            this.labelTextBoxCardNumber.Name = "labelTextBoxCardNumber";
            this.labelTextBoxCardNumber.Size = new System.Drawing.Size(64, 13);
            this.labelTextBoxCardNumber.TabIndex = 54;
            this.labelTextBoxCardNumber.Text = "Numer karty";
            // 
            // textBoxDTRachunekID
            // 
            this.textBoxDTRachunekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDTRachunekID.Location = new System.Drawing.Point(547, 259);
            this.textBoxDTRachunekID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDTRachunekID.Name = "textBoxDTRachunekID";
            this.textBoxDTRachunekID.Size = new System.Drawing.Size(373, 23);
            this.textBoxDTRachunekID.TabIndex = 55;
            // 
            // labelDTRachunekIDText
            // 
            this.labelDTRachunekIDText.AutoSize = true;
            this.labelDTRachunekIDText.Location = new System.Drawing.Point(547, 244);
            this.labelDTRachunekIDText.Name = "labelDTRachunekIDText";
            this.labelDTRachunekIDText.Size = new System.Drawing.Size(83, 13);
            this.labelDTRachunekIDText.TabIndex = 56;
            this.labelDTRachunekIDText.Text = "DTRachunekID";
            // 
            // labelKartaID
            // 
            this.labelKartaID.AutoSize = true;
            this.labelKartaID.Location = new System.Drawing.Point(547, 197);
            this.labelKartaID.Name = "labelKartaID";
            this.labelKartaID.Size = new System.Drawing.Size(43, 13);
            this.labelKartaID.TabIndex = 58;
            this.labelKartaID.Text = "KartaID";
            // 
            // textBoxKartaID
            // 
            this.textBoxKartaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKartaID.Location = new System.Drawing.Point(547, 212);
            this.textBoxKartaID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKartaID.Name = "textBoxKartaID";
            this.textBoxKartaID.Size = new System.Drawing.Size(373, 23);
            this.textBoxKartaID.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 45);
            this.Controls.Add(this.labelKartaID);
            this.Controls.Add(this.textBoxKartaID);
            this.Controls.Add(this.labelDTRachunekIDText);
            this.Controls.Add(this.textBoxDTRachunekID);
            this.Controls.Add(this.labelTextBoxCardNumber);
            this.Controls.Add(this.labelTextBoxTelevendAmount);
            this.Controls.Add(this.labelTextBoxCredit);
            this.Controls.Add(this.labelDoplataValue);
            this.Controls.Add(this.labelTotalText);
            this.Controls.Add(this.labelTotalValue);
            this.Controls.Add(this.labelDoplataText);
            this.Controls.Add(this.labelNumerKarty);
            this.Controls.Add(this.labelSaldoValue);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTelevendRequest);
            this.Controls.Add(this.labelSaldoText);
            this.Controls.Add(this.textBoxTelevendAmount);
            this.Controls.Add(this.groupBoxTelevend);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.btnTelevendGetPricingGroup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 45);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VendGastro Connector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBoxDb.ResumeLayout(false);
            this.groupBoxDb.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGastroKartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngastroKartaDataSet)).EndInit();
            this.groupBoxTelevend.ResumeLayout(false);
            this.groupBoxTelevend.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxDb;
        private System.Windows.Forms.Button btnSaveRsConfig;
        private System.Windows.Forms.ProgressBar progressBarDb;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelDbResult;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button btnTelevendDenit;
        private System.Windows.Forms.Button btnTelevendStatus;
        private System.Windows.Forms.Button btnTelevendGetPricingGroup;
        private System.Windows.Forms.TextBox textBoxComNumber;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.ProgressBar progressBarRs;
        private System.Windows.Forms.Button btnTelevendInit;
        private System.Windows.Forms.GroupBox groupBoxTelevend;
        private System.Windows.Forms.TextBox textBoxTelevendAmount;
        private System.Windows.Forms.Label labelSaldoText;
        private System.Windows.Forms.Button btnTelevendRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.Label labelSaldoValue;
        private System.Windows.Forms.Label labelNumerKarty;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.Label labelDoplataText;
        private System.Windows.Forms.Label labelDoplataValue;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Label labelTextBoxCredit;
        private System.Windows.Forms.Label labelTextBoxTelevendAmount;
        private System.Windows.Forms.Label labelTextBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxDTRachunekID;
        private System.Windows.Forms.Label labelDTRachunekIDText;
        private System.Windows.Forms.Label labelKartaID;
        private System.Windows.Forms.TextBox textBoxKartaID;
    }
}

