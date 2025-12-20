using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.State
{
    public static class StateStore
    {
        private static readonly AppState _state = new();

        public static AppState State => _state;

        public static event Action<string>? StateChanged;

        public static void Update(Action<AppState> updater, string key)
        {
            updater(_state);
            _state.LastUpdated = DateTime.Now;
            StateChanged?.Invoke(key);
        }
    }

}
