
using RealtyModel.Event.CommonEvents;

namespace RealtyModel.Event
{
    public class CommonEventHandlers
    {
        public delegate void EnqueuedEventHandler(object sender, EnqueuedEventArgs e);
    }
}
