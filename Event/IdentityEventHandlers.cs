using RealtyModel.Event.IdentityEvents;

namespace RealtyModel.Event
{
    public delegate void LoggedInEventHandler(object sender, LoggedInEventArgs e);
    public delegate void LoggedOutEventHandler(object sender, LoggedInEventArgs e);
    public delegate void RegisteredEventHandler(object sender, LoggedInEventArgs e);
    public delegate void LoggingInEventHandler(object sender, LoggingInEventArgs e);
    public delegate void LoggingOutEventHandler(object sender, LoggingOutEventArgs e);
    public delegate void RegisteringEventHandler(object sender, RegisteringEventArgs e);
}
