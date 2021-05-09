using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public class FlatCreatedEventArgs
    {
        private Flat flat;
        public Flat Flat {
            get => flat;
            set => flat = value;
        }

        public FlatCreatedEventArgs() {
        }
        public FlatCreatedEventArgs(Flat flat) {
            this.Flat = flat;
        }
    }
}
