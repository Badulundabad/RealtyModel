using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public class DeleteHouseEventArgs
    {
        private House house;
        public House House { get => house; set => house = value; }
        public DeleteHouseEventArgs(House house)
        {
            this.house = house;
        }
    }
}
