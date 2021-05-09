using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RealtyModel.Model.RealtyObjects
{
    public class Photo
    {
        [Key]
        public Int32 Id { get; set; }
        public String Location { get; set; }
        public TargetType ObjectType { get; set; }
        public String DataJson { get; set; }

        public void FillData()
        {
            Data = JsonSerializer.Deserialize<Byte[]>(DataJson);
        }
        [NotMapped, JsonIgnore]
        public Byte[] Data { get; set; }
        [NotMapped, JsonIgnore]
        public String Guid { get; set; }
    }
}
