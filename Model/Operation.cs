using System;
using System.Net;
using System.Text.Json.Serialization;

namespace RealtyModel.Model
{
    public class Operation
    {
        public String Name { get; set; }
        public String Token { get; set; }
        public Boolean IsBroadcast { get; set; }
        public String IpAddress { get; set; }
        public String Number { get; set; }
        public OperationParameters Parameters { get; set; }
        public String Data { get; set; }
        public Boolean IsSuccessfully { get; set; }

        public Operation()
        {

        }
        public Operation(String name, String token, String ip, String number)
        {
            Name = name;
            Token = token;
            IpAddress = ip;
            Number = number;
        }
    }
}
