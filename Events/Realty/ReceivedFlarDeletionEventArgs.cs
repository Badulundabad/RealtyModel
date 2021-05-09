using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class ReceivedFlatDeletionEventArgs
    {
        private Flat flat;
        public Flat Flat { get => flat; set => flat = value; }

        public ReceivedFlatDeletionEventArgs(Flat flat)
        {
            this.flat = flat;
        }
    }
}
