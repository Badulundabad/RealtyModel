using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class FlatChangingEventArgs
    {
        private Flat flat = new Flat();
        public Flat Flat
        {
            get => flat;
            set => flat = value;
        }

        public FlatChangingEventArgs()
        {
        }
        public FlatChangingEventArgs(Flat flat)
        {
            this.Flat = flat;
        }
    }
}
