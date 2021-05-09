using RealtyModel.Events.UI;

namespace RealtyModel.Events.Realty
{
    public delegate void QueryCreatedEventHandler(object sender, QueryCreatedEventArgs e);
    public delegate void FlatCreatingEventHandler(object sender, FlatCreatingEventArgs e);
    public delegate void FlatChangingEventHandler(object sender, FlatChangingEventArgs e);
    public delegate void ReceivedPhotoEventHandler(object sender, ReceivedPhotoEventArgs e);
    public delegate void ReceivedFlatEventHandler(object sender, ReceivedFlatEventArgs e);
    public delegate void ReceivedHouseEventHandler(object sender, ReceivedHouseEventArgs e);
}
