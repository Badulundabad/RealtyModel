using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RealtyModel.Model
{
    public class BinarySerializer
    {
        public static byte[] Serialize<T>(T obj)
        {
            if (obj == null)
            {
                return null;
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        public static T Deserialize<T>(byte[] data)
        {
            if (data == null)
            {
                return default(T);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }
    }
}
