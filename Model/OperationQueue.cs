using RealtyModel.Events;
using RealtyModel.Model.Operations;
using System.Collections.Generic;

namespace RealtyModel.Model
{
    public class OperationQueue : Queue<Operation>
    {
        public new void Enqueue(Operation item)
        {
            base.Enqueue(item);
            OnEnqueued(item);
        }
        
        private void OnEnqueued(Operation item)
        {
            if (Enqueued != null)
                Enqueued?.Invoke(this, new EnqueuedEventArgs(item));
        }
        public event EnqueuedEventHandler Enqueued;
    }
}
