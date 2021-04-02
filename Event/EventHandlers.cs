using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public delegate void LoggedEventHandler(object sender, LoggedEventArgs e);
    public delegate void FlatCreatedEventHandler(object sender, FlatCreatedEventArgs e);
}
