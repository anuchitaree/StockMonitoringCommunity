using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Interfaces;
using StockMonitoringCommunity.Models;
using StockMonitoringCommunity.Services;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace StockMonitoringCommunity.SubForm
{
    public partial class ComportUserForm : UserControl
    {
        private bool _formLoaded = false;
        private BindingList<ScanList> scanLists = new();
        private int rowIndex = 0;
        public ComportUserForm()
        {
            InitializeComponent();
        }
        int channel_number;
        public void SetData(int Channel)
        {
            channel_number = Channel;
        }


        private void ComportUserForm_Load(object sender, EventArgs e)
        {
            COMPort();
            LoadSettingfile(1);
            string[] head = new string[] { "Id", "Channel", "Raw", "Partnumber", "Timestamp" };
            int[] width = new int[] { 50, 50, 300,200,200 };
            InitialDatagridview.Pattern_1(head, width, dataGridView1);
            UiEventBus.MessagePublished += OnMessage;
            scanLists.Clear();

            dataGridView1.DataSource = scanLists;
            _formLoaded = true;
        }
        private void OnMessage(UiMessage msg)
        {
            switch (msg.Key)
            {
                case "COMPORT_UC_CH1_RAW":

                    var ch = msg.MoreExtraData?.ToString()!;
                   var raw = msg.Data?.ToString()!;
                    var partnumber = msg.ExtraData?.ToString()!;
                    var item = new ScanList
                    {
                        Id = rowIndex++,
                        Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        Channel = ch.ToString(),
                        Raw = raw,
                        Partnumber = partnumber
                    };

                    if (InvokeRequired)
                    {
                        Invoke(() => scanLists.Insert(0,item));
                    }
                    else
                    {
                        scanLists.Insert(0,item);
                    }

                    break;
              
                default:
                    break;

            }


        }

        private void addlist(string raw,string partnumber,string ch)
        {
            scanLists.Add(new ScanList
            {
                Id = rowIndex++,
                Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Channel = ch.ToString(),
                Raw = raw,
                Partnumber = partnumber
            });
            dataGridView1.DataSource = scanLists;

        }
        private void COMPort()
        {
            for (int i = 1; i < 100; i++)
            {
                string str = string.Format("COM{0}", i);
                cmbCom.Items.Add(str);
            }

            cmbCh.DataSource = Enumerable.Range(1, 6).ToList();
            cmbCh.SelectedIndex = 0;
            cmbCom.SelectedIndex = 0;
            string[] baudrate = new string[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" };
            string[] parity = new string[] { "None", "Even", "Odd" };
            string[] lenght = new string[] { "7", "8", "9" };
            string[] stopbit = new string[] { "1", "1.5", "2" };
            string[] direction = new string[] { "IN", "OUT" };
            string[] handshake = new string[] { "None", "XOnXOff", "RequestToSend", "RequestToSendXOnXOff" };
            string[] enable = new string[] { "Disable", "Enable" };
            cmbBaudrate.DataSource = baudrate;
            cmbParity.DataSource = parity;
            cmbLength.DataSource = lenght;
            cmbStop.DataSource = stopbit;
            cmbHand.DataSource = handshake;
            cmbInput.DataSource = direction;
            cmbPatt1.DataSource = Enumerable.Range(0, 10).ToList();
            cmbPatt2.DataSource = Enumerable.Range(0, 10).ToList();
            cmbPatt3.DataSource = Enumerable.Range(0, 10).ToList();
            cmbPatt4.DataSource = Enumerable.Range(0, 10).ToList();
            cmbPatt5.DataSource = Enumerable.Range(0, 10).ToList();
            cmbPatt6.DataSource = Enumerable.Range(0, 10).ToList();
            cmbEnable.DataSource = enable;



        }
        private void LoadSettingfile(int channel_number)
        {
            using (var db = new AppDbContext())
            {
                var setting = db.Comports.Where(x => x.Channel_ID == channel_number).ToList().FirstOrDefault();
                if (setting != null)
                {
                    cmbCom.SelectedItem = setting.PortName;
                    cmbBaudrate.SelectedItem = setting.Baudrate;
                    cmbParity.SelectedItem = setting.Parity;
                    cmbLength.SelectedItem = setting.DataBits;
                    cmbStop.SelectedItem = setting.Stopbit;
                    cmbInput.SelectedItem = setting.Direction;

                    cmbHand.SelectedItem = setting.Handshake;
                    cmbPatt1.SelectedItem = setting.Pattern1;
                    cmbPatt2.SelectedItem = setting.Pattern2;
                    cmbPatt3.SelectedItem = setting.Pattern3;
                    cmbPatt4.SelectedItem = setting.Pattern4;
                    cmbPatt5.SelectedItem = setting.Pattern5;
                    cmbPatt6.SelectedItem = setting.Pattern6;

                    cmbEnable.SelectedItem = setting.Enable == true ? "Enable" : "Disable";
                    txtLastedit.Text = (setting.CreatedAt).ToString("yyyy-MM-dd HH:mm:ss");
                    label1.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    label1.BackColor = System.Drawing.Color.LightCoral;
                    cmbCom.SelectedIndex = -1;
                    cmbBaudrate.SelectedIndex = -1;
                    cmbParity.SelectedIndex = -1;
                    cmbLength.SelectedIndex = -1;
                    cmbStop.SelectedIndex = -1;
                    cmbInput.SelectedIndex = -1;
                    cmbHand.SelectedIndex = -1;
                    cmbPatt1.SelectedIndex = -1;
                    cmbPatt2.SelectedIndex = -1;
                    cmbPatt3.SelectedIndex = -1;
                    cmbPatt4.SelectedIndex = -1;
                    cmbPatt5.SelectedIndex = -1;
                    cmbPatt6.SelectedIndex = -1;
                    cmbEnable.SelectedIndex = -1;
                    txtLastedit.Text = null;
                }
            }


        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var map = new Dictionary<string, bool>
                {
                { "Enable", true },
                { "Disable", false }
                };

                var channel_ID = int.Parse(cmbCh.SelectedItem!.ToString()!);
                var port_name = cmbCom.SelectedItem!.ToString()!;

                using (var db = new AppDbContext())
                {

                    var com_check = db.Comports.Where(x => x.PortName == port_name).ToList();
                    if (com_check.Count > 0)
                    {
                        if (com_check[0].Channel_ID != channel_ID)
                        {
                            MessageBox.Show("This COM port is already in use. Please select another COM port.", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    var comport = new Comport()
                    {
                        Channel_ID = channel_ID,
                        PortName = port_name,
                        Baudrate = cmbBaudrate.SelectedItem!.ToString()!,
                        DataBits = cmbLength.SelectedItem!.ToString()!,
                        Stopbit = cmbStop.SelectedItem!.ToString()!,
                        Parity = cmbParity.SelectedItem!.ToString()!,
                        Handshake = cmbHand.SelectedItem!.ToString()!,
                        Direction = cmbInput.SelectedItem!.ToString()!,
                        Pattern1 = int.Parse(cmbPatt1.SelectedItem!.ToString()!),
                        Pattern2 = int.Parse(cmbPatt2.SelectedItem!.ToString()!),
                        Pattern3 = int.Parse(cmbPatt3.SelectedItem!.ToString()!),
                        Pattern4 = int.Parse(cmbPatt4.SelectedItem!.ToString()!),
                        Pattern5 = int.Parse(cmbPatt5.SelectedItem!.ToString()!),
                        Pattern6 = int.Parse(cmbPatt6.SelectedItem!.ToString()!),
                        Enable = map[cmbEnable.Text],
                        CreatedAt = DateTime.UtcNow,
                    };
                    var setting = db.Comports.Where(x => x.Channel_ID == channel_ID).ToList().FirstOrDefault();
                    if (setting == null)
                    {
                        await db.Comports.AddAsync(comport);
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        setting.PortName = comport.PortName;
                        setting.Baudrate = comport.Baudrate;
                        setting.Stopbit = comport.Stopbit;
                        setting.Parity = comport.Parity;
                        setting.Direction = comport.Direction;
                        setting.DataBits = comport.DataBits;
                        setting.Stopbit = comport.Stopbit;
                        setting.Handshake = comport.Handshake;
                        setting.Pattern1 = comport.Pattern1;
                        setting.Pattern2 = comport.Pattern2;
                        setting.Pattern3 = comport.Pattern3;
                        setting.Pattern4 = comport.Pattern4;
                        setting.Pattern5 = comport.Pattern5;
                        setting.Pattern6 = comport.Pattern6;
                        setting.Enable = comport.Enable;
                        setting.CreatedAt = DateTime.UtcNow;
                        await db.SaveChangesAsync();
                    }

                }
                UiEventBus.Publish("MAIN_FORM_CH1_RESET", channel_ID);
                MessageBox.Show("Save setting completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //StateHub.Raise("Postsetting", channel_number);

            }
            catch (Exception ex)
            {
                var logger = ex.Message;
                MessageBox.Show("Save setting error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StateHub.Raise("Postsetting", channel_number);
        }

        private void cmbCh_TextChanged(object sender, EventArgs e)
        {
            if (!_formLoaded)
                return;
            LoadSettingfile(int.Parse(cmbCh.SelectedItem!.ToString()!));
        }




    }
}
