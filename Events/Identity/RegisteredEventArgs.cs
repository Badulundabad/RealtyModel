using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Identity
{
    public class RegisteredEventArgs
    {
        private String name = "";
        public String Name { get => name; set => name = value; }
        public RegisteredEventArgs(String name)
        {
            this.name = name;
        }
    }
}
