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

    public delegate void ReceivedDbUpdateEventHandler(object sender, ReceivedDbUpdateEventArgs e);
    public delegate void UpdateFinishedEventHandler(object sender, UpdateFinishedEventArgs e);
    public delegate void OpeningFlatFormEventHandler(object sender, OpeningFlatFormEventArgs e);
    public delegate void FlatCreatedEventHandler(object sender, FlatCreatedEventArgs e);
    public delegate void FlatModifiedEventHandler(object sender, FlatModifiedEventArgs e);

    public delegate void ReceivedFlatEventHandler(object sendet, ReceivedFlatEventArgs e);
    public delegate void ReceivedFlatUpdateEventHandler(object sender, ReceivedFlatUpdateEventArgs e);
    public delegate void ReceivedFlatDeletionEventHandler(object sender, ReceivedFlatDeletionEventArgs e);
    public delegate void ReceivedHouseEventHandler(object sender, ReceivedHouseEventArgs e);
    public delegate void ReceivedHouseUpdateEventHandler(object sender, ReceivedHouseUpdateEventArgs e);
    public delegate void ReceivedHouseDeletionEventHandler(object sender, ReceivedHouseDeletionEventArgs e);

    public delegate void EnqueuedEventHandler(object sender, EnqueuedEventArgs e);
}
