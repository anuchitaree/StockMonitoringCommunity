using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Interfaces;
using StockMonitoringCommunity.Models;
using System.IO.Ports;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public static class SerialService
    {
        public static readonly SerialPort serialPort1 = new SerialPort();
        public static readonly SerialPort serialPort2 = new SerialPort();
        public static readonly SerialPort serialPort3 = new SerialPort();
        public static readonly SerialPort serialPort4 = new SerialPort();
        public static readonly SerialPort serialPort5 = new SerialPort();
        public static readonly SerialPort serialPort6 = new SerialPort();

        private static StringBuilder buffer1 = new StringBuilder();
        private static StringBuilder buffer2 = new StringBuilder();
        private static StringBuilder buffer3 = new StringBuilder();
        private static StringBuilder buffer4 = new StringBuilder();
        private static StringBuilder buffer5 = new StringBuilder();
        private static StringBuilder buffer6 = new StringBuilder();





        public async static void OpenPort1(Comport comp)
        {
            try
            {
                if (true)
                {
                    serialPort1.PortName = comp.PortName;
                    serialPort1.BaudRate = int.Parse(comp.Baudrate);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                    serialPort1.DataBits = Convert.ToInt16(comp.DataBits);
                    serialPort1.Encoding = Encoding.ASCII; // Thai
                    serialPort1.DtrEnable = true;
                    serialPort1.RtsEnable = true;
                    serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);
                    int maxRetries = 3;
                    const int sleepTimeInMs = 500;
                    while (maxRetries > 0)
                    {
                        try
                        {
                            if (serialPort1.IsOpen == false)
                                serialPort1.Open();
                            if (serialPort1.IsOpen)
                            {
                                serialPort1.DiscardInBuffer();
                                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler1);
                                var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", comp.Direction, comp.PortName,
                                   comp.Baudrate, comp.DataBits, comp.Stopbit, comp.Parity, comp.Handshake);
                                UiEventBus.Publish("MAIN_FORM_CH1_COM", setting1);
                                UiEventBus.Publish("MAIN_FORM_CH1_STATUS", Color.FromArgb(0, 255, 0));
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
                            UiEventBus.Publish("MAIN_FORM_CH1_STATUS", Color.Empty);
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



        public async static void OpenPort2(Comport comp)
        {
            try
            {
                serialPort2.PortName = comp.PortName;
                serialPort2.BaudRate = int.Parse(comp.Baudrate);
                serialPort2.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                serialPort2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                serialPort2.DataBits = Convert.ToInt16(comp.DataBits);
                serialPort2.Encoding = Encoding.ASCII; // Thai
                serialPort2.DtrEnable = true;
                serialPort2.RtsEnable = true;
                serialPort2.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);
                int maxRetries = 3;
                const int sleepTimeInMs = 500;
                while (maxRetries > 0)
                {
                    try
                    {
                        if (serialPort2.IsOpen == false)
                            serialPort2.Open();
                        if (serialPort2.IsOpen)
                        {
                            serialPort2.DiscardInBuffer();
                            serialPort2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
                            StateHub.Raise("ch2_status", Color.FromArgb(0, 255, 0));
                            var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", comp.Direction, comp.PortName,
                                   comp.Baudrate, comp.DataBits, comp.Stopbit, comp.Parity, comp.Handshake);
                            UiEventBus.Publish("MAIN_FORM_CH2_COM", setting1);
                            UiEventBus.Publish("MAIN_FORM_CH2_STATUS", Color.FromArgb(0, 255, 0));
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
                        UiEventBus.Publish("MAIN_FORM_CH1_STATUS", Color.Empty);
                    }
                }

                if (maxRetries != 3)
                {
                    Console.WriteLine("maxRetries:{0}", maxRetries);
                }

            }
            catch (Exception)
            {
                //throw;
            }

        }

        public async static void OpenPort3(Comport comp)
        {
            try
            {
                serialPort3.PortName = comp.PortName;
                serialPort3.BaudRate = int.Parse(comp.Baudrate);
                serialPort3.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                serialPort3.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                serialPort3.DataBits = Convert.ToInt16(comp.DataBits);
                serialPort3.Encoding = Encoding.ASCII; // Thai
                serialPort3.DtrEnable = true;
                serialPort3.RtsEnable = true;
                serialPort3.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);
                int maxRetries = 3;
                const int sleepTimeInMs = 500;
                while (maxRetries > 0)
                {
                    try
                    {
                        if (serialPort3.IsOpen == false)
                            serialPort3.Open();
                        if (serialPort3.IsOpen)
                        {
                            serialPort3.DiscardInBuffer();
                            serialPort3.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler3);
                            StateHub.Raise("ch3_status", Color.FromArgb(0, 255, 0));
                            var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", comp.Direction, comp.PortName,
                                   comp.Baudrate, comp.DataBits, comp.Stopbit, comp.Parity, comp.Handshake);
                            UiEventBus.Publish("MAIN_FORM_CH3_COM", setting1);
                            UiEventBus.Publish("MAIN_FORM_CH3_STATUS", Color.FromArgb(0, 255, 0));
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
                        UiEventBus.Publish("MAIN_FORM_CH1_STATUS", Color.Empty);
                    }
                }

                if (maxRetries != 3)
                {
                    Console.WriteLine("maxRetries:{0}", maxRetries);
                }

            }
            catch (Exception)
            {
                //throw;
            }

        }

        public async static void OpenPort4(Comport comp)
        {
            try
            {
                serialPort4.PortName = comp.PortName;
                serialPort4.BaudRate = int.Parse(comp.Baudrate);
                serialPort4.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                serialPort4.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                serialPort4.DataBits = Convert.ToInt16(comp.DataBits);
                serialPort4.Encoding = Encoding.ASCII; // Thai
                serialPort4.DtrEnable = true;
                serialPort4.RtsEnable = true;
                serialPort4.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);
                int maxRetries = 3;
                const int sleepTimeInMs = 500;
                while (maxRetries > 0)
                {
                    try
                    {
                        if (serialPort4.IsOpen == false)
                            serialPort4.Open();
                        if (serialPort4.IsOpen)
                        {
                            serialPort4.DiscardInBuffer();
                            serialPort4.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler4);
                            StateHub.Raise("ch4_status", Color.FromArgb(0, 255, 0));
                            var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", comp.Direction, comp.PortName,
                                   comp.Baudrate, comp.DataBits, comp.Stopbit, comp.Parity, comp.Handshake);
                            UiEventBus.Publish("MAIN_FORM_CH4_COM", setting1);
                            UiEventBus.Publish("MAIN_FORM_CH4_STATUS", Color.FromArgb(0, 255, 0));
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
                        UiEventBus.Publish("MAIN_FORM_CH1_STATUS", Color.Empty);
                    }
                }

                if (maxRetries != 3)
                {
                    Console.WriteLine("maxRetries:{0}", maxRetries);
                }

            }
            catch (Exception)
            {
                //throw;
            }

        }

        public async static void OpenPort5(Comport comp)
        {
            try
            {
                serialPort5.PortName = comp.PortName;
                serialPort5.BaudRate = int.Parse(comp.Baudrate);
                serialPort5.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                serialPort5.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                serialPort5.DataBits = Convert.ToInt16(comp.DataBits);
                serialPort5.Encoding = Encoding.ASCII; // Thai
                serialPort5.DtrEnable = true;
                serialPort5.RtsEnable = true;
                serialPort5.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);
                int maxRetries = 3;
                const int sleepTimeInMs = 500;
                while (maxRetries > 0)
                {
                    try
                    {
                        if (serialPort5.IsOpen == false)
                            serialPort5.Open();
                        if (serialPort5.IsOpen)
                        {
                            serialPort5.DiscardInBuffer();
                            serialPort5.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler5);
                            StateHub.Raise("ch5_status", Color.FromArgb(0, 255, 0));
                            var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", comp.Direction, comp.PortName,
                                   comp.Baudrate, comp.DataBits, comp.Stopbit, comp.Parity, comp.Handshake);
                            UiEventBus.Publish("MAIN_FORM_CH5_COM", setting1);
                            UiEventBus.Publish("MAIN_FORM_CH5_STATUS", Color.FromArgb(0, 255, 0));
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
                        UiEventBus.Publish("MAIN_FORM_CH1_STATUS", Color.Empty);
                    }
                }

                if (maxRetries != 3)
                {
                    Console.WriteLine("maxRetries:{0}", maxRetries);
                }

            }
            catch (Exception)
            {
                //throw;
            }

        }

        public async static void OpenPort6(Comport comp)
        {
            try
            {
                serialPort6.PortName = comp.PortName;
                serialPort6.BaudRate = int.Parse(comp.Baudrate);
                serialPort6.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                serialPort6.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                serialPort6.DataBits = Convert.ToInt16(comp.DataBits);
                serialPort6.Encoding = Encoding.ASCII; // Thai
                serialPort6.DtrEnable = true;
                serialPort6.RtsEnable = true;
                serialPort6.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);
                int maxRetries = 3;
                const int sleepTimeInMs = 500;
                while (maxRetries > 0)
                {
                    try
                    {
                        if (serialPort6.IsOpen == false)
                            serialPort6.Open();
                        if (serialPort6.IsOpen)
                        {
                            serialPort6.DiscardInBuffer();
                            serialPort6.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler6);
                            StateHub.Raise("ch3_status", Color.FromArgb(0, 255, 0));
                            var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", comp.Direction, comp.PortName,
                                   comp.Baudrate, comp.DataBits, comp.Stopbit, comp.Parity, comp.Handshake);
                            UiEventBus.Publish("MAIN_FORM_CH6_COM", setting1);
                            UiEventBus.Publish("MAIN_FORM_CH6_STATUS", Color.FromArgb(0, 255, 0));
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
                        UiEventBus.Publish("MAIN_FORM_CH1_STATUS", Color.Empty);
                    }
                }

                if (maxRetries != 3)
                {
                    Console.WriteLine("maxRetries:{0}", maxRetries);
                }

            }
            catch (Exception)
            {
                //throw;
            }

        }



        private static void DataReceivedHandler1(object sender, SerialDataReceivedEventArgs e)
        {
            int channel = 1;
            var ReadingText = serialPort1.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer1.Append(ReadingText);
            string result = buffer1.ToString();
            if (buffer1.ToString().EndsWith("\r")) // && buffer1.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer1.ToString().Trim();
                var ch = Parameter.ComportPattenList.Where(x => x.Channel_ID == channel).FirstOrDefault();
                string text_part="";
                if (ch != null)
                {
                    var pt1 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern1).FirstOrDefault();
                    if (pt1 != null)
                    {
                         text_part = result_clean.Substring(pt1.StartCharactor, pt1.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH1_DATA", text_part);
                    }
                    var pt2 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern2).FirstOrDefault();
                    if (pt2 != null && ch.Pattern1 == 0)
                    {
                         text_part = result_clean.Substring(pt2.StartCharactor, pt2.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH1_DATA", text_part);
                    }
                    var pt3 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern3).FirstOrDefault();
                    if (pt3 != null && ch.Pattern1 == 0 && ch.Pattern2 == 0)
                    {
                        text_part = result_clean.Substring(pt3.StartCharactor, pt3.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH1_DATA", text_part);
                    }
                }

                UiEventBus.Publish("COMPORT_UC_CH1_RAW", result_clean, text_part, 1);
                UiEventBus.Publish("MAIN_FORM_CH1_RAW", result_clean);
                buffer1.Clear();
                serialPort1.DiscardInBuffer();
            }
        }


        private static void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            int channel = 2;
            var ReadingText = serialPort2.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer2.Append(ReadingText);
            string result = buffer2.ToString();

            if (buffer2.ToString().EndsWith("\r")) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer2.ToString().Trim();
                var ch = Parameter.ComportPattenList.Where(x => x.Channel_ID == channel).FirstOrDefault();
                if (ch != null)
                {
                    var pt1 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern1).FirstOrDefault();
                    if (pt1 != null)
                    {
                        string text_part = result_clean.Substring(pt1.StartCharactor, pt1.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH2_DATA", text_part);
                    }
                    var pt2 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern2).FirstOrDefault();
                    if (pt2 != null && ch.Pattern1 == 0)
                    {
                        string text_part = result_clean.Substring(pt2.StartCharactor, pt2.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH2_DATA", text_part);
                    }
                    var pt3 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern3).FirstOrDefault();
                    if (pt3 != null && ch.Pattern1 == 0 && ch.Pattern2 == 0)
                    {
                        string text_part = result_clean.Substring(pt3.StartCharactor, pt3.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH2_DATA", text_part);
                    }
                }
                buffer2.Clear();
                serialPort2.DiscardInBuffer();
            }
        }

        private static void DataReceivedHandler3(object sender, SerialDataReceivedEventArgs e)
        {
            int channel = 3;
            var ReadingText = serialPort3.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer3.Append(ReadingText);

            string result = buffer3.ToString();

            if (buffer3.ToString().EndsWith("\r")) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer3.ToString().Trim();
                var ch = Parameter.ComportPattenList.Where(x => x.Channel_ID == channel).FirstOrDefault();
                if (ch != null)
                {
                    var pt1 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern1).FirstOrDefault();
                    if (pt1 != null)
                    {
                        string text_part = result_clean.Substring(pt1.StartCharactor, pt1.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH3_DATA", text_part);
                    }
                    var pt2 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern2).FirstOrDefault();
                    if (pt2 != null && ch.Pattern1 == 0)
                    {
                        string text_part = result_clean.Substring(pt2.StartCharactor, pt2.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH3_DATA", text_part);
                    }
                    var pt3 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern3).FirstOrDefault();
                    if (pt3 != null && ch.Pattern1 == 0 && ch.Pattern2 == 0)
                    {
                        string text_part = result_clean.Substring(pt3.StartCharactor, pt3.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH3_DATA", text_part);
                    }
                }

                buffer3.Clear();
                serialPort3.DiscardInBuffer();
            }
        }

        private static void DataReceivedHandler4(object sender, SerialDataReceivedEventArgs e)
        {
            int channel = 4;
            var ReadingText = serialPort4.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer4.Append(ReadingText);

            string result = buffer4.ToString();

            if (buffer4.ToString().EndsWith("\r")) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer4.ToString().Trim();
                var ch = Parameter.ComportPattenList.Where(x => x.Channel_ID == channel).FirstOrDefault();
                if (ch != null)
                {
                    var pt1 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern1).FirstOrDefault();
                    if (pt1 != null)
                    {
                        string text_part = result_clean.Substring(pt1.StartCharactor, pt1.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH4_DATA", text_part);
                    }
                    var pt2 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern2).FirstOrDefault();
                    if (pt2 != null && ch.Pattern1 == 0)
                    {
                        string text_part = result_clean.Substring(pt2.StartCharactor, pt2.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH4_DATA", text_part);
                    }
                    var pt3 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern3).FirstOrDefault();
                    if (pt3 != null && ch.Pattern1 == 0 && ch.Pattern2 == 0)
                    {
                        string text_part = result_clean.Substring(pt3.StartCharactor, pt3.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH4_DATA", text_part);
                    }
                }

                buffer4.Clear();
                serialPort4.DiscardInBuffer();
            }
        }
        private static void DataReceivedHandler5(object sender, SerialDataReceivedEventArgs e)
        {
            int channel = 5;
            var ReadingText = serialPort4.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer5.Append(ReadingText);

            string result = buffer5.ToString();

            if (buffer5.ToString().EndsWith("\r")) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer4.ToString().Trim();
                var ch = Parameter.ComportPattenList.Where(x => x.Channel_ID == channel).FirstOrDefault();
                if (ch != null)
                {
                    var pt1 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern1).FirstOrDefault();
                    if (pt1 != null)
                    {
                        string text_part = result_clean.Substring(pt1.StartCharactor, pt1.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH5_DATA", text_part);
                    }
                    var pt2 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern2).FirstOrDefault();
                    if (pt2 != null && ch.Pattern1 == 0)
                    {
                        string text_part = result_clean.Substring(pt2.StartCharactor, pt2.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH5_DATA", text_part);
                    }
                    var pt3 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern3).FirstOrDefault();
                    if (pt3 != null && ch.Pattern1 == 0 && ch.Pattern2 == 0)
                    {
                        string text_part = result_clean.Substring(pt3.StartCharactor, pt3.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH5_DATA", text_part);
                    }
                }

                buffer5.Clear();
                serialPort5.DiscardInBuffer();
            }
        }
        private static void DataReceivedHandler6(object sender, SerialDataReceivedEventArgs e)
        {
            int channel = 6;
            var ReadingText = serialPort4.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer6.Append(ReadingText);

            string result = buffer6.ToString();

            if (buffer6.ToString().EndsWith("\r")) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer4.ToString().Trim();
                var ch = Parameter.ComportPattenList.Where(x => x.Channel_ID == channel).FirstOrDefault();
                if (ch != null)
                {
                    var pt1 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern1).FirstOrDefault();
                    if (pt1 != null)
                    {
                        string text_part = result_clean.Substring(pt1.StartCharactor, pt1.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH6_DATA", text_part);
                    }
                    var pt2 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern2).FirstOrDefault();
                    if (pt2 != null && ch.Pattern1 == 0)
                    {
                        string text_part = result_clean.Substring(pt2.StartCharactor, pt2.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH6_DATA", text_part);
                    }
                    var pt3 = Parameter.InputPatternList.Where(x => x.Pattern_ID == ch.Pattern3).FirstOrDefault();
                    if (pt3 != null && ch.Pattern1 == 0 && ch.Pattern2 == 0)
                    {
                        string text_part = result_clean.Substring(pt3.StartCharactor, pt3.NumberOfCharactor);
                        UiEventBus.Publish("MAIN_FORM_CH6_DATA", text_part);
                    }
                }
                buffer6.Clear();
                serialPort6.DiscardInBuffer();
            }
        }
        public static void Close()
        {
            if (serialPort1 != null)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.DiscardOutBuffer();
                    serialPort1.DiscardInBuffer();
                    serialPort1.Close();
                }
            }
            if (serialPort2 != null)
            {
                if (serialPort2.IsOpen)
                {
                    serialPort2.DiscardOutBuffer();
                    serialPort2.DiscardInBuffer();
                    serialPort2.Close();
                }
            }
            if (serialPort3 != null)
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.DiscardOutBuffer();
                    serialPort3.DiscardInBuffer();
                    serialPort3.Close();
                }
            }
            if (serialPort4 != null)
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.DiscardOutBuffer();
                    serialPort4.DiscardInBuffer();
                    serialPort4.Close();
                }
            }
            if (serialPort5 != null)
            {
                if (serialPort5.IsOpen)
                {
                    serialPort5.DiscardOutBuffer();
                    serialPort5.DiscardInBuffer();
                    serialPort5.Close();
                }
            }
            if (serialPort6 != null)
            {
                if (serialPort6.IsOpen)
                {
                    serialPort6.DiscardOutBuffer();
                    serialPort6.DiscardInBuffer();
                    serialPort6.Close();
                }
            }
        }
        public static void Close1(SerialPort? serialPort)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.DiscardOutBuffer();
                    serialPort.DiscardInBuffer();
                    serialPort.Close();
                    serialPort = null;
                }
            }
        }
    }
}
