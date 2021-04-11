using RealtyModel.Model;
using System;

namespace RealtyModel.Event
{
    public class LoggedInEventArgs
    {
        private String name = "";
        public String Name { get => name; set => name = value; }
        public LoggedInEventArgs(String name)
        {
            this.name = name;
        }
    }
}