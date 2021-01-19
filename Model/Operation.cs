using System;

namespace RealtyModel.Model
{
    public class Operation
    {
        public Guid OperationNumber { get; set; }
        public string IpAddress { get; set; }
        public OperationType OperationType { get; set; }
        public ObjectType ObjectType { get; set; }
        public string Data { get; set; }
        public bool IsSuccessfully { get; set; }
    }
    public enum OperationType
    {
        Register = 0,
        Login = 1,
        Add = 2,
        Change = 3,
        Remove = 4,
        Update = 5
    }
    public enum ObjectType
    {
        Flat = 0,
        House = 1,
        Customer = 2,
        Album = 3
    }
}
