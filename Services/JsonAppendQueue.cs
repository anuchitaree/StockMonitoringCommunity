using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public class JsonAppendQueue<T> : IDisposable
    {
        private readonly ConcurrentQueue<T> _queue = new();
        private readonly CancellationTokenSource _cts = new();
        private readonly Task _worker;
        private readonly string _path;

        public JsonAppendQueue(string path)
        {
            _path = path;
            _worker = Task.Run(Worker);
        }

        public void Enqueue(T item)
        {
            _queue.Enqueue(item);
        }
        private async Task Worker()
        {
            while (!_cts.IsCancellationRequested)
            {
                if (_queue.TryDequeue(out var item))
                {
                    JsonAtomicWriter.Append(_path, item);
                }
                else
                {
                    await Task.Delay(1); // เบามาก
                }
            }
        }
        public void Dispose()
        {
            _cts.Cancel();
            _worker.Wait();
        }



    }
}
