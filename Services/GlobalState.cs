using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public static class GlobalState
    {

        private static string _message = string.Empty;

        public static event Action<string>? MessageChanged;

        public static string Message
        {
            get => _message ?? string.Empty;
            set
            {
                if (string.Equals(_message, value, StringComparison.Ordinal))
                    return;

                _message = value ?? string.Empty;

                MessageChanged?.Invoke(_message);
            }
        }
    }
}
