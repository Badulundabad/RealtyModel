using System;

namespace RealtyModel.Model
{
    [Serializable]
    public class Album
    {
        public Int32 Id
        {
            get; set;
        }
        public String Location
        {
            get; set;
        }
        public Byte[] PhotoCollection { get; set; }

        public Album()
        {
            PhotoCollection = Array.Empty<Byte>();
        }

        public void WriteLocation(Location location)
        {
            Location = $"{location.City};{location.District};{location.Street.Name};{location.HouseNumber};{location.FlatNumber};";
        }
    }
}
