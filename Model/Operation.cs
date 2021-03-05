using System;

namespace RealtyModel.Model
{
    public class Operation
    {
        public Guid OperationNumber { get; set; }
        public String IpAddress { get; set; }
        public String Name { get; set; }
        public String Token { get; set; }
        public String Part { get; set; }
        public OperationParameters OperationParameters { get; set; }
        public String Data { get; set; }
        public Boolean IsSuccessfully { get; set; }
    }
    public class OperationParameters
    {
        public OperationDirection Direction { get; set; }
        public OperationType Type { get; set; }
        public TargetType Target { get; set; }

        public Boolean HasBaseChanges { get; set; }
        public Boolean HasAlbumChanges { get; set; }
        public Boolean HasCustomerChanges { get; set; }
        public Boolean HasLocationChanges { get; set; }
    }
    public enum OperationDirection
    {
        Identity = 0,
        Realty = 1
    }
    public enum OperationType
    {
        Register = 0,
        ToFire = 1,
        Login = 2,
        Logout = 3,
        Add = 4,
        Change = 5,
        Remove = 6,
        Update = 7
    }
    public enum TargetType
    {
        Flat = 0,
        House = 1,
        Agent = 2,
        Customer = 3,
        All = 4
    }
}
