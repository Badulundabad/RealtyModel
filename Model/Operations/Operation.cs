using System;

namespace RealtyModel.Model.Operations
{
    [Serializable]
    public class Operation
    {
        public String Name { get; set; }
        public String Token { get; set; }
        public Boolean IsBroadcast { get; set; }
        public String IpAddress { get; set; }
        public String Number { get; set; }
        public Parameters Parameters { get; set; }
        public Byte[] Data { get; set; }
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

        public Operation GetCopy()
        {
            return new Operation()
            {
                Name = this.Name,
                Token = this.Token,
                IpAddress = this.IpAddress,
                Number = this.Number,
                Parameters = this.Parameters,
                Data = this.Data,
                IsBroadcast = this.IsBroadcast,
                IsSuccessfully = this.IsSuccessfully
            };
        }
    }
}
