using System;
using RealtyModel.Model;

namespace RealtyModel.Events.Realty
{
    public class ReceivedPhotoEventArgs
    {
        public OperationType OperationType { get; set; }
        public String Data { get; set; }

        public ReceivedPhotoEventArgs(OperationType type, String data)
        {
            OperationType = type;
            Data = data;
        }
    }
}
