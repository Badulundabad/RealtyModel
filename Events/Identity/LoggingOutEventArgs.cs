using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Identity
{
    public class LoggingOutEventArgs
    {
        private String name = "";
        public String Name { get => name; set => name = value; }
        public LoggingOutEventArgs(String name)
        {
            this.name = name;
        }
    }
}
