using RealtyModel.Event.RealtyEvents;

namespace RealtyModel.Event
{
    public class UIEventHandlers
    {
        public delegate void OpeningFlatFormEventHandler(object sender, OpeningFlatFormEventArgs e);
        public delegate void FlatCreatedEventHandler(object sender, FlatCreatedEventArgs e);
        public delegate void FlatModifiedEventHandler(object sender, FlatModifiedEventArgs e);
    }
}
