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
        private bool isNew = false;
        private Flat flat;
        public FlatCreatedEventArgs() {
        }
        public FlatCreatedEventArgs(Flat flat) {
            this.Flat = flat;
        }
        public FlatCreatedEventArgs(Flat flat, bool isNew) {
            this.Flat = flat;
            this.IsNew = isNew;
        }
        public Flat Flat {
            get => flat;
            set => flat = value;
        }
        public bool IsNew {
            get => isNew;
            set => isNew = value;
        }
    }
}
