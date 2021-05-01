using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace RealtyModel.Model
{
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
    }
}
