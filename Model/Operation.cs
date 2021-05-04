using System;
using System.Net;
using System.Text.Json.Serialization;

namespace RealtyModel.Model
{
    public class Operation
    {
        public String Name { get; set; }
        public Guid Token { get; set; }
        public Boolean IsBroadcast { get; set; }
        public String IpAddress { get; set; }
        public Guid OperationNumber { get; set; }
        public OperationParameters Parameters { get; set; }
        public Byte[] Data { get; set; }
        public Boolean IsSuccessfully { get; set; }
    }
}
