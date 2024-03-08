using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms; 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        // [DllImport("C:\\Users\\Marcin\\source\\repos\\VendGastro\\TelevendPOS.dll")]


        // Check if the user has access to the requested DLL.
        public static string dllPath = Path.GetFullPath("C:\\Users\\Marcin\\source\\repos\\VendGastro\\TelevendPOS.dll");
 

        // Load the assembly from the specified path.
        // Assembly loadedAssembly = Assembly.LoadFrom(dllPath);

        // Now you can work with types and methods from the loaded assembly.
        // For example:
        // TelevendInit televendInit = loadedAssembly.GetType("TelevendInit");
        // object instance = Activator.CreateInstance(myType);
        // Invoke methods or access properties as needed.

        // int TelevendInit(int serial_port_number, TelevendCallback callback);


        string rsDataOut;
        string rsDataIn;


        public Form1()
        {
            InitializeComponent();
            actualConfig();
        }

        void actualConfig() {

            var dbHost = ConfigurationManager.AppSettings["db_host"];
            textBoxDbHost.Text = dbHost;

            var dbName = ConfigurationManager.AppSettings["db_name"];
            textBoxDbName.Text = dbName;

            var dbUser = ConfigurationManager.AppSettings["db_user"];
            textBoxDbUser.Text = dbUser;

            var dbPass = ConfigurationManager.AppSettings["db_pass"];
            textBoxDbPass.Text = dbPass;



            var rsComName = ConfigurationManager.AppSettings["rs_com_name"];
            comboBoxCom.Text = rsComName;

            var rsBaudRate = ConfigurationManager.AppSettings["rs_baud_rate"];
            comboBoxBaudRate.Text = rsBaudRate;

            var rsDataBits = ConfigurationManager.AppSettings["rs_data_bits"];
            comboBoxDataBits.Text = rsDataBits;

            var rsStopBits = ConfigurationManager.AppSettings["rs_stop_bits"];
            comboBoxStopBits.Text = rsStopBits;

            var rsParityBits = ConfigurationManager.AppSettings["rs_parity_bits"];
            comboBoxParityBits.Text = rsParityBits;

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

                MessageBox.Show("Zmiany zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualConfig();
            }
            catch(Exception ex)
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
                configuration.AppSettings.Settings["rs_com_name"].Value = comboBoxCom.Text;
                configuration.AppSettings.Settings["rs_baud_rate"].Value = comboBoxBaudRate.Text;
                configuration.AppSettings.Settings["rs_data_bits"].Value = comboBoxDataBits.Text;
                configuration.AppSettings.Settings["rs_stop_bits"].Value = comboBoxStopBits.Text;
                configuration.AppSettings.Settings["rs_parity_bits"].Value = comboBoxParityBits.Text;

                configuration.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                MessageBox.Show("Zmiany zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualConfig();
            }
            catch (Exception ex)
            {
                string msg = string.Format("Błąd podczas zapisu \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {

            var dbHost = ConfigurationManager.AppSettings["db_host"]; 
            var dbName = ConfigurationManager.AppSettings["db_name"]; 
            var dbUser = ConfigurationManager.AppSettings["db_user"]; 
            var dbPass = ConfigurationManager.AppSettings["db_pass"];

            // Data Source=DESKTOP-Q2O4CJ3\SQL2019;Initial Catalog=BB_06_AUT_23;Persist Security Info=True;User ID=sa

            try
            {
                progressBarDb.Value = 0;
                SqlConnection connection = new SqlConnection("Data Source=" + dbHost + ";Database=" + dbName + ";User Id=" + dbUser + ";Password=" + dbPass);

                progressBarDb.Value = 10;

                connection.Open();

                progressBarDb.Value = 20;

                if (connection.State == System.Data.ConnectionState.Open) {

                    this.loadDataKarty(connection);

                    progressBarDb.Value = 30;
                    string symbol = string.Format("AUT");

                    SqlCommand command = new SqlCommand($"SELECT TOP 1 Symbol, Opis FROM NSysLokal WHERE Symbol = '{symbol}'",connection);
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
            catch(Exception ex)
            {
                string msg = string.Format("Błąd podczas próby połaczenia \n{0}", ex.Message);

                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progressBarDb.Value = 100;
                progressBarDb.ForeColor = Color.Red;


            }

        }

        public void loadDataKarty(SqlConnection connection)
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


        // https://learn.microsoft.com/en-us/dotnet/api/system.io.ports.serialport?view=dotnet-plat-ext-7.0 

        private void btnCheckRs_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port); 
            }

            Console.ReadLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ngastroKartaDataSet.NGastroKarta' . Możesz go przenieść lub usunąć.
            // this.nGastroKartaTableAdapter.Fill(this.ngastroKartaDataSet.NGastroKarta);
            string[] ports = SerialPort.GetPortNames();
            comboBoxCom.Items.AddRange(ports);
            buttonRsOpen.Enabled = true;
            buttonRsClose.Enabled = false;
            buttonRsSendData.Enabled = false;

        }

        private void buttonRsOpen_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.PortName = comboBoxCom.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits.Text);

                serialPort1.Open();
                progressBarRs.Value = 100;

                buttonRsClose.Enabled = true;
                buttonRsOpen.Enabled = false;
                buttonRsSendData.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonRsClose.Enabled = false;
                buttonRsOpen.Enabled = true;
                buttonRsSendData.Enabled = false;
            }
        }

        private void buttonRsClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBarRs.Value = 0;
                buttonRsClose.Enabled = false;
                buttonRsOpen.Enabled = true;
            }
            else {
                buttonRsClose.Enabled = false;
                buttonRsOpen.Enabled = true;
            }
            buttonRsSendData.Enabled = false;
        }

  

        // https://stackoverflow.com/questions/957337/what-is-the-difference-between-dtr-dsr-and-rts-cts-flow-control 
        private void buttonRsSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                rsDataOut = textBoxRsDataOut.Text;
                serialPort1.Write(rsDataOut);
                 
            }

        }

        private void buttonRsClearData_Click(object sender, EventArgs e)
        {
            if (textBoxRsDataOut.Text != "") {
                textBoxRsDataOut.Text = "";
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            rsDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));

        }

        private void ShowData(object sender, EventArgs e)
        {
            textBoxRsDataIn.Text += rsDataIn;
        }

        private void buttonRsClearDataIn_Click(object sender, EventArgs e)
        {
            textBoxRsDataIn.Text = "";

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool mousePointerNotInTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && mousePointerNotInTaskbar) {
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

            if (this.WindowState == FormWindowState.Normal) {

                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridView1.Columns[0].Selected = true;
            //dataGridView1.Rows[0].Selected = true;

            //dataGridView1.CurrentCell = dataGridView1[1,2];

            var str = dataGridView1.CurrentCell.Value.ToString();


            textBoxRsDataOut.Text = str;


            MessageBox.Show(str, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}
