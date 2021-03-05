using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public interface ILogged
    {
        event LoggedEventHandler Logged;
    }
}
