using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Interfaces;
using StockMonitoringCommunity.Models;
using StockMonitoringCommunity.SubForm;
using System.IO.Ports;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StockMonitoringCommunity
{
    public partial class MainForm : Form
    {
        private ComportUserForm _comportUserForm;
        private InputPatternUserForm _inputPatternUserForm;
        private ConnectServerUserForm _connectServerUserForm;
        private InputMonitorUserForm _inputMonitorUserForm;


        private static readonly SerialPort serialPort1 = new SerialPort();
        private static readonly SerialPort serialPort2 = new SerialPort();
        private static readonly SerialPort serialPort3 = new SerialPort();
        private static readonly SerialPort serialPort4 = new SerialPort();
        private static readonly SerialPort serialPort5 = new SerialPort();
        private static readonly SerialPort serialPort6 = new SerialPort();

        private static StringBuilder buffer1 = new StringBuilder();
        private static StringBuilder buffer2 = new StringBuilder();
        private static StringBuilder buffer3 = new StringBuilder();
        private static StringBuilder buffer4 = new StringBuilder();
        private static StringBuilder buffer5 = new StringBuilder();
        private static StringBuilder buffer6 = new StringBuilder();

        private static MainForm Instance = null!;


        public static event Action<string>? DataReceived;



        public MainForm()
        {
            InitializeComponent();
            DataReceived += SerialService_DataReceived;

            _comportUserForm = new ComportUserForm();
            _inputPatternUserForm = new InputPatternUserForm();
            _connectServerUserForm = new ConnectServerUserForm();
            _inputMonitorUserForm = new InputMonitorUserForm();
        }
        private void SerialService_DataReceived(string text)
        {
            UpdateText(text);
        }

        // 🔹 อัปเดต UI อย่างปลอดภัย
        private void UpdateText(string text)
        {
            if (textBox1.IsDisposed || !textBox1.IsHandleCreated)
                return;

            if (textBox1.InvokeRequired)
            {
                textBox1.BeginInvoke(() =>
                {
                    textBox1.AppendText(text + Environment.NewLine);
                });
            }
            else
            {
                textBox1.AppendText(text + Environment.NewLine);
            }
        }
        private void StateHub_OnChanged(string key, object value)
        {
            if (key == "Postsetting")
            {
                if ((int)value == 1)
                {
                    SerialPortSetting.Close(serialPort1);
                    Reset_status((int)value);


                    LoadSettingAndOpenSerialPort(1, serialPort1);
                }
            }
        }
        private void Reset_status(int ch)
        {
            switch (ch)
            {
                case 1:
                    button1.BackColor = Color.FromArgb(225, 225, 225);
                    StateHub.Raise("ch1_status", Color.FromArgb(255, 255, 255));
                    StateHub.Raise("ch1_com", "");

                    break;
                default:
                    break;
            }
        }

        private void serialCOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _comportUserForm = new ComportUserForm
            {
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(_comportUserForm);
        }

        private void inputPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _inputPatternUserForm = new InputPatternUserForm
            {
                Dock = DockStyle.Fill
            };
            panelMain.Controls.Clear();
            panelMain.Controls.Add(_inputPatternUserForm);
        }

        private void connectionToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _connectServerUserForm = new ConnectServerUserForm
            {
                Dock = DockStyle.Fill
            };
            panelMain.Controls.Clear();
            panelMain.Controls.Add(_connectServerUserForm);
        }

        private void serialCOMPortMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _inputMonitorUserForm = new InputMonitorUserForm
            {
                Dock = DockStyle.Fill
            };
            panelMain.Controls.Clear();
            panelMain.Controls.Add(_inputMonitorUserForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitialSetup();
            //_uiContext = SynchronizationContext.Current!;

        }

        #region Initial setup

        private void InitialSetup()
        {

            TimerTickStop();

            LoadSettingAndOpenSerialPort(1, serialPort1);

            //Loadpattern();

        }
        private void TimerTickStop()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
        }
        private async void LoadSettingAndOpenSerialPort(int port, SerialPort serialPort)
        {
            try
            {
                var comp = new Comport();
                using (var db = new AppDbContext())
                {
                    comp = await db.Comports.Where(x => x.Channel_ID == port).FirstOrDefaultAsync();
                }

                if (comp != null)
                {
                    string comport = comp.PortName;
                    string BaudRate = comp.Baudrate;
                    string DataBits = comp.DataBits;
                    string stopbit = comp.Stopbit;
                    string parity = comp.Parity;
                    string mode = comp.Direction;
                    string handshake = comp.Handshake;

                    serialPort.PortName = comp.PortName;
                    serialPort.BaudRate = Convert.ToInt32(comp.Baudrate);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                    serialPort.DataBits = Convert.ToInt16(comp.DataBits);

                    //serialPort.Encoding = System.Text.Encoding.UTF8;
                    serialPort.Encoding = Encoding.ASCII; // Thai
                    serialPort.DtrEnable = true;
                    serialPort.RtsEnable = true;

                    //serialPort.Handshake = Handshake.None;
                    serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);

                    int maxRetries = 3;
                    const int sleepTimeInMs = 500;
                    while (maxRetries > 0)
                    {
                        try
                        {
                            serialPort.Open();
                            if (serialPort.IsOpen)
                            {
                                serialPort.DiscardInBuffer();
                                switch (port)
                                {
                                    case 1:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler1);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        StateHub.Raise("ch1_status", Color.FromArgb(0, 255, 0));
                                        timer1.Enabled = true;
                                        //Parameter.Direction1 = mode;
                                        var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch1_com", setting1);

                                        break;
                                    case 2:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        //Parameter.Direction2 = mode;
                                        var setting2 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch2_com", setting2);
                                        timer2.Enabled = true;
                                        break;
                                    case 3:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler3);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        var setting3 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch3_com", setting3);
                                        timer3.Enabled = true;
                                        //Parameter.Direction3 = mode;
                                        break;
                                    case 4:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler4);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        var setting4 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch4_com", setting4);
                                        timer4.Enabled = true;
                                        //Parameter.Direction4 = mode;
                                        break;
                                }

                                break;
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            maxRetries--;
                            Thread.Sleep(sleepTimeInMs);
                        }
                        catch (Exception exception)
                        {
                            maxRetries--;
                            Console.WriteLine(exception.Message);
                        }
                    }

                    if (maxRetries != 3)
                    {
                        Console.WriteLine("maxRetries:{0}", maxRetries);
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }

        }

        private static void DataReceivedHandler1(object sender, SerialDataReceivedEventArgs e)
        {


            var ReadingText = serialPort1.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer1.Append(ReadingText);

            string result = buffer1.ToString();

            if (buffer1.ToString().EndsWith("\r")) // && buffer1.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer1.ToString().Trim();

                buffer1.Clear();

                //StateHub.Raise("Portsetting_ch1", result);
                //StateHub.Raise("ch1_raw", result);
                //StateHub.Raise("raw_message", result);

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                DataReceived?.Invoke(text_part);

                //StateHub.Raise("ch1_data", text_part);

                serialPort1.DiscardInBuffer();
            }


        }



        private static void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            var ReadingText = serialPort2.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer1.Append(ReadingText);

            string result = buffer2.ToString();

            if (buffer2.ToString().EndsWith("\r") && buffer2.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer2.ToString().Trim();

                buffer2.Clear();

                //if (Instance.richTextBox2.InvokeRequired)
                //{
                //    Instance.richTextBox2.Invoke(new Action(() =>
                //    {
                //        Instance.richTextBox2.Text = result_clean;
                //    }));
                //}

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                if (Instance.textBox2.InvokeRequired)
                {
                    Instance.textBox2.Invoke(new Action(() =>
                    {
                        Instance.textBox2.Text = text_part;
                    }));
                }

                //Counter2++;
                serialPort2.DiscardInBuffer();
                //Console.WriteLine("Data Received Port 1:{0} : {1}", Counter2, result);
            }
        }

        private static void DataReceivedHandler3(object sender, SerialDataReceivedEventArgs e)
        {
            var ReadingText = serialPort3.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer3.Append(ReadingText);

            string result = buffer3.ToString();

            if (buffer3.ToString().EndsWith("\r") && buffer3.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer3.ToString().Trim();

                buffer3.Clear();

                //if (Instance.richTextBox3.InvokeRequired)
                //{
                //    Instance.richTextBox3.Invoke(new Action(() =>
                //    {
                //        Instance.richTextBox3.Text = result_clean;
                //    }));
                //}

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                if (Instance.textBox3.InvokeRequired)
                {
                    Instance.textBox3.Invoke(new Action(() =>
                    {
                        Instance.textBox3.Text = text_part;
                    }));
                }

                //Counter3++;
                serialPort3.DiscardInBuffer();
                //Console.WriteLine("Data Received Port 1:{0} : {1}", Counter3, result);
            }
        }

        private static void DataReceivedHandler4(object sender, SerialDataReceivedEventArgs e)
        {
            var ReadingText = serialPort4.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer4.Append(ReadingText);

            string result = buffer4.ToString();

            if (buffer4.ToString().EndsWith("\r") && buffer4.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer4.ToString().Trim();

                buffer4.Clear();

                //if (Instance.richTextBox4.InvokeRequired)
                //{
                //    Instance.richTextBox4.Invoke(new Action(() =>
                //    {
                //        Instance.richTextBox4.Text = result_clean;
                //    }));
                //}

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                if (Instance.textBox4.InvokeRequired)
                {
                    Instance.textBox4.Invoke(new Action(() =>
                    {
                        Instance.textBox4.Text = text_part;
                    }));
                }

                //Counter4++;
                serialPort4.DiscardInBuffer();
                //Console.WriteLine("Data Received Port 1:{0} : {1}", Counter4, result);
            }
        }



        #endregion
    }
}
