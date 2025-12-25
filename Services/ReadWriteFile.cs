using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace StockMonitoringCommunity.Services
{
    public  static class ReadWriteFile
    {
        public static void WriteJsonAtomic<T>(string path, T data)
        {
            var tempPath = path + ".tmp";

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(tempPath, json);

            // replace แบบ atomic
            File.Move(tempPath, path, overwrite: true);
        }
    }
}
