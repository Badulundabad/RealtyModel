using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Identity
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
