using RealtyModel.Model;

namespace RealtyModel.Event.CommonEvents
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
