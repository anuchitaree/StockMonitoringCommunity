using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public sealed class PeriodicWorker : IDisposable
    {
        private readonly TimeSpan _interval;
        private PeriodicTimer? _timer;
        private CancellationTokenSource? _cts;
        private bool _running;

        public PeriodicWorker(TimeSpan interval)
        {
            _interval = interval;
        }

        public async Task StartAsync(Func<Task> work)
        {
            if (_running) return;

            _running = true;
            _cts = new CancellationTokenSource();
            _timer = new PeriodicTimer(_interval);

            try
            {
                while (await _timer.WaitForNextTickAsync(_cts.Token))
                {
                    await work();
                }
            }
            catch (OperationCanceledException)
            {
                // Stop
            }
        }

        public void Stop()
        {
            if (!_running) return;

            _cts?.Cancel();
            _timer?.Dispose();
            _cts?.Dispose();
            _running = false;
        }

        public void Dispose() => Stop();
    }

}
