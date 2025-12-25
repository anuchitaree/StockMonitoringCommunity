using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public class JsonWriteQueue<T> : IDisposable
    {

        private readonly ConcurrentQueue<T> _queue = new();
        private readonly CancellationTokenSource _cts = new();
        private readonly Task _worker;
        private readonly string _path;

        public JsonWriteQueue(string path)
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
                    JsonAtomicWriter.Write(_path, item);
                }
                else
                {
                    await Task.Delay(5); // ลด CPU usage
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
