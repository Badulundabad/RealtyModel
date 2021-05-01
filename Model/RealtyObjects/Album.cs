using System;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Album
    {
        public Int32 Id { get; set; }
        public String Location { get; set; }
        public Byte[] Preview { get; set; }
        public Byte[] PhotoList { get; set; }
    }
}
