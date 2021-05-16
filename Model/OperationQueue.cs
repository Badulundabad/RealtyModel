using RealtyModel.Events;
using RealtyModel.Model.Operations;
using System;
using System.Collections.Generic;

namespace RealtyModel.Model
{
    [Serializable]
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
        [field: NonSerialized]
        public event EnqueuedEventHandler Enqueued;
    }
}
