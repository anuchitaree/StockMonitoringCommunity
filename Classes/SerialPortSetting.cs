using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Interfaces;
using StockMonitoringCommunity.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringCommunity.Classes
{
    public static class SerialPortSetting
    {

     
        public static void Close(SerialPort? serialPort)
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
