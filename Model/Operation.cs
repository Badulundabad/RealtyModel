using System;

namespace RealtyModel.Model
{
    public class Operation
    {
        private Guid operationNumber;
        private string ipAddress;
        private string name;
        private string data;
        private string token;
        private OperationParameters operationParameters = new OperationParameters();
        private bool isSuccessfully;

        public Operation()
        {
            EOF = "<EOF>";
        }
        public Operation(string name, string data, OperationDirection direction, OperationType type)
        {
            this.Name = name;
            this.Data = data;
            this.OperationParameters.Direction = direction;
            this.OperationParameters.Type = type;
            EOF = "<EOF>";
        }
        public Operation(string name, string data, OperationDirection direction, OperationType type, TargetType target)
        {
            this.Name = name;
            this.Data = data;
            this.OperationParameters.Direction = direction;
            this.OperationParameters.Type = type;
            this.OperationParameters.Target = target;
            EOF = "<EOF>";
        }

        public Guid OperationNumber
        {
            get => operationNumber;
            set => operationNumber = value;
        }
        public string IpAddress
        {
            get => ipAddress;
            set => ipAddress = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Data
        {
            get => data;
            set => data = value;
        }
        public string Token
        {
            get => token;
            set => token = value;
        }
        public OperationParameters OperationParameters
        {
            get => operationParameters;
            set => operationParameters = value;
        }
        public bool IsSuccessfully
        {
            get => isSuccessfully;
            set => isSuccessfully = value;
        }
        public String EOF
        {
            get; private set;
        }
    }
}
