using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Interfaces;
using StockMonitoringCommunity.Models;
using StockMonitoringCommunity.Services;
using StockMonitoringCommunity.SubForm;

namespace StockMonitoringCommunity
{
    public partial class MainForm : Form
    {
        private ComportUserForm _comportUserForm;
        private InputPatternUserForm _inputPatternUserForm;
        private ConnectServerUserForm _connectServerUserForm;
        private InputMonitorUserForm _inputMonitorUserForm;



        public MainForm()
        {
            InitializeComponent();

            _comportUserForm = new ComportUserForm();
            _inputPatternUserForm = new InputPatternUserForm();
            _connectServerUserForm = new ConnectServerUserForm();
            _inputMonitorUserForm = new InputMonitorUserForm();

        }

        

        #region Docking form
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

        #endregion


        #region Initial setup

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitialSetup();

            UiEventBus.MessagePublished += OnMessage;
        }


        private void OnMessage(UiMessage msg)
        {
            switch (msg.Key)
            {
                case "MAIN_FORM_CH1_STATUS":
                    if (msg.Data is not Color color1)
                        return;
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => button1.BackColor = color1));
                    }
                    else
                    {
                        button1.BackColor = color1;
                    }
                    break;
                case "MAIN_FORM_CH2_STATUS":
                    if (msg.Data is not Color color2)
                        return;
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => button2.BackColor = color2));
                    }
                    else
                    {
                        button2.BackColor = color2;
                    }
                    break;
                case "MAIN_FORM_CH3_STATUS":
                    if (msg.Data is not Color color3)
                        return;
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => button3.BackColor = color3));
                    }
                    else
                    {
                        button3.BackColor = color3;
                    }
                    break;
                case "MAIN_FORM_CH4_STATUS":
                    if (msg.Data is not Color color4)
                        return;
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => button4.BackColor = color4));
                    }
                    else
                    {
                        button4.BackColor = color4;
                    }
                    break;
                case "MAIN_FORM_CH5_STATUS":
                    if (msg.Data is not Color color5)
                        return;
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => button5.BackColor = color5));
                    }
                    else
                    {
                        button5.BackColor = color5;
                    }
                    break;
                case "MAIN_FORM_CH6_STATUS":
                    if (msg.Data is not Color color6)
                        return;
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => button6.BackColor = color6));
                    }
                    else
                    {
                        button6.BackColor = color6;
                    }
                    break;
                case "MAIN_FORM_CH1_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => textBox1.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        textBox1.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH2_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => textBox2.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        textBox2.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH3_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => textBox3.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        textBox3.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH4_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => textBox4.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        textBox4.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH5_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => textBox5.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        textBox5.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH6_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => textBox6.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        textBox6.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH1_RESET":
                    SerialService.Close();
                    InitialSetup();
                    break;
                default:
                    break;

            }


        }


        private async void InitialSetup()
        {
            Parameter.ComportPattenList.Clear();
            Parameter.InputPatternList.Clear();

            using (var db = new AppDbContext())
            {
                var comp = await db.Comports.ToListAsync();
                foreach (var c in comp)
                {
                    if (c.Enable == false)
                    {
                        continue;
                    }
                    switch (c.Channel_ID)
                    {
                        case 1:
                            SerialService.OpenPort1(c);
                            break;
                        case 2:
                            SerialService.OpenPort2(c);
                            break;
                        case 3:
                            SerialService.OpenPort3(c);
                            break;
                        case 4:
                            SerialService.OpenPort4(c);
                            break;
                        case 5:
                            SerialService.OpenPort5(c);
                            break;
                        case 6:
                            SerialService.OpenPort6(c);
                            break;
                        default:
                            break;
                    }

                    Parameter.ComportPattenList.Add(new ComportPatten 
                    {
                        Channel_ID = c.Channel_ID,
                        Setting = $"{c.Direction},{c.PortName},{c.Baudrate},{c.DataBits},{c.Stopbit},{c.Parity},Hand.{c.Handshake},Enable.{c.Enable}",
                        Pattern1 = c.Pattern1,
                         Pattern2 = c.Pattern2,
                        Pattern3 = c.Pattern3,
                        Pattern4 = c.Pattern4,
                        Pattern5 = c.Pattern5,
                        Pattern6 = c.Pattern6,
                    });

                }
                Parameter.InputPatternList = await db.InputPatterns.ToListAsync();
            }

        }

       

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UiEventBus.MessagePublished -= OnMessage;
        }


        #endregion
    }
}
