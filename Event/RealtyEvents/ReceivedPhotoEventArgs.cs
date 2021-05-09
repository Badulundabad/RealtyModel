using RealtyModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event.RealtyEvents
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
