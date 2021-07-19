﻿using RealtyModel.Model;
using RealtyModel.Model.Operations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using NLog;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Tools
{
    public static class Transfer
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static Operation ReceiveOperation(NetworkStream stream) {
            try {
                List<byte> byteList = new List<byte>();
                int size = GetSize(stream);
                while (byteList.Count < size) {
                    byte[] buffer = new byte[8192];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    byte[] receivedData = new byte[bytes];
                    Array.Copy(buffer, receivedData, bytes);
                    byteList.AddRange(receivedData);
                }
                Operation operation = BinarySerializer.Deserialize<Operation>(byteList.ToArray());
                LogInfo($"Total bytes received {byteList.Count} from {operation.Name}");
                return operation;
            } catch (Exception ex) {
                LogError(ex.Message);
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
                    byte[] receivedData = new byte[bytes];
                    Array.Copy(buffer, receivedData, bytes);
                    byteList.AddRange(receivedData);
                }
                LogInfo($"Total bytes received {byteList.Count}");
                Response response = BinarySerializer.Deserialize<Response>(byteList.ToArray());
                return response;
            } catch (Exception ex) {
                LogError(ex.Message);
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
                    byte[] receivedData = new byte[bytes];
                    Array.Copy(buffer, receivedData, bytes);
                    byteList.AddRange(receivedData);
                }
                LogInfo($"Total bytes received {byteList.Count}");
                return BinarySerializer.Deserialize<T>(byteList.ToArray());
            } catch (Exception ex) {
                LogError(ex.Message);
                return (T)Activator.CreateInstance(typeof(T));
            }
        }
        public static void SendOperation(Operation operation, NetworkStream stream) {
            try {
                byte[] rawOperation = BinarySerializer.Serialize(operation);
                byte[] sizeBlob = BitConverter.GetBytes(rawOperation.Length);
                stream.Write(sizeBlob, 0, 4);
                LogInfo($"Sent 4 bytes");
                stream.Write(rawOperation, 0, rawOperation.Length);
                LogInfo($"Sent {rawOperation.Length} bytes");
            } catch (Exception ex) {
                LogError(ex.Message);
            }
        }
        public static void SendResponse(Response response, NetworkStream stream) {
            try {
                byte[] rawResponse = BinarySerializer.Serialize(response);
                byte[] sizeBlob = BitConverter.GetBytes(rawResponse.Length);
                stream.Write(sizeBlob, 0, 4);
                LogInfo($"Sent 4 bytes");
                stream.Write(rawResponse, 0, rawResponse.Length);
                LogInfo($"Sent {rawResponse.Length} bytes");
            } catch (Exception ex) {
                LogError(ex.Message);
            }
        }
        private static int GetSize(NetworkStream stream) {
            try {
                byte[] buffer = new byte[4];
                stream.Read(buffer, 0, buffer.Length);
                return BitConverter.ToInt32(buffer, 0);
            } catch (Exception ex) {
                LogError(ex.Message);
                return 0;
            }
        }

        private static void LogInfo(String text, [CallerMemberName] string caller = null) {
            Debug.WriteLine($"{DateTime.Now} INFO    {text}");
            Console.WriteLine($"{DateTime.Now} INFO    {text}");
            logger.Info($"    {text}");
        }
        private static void LogError(String text, [CallerMemberName] string caller = null) {
            Debug.WriteLine($"{DateTime.Now} ERROR    {text}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{DateTime.Now} ERROR    {text}");
            Console.ResetColor();
            logger.Error($"    {text}");
        }
    }
}