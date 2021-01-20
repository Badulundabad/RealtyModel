using System;

namespace RealtyModel.Model
{
    public class Operation
    {
        public Guid OperationNumber { get; set; }
        public String IpAddress { get; set; }
        public String Token { get; set; }
        public String Part { get; set; }
        public OperationType OperationType { get; set; }
        public ObjectType ObjectType { get; set; }
        public String Data { get; set; }
        public Boolean IsSuccessfully { get; set; }
    }
    public enum OperationType
    {
        Register = 0,
        Login = 1,
        Logout =2,
        Add = 3,
        Change = 4,
        Remove = 5,
        Update = 6
    }
    public enum ObjectType
    {
        Flat = 0,
        House = 1,
        Customer = 2,
        Album = 3
    }
}
