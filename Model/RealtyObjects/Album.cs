using RealtyModel.Model.RealtyObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
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
