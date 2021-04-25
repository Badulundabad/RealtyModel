using RealtyModel.Event;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace RealtyModel.Model
{
    public class OperationQueue : Queue<Operation>
    {
        public new void Enqueue(Operation item)
        {
            base.Enqueue(item);
            OnEnqueue(item);
        }
        
        private void OnEnqueue(Operation item)
        {
            if (Enqueued != null)
                Enqueued?.Invoke(this, new EnqueuedEventArgs(item));
        }
        public event EnqueuedEventHandler Enqueued;
    }
}
