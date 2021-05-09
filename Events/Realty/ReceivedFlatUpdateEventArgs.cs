using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class ReceivedFlatUpdateEventArgs
    {
        private Flat flat;
        public Flat Flat { get => flat; set => flat = value; }

        public ReceivedFlatUpdateEventArgs(Flat flat)
        {
            this.flat = flat;
        }
    }
}
