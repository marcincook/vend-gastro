using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


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

            
        }


        private void btnSaveConfig_Click(object sender, EventArgs e)
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

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {

            var dbHost = ConfigurationManager.AppSettings["db_host"]; 
            var dbName = ConfigurationManager.AppSettings["db_name"]; 
            var dbUser = ConfigurationManager.AppSettings["db_user"]; 
            var dbPass = ConfigurationManager.AppSettings["db_pass"];  

            try
            {
                progressBarDb.Value = 0;
                SqlConnection connection = new SqlConnection("Data Source=" + dbHost + ";Database=" + dbName + ";User Id=" + dbUser + ";Password=" + dbPass);

                progressBarDb.Value = 10;

                connection.Open();

                progressBarDb.Value = 20;

                if (connection.State == System.Data.ConnectionState.Open) {

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
                notifyIcon1.Icon = SystemIcons.Application;
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
    }
}
