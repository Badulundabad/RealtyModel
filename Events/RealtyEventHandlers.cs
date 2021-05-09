namespace RealtyModel.Events.Realty
{
    public delegate void ReceivedPhotoEventHandler(object sender, ReceivedPhotoEventArgs e);
    public delegate void ReceivedFlatEventHandler(object sender, ReceivedFlatEventArgs e);
    public delegate void ReceivedFlatUpdateEventHandler(object sender, ReceivedFlatUpdateEventArgs e);
    public delegate void ReceivedFlatDeletionEventHandler(object sender, ReceivedFlatDeletionEventArgs e);
    public delegate void ReceivedHouseEventHandler(object sender, ReceivedHouseEventArgs e);
    public delegate void ReceivedHouseUpdateEventHandler(object sender, ReceivedHouseUpdateEventArgs e);
    public delegate void ReceivedHouseDeletionEventHandler(object sender, ReceivedHouseDeletionEventArgs e);
}
