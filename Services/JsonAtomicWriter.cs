using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace StockMonitoringCommunity.Services
{
    public static class JsonAtomicWriter
    {
        private static readonly byte[] NewLine = Encoding.UTF8.GetBytes("\n");


        public static void Write<T>(string path, T data)
        {
            var temp = path + ".tmp";

            using (var fs = new FileStream(
                temp,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                bufferSize: 4096,
                FileOptions.WriteThrough))
            {
                JsonSerializer.Serialize(fs, data);
            }

            File.Move(temp, path, overwrite: true);
        }

        public static void Append<T>(string path, T data)
        {
            using var fs = new FileStream(
                path,
                FileMode.Append,
                FileAccess.Write,
                FileShare.Read,       // reader อ่านได้
                bufferSize: 4096,
                FileOptions.WriteThrough);

            JsonSerializer.Serialize(fs, data);
            fs.Write(NewLine);
        }

    }
}
