using System;
using System.ComponentModel.DataAnnotations;
using RealtyModel.Model.Operations;

namespace RealtyModel.Model.RealtyObjects
{
    [Serializable]
    public class Photo
    {
        [Key]
        public Int32 Id { get; set; }
        public String Location { get; set; }
        public Target ObjectType { get; set; }
        public Byte[] Data { get; set; }
    }
}
