using RealtyModel.Model;

namespace RealtyModel.Events.Realty
{
    public class ListsArrivedEventArgs
    {
        private LocationOptions locationOptions;
        public ListsArrivedEventArgs(LocationOptions locationOptions)
        {
            this.LocationOptions = locationOptions;
        }

        public LocationOptions LocationOptions
        {
            get => locationOptions;
            set => locationOptions = value;
        }
    }
}