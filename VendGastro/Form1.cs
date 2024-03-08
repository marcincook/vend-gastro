using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using VendGastro;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        // Delegat funkcji zwrotnej
        //private TelevendCallbackHandler.TelevendCallback televendCallback;

        // Set the callback in the C++ DLL
        //TelevendInterface.TelevendCallback(TelevendCallbackHandler.OnTelevendCallback);



        public string comNumber = ConfigurationManager.AppSettings["com_number"];
        public string dbHost = ConfigurationManager.AppSettings["db_host"];
        public string dbName = ConfigurationManager.AppSettings["db_name"];
        public string dbUser = ConfigurationManager.AppSettings["db_user"];
        public string dbPass = ConfigurationManager.AppSettings["db_pass"];

        public Form1()
        {
            InitializeComponent();
            getConfig();

            // Inicjalizacja delegata funkcji zwrotnej
            //televendCallback = new TelevendCallbackHandler.TelevendCallback(OnTelevendCallback);

        }

        private void OnTelevendCallback(int result, int paymentType, int discount, int totalAmount, ulong transactionID)
        {
            // Obsługa funkcji zwrotnej w kontekście UI
            Invoke(new Action(() =>
            {
                // Tutaj umieść logikę obsługi funkcji zwrotnej w formularzu
                // ...

                // Przykład: Wyświetlenie komunikatu z informacjami zwrotnymi
                MessageBox.Show($"Result: {result}\nPayment Type: {paymentType}\nDiscount: {discount}\nTotal Amount: {totalAmount}\nTransaction ID: {transactionID}");
            }));
        }

        void getConfig()
        {
            textBoxDbHost.Text = dbHost;
            textBoxDbName.Text = dbName;
            textBoxDbUser.Text = dbUser;
            textBoxDbPass.Text = dbPass;
            textBoxComNumber.Text = comNumber;

        }


        private void btnSaveDbConfig_Click(object sender, EventArgs e)
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

                getConfig();
            }
            catch (Exception ex)
            {
                string msg = string.Format("Błąd podczas zapisu \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSaveRsConfig_Click(object sender, EventArgs e)
        {

            try
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings["rs_com_number"].Value = textBoxComNumber.Text;

                configuration.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                comNumber = ConfigurationManager.AppSettings["com_number"];

                MessageBox.Show("Zmiany zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getConfig();
            }
            catch (Exception ex)
            {
                string msg = string.Format("Błąd podczas zapisu \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {

 

            /*            var dbHost = ConfigurationManager.AppSettings["db_host"];
                        var dbName = ConfigurationManager.AppSettings["db_name"];
                        var dbUser = ConfigurationManager.AppSettings["db_user"];
                        var dbPass = ConfigurationManager.AppSettings["db_pass"];*/

            // Data Source=DESKTOP-Q2O4CJ3\SQL2019;Initial Catalog=BB_06_AUT_23;Persist Security Info=True;User ID=sa

            try
            {
                progressBarDb.Value = 0;
                SqlConnection connection = new SqlConnection("Data Source=" + dbHost + ";Database=" + dbName + ";User Id=" + dbUser + ";Password=" + dbPass);

                progressBarDb.Value = 10;

                connection.Open();

                progressBarDb.Value = 20;

                if (connection.State == System.Data.ConnectionState.Open)
                {

                    this.loadDataDbCards(connection);

                    progressBarDb.Value = 30;
                    //string symbol = string.Format("AUT");

                    SqlCommand command = new SqlCommand($"SELECT TOP 1 Symbol, Opis FROM NSysLokal WHERE FlgCentrala = 1", connection);
                    progressBarDb.Value = 40;

                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    progressBarDb.Value = 50;
                    //if (sqlDataReader.Read()) {
                    //  sqlDataReader.Close();
                    //MessageBox.Show($"Witaj {symbol}!");
                    //}

                    // Call Read before accessing data.
                    while (sqlDataReader.Read())
                    {
                        ReadSingleRow((IDataRecord)sqlDataReader);
                    }
                    progressBarDb.Value = 100;
                    progressBarDb.ForeColor = Color.Green;
                    // Call Close when done reading.
                    sqlDataReader.Close();

                    labelDbResult.Text = "OK";

                    // // this.nGastroKartaTableAdapter.Fill(this.ngastroKartaDataSet.NGastroKarta);
                }

            }
            catch (Exception ex)
            {

                progressBarDb.Value = 10;
                progressBarDb.ForeColor = Color.Red;

                string msg = string.Format("Błąd podczas próby połaczenia \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }

        }

        public void loadDataDbCards(SqlConnection connection)
        {
            //using (SqlConnection connection = new SqlConnection(connectionString) //use your connection string here
            //{
            var bindingSource = new BindingSource();
            string queryString = "SELECT * FROM dbo.NgastroKarta WHERE FlgBlokada=0";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection))
            {
                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = bindingSource;
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
        }

        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            string str = String.Format("{0}, {1}", dataRecord[0], dataRecord[1]);
            Console.WriteLine(str);
            MessageBox.Show($"Rezultat {str}. \nJeśli widzisz ten komunikat znaczy że połaczono z bazą poprawnie");

        }



        private void Form1_Load(object sender, EventArgs e)
        {


            televendInit();

        }

        private void televendInit()
        {
            int comInt = Int32.Parse(comNumber);

            // Wywołaj funkcję inicjalizacyjną
            int result = TelevendInterface.TelevendInit(comInt, TelevendCallback );

            // Sprawdź wynik inicjalizacji
            if (result == 0)
            {
                // Inicjalizacja powiodła się
                MessageBox.Show("Połączono z Televend BOX!");
                progressBarRs.Value = 100;
                progressBarRs.ForeColor = Color.Green;
            }
            else
            {
                // Inicjalizacja nie powiodła się
                MessageBox.Show("Brak połączenia");
                progressBarRs.Value = 100;
                progressBarRs.ForeColor = Color.Red;
            }
        }

        // Funkcja zwrotna (callback), którą możesz przekazać do DLL-a
/*        private void TelevendCallback(int result)
        {
            // Obsługa zwrotu funkcji, np. wyświetlenie komunikatu
            MessageBox.Show($"Zwrot funkcji z wynikiem: {result}");

            // ParseTelevendCallback(result);

        }*/
 
        private  void TelevendCallback(int result, int paymentType, int discount, int totalAmount, ulong transactionID)
        {
            // Handle the callback result
            switch (result)
            {
                case 0:
                    MessageBox.Show("Payment Approved");
                    break;
                case -1:
                    MessageBox.Show("Payment Authorization Timeout");
                    break;
                case -2:
                    MessageBox.Show("Payment Authorization Rejected - Not Enough Credit");
                    break;
                case -3:
                    MessageBox.Show("No Response from Televend Box (Local Communication Failure)");
                    break;
                case -4:
                    MessageBox.Show("Payment Canceled by User");
                    break;
                case -9:
                    MessageBox.Show("Payment Denied with Unspecified Reason");
                    break;
                default:
                    MessageBox.Show($"Unknown Result: {result}");
                    break;
            }

            // Handle additional information
            MessageBox.Show($"Payment Type: {paymentType}");
            MessageBox.Show($"Discount: {discount}");
            MessageBox.Show($"Total Amount: {totalAmount}");
            MessageBox.Show($"Transaction ID: {transactionID}");
        } 





        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool mousePointerNotInTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && mousePointerNotInTaskbar)
            {
                // notifyIcon1.Icon = Resources televend_logo_ico;
                notifyIcon1.BalloonTipText = "Integration televend is running in System Tray";
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

                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }

        }


        private void btnTelevendDenit_Click(object sender, EventArgs e)
        {
            // Wywołaj funkcję deinicjalizacyjną
            TelevendInterface.TelevendDeinit();
            progressBarRs.Value = 10;
            progressBarRs.ForeColor = Color.Red;
            progressBarRs.BackColor = Color.Red;

            // Inne działania związane z zakończeniem
            // ...
        }

        private void btnTelevendStatus_Click(object sender, EventArgs e)
        {
            // Wywołaj funkcję sprawdzającą status
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


        private void btnTelevendInit_Click(object sender, EventArgs e)
        {

            televendInit();
        }

        private void btnTelevendGetPricingGroup_Click(object sender, EventArgs e)
        {
            textBoxCardNumber.Text = string.Empty;

            // 12006942281

            //availableCredit

            // Call the function to get pricing group information
            int pricingGroup = TelevendInterface.TelevendGetPricingGroup(out uint availableCredit, out uint cardID);

            textBoxCardNumber.Text = cardID.ToString();

            // Check the result and display information
            switch (pricingGroup)
            {
                case -1:
                    MessageBox.Show("Not Initialized");
                    break;
                case -2:
                    MessageBox.Show("No Communication");
                    break;
                case -4:
                    MessageBox.Show("Pricing Group Unknown/Not Available");
                    break;
                default:
                    textBoxCardNumber.Text = cardID.ToString();
                    MessageBox.Show($"Pricing Group: {pricingGroup}\nAvailable Credit: {availableCredit}\nCard ID: {cardID}");
                    break;
            }
        }

        private void btnTelevendRequestPayment_Click(object sender, EventArgs e)
        {
            // Specify the requested amount in minimal monetary units (for example, 100 = 1.00 EUR)
            int requestedAmount = 100;

            // Call the function to request payment authorization
            int result = TelevendInterface.TelevendRequest(requestedAmount);

            // Check the result and take appropriate actions
            switch (result)
            {
                case 0:
                    MessageBox.Show("Payment Request Accepted");
                    // The callback function will be called for approval/denial
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

        private void btnTelevendRequest_Click(object sender, EventArgs e)
        {
            int requestedAmount = Int32.Parse(textBoxTelevendAmount.Text) * 100;

            // Call the function to request payment authorization
            int result = TelevendInterface.TelevendRequest(requestedAmount);

            // Check the result and take appropriate actions
            switch (result)
            {
                case 0:
                    MessageBox.Show("Payment Request Accepted");
                    // The callback function will be called for approval/denial
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
}
