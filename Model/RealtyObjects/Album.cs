using System;

namespace RealtyModel.Model
{
    [Serializable]
    public class Album
    {
        private Int32 id = 0;
        private string location = "";
        private byte[] photoCollection = Array.Empty<byte>();

        public int Id {
            get => id;
            set => id = value;
        }
        public string Location {
            get => location;
            set => location = value;
        }
        public byte[] PhotoCollection {
            get => photoCollection;
            set => photoCollection = value;
        }

        public void WriteLocation(Location location) {
            Location = $"{location.City};{location.District};{location.Street};{location.HouseNumber};{location.FlatNumber};";
        }
    }
}
