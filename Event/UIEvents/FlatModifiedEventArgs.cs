using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event.RealtyEvents
{
    public class FlatModifiedEventArgs
    {
        private Flat flat = new Flat();
        public Flat Flat
        {
            get => flat;
            set => flat = value;
        }

        public FlatModifiedEventArgs()
        {
        }
        public FlatModifiedEventArgs(Flat flat)
        {
            this.Flat = flat;
        }
    }
}
