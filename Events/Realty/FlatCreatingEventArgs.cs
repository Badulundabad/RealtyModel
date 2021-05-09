using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class FlatCreatingEventArgs
    {
        private Flat flat;
        public Flat Flat {
            get => flat;
            set => flat = value;
        }

        public FlatCreatingEventArgs() {
        }
        public FlatCreatingEventArgs(Flat flat) {
            this.Flat = flat;
        }
    }
}
