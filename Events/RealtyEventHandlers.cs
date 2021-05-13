using RealtyModel.Events.UI;

namespace RealtyModel.Events.Realty
{
    public delegate void QueryCreatedEventHandler(object sender, QueryCreatedEventArgs e);
    public delegate void QueryResultReceivedEventHandler(object sender, QueryResultReceivedEventArgs e);

    public delegate void FlatCreatingEventHandler(object sender, FlatCreatingEventArgs e);
    public delegate void FlatModifyingEventHandler(object sender, FlatModifyingEventArgs e);
    public delegate void FlatRegisteredEventHandler(object sender, FlatRegisteredEventArgs e);
    public delegate void FlatModificationRegisteredEventHandler(object sender, FlatModificationRegisteredEventArgs e);

    public delegate void PhotoSavedEventHandler(object sender, PhotoSavedEventArgs e);
    public delegate void PhotoReceivedEventHandler(object sender, PhotoReceivedEventArgs e);
}
