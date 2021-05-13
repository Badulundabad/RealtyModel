using RealtyModel.Model.RealtyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class PhotoReceivedEventArgs
    {
        private Photo photo = new Photo();
        public Photo Photo { get => photo; set => photo = value; }

        public PhotoReceivedEventArgs(Photo photo)
        {
            this.photo = photo;
        }
    }
}
