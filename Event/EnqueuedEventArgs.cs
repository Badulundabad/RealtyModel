using RealtyModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public class EnqueuedEventArgs
    {
        private Operation item;
        public Operation Item
        {
            get => item;
            set => item = value;
        }

        public EnqueuedEventArgs(Operation item)
        {
            this.item = item;
        }
    }
}
