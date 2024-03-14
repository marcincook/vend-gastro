using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using VendGastro;

namespace VendGastroApp
{
    public partial class FormMain : Form
    {
        private Timer timer;


        public string comNumber = ConfigurationManager.AppSettings["com_number"];
        public string dbHost = ConfigurationManager.AppSettings["db_host"];
        public string dbName = ConfigurationManager.AppSettings["db_name"];
        public string dbUser = ConfigurationManager.AppSettings["db_user"];
        public string dbPass = ConfigurationManager.AppSettings["db_pass"];
        public string posId = ConfigurationManager.AppSettings["pos_id"];
        public string connectionString;
        public string KartaID = null;
        public string IdentyfikatorSystemowy = null;
        public string DTRachunekID = null;
        public int settingsClickCounter = 0;

        public int saldo = 0, total = 0, paid = 0, credit = 0;

        // Delegat funkcji zwrotnej
        private TelevendCallbackHandler.TelevendCallback televendCallback;


        public FormMain()
        {
            InitializeComponent();
            GetConfig();
            connectionString = "Data Source=" + dbHost + ";Database=" + dbName + ";User Id=" + dbUser + ";Password=" + dbPass;

            // Inicjalizacja delegata funkcji zwrotnej
            televendCallback = new TelevendCallbackHandler.TelevendCallback(OnTelevendCallback);

            // Inicjalizacja timera
            timer = new Timer();
            timer.Interval = 2000; // Ustawienie interwału na 2000 milisekund (czyli 2 sekundy)
            timer.Tick += Timer_Tick; // Dodanie obsługi zdarzenia Tick
            timer.Start(); // Uruchomienie timera

            this.Size = new System.Drawing.Size(1024, 45);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Wywołanie funkcji CheckBasket w interwale co 2 sekundy
            CheckBasket();
        }

        private void FindCard()
        {

            string query = $"SELECT TOP 1 ID as KartaID From NGastroKarta WHERE IdentyfikatorSystemowy = '{IdentyfikatorSystemowy}' AND FlgBlokada = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow firstRow = dataTable.Rows[0];
                    KartaID = firstRow["KartaID"].ToString().ToUpper();
                    Console.WriteLine($"KartaID: {KartaID}");
                }
                else
                {
                    Console.WriteLine("Brak karty");
                }

                // Po zakończeniu pracy zamknij połączenie
                connection.Close();

                textBoxKartaID.Text = KartaID;

            }
        }


        private void TransformBasketToCardOpenType()
        {

            if (KartaID != null && KartaID.GetType() == typeof(string) && DTRachunekID != null && DTRachunekID.GetType() == typeof(string))
            {

                string query = $@"UPDATE NGastroDTRachunek 
                             SET KartaID = '{KartaID}',
                                 RodzajOtwarciaRachunkuID = '17242DE3-B2EB-47E4-B361-B302E5F35BAE'
                             WHERE ID = '{DTRachunekID}'";

                bool updateSuccessful = ExecuteUpdateQuery(connectionString, query);

                if (updateSuccessful)
                {
                    Console.WriteLine("Zmieniono rachunek na karte.");
                }
                else
                {
                    Console.WriteLine("Aktualizacja rahunku na kartę nie powiodła się.");
                }
            }



        }

        private void CheckBasket()
        {
            // Tutaj umieść logikę sprawdzania koszyka
            // Ta funkcja będzie wywoływana co 2 sekundy przez timer
            // Możesz tutaj umieścić kod do sprawdzania zawartości koszyka lub inne operacje cykliczne
            // Console.WriteLine("Funkcja CheckBasket została wywołana.");

            total = 0;

            string query = $@"
                SELECT TOP 1
                    st.Nazwa AS pos,
                    CAST(t.WartoscBrutto * 100 AS INT) AS cents,
                    t.WartoscBrutto AS total,
                    dtr.Numer AS nr,
                    sb.ObiektID AS DTRachunekID
                FROM NSysSesjaObiektBlokada sb
                    LEFT JOIN NGastroDTRachunek dtr ON dtr.ID = sb.ObiektID
                    LEFT JOIN NGastroDTRachunekTotalizer t ON t.DTRachunekID = dtr.ID
                    LEFT JOIN NSysSesja s ON s.ID = sb.SesjaID
                    LEFT JOIN NSysStanowisko st ON st.ID = s.StanowiskoID
                WHERE sb.ObiektSymbol = 'NGastroDTRachunek'
                    AND dtr.KasaID = '{posId}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SqlConnection connection = new SqlConnection("Data Source=" + dbHost + ";Database=" + dbName + ";User Id=" + dbUser + ";Password=" + dbPass);

                // Otwórz połączenie
                connection.Open();

                // Utwórz obiekt SqlDataAdapter i użyj go do pobrania danych z bazy danych
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Utwórz nowy obiekt DataTable, który będzie przechowywał pobrane dane
                DataTable dataTable = new DataTable();

                // Wypełnij DataTable danymi z bazy danych za pomocą SqlDataAdapter
                adapter.Fill(dataTable);

                // Sprawdzenie, czy DataTable zawiera jakiekolwiek wiersze
                if (dataTable.Rows.Count > 0)
                {
                    // Pobranie pierwszego wiersza
                    DataRow firstRow = dataTable.Rows[0];

                    total = (int)firstRow["cents"];

                    if (saldo > 0 && total > 0)
                    {
                        // total 24 saldo 80  paid 0  credit 24
                        // total 24 saldo 10  paid 14 credit 0


                        if (total < saldo)
                        {
                            // Jeśli rachunek jest mniejszy niż saldo mogę pobrać wszystko na kredyt televendu 
                            credit = total;
                            paid = 0;
                        }
                        else
                        {

                            paid = (int)total - saldo;
                            credit = total - paid;
                        }
                    }
                    else
                    {
                        paid = total;
                        credit = 0;
                    }
                    //paid = total - paid - saldo;


                    //string formattedTotal = ((decimal)firstRow["total"]).ToString("C");


                    //labelDTRTotal.Text = formattedTotal;

                    DTRachunekID = firstRow["DTRachunekID"].ToString().ToUpper();

                    // Przetwarzanie pierwszego wiersza
                    Console.WriteLine($"Pos: {firstRow["pos"]}, Cents: {firstRow["cents"]}, Total: {firstRow["total"]}, Nr: {firstRow["nr"]}, Rid: {firstRow["DTRachunekID"]}");
                }
                else
                {
                    DTRachunekID = null;
                    Console.WriteLine("Brak otwartego rachunku");
                }

                // Po zakończeniu pracy zamknij połączenie
                connection.Close();

                textBoxDTRachunekID.Text = DTRachunekID;

                labelDoplataValue.Visible = false;
                labelDoplataText.Visible = false;

                labelSaldoValue.Text = (saldo / 100.0m).ToString("C");
                labelTotalValue.Text = (total / 100.0m).ToString("C");
                labelDoplataValue.Text = (paid / 100.0m).ToString("C");

                textBoxTelevendAmount.Text = credit.ToString();
                if (paid > 0)
                {
                    labelDoplataValue.Visible = true;
                    labelDoplataText.Visible = true;
                }
                string fCredit = (credit / 100.0m).ToString("C");
                btnTelevendRequest.Text = $"Televend {fCredit}";

                TransformBasketToCardOpenType();
            }
        }

        private void OnTelevendCallback(int result, int paymentType, int discount, int totalAmount, ulong transactionID)
        {
            TelevendLogger.LogRequestTransactionCallback(result, paymentType, discount, totalAmount, transactionID);

            // Obsługa funkcji zwrotnej w kontekście UI
            Invoke(new Action(() =>
            {
                string message = "";
                // Handle the callback result


                switch (result)
                {
                    case 0:
                        message = "Platnosc zatwierdzona";
                        MessageBox.Show($"Platnosc zatwierdzona \n\nTotal: {totalAmount}\n\nID Transakcji w televend: {transactionID}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case -1:
                        message = "Autoryzacja Platnosci Timeout";
                        MessageBox.Show($"Autoryzacja Platnosci Timeout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -2:
                        message = "Autoryzacja Odrzucona - Brakuje Kredytu";
                        MessageBox.Show($"Autoryzacja Odrzucona - Brakuje Kredytu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -3:
                        message = "Brak odpowiedzi z Televend Box (Local Communication Failure)";
                        MessageBox.Show($"Brak odpowiedzi z Televend Box (Local Communication Failure)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -4:
                        message = "Płatność Ordzucona przez użytkownika";
                        MessageBox.Show($"Płatność Ordzucona przez użytkownika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -9:
                        message = "Płatnośc odrzucona z niewiadomego powodu";
                        MessageBox.Show($"Płatnośc odrzucona z niewiadomego powodu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        message = $"Nieznany Result: {result}";
                        MessageBox.Show($"Nieznany Result: {result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }));
        }

        private void GetConfig()
        {
            textBoxDbHost.Text = dbHost;
            textBoxDbName.Text = dbName;
            textBoxDbUser.Text = dbUser;
            textBoxDbPass.Text = dbPass;
            textBoxComNumber.Text = comNumber;

        }


        private void SaveDbConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings["db_host"].Value = textBoxDbHost.Text;
                configuration.AppSettings.Settings["db_name"].Value = textBoxDbName.Text;
                configuration.AppSettings.Settings["db_user"].Value = textBoxDbUser.Text;
                configuration.AppSettings.Settings["db_pass"].Value = textBoxDbPass.Text;

                configuration.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                dbHost = ConfigurationManager.AppSettings["db_host"];
                dbName = ConfigurationManager.AppSettings["db_name"];
                dbUser = ConfigurationManager.AppSettings["db_user"];
                dbPass = ConfigurationManager.AppSettings["db_pass"];

                MessageBox.Show("Zmiany zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetConfig();
            }
            catch (Exception ex)
            {
                string msg = string.Format("Błąd podczas zapisu \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void SaveComConfig_Click(object sender, EventArgs e)
        {

            try
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings["com_number"].Value = textBoxComNumber.Text;

                configuration.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                comNumber = ConfigurationManager.AppSettings["com_number"];

                MessageBox.Show("Zmiany zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetConfig();
            }
            catch (Exception ex)
            {
                string msg = string.Format("Błąd podczas zapisu \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CheckConnection_Click(object sender, EventArgs e)
        {


            try
            {
                progressBarDb.Value = 0;
                SqlConnection connection = new SqlConnection(connectionString);

                progressBarDb.Value = 10;

                connection.Open();

                progressBarDb.Value = 20;

                if (connection.State == System.Data.ConnectionState.Open)
                {

                    //this.loadDataDbCards(connection);

                    progressBarDb.Value = 30;
                    //string symbol = string.Format("AUT");

                    SqlCommand command = new SqlCommand($"SELECT TOP 1 Symbol, Opis FROM NSysLokal WHERE FlgCentrala = 1", connection);
                    progressBarDb.Value = 40;

                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    progressBarDb.Value = 50;


                    // Call Read before accessing data.
                    while (sqlDataReader.Read())
                    {
                        ReadSingleRow((IDataRecord)sqlDataReader);
                    }
                    progressBarDb.Value = 100;
                    progressBarDb.ForeColor = Color.Green;
                    sqlDataReader.Close();


                }

            }
            catch (Exception ex)
            {

                progressBarDb.Value = 0;

                string msg = string.Format("Błąd podczas próby połaczenia \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }

        }

        /* public void loadDataDbCards(SqlConnection connection)
         {
             //using (SqlConnection connection = new SqlConnection(connectionString) //use your connection string here
             //{
             var bindingSource = new BindingSource();
             string queryString = "SELECT TOP 50 * FROM dbo.NgastroKarta WHERE FlgBlokada=0";
             using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection))
             {
                 try
                 {
                     SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                     DataTable table = new DataTable();
                     dataAdapter.Fill(table);
                     bindingSource.DataSource = table;
                     //dataGridView1.ReadOnly = true;
                     //dataGridView1.DataSource = bindingSource;
                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                 }
                 finally
                 {
                     //connection.Close();
                 }
             }

             //}
         }*/

        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            string str = String.Format("{0}, {1}", dataRecord[0], dataRecord[1]);
            Console.WriteLine(str);
            MessageBox.Show($"{str}. \n\n\nJeśli widzisz ten komunikat znaczy że połaczono z bazą poprawnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void FormMain_Load(object sender, EventArgs e)
        {


            AppTelevendInit();

        }

        private void AppTelevendInit()
        {
            int comInt = Int32.Parse(comNumber);

            // Wywołaj funkcję inicjalizacyjną
            int result = TelevendInterface.TelevendInit(comInt, televendCallback);

            // Sprawdź wynik inicjalizacji
            if (result == 0)
            {
                btnTelevendGetPricingGroup.Enabled = true;
                btnTelevendGetPricingGroup.Visible = true;
                btnTelevendRequest.Enabled = false;
                btnTelevendRequest.Visible = false;

                // Inicjalizacja powiodła się
                // MessageBox.Show("Połączono z Televend BOX!");
                progressBarCom.Value = 100;
                progressBarCom.ForeColor = Color.Green;
            }
            else
            {
                btnTelevendGetPricingGroup.Enabled = false;
                btnTelevendGetPricingGroup.Visible = false;
                btnTelevendRequest.Enabled = false;
                btnTelevendRequest.Visible = false;
                // Inicjalizacja nie powiodła się
                MessageBox.Show("Brak połączenia");
                progressBarCom.Value = 100;
                progressBarCom.ForeColor = Color.Red;
            }
        }

        // Funkcja zwrotna (callback), którą możesz przekazać do DLL-a
        /*        private void TelevendCallback(int result)
                {
                    // Obsługa zwrotu funkcji, np. wyświetlenie komunikatu
                    MessageBox.Show($"Zwrot funkcji z wynikiem: {result}");

                    // ParseTelevendCallback(result);

                }*/

        /*private void TelevendCallback(int result, int paymentType, int discount, int totalAmount, ulong transactionID)
        {
            string message = "";
            // Handle the callback result
            switch (result)
            {
                case 0:
                    message = "Platnosc zatwierdzona";

                    //btnTelevendRequest.Visible = false;
                    //credit = 0;
                    //labelNumerKarty.Text = "Platnosc zatwierdzona";

                    break;
                case -1:
                    message = "Autoryzacja Platnosci Timeout";
                    break;
                case -2:
                    message = "Autoryzacja Odrzucona - Brakuje Kredytu";
                    break;
                case -3:
                    message = "Brak odpowiedzi z Televend Box (Local Communication Failure)";
                    break;
                case -4:
                    message = "Płatność Ordzucona przez użytkownika";
                    break;
                case -9:
                    message = "Płatnośc odrzucona z niewiadomego powodu";
                    break;
                default:
                    message = $"Nieznany Result: {result}";
                    break;
            }

            labelNumerKarty.Invoke(new Action(() => { labelNumerKarty.Text = ""; }));
            labelSaldoValue.Invoke(new Action(() => { labelSaldoValue.Text = ""; }));





            // Handle additional information
            string displayMessage = message + $"\nPayment Type: {paymentType}" + $"\nDiscount: {discount}" + $"\nTotal Amount: {totalAmount}" + $"\nTransaction ID: {transactionID}";
            //MessageBox.Show($"Payment Type: {paymentType}");
            //MessageBox.Show($"Discount: {discount}");
            //MessageBox.Show($"Total Amount: {totalAmount}");
            //MessageBox.Show($"Transaction ID: {transactionID}");

            MessageBox.Show(displayMessage);


        }*/





        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            bool mousePointerNotInTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && mousePointerNotInTaskbar)
            {
                // notifyIcon1.Icon = Resources televend_logo_ico;
                notifyIcon1.BalloonTipText = "Televend jest uruchomiony w zasobniku systemowym System Tray";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;

            }


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (this.WindowState == FormWindowState.Normal)
            {
                this.Size = new System.Drawing.Size(1024, 400);
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }

        }


        private void TelevendDenit_Click(object sender, EventArgs e)
        {
            // Wywołaj funkcję deinicjalizacyjną
            TelevendInterface.TelevendDeinit();
            progressBarCom.Value = 0;

            // Inne działania związane z zakończeniem
            // ...
        }

        private void TelevendStatus_Click(object sender, EventArgs e)
        {

            int status = TelevendInterface.TelevendStatus();

            // Sprawdź status i podjęcie odpowiednich działań
            switch (status)
            {
                case 0:
                    MessageBox.Show("Status: Idle");
                    break;
                case 1:
                    MessageBox.Show("Status: Approving");
                    break;
                case 2:
                    MessageBox.Show("Status: Waiting Finalization");
                    break;
                case -1:
                    MessageBox.Show("Status: Not Initialized");
                    break;
                case -2:
                    MessageBox.Show("Status: No Communication");
                    break;
                default:
                    MessageBox.Show("Unknown Status");
                    break;
            }
        }


        private void TelevendInit_Click(object sender, EventArgs e)
        {

            AppTelevendInit();
        }

        private void HideSettings_Click(object sender, EventArgs e)
        {
            // Zmiana szerokości i wysokości okna
            this.Size = new System.Drawing.Size(1024, 45);
        }
        private void ShowSettings_Click(object sender, EventArgs e)
        {
            // Zmiana szerokości i wysokości okna
            this.Size = new System.Drawing.Size(1024, 400);
        }

        private void TextBoxTelevendAmount_TextChanged(object sender, EventArgs e)
        {
            credit = Int32.Parse(textBoxTelevendAmount.Text);
        }

        private void TelevendGetPricingGroup_Click(object sender, EventArgs e)
        {
            textBoxCardNumber.Text = "Sprawdzam ..."; // string.Empty;
            labelSaldoValue.Text = "0,00";

            // 12006942281 
            uint availableCredit;
            ulong cardID;

            int pricingGroup = TelevendInterface.TelevendGetPricingGroup(out availableCredit, out cardID);


            TelevendLogger.LogPricingGroup((int)availableCredit, cardID);

            textBoxCardNumber.Text = cardID.ToString();
            textBoxCredit.Text = availableCredit.ToString();
            IdentyfikatorSystemowy = cardID.ToString();
            labelNumerKarty.Text = cardID.ToString();

            FindCard();

            switch (pricingGroup)
            {
                case -1:
                    //MessageBox.Show("Not Initialized");
                    labelNumerKarty.Text = "Podłącz televend";
                    break;
                case -2:
                    //MessageBox.Show("No Communication");
                    labelNumerKarty.Text = "Brak komunikacji";
                    break;
                case -4:
                    //MessageBox.Show("Pricing Group Niznany/Nie Dostępny");
                    labelNumerKarty.Text = "Saldo niedostępne / spróbuj ponownie";
                    break;
                default:
                    textBoxCardNumber.Text = cardID.ToString();
                    textBoxCredit.Text = availableCredit.ToString();

                    if (availableCredit > 0)
                    {
                        btnTelevendRequest.Enabled = true;
                        btnTelevendRequest.Visible = true;

                        saldo = (int)availableCredit;
                        decimal amountInZloty = availableCredit / 100.0m;
                        string formattedAmount = amountInZloty.ToString("C");
                        labelSaldoValue.Text = formattedAmount;

                        TransformBasketToCardOpenType();
                    }
                    else
                    {
                        saldo = 0;
                        decimal amountInZloty = saldo / 100.0m;
                        string formattedAmount = amountInZloty.ToString("C");
                        labelSaldoValue.Text = formattedAmount;

                    }






                    //MessageBox.Show($"Pricing Group: {pricingGroup}\nAvailable Credit: {availableCredit}\nCard ID: {cardID} \n Avv {gg}");
                    break;
            }




        }


        private void BtnTelevendRequest_Click(object sender, EventArgs e)
        {
            if (credit > 0)
            {
                int requestedAmount = credit;// Int32.Parse(textBoxTelevendAmount.Text) * 1;

                // Call the function to request payment authorization
                int result = TelevendInterface.TelevendRequest(requestedAmount);

                // Check the result and take appropriate actions
                switch (result)
                {
                    case 0:
                        //MessageBox.Show("Payment Request Accepted");
                        // The callback function will be called for approval/denial
                        btnTelevendRequest.Visible = false;
                        credit = 0;

                        break;
                    case -1:
                        MessageBox.Show("Not Initialized");
                        break;
                    case -2:
                        MessageBox.Show("No Communication");
                        break;
                    case -3:
                        MessageBox.Show("Busy, Please Try Again Later");
                        break;
                    default:
                        MessageBox.Show("Unknown Result");
                        break;
                }
            }


        }





        static bool ExecuteUpdateQuery(string connectionString, string query)
        {
            int rowsAffected;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Otwarcie połączenia
                        connection.Open();

                        // Wykonanie zapytania
                        rowsAffected = command.ExecuteNonQuery();

                        // Jeśli rowsAffected > 0, to aktualizacja się powiodła
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Błąd podczas aktualizacji: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
