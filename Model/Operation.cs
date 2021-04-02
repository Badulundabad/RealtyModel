using System;

namespace RealtyModel.Model
{
    public class Operation
    {
        public Operation() {
        }
        public Operation(string name, string data, OperationDirection direction, OperationType type) {
            this.Name = name;
            this.Data = data;
            this.OperationParameters.Direction = direction;
            this.OperationParameters.Type = type;
        }
        private Guid operationNumber;
        private string ipAddress;
        private string name;
        private string data;
        private string token;
        private string part;
        private OperationParameters operationParameters = new OperationParameters();
        private bool isSuccessfully;

        public Guid OperationNumber {
            get => operationNumber;
            set => operationNumber = value;
        }
        public string IpAddress {
            get => ipAddress;
            set => ipAddress = value;
        }
        public string Name {
            get => name;
            set => name = value;
        }
        public string Data {
            get => data;
            set => data = value;
        }
        public string Token {
            get => token;
            set => token = value;
        }
        public string Part {
            get => part;
            set => part = value;
        }
        public OperationParameters OperationParameters {
            get => operationParameters;
            set => operationParameters = value;
        }
        public bool IsSuccessfully {
            get => isSuccessfully;
            set => isSuccessfully = value;
        }
    }
}
