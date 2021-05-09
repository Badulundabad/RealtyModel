namespace RealtyModel.Events.Network
{
    public delegate void ConnectingEventHandler(object sender, ConnectingEventArgs e);
    public delegate void ConnectedEventHandler(object sender, ConnectedEventArgs e);
    public delegate void DisconnectedEventHandler(object sender, DisconnectedEventArgs e);
    public delegate void ReconnectedEventHandler(object sender, ReconnectedEventArgs e);
}
