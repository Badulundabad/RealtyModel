using RealtyModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class FlatRegisteredEventArgs
    {
        private Location location = new Location();
        public Location Location { get => location; set => location = value; }

        public FlatRegisteredEventArgs(Location location)
        {
            this.location = location;
        }
    }
}
