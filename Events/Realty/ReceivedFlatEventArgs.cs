using RealtyModel.Model.Derived;
using RealtyModel.Model.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class ReceivedFlatEventArgs
    {
        private Flat flat;
        public Flat Flat { get => flat; set => flat = value; }
        public Act Action { get; set; }
        public Initiator Initiator { get; set; }

        public ReceivedFlatEventArgs(Flat flat, Act act, Initiator initiator)
        {
            this.flat = flat;
            Action = act;
            Initiator = initiator;
        }
    }
}
