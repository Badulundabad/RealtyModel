using RealtyModel.Model;
using RealtyModel.Model.Operations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Service
{
    public static class Transfer
    {
        public static Operation ReceiveOperation(NetworkStream stream) {
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
                return BinarySerializer.Deserialize<Operation>(byteList.ToArray());
            } catch (Exception ex) {
                Debug.WriteLine($"(ReceiveData) {ex.Message}");
                return new Operation();
            }
        }
        public static Response ReceiveResponse(NetworkStream stream) {
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
                Response response = BinarySerializer.Deserialize<Response>(byteList.ToArray());
                return response;
            } catch (Exception ex) {
                Debug.WriteLine($"(ReceiveData) {ex.Message}");
                return new Response(Array.Empty<byte>(), ErrorCode.Unknown);
            }
        }
        public static T ReceiveResponse<T>(NetworkStream stream) {
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
                return BinarySerializer.Deserialize<T>(byteList.ToArray());
            } catch (Exception ex) {
                Debug.WriteLine($"(ReceiveData) {ex.Message}");
                return (T)Activator.CreateInstance(typeof(T));
            }
        }
        public static void SendOperation(Operation operation, NetworkStream stream) {
            byte[] rawOperation = BinarySerializer.Serialize(operation);
            byte[] sizeBlob = BitConverter.GetBytes(rawOperation.Length);
            stream.Write(sizeBlob, 0, 4);
            stream.Write(rawOperation, 0, rawOperation.Length);
        }
        public static void SendResponse(Response response, NetworkStream stream) {
            byte[] rawResponse = BinarySerializer.Serialize(response);
            byte[] sizeBlob = BitConverter.GetBytes(rawResponse.Length);
            stream.Write(sizeBlob, 0, 4);
            stream.Write(rawResponse, 0, rawResponse.Length);
        }
        private static int GetSize(NetworkStream stream) {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);
            return BitConverter.ToInt32(buffer, 0);
        }
    }
}
