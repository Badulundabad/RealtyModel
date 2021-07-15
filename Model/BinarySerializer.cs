using NLog;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace RealtyModel.Model
{
    public class BinarySerializer
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static byte[] Serialize<T>(T obj)
        {
            try {
                if (obj == null) {
                    return null;
                }
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream()) {
                    bf.Serialize(ms, obj);
                    return ms.ToArray();
                }
            } catch {
                LogError("Data serializing error");
                return Array.Empty<byte>();
            }
        }
        public static T Deserialize<T>(byte[] data)
        {
            try {
                if (data == null) {
                    return default(T);
                }
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream(data)) {
                    object obj = bf.Deserialize(ms);
                    return (T)obj;
                }
            } catch {
                LogError("Data deserializing error");
                return default(T);
            }
        }
        private static void LogError(String text) {
            Debug.WriteLine($"{DateTime.Now} ERROR    {text}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{DateTime.Now} ERROR    {text}");
            Console.ResetColor();
            logger.Error($"    {text}");
        }
    }
}
