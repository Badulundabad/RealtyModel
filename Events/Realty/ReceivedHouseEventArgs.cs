using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class ReceivedHouseEventArgs
    {
        private House house;
        public House House { get => house; set => house = value; }
        public ReceivedHouseEventArgs(House house)
        {
            this.house = house;
        }
    }
}
