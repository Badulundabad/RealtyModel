using RealtyModel.Model.RealtyObjects;
using System;

namespace RealtyModel.Model
{
    [Serializable]
    public class Location
    {
        public Int32 Id { get; set; }
        public City City { get; set; }
        public District District { get; set; }
        public Int32 StreetId { get; set; }
        public Street Street { get; set; }
        public String HouseNumber { get; set; }
        public Int16 FlatNumber { get; set; }

        public Boolean CompareWith(Location location)
        {
            return this.City == location.City
                && this.District == location.District
                && this.Street.Name == location.Street.Name
                && this.HouseNumber == location.HouseNumber
                && this.FlatNumber == location.FlatNumber;
        }
        public override Boolean Equals(object obj)
        {
            Location location = obj as Location;
            return City == location.City &&
                   District == location.District &&
                   Street.Name == location.Street.Name &&
                   HouseNumber.Equals(location.HouseNumber) &&
                   FlatNumber == FlatNumber;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
