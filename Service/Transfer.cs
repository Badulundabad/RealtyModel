using RealtyModel.Model;
using RealtyModel.Model.Operations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using NLog;

namespace RealtyModel.Service
{
    public static class Transfer
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static Operation ReceiveOperation(NetworkStream stream)
        {
            try
            {
                List<byte> byteList = new List<byte>();
                int size = GetSize(stream);
                while (byteList.Count < size)
                {
                    byte[] buffer = new byte[8192];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    byte[] receivedData = new byte[bytes];
                    Array.Copy(buffer, receivedData, bytes);
                    byteList.AddRange(receivedData);
                }
                LogInfo($"Total bytes received {byteList.Count}");
                return BinarySerializer.Deserialize<Operation>(byteList.ToArray());
            }
            catch (Exception ex)
            {
                LogError($"(ReceiveOperation) {ex.Message}");
                return new Operation();
            }
        }
        public static Response ReceiveResponse(NetworkStream stream)
        {
            try
            {
                List<byte> byteList = new List<byte>();
                int size = GetSize(stream);
                while (byteList.Count < size)
                {
                    byte[] buffer = new byte[8192];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    byte[] receivedData = new byte[bytes];
                    Array.Copy(buffer, receivedData, bytes);
                    byteList.AddRange(receivedData);
                }
                LogInfo($"Total bytes received {byteList.Count}");
                Response response = BinarySerializer.Deserialize<Response>(byteList.ToArray());
                return response;
            }
            catch (Exception ex)
            {
                LogError($"(ReceiveResponse) {ex.Message}");
                return new Response(Array.Empty<byte>(), ErrorCode.Unknown);
            }
        }
        public static T ReceiveResponse<T>(NetworkStream stream)
        {
            try
            {
                List<byte> byteList = new List<byte>();
                int size = GetSize(stream);
                while (byteList.Count < size)
                {
                    byte[] buffer = new byte[8192];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    byte[] receivedData = new byte[bytes];
                    Array.Copy(buffer, receivedData, bytes);
                    byteList.AddRange(receivedData);
                }
                LogInfo($"Total bytes received {byteList.Count}");
                return BinarySerializer.Deserialize<T>(byteList.ToArray());
            }
            catch (Exception ex)
            {
                LogError($"(ReceiveData) {ex.Message}");
                return (T)Activator.CreateInstance(typeof(T));
            }
        }
        public static void SendOperation(Operation operation, NetworkStream stream)
        {
            try
            {
                byte[] rawOperation = BinarySerializer.Serialize(operation);
                byte[] sizeBlob = BitConverter.GetBytes(rawOperation.Length);
                stream.Write(sizeBlob, 0, 4);
                LogInfo($"Sent 4 bytes");
                stream.Write(rawOperation, 0, rawOperation.Length);
                LogInfo($"Sent {rawOperation.Length} bytes");
            }
            catch (Exception ex)
            {
                LogError($"(SendOperation) {ex.Message}");
            }
        }
        public static void SendResponse(Response response, NetworkStream stream)
        {
            try
            {
                byte[] rawResponse = BinarySerializer.Serialize(response);
                byte[] sizeBlob = BitConverter.GetBytes(rawResponse.Length);
                stream.Write(sizeBlob, 0, 4);
                LogInfo($"Sent 4 bytes");
                stream.Write(rawResponse, 0, rawResponse.Length);
                LogInfo($"Sent {rawResponse.Length} bytes");
            }
            catch (Exception ex)
            {
                LogError($"(SendResponse) {ex.Message}");
            }
        }
        private static int GetSize(NetworkStream stream)
        {
            try
            {
                byte[] buffer = new byte[4];
                stream.Read(buffer, 0, buffer.Length);
                return BitConverter.ToInt32(buffer, 0);
            }
            catch (Exception ex)
            {
                LogError($"(GetSize) {ex.Message}");
                return 0;
            }
        }

        private static void LogInfo(String text)
        {
            Debug.WriteLine($"{DateTime.Now} INFO    {text}");
            logger.Info($"    {text}");
        }
        private static void LogError(String text)
        {
            Debug.WriteLine($"\n{DateTime.Now} ERROR    {text}\n");
            logger.Error($"    {text}");
        }
    }
}
