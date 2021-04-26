using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event.RealtyEvents
{
    public class ReceivedFlatEventArgs
    {
        private Flat flat;
        public Flat Flat { get => flat; set => flat = value; }

        public ReceivedFlatEventArgs(Flat flat)
        {
            this.flat = flat;
        }
    }
}
