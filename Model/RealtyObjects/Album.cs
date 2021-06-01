using System;

namespace RealtyModel.Model
{
    [Serializable]
    public class Album
    {
        public Int32 Id { get; set; }
        public String Location { get; set; }
        public Byte[] PhotoCollection { get; set; }

        public void WriteLocation(Location location)
        {
            Location = $"{location.City.Name};{location.District.Name};{location.Street.Name};{location.HouseNumber};{location.FlatNumber};";
        }
        public Album GetCopy()
        {
            return (Album)this.MemberwiseClone();
        }
    }
}
