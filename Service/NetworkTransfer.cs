using RealtyModel.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Service
{
    public static class NetworkTransfer
    {
        public static byte[] ReceiveData(NetworkStream stream) {
            try {
                List<byte> byteList = new List<byte>();
                int size = GetSize(stream);
                while (byteList.Count < size) {
                    byte[] buffer = new byte[8192];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    Debug.WriteLine($"Received {bytes} bytes");
                    byte[] receivedData = new byte[bytes];
                    Array.Copy(buffer, receivedData, bytes);
                    byteList.AddRange(receivedData);
                }
                Debug.WriteLine($"Total bytes received {byteList.Count}");
                return byteList.ToArray();
            } catch (Exception ex) {
                Debug.WriteLine($"(ReceiveData) {ex.Message}");
                return new byte[0];
            }
        }
        public static void SendData(byte[] data, NetworkStream stream) {
            byte[] sizeBlob = BitConverter.GetBytes(data.Length);
            stream.Write(sizeBlob, 0, 4);
            stream.Write(data, 0, data.Length);
        }
        private static int GetSize(NetworkStream stream) {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);
            return BitConverter.ToInt32(buffer, 0);
        }
    }
}
