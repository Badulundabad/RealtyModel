using RealtyModel.Event.IdentityEvents;
using RealtyModel.Event.RealtyEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public delegate void LoggedInEventHandler(object sender, LoggedInEventArgs e);
    public delegate void LoggedOutEventHandler(object sender, LoggedInEventArgs e);
    public delegate void RegisteredEventHandler(object sender, LoggedInEventArgs e);
    public delegate void LoggingInEventHandler(object sender, LoggingInEventArgs e);
    public delegate void LoggingOutEventHandler(object sender, LoggingOutEventArgs e);
    public delegate void RegisteringEventHandler(object sender, RegisteringEventArgs e);

    public delegate void ReceivedListsEventHandler(object sender, ReceivedListsEventArgs e);
    public delegate void ReceivedObjectDBEventHandler(object sender, ReceivedObjectDBEventArgs e);
    public delegate void OpeningFlatFormEventHandler(object sender, OpeningFlatFormEventArgs e);
    public delegate void FlatCreatedEventHandler(object sender, FlatCreatedEventArgs e);
    public delegate void FlatModifiedEventHandler(object sender, FlatModifiedEventArgs e);
    public delegate void UpdateFlatEventHandler(object sender, UpdateFlatEventArgs e);
    public delegate void DeleteFlatEventHandler(object sender, DeleteFlatEventArgs e);
    public delegate void UpdateHouseEventHandler(object sender, UpdateHouseEventArgs e);
    public delegate void DeleteHouseEventHandler(object sender, DeleteHouseEventArgs e);

}
