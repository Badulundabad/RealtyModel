using RealtyModel.Model.Operations;

namespace RealtyModel.Events
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
