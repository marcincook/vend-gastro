namespace VendGastroApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSaveDbConfig = new System.Windows.Forms.Button();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxDbHost = new System.Windows.Forms.TextBox();
            this.textBoxDbUser = new System.Windows.Forms.TextBox();
            this.textBoxDbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDbStatus = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxDb = new System.Windows.Forms.GroupBox();
            this.progressBarDb = new System.Windows.Forms.ProgressBar();
            this.btnSaveComConfig = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.copyright = new System.Windows.Forms.Label();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.buttonHideSettings = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.identyfikatorSystemowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielImieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okazicielWyroznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTelevendDenit = new System.Windows.Forms.Button();
            this.btnTelevendStatus = new System.Windows.Forms.Button();
            this.btnTelevendGetPricingGroup = new System.Windows.Forms.Button();
            this.textBoxComNumber = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.progressBarCom = new System.Windows.Forms.ProgressBar();
            this.btnTelevendInit = new System.Windows.Forms.Button();
            this.groupBoxTelevend = new System.Windows.Forms.GroupBox();
            this.textBoxTelevendAmount = new System.Windows.Forms.TextBox();
            this.labelSaldoText = new System.Windows.Forms.Label();
            this.btnTelevendRequest = new System.Windows.Forms.Button();
            this.labelNumerKartyText = new System.Windows.Forms.Label();
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
            this.groupBoxBasket = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCard = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSaldo = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShowSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDb.SuspendLayout();
            this.panelCopyright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTelevend.SuspendLayout();
            this.groupBoxBasket.SuspendLayout();
            this.tableLayoutPanelCard.SuspendLayout();
            this.tableLayoutPanelSaldo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveDbConfig
            // 
            this.btnSaveDbConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveDbConfig.Location = new System.Drawing.Point(91, 130);
            this.btnSaveDbConfig.Name = "btnSaveDbConfig";
            this.btnSaveDbConfig.Size = new System.Drawing.Size(180, 24);
            this.btnSaveDbConfig.TabIndex = 0;
            this.btnSaveDbConfig.Text = "Zapisz";
            this.btnSaveDbConfig.UseVisualStyleBackColor = true;
            this.btnSaveDbConfig.Click += new System.EventHandler(this.SaveDbConfig_Click);
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(91, 51);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbName.TabIndex = 1;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHost.Location = new System.Drawing.Point(46, 29);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(29, 13);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "Host";
            // 
            // textBoxDbHost
            // 
            this.textBoxDbHost.Location = new System.Drawing.Point(91, 26);
            this.textBoxDbHost.Name = "textBoxDbHost";
            this.textBoxDbHost.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbHost.TabIndex = 3;
            // 
            // textBoxDbUser
            // 
            this.textBoxDbUser.Location = new System.Drawing.Point(91, 78);
            this.textBoxDbUser.Name = "textBoxDbUser";
            this.textBoxDbUser.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbUser.TabIndex = 4;
            // 
            // textBoxDbPass
            // 
            this.textBoxDbPass.Location = new System.Drawing.Point(91, 104);
            this.textBoxDbPass.Name = "textBoxDbPass";
            this.textBoxDbPass.PasswordChar = '*';
            this.textBoxDbPass.Size = new System.Drawing.Size(180, 20);
            this.textBoxDbPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa bazy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasło";
            // 
            // btnDbStatus
            // 
            this.btnDbStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDbStatus.Location = new System.Drawing.Point(91, 201);
            this.btnDbStatus.Name = "btnDbStatus";
            this.btnDbStatus.Size = new System.Drawing.Size(180, 24);
            this.btnDbStatus.TabIndex = 11;
            this.btnDbStatus.Text = "Status";
            this.btnDbStatus.UseVisualStyleBackColor = true;
            this.btnDbStatus.Click += new System.EventHandler(this.CheckConnection_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Numer Com";
            // 
            // groupBoxDb
            // 
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
            this.groupBoxDb.Controls.Add(this.btnDbStatus);
            this.groupBoxDb.Location = new System.Drawing.Point(6, 51);
            this.groupBoxDb.Name = "groupBoxDb";
            this.groupBoxDb.Size = new System.Drawing.Size(280, 240);
            this.groupBoxDb.TabIndex = 24;
            this.groupBoxDb.TabStop = false;
            this.groupBoxDb.Text = "Baza Gastro";
            // 
            // progressBarDb
            // 
            this.progressBarDb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarDb.Location = new System.Drawing.Point(91, 175);
            this.progressBarDb.Name = "progressBarDb";
            this.progressBarDb.Size = new System.Drawing.Size(180, 20);
            this.progressBarDb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDb.TabIndex = 25;
            // 
            // btnSaveComConfig
            // 
            this.btnSaveComConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveComConfig.Location = new System.Drawing.Point(95, 51);
            this.btnSaveComConfig.Name = "btnSaveComConfig";
            this.btnSaveComConfig.Size = new System.Drawing.Size(180, 24);
            this.btnSaveComConfig.TabIndex = 24;
            this.btnSaveComConfig.Text = "Zapisz";
            this.btnSaveComConfig.UseVisualStyleBackColor = true;
            this.btnSaveComConfig.Click += new System.EventHandler(this.SaveComConfig_Click);
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
            this.copyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.copyright.Location = new System.Drawing.Point(240, 38);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(106, 13);
            this.copyright.TabIndex = 31;
            this.copyright.Text = "Copyright GrupaAMB";
            // 
            // panelCopyright
            // 
            this.panelCopyright.Controls.Add(this.buttonHideSettings);
            this.panelCopyright.Controls.Add(this.label11);
            this.panelCopyright.Controls.Add(this.label10);
            this.panelCopyright.Controls.Add(this.pictureBox2);
            this.panelCopyright.Controls.Add(this.copyright);
            this.panelCopyright.Controls.Add(this.pictureBox1);
            this.panelCopyright.Location = new System.Drawing.Point(6, 297);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(999, 51);
            this.panelCopyright.TabIndex = 33;
            // 
            // buttonHideSettings
            // 
            this.buttonHideSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonHideSettings.Location = new System.Drawing.Point(749, 4);
            this.buttonHideSettings.Name = "buttonHideSettings";
            this.buttonHideSettings.Size = new System.Drawing.Size(246, 42);
            this.buttonHideSettings.TabIndex = 35;
            this.buttonHideSettings.Text = "Ukryj ustawienia";
            this.buttonHideSettings.UseVisualStyleBackColor = true;
            this.buttonHideSettings.Click += new System.EventHandler(this.HideSettings_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(229, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Release 2023-10-20 by Grupa AMB IT";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(226, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(375, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Televend-Gastro Connector v1.0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VendGastro.Properties.Resources.pos;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(171, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendGastro.Properties.Resources.televend_logo;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // identyfikatorSystemowyDataGridViewTextBoxColumn
            // 
            this.identyfikatorSystemowyDataGridViewTextBoxColumn.Name = "identyfikatorSystemowyDataGridViewTextBoxColumn";
            // 
            // okazicielImieDataGridViewTextBoxColumn
            // 
            this.okazicielImieDataGridViewTextBoxColumn.Name = "okazicielImieDataGridViewTextBoxColumn";
            // 
            // okazicielNazwiskoDataGridViewTextBoxColumn
            // 
            this.okazicielNazwiskoDataGridViewTextBoxColumn.Name = "okazicielNazwiskoDataGridViewTextBoxColumn";
            // 
            // okazicielIdentyfikatorDataGridViewTextBoxColumn
            // 
            this.okazicielIdentyfikatorDataGridViewTextBoxColumn.Name = "okazicielIdentyfikatorDataGridViewTextBoxColumn";
            // 
            // okazicielWyroznikDataGridViewTextBoxColumn
            // 
            this.okazicielWyroznikDataGridViewTextBoxColumn.Name = "okazicielWyroznikDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // btnTelevendDenit
            // 
            this.btnTelevendDenit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTelevendDenit.Location = new System.Drawing.Point(95, 107);
            this.btnTelevendDenit.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendDenit.Name = "btnTelevendDenit";
            this.btnTelevendDenit.Size = new System.Drawing.Size(180, 24);
            this.btnTelevendDenit.TabIndex = 33;
            this.btnTelevendDenit.Text = "Rozłącz";
            this.btnTelevendDenit.UseVisualStyleBackColor = true;
            this.btnTelevendDenit.Click += new System.EventHandler(this.TelevendDenit_Click);
            // 
            // btnTelevendStatus
            // 
            this.btnTelevendStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTelevendStatus.Location = new System.Drawing.Point(95, 201);
            this.btnTelevendStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendStatus.Name = "btnTelevendStatus";
            this.btnTelevendStatus.Size = new System.Drawing.Size(179, 24);
            this.btnTelevendStatus.TabIndex = 35;
            this.btnTelevendStatus.Text = "Status";
            this.btnTelevendStatus.UseVisualStyleBackColor = true;
            this.btnTelevendStatus.Click += new System.EventHandler(this.TelevendStatus_Click);
            // 
            // btnTelevendGetPricingGroup
            // 
            this.btnTelevendGetPricingGroup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTelevendGetPricingGroup.FlatAppearance.BorderSize = 0;
            this.btnTelevendGetPricingGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelevendGetPricingGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnTelevendGetPricingGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTelevendGetPricingGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTelevendGetPricingGroup.Location = new System.Drawing.Point(-1, 0);
            this.btnTelevendGetPricingGroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendGetPricingGroup.Name = "btnTelevendGetPricingGroup";
            this.btnTelevendGetPricingGroup.Size = new System.Drawing.Size(115, 45);
            this.btnTelevendGetPricingGroup.TabIndex = 36;
            this.btnTelevendGetPricingGroup.Text = "Pobierz kartę";
            this.btnTelevendGetPricingGroup.UseVisualStyleBackColor = false;
            this.btnTelevendGetPricingGroup.Click += new System.EventHandler(this.TelevendGetPricingGroup_Click);
            // 
            // textBoxComNumber
            // 
            this.textBoxComNumber.Location = new System.Drawing.Point(95, 26);
            this.textBoxComNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxComNumber.Name = "textBoxComNumber";
            this.textBoxComNumber.Size = new System.Drawing.Size(180, 20);
            this.textBoxComNumber.TabIndex = 38;
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCardNumber.Location = new System.Drawing.Point(127, 57);
            this.textBoxCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(290, 23);
            this.textBoxCardNumber.TabIndex = 37;
            // 
            // progressBarCom
            // 
            this.progressBarCom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarCom.Location = new System.Drawing.Point(95, 176);
            this.progressBarCom.Name = "progressBarCom";
            this.progressBarCom.Size = new System.Drawing.Size(179, 20);
            this.progressBarCom.TabIndex = 23;
            // 
            // btnTelevendInit
            // 
            this.btnTelevendInit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTelevendInit.Location = new System.Drawing.Point(95, 79);
            this.btnTelevendInit.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelevendInit.Name = "btnTelevendInit";
            this.btnTelevendInit.Size = new System.Drawing.Size(180, 24);
            this.btnTelevendInit.TabIndex = 39;
            this.btnTelevendInit.Text = "Połącz";
            this.btnTelevendInit.UseVisualStyleBackColor = true;
            this.btnTelevendInit.Click += new System.EventHandler(this.TelevendInit_Click);
            // 
            // groupBoxTelevend
            // 
            this.groupBoxTelevend.Controls.Add(this.textBoxComNumber);
            this.groupBoxTelevend.Controls.Add(this.btnTelevendInit);
            this.groupBoxTelevend.Controls.Add(this.label9);
            this.groupBoxTelevend.Controls.Add(this.btnTelevendDenit);
            this.groupBoxTelevend.Controls.Add(this.progressBarCom);
            this.groupBoxTelevend.Controls.Add(this.btnSaveComConfig);
            this.groupBoxTelevend.Controls.Add(this.btnTelevendStatus);
            this.groupBoxTelevend.Location = new System.Drawing.Point(296, 51);
            this.groupBoxTelevend.Name = "groupBoxTelevend";
            this.groupBoxTelevend.Size = new System.Drawing.Size(280, 240);
            this.groupBoxTelevend.TabIndex = 40;
            this.groupBoxTelevend.TabStop = false;
            this.groupBoxTelevend.Text = "TelevendBox";
            // 
            // textBoxTelevendAmount
            // 
            this.textBoxTelevendAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTelevendAmount.Location = new System.Drawing.Point(127, 151);
            this.textBoxTelevendAmount.Name = "textBoxTelevendAmount";
            this.textBoxTelevendAmount.Size = new System.Drawing.Size(289, 23);
            this.textBoxTelevendAmount.TabIndex = 41;
            this.textBoxTelevendAmount.TextChanged += new System.EventHandler(this.TextBoxTelevendAmount_TextChanged);
            // 
            // labelSaldoText
            // 
            this.labelSaldoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaldoText.AutoSize = true;
            this.labelSaldoText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSaldoText.Location = new System.Drawing.Point(28, 4);
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
            this.btnTelevendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnTelevendRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTelevendRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTelevendRequest.Location = new System.Drawing.Point(825, 0);
            this.btnTelevendRequest.Name = "btnTelevendRequest";
            this.btnTelevendRequest.Size = new System.Drawing.Size(200, 45);
            this.btnTelevendRequest.TabIndex = 43;
            this.btnTelevendRequest.Text = "Televend 0,00 zł";
            this.btnTelevendRequest.UseVisualStyleBackColor = false;
            this.btnTelevendRequest.Click += new System.EventHandler(this.BtnTelevendRequest_Click);
            // 
            // labelNumerKartyText
            // 
            this.labelNumerKartyText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNumerKartyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNumerKartyText.Location = new System.Drawing.Point(3, 0);
            this.labelNumerKartyText.Name = "labelNumerKartyText";
            this.labelNumerKartyText.Size = new System.Drawing.Size(250, 17);
            this.labelNumerKartyText.TabIndex = 44;
            this.labelNumerKartyText.Text = "Numer karty";
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCredit.Location = new System.Drawing.Point(127, 122);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(289, 23);
            this.textBoxCredit.TabIndex = 45;
            // 
            // labelSaldoValue
            // 
            this.labelSaldoValue.AutoSize = true;
            this.labelSaldoValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSaldoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSaldoValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSaldoValue.Location = new System.Drawing.Point(3, 17);
            this.labelSaldoValue.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelSaldoValue.Name = "labelSaldoValue";
            this.labelSaldoValue.Size = new System.Drawing.Size(107, 27);
            this.labelSaldoValue.TabIndex = 46;
            this.labelSaldoValue.Text = "0,00";
            this.labelSaldoValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNumerKarty
            // 
            this.labelNumerKarty.AutoSize = true;
            this.labelNumerKarty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumerKarty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelNumerKarty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNumerKarty.Location = new System.Drawing.Point(3, 17);
            this.labelNumerKarty.MinimumSize = new System.Drawing.Size(240, 0);
            this.labelNumerKarty.Name = "labelNumerKarty";
            this.labelNumerKarty.Size = new System.Drawing.Size(323, 27);
            this.labelNumerKarty.TabIndex = 47;
            this.labelNumerKarty.Text = "0";
            this.labelNumerKarty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotalValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTotalValue.Location = new System.Drawing.Point(116, 17);
            this.labelTotalValue.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalValue.Size = new System.Drawing.Size(107, 27);
            this.labelTotalValue.TabIndex = 49;
            this.labelTotalValue.Text = "0,00";
            this.labelTotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDoplataText
            // 
            this.labelDoplataText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoplataText.AutoSize = true;
            this.labelDoplataText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDoplataText.Location = new System.Drawing.Point(260, 4);
            this.labelDoplataText.Name = "labelDoplataText";
            this.labelDoplataText.Size = new System.Drawing.Size(80, 13);
            this.labelDoplataText.TabIndex = 48;
            this.labelDoplataText.Text = "Gotówka/Karta";
            // 
            // labelDoplataValue
            // 
            this.labelDoplataValue.AutoSize = true;
            this.labelDoplataValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDoplataValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDoplataValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelDoplataValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDoplataValue.Location = new System.Drawing.Point(229, 17);
            this.labelDoplataValue.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelDoplataValue.Name = "labelDoplataValue";
            this.labelDoplataValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDoplataValue.Size = new System.Drawing.Size(111, 27);
            this.labelDoplataValue.TabIndex = 51;
            this.labelDoplataValue.Text = "0,00";
            this.labelDoplataValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalText
            // 
            this.labelTotalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTotalText.Location = new System.Drawing.Point(130, 4);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(93, 13);
            this.labelTotalText.TabIndex = 50;
            this.labelTotalText.Text = "Rachunek w POS";
            // 
            // labelTextBoxCredit
            // 
            this.labelTextBoxCredit.AutoSize = true;
            this.labelTextBoxCredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTextBoxCredit.Location = new System.Drawing.Point(7, 130);
            this.labelTextBoxCredit.Name = "labelTextBoxCredit";
            this.labelTextBoxCredit.Size = new System.Drawing.Size(115, 13);
            this.labelTextBoxCredit.TabIndex = 52;
            this.labelTextBoxCredit.Text = "Credit (SaldoTelevend)";
            // 
            // labelTextBoxTelevendAmount
            // 
            this.labelTextBoxTelevendAmount.AutoSize = true;
            this.labelTextBoxTelevendAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTextBoxTelevendAmount.Location = new System.Drawing.Point(31, 156);
            this.labelTextBoxTelevendAmount.Name = "labelTextBoxTelevendAmount";
            this.labelTextBoxTelevendAmount.Size = new System.Drawing.Size(91, 13);
            this.labelTextBoxTelevendAmount.TabIndex = 53;
            this.labelTextBoxTelevendAmount.Text = "Televend Amount";
            // 
            // labelTextBoxCardNumber
            // 
            this.labelTextBoxCardNumber.AutoSize = true;
            this.labelTextBoxCardNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTextBoxCardNumber.Location = new System.Drawing.Point(58, 62);
            this.labelTextBoxCardNumber.Name = "labelTextBoxCardNumber";
            this.labelTextBoxCardNumber.Size = new System.Drawing.Size(64, 13);
            this.labelTextBoxCardNumber.TabIndex = 54;
            this.labelTextBoxCardNumber.Text = "Numer karty";
            // 
            // textBoxDTRachunekID
            // 
            this.textBoxDTRachunekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDTRachunekID.Location = new System.Drawing.Point(127, 24);
            this.textBoxDTRachunekID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDTRachunekID.Name = "textBoxDTRachunekID";
            this.textBoxDTRachunekID.Size = new System.Drawing.Size(290, 23);
            this.textBoxDTRachunekID.TabIndex = 55;
            // 
            // labelDTRachunekIDText
            // 
            this.labelDTRachunekIDText.AutoSize = true;
            this.labelDTRachunekIDText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDTRachunekIDText.Location = new System.Drawing.Point(39, 29);
            this.labelDTRachunekIDText.Name = "labelDTRachunekIDText";
            this.labelDTRachunekIDText.Size = new System.Drawing.Size(83, 13);
            this.labelDTRachunekIDText.TabIndex = 56;
            this.labelDTRachunekIDText.Text = "DTRachunekID";
            // 
            // labelKartaID
            // 
            this.labelKartaID.AutoSize = true;
            this.labelKartaID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKartaID.Location = new System.Drawing.Point(79, 95);
            this.labelKartaID.Name = "labelKartaID";
            this.labelKartaID.Size = new System.Drawing.Size(43, 13);
            this.labelKartaID.TabIndex = 58;
            this.labelKartaID.Text = "KartaID";
            // 
            // textBoxKartaID
            // 
            this.textBoxKartaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxKartaID.Location = new System.Drawing.Point(127, 90);
            this.textBoxKartaID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKartaID.Name = "textBoxKartaID";
            this.textBoxKartaID.Size = new System.Drawing.Size(290, 23);
            this.textBoxKartaID.TabIndex = 57;
            // 
            // groupBoxBasket
            // 
            this.groupBoxBasket.Controls.Add(this.textBoxDTRachunekID);
            this.groupBoxBasket.Controls.Add(this.labelTextBoxTelevendAmount);
            this.groupBoxBasket.Controls.Add(this.labelKartaID);
            this.groupBoxBasket.Controls.Add(this.labelTextBoxCredit);
            this.groupBoxBasket.Controls.Add(this.textBoxKartaID);
            this.groupBoxBasket.Controls.Add(this.labelDTRachunekIDText);
            this.groupBoxBasket.Controls.Add(this.textBoxCardNumber);
            this.groupBoxBasket.Controls.Add(this.labelTextBoxCardNumber);
            this.groupBoxBasket.Controls.Add(this.textBoxCredit);
            this.groupBoxBasket.Controls.Add(this.textBoxTelevendAmount);
            this.groupBoxBasket.Location = new System.Drawing.Point(585, 51);
            this.groupBoxBasket.Name = "groupBoxBasket";
            this.groupBoxBasket.Size = new System.Drawing.Size(422, 240);
            this.groupBoxBasket.TabIndex = 59;
            this.groupBoxBasket.TabStop = false;
            this.groupBoxBasket.Text = "Aktualna transakcja";
            // 
            // tableLayoutPanelCard
            // 
            this.tableLayoutPanelCard.ColumnCount = 1;
            this.tableLayoutPanelCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCard.Controls.Add(this.labelNumerKartyText, 0, 0);
            this.tableLayoutPanelCard.Controls.Add(this.labelNumerKarty, 0, 1);
            this.tableLayoutPanelCard.Location = new System.Drawing.Point(119, 1);
            this.tableLayoutPanelCard.Name = "tableLayoutPanelCard";
            this.tableLayoutPanelCard.RowCount = 2;
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelCard.Size = new System.Drawing.Size(329, 44);
            this.tableLayoutPanelCard.TabIndex = 60;
            // 
            // tableLayoutPanelSaldo
            // 
            this.tableLayoutPanelSaldo.ColumnCount = 3;
            this.tableLayoutPanelSaldo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelSaldo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelSaldo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelSaldo.Controls.Add(this.labelSaldoText, 0, 0);
            this.tableLayoutPanelSaldo.Controls.Add(this.labelTotalText, 1, 0);
            this.tableLayoutPanelSaldo.Controls.Add(this.labelDoplataText, 2, 0);
            this.tableLayoutPanelSaldo.Controls.Add(this.labelDoplataValue, 2, 1);
            this.tableLayoutPanelSaldo.Controls.Add(this.labelSaldoValue, 0, 1);
            this.tableLayoutPanelSaldo.Controls.Add(this.labelTotalValue, 1, 1);
            this.tableLayoutPanelSaldo.Location = new System.Drawing.Point(476, 1);
            this.tableLayoutPanelSaldo.Name = "tableLayoutPanelSaldo";
            this.tableLayoutPanelSaldo.RowCount = 2;
            this.tableLayoutPanelSaldo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelSaldo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelSaldo.Size = new System.Drawing.Size(343, 44);
            this.tableLayoutPanelSaldo.TabIndex = 61;
            // 
            // buttonShowSettings
            // 
            this.buttonShowSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowSettings.FlatAppearance.BorderSize = 0;
            this.buttonShowSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowSettings.Location = new System.Drawing.Point(3, 3);
            this.buttonShowSettings.Name = "buttonShowSettings";
            this.buttonShowSettings.Size = new System.Drawing.Size(16, 38);
            this.buttonShowSettings.TabIndex = 36;
            this.buttonShowSettings.Text = ".";
            this.buttonShowSettings.UseVisualStyleBackColor = true;
            this.buttonShowSettings.Click += new System.EventHandler(this.ShowSettings_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonShowSettings, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(451, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(22, 44);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelSaldo);
            this.Controls.Add(this.tableLayoutPanelCard);
            this.Controls.Add(this.groupBoxBasket);
            this.Controls.Add(this.btnTelevendRequest);
            this.Controls.Add(this.groupBoxTelevend);
            this.Controls.Add(this.btnTelevendGetPricingGroup);
            this.Controls.Add(this.panelCopyright);
            this.Controls.Add(this.groupBoxDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 45);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VendGastro Connector";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.groupBoxDb.ResumeLayout(false);
            this.groupBoxDb.PerformLayout();
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTelevend.ResumeLayout(false);
            this.groupBoxTelevend.PerformLayout();
            this.groupBoxBasket.ResumeLayout(false);
            this.groupBoxBasket.PerformLayout();
            this.tableLayoutPanelCard.ResumeLayout(false);
            this.tableLayoutPanelCard.PerformLayout();
            this.tableLayoutPanelSaldo.ResumeLayout(false);
            this.tableLayoutPanelSaldo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxDb;
        private System.Windows.Forms.Button btnSaveComConfig;
        private System.Windows.Forms.ProgressBar progressBarDb;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Panel panelCopyright;
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
        private System.Windows.Forms.ProgressBar progressBarCom;
        private System.Windows.Forms.Button btnTelevendInit;
        private System.Windows.Forms.GroupBox groupBoxTelevend;
        private System.Windows.Forms.TextBox textBoxTelevendAmount;
        private System.Windows.Forms.Label labelSaldoText;
        private System.Windows.Forms.Button btnTelevendRequest;
        private System.Windows.Forms.Label labelNumerKartyText;
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
        private System.Windows.Forms.GroupBox groupBoxBasket;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSaldo;
        private System.Windows.Forms.Button buttonHideSettings;
        private System.Windows.Forms.Button buttonShowSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

