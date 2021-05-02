using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model
{
    public class District
    {
        public override string ToString() {
            return this.Name;
        }
        public Int32 Id { get; set; }
        public String Name { get; set; }
    }
}
