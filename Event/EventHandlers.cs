using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public delegate void LoggedEventHandler(object sender, LoggedEventArgs e);
    public delegate void LoggingEventHandler(object sender, LoggingEventArgs e);
    public delegate void FlatCreatedEventHandler(object sender, FlatCreatedEventArgs e);
    public delegate void UpdateFlatEventHandler(object sender, UpdateFlatEventArgs e);
    public delegate void DeleteFlatEventHandler(object sender, DeleteFlatEventArgs e);
}
