using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.State
{
    public sealed class AppState
    {
        // --- UI ---
        public bool IsConnected { get; set; }
        public string? CurrentUser { get; set; }

        // --- Setting ---
        public bool AutoStart { get; set; }


        // --- Running Scanner ----
        public bool IsRunning { get; set; }

        // --- Runtime ---
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }

}
