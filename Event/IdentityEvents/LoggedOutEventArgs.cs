using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event.IdentityEvents
{
    public class LoggedOutEventArgs
    {
        private String name = "";
        public String Name { get => name; set => name = value; }
        public LoggedOutEventArgs(String name)
        {
            this.name = name;
        }
    }
}
