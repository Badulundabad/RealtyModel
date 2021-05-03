using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model.RealtyObjects
{
    public class Photo
    {
        [Key]
        public Int32 Id { get; set; }
        public Int32 AlbumId { get; set; }
        public Byte[] Data { get; set; }
    }
}
