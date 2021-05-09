using System;
using RealtyModel.Model.Operations;

namespace RealtyModel.Events.Realty
{
    public class ReceivedPhotoEventArgs
    {
        public Act Act { get; set; }
        public String Data { get; set; }

        public ReceivedPhotoEventArgs(Act act, String data)
        {
            Act = act;
            Data = data;
        }
    }
}
