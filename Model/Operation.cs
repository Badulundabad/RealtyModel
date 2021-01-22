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
        ToFire = 1,
        Login = 2,
        Logout =3,
        Add = 4,
        Change = 5,
        Remove = 6,
        Update = 7
    }
    public enum ObjectType
    {
        Flat = 0,
        House = 1,
        Customer = 2,
        Album = 3
    }
}
