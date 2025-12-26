using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Models;
using StockMonitoringCommunity.Services;

namespace StockMonitoringCommunity.SubForm
{
    public partial class InputMonitorUserForm : UserControl
    {
        public InputMonitorUserForm()
        {
            InitializeComponent();
        }

        private void InputMonitorUserForm_Load(object sender, EventArgs e)
        {
            UiEventBus.MessagePublished += OnMessage;

            txtCOM1.Text = Parameter.ComportPattenList.Where(x => x.Channel_ID == 1).FirstOrDefault()?.Setting?.ToString();
            txtCOM2.Text = Parameter.ComportPattenList.Where(x => x.Channel_ID == 2).FirstOrDefault()?.Setting?.ToString();
            txtCOM3.Text = Parameter.ComportPattenList.Where(x => x.Channel_ID == 3).FirstOrDefault()?.Setting?.ToString();
            txtCOM4.Text = Parameter.ComportPattenList.Where(x => x.Channel_ID == 4).FirstOrDefault()?.Setting?.ToString();
            txtCOM5.Text = Parameter.ComportPattenList.Where(x => x.Channel_ID == 5).FirstOrDefault()?.Setting?.ToString();
            txtCOM6.Text = Parameter.ComportPattenList.Where(x => x.Channel_ID == 6).FirstOrDefault()?.Setting?.ToString();
        }

        private void OnMessage(UiMessage msg)
        {
            switch (msg.Key)
            {
                case "CH1_STATUS":
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
                case "CH2_STATUS":
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
                case "CH3_STATUS":
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
                case "CH4_STATUS":
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
                case "CH5_STATUS":
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
                case "CH6_STATUS":
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
                case "CH1_COM":

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtCOM1.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtCOM1.Text = msg.Data?.ToString();

                    }
                    break;
                case "CH2_COM":

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtCOM2.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtCOM2.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH3_COM":

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtCOM3.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtCOM3.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH4_COM":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtCOM4.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtCOM4.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH5_COM":

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtCOM5.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtCOM5.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH6_COM":

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtCOM6.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtCOM6.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH1_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtdata1.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtdata1.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH2_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtdata2.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtdata2.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH3_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtdata3.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtdata3.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH4_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtdata4.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtdata4.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH5_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtdata5.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtdata5.Text = msg.Data?.ToString();
                    }
                    break;
                case "MAIN_FORM_CH6_DATA":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtdata6.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtdata6.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH1_RAW":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtraw1.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtraw1.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH2_RAW":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtraw2.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtraw2.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH3_RAW":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtraw3.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtraw3.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH4_RAW":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtraw4.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtraw4.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH5_RAW":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtraw5.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtraw5.Text = msg.Data?.ToString();
                    }
                    break;
                case "CH6_RAW":
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => txtraw6.Text = msg.Data?.ToString()));
                    }
                    else
                    {
                        txtraw6.Text = msg.Data?.ToString();
                    }
                    break;
                default:
                    break;

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SerialService.serialPort1.IsOpen)
            {
                button1.BackColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                button1.BackColor = Color.Empty;
            }




        }
    }
}
