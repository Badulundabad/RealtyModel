using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace RealtyModel.Model
{
    [Serializable]
    public class Location
    {
        public Int32 Id { get; set; }
        public Int32 CityId { get; set; }
        public City City { get; set; }
        public Int32 DistrictId { get; set; }
        public District District { get; set; }
        public Int32 StreetId { get; set; }
        public Street Street { get; set; }
        public Int16 HouseNumber { get; set; }
        public Int16 FlatNumber { get; set; }
        public Boolean HasBanner { get; set; }
        public Boolean HasExchange { get; set; }

        public Boolean CompareWith(Location location)
        {
            return this.City.Name == location.City.Name
                && this.District.Name == location.District.Name
                && this.Street.Name == location.Street.Name
                && this.HouseNumber == location.HouseNumber
                && this.FlatNumber == location.FlatNumber;
        }
        public Location GetCopy()
        {
            return new Location()
            {
                City = new City() { Name = this.City.Name },
                District = new District() { Name = this.District.Name },
                Street = new Street() { Name = this.Street.Name },
                HouseNumber = this.HouseNumber,
                FlatNumber = this.FlatNumber
            };
        }
    }
}
