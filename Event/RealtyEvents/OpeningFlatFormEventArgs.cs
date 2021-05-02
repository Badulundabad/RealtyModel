using RealtyModel.Model;
using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event.RealtyEvents
{
    public class OpeningFlatFormEventArgs
    {
        private Boolean isNewFlat;
        private Flat flat = new Flat();
        private LocationOptions locationOptions = new LocationOptions();

        public Boolean IsNewFlat
        {
            get => isNewFlat;
            set => isNewFlat = value;
        }
        public Flat Flat
        {
            get => flat;
            set => flat = value;
        }
        public LocationOptions LocationOptions
        {
            get => locationOptions;
            set
            {
                locationOptions = value;
            }
        }

        public OpeningFlatFormEventArgs(Boolean isNewFlat)
        {
            this.isNewFlat = isNewFlat;
        }
        public OpeningFlatFormEventArgs(Boolean isNewFlat, Flat flat)
        {
            this.isNewFlat = isNewFlat;
            this.flat = flat;
        }
        public OpeningFlatFormEventArgs(Boolean isNewFlat, Flat flat, LocationOptions locationOptions)
        {
            this.isNewFlat = isNewFlat;
            this.flat = flat;
            this.locationOptions = locationOptions;
        }
    }
}
