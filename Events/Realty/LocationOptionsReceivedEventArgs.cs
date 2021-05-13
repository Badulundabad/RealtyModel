using RealtyModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class LocationOptionsReceivedEventArgs
    {
        private LocationOptions locationOptions = new LocationOptions();
        public LocationOptions LocationOptions { get => locationOptions; set => locationOptions = value; }

        public LocationOptionsReceivedEventArgs(LocationOptions locationOptions)
        {
            this.locationOptions = locationOptions;
        }
    }
}
