using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Models
{
    public class UiMessage
    {
        public string Key { get; init; } = string.Empty;   // เช่น "FORM_MAIN", "UC_LOGIN"
        public object? Data { get; init; }                 // ข้อมูลจริง
        public object? ExtraData { get; init; }            // ข้อมูลเสริม (ถ้ามี)
        public object? MoreExtraData { get; init; }        // ข้อมูลเสริมเพิ่มเติม (ถ้ามี)

    }

}
