using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class PhotoSavedEventArgs
    {
        private String guid = "";
        public String Guid { get => guid; set => guid = value; }

        public PhotoSavedEventArgs(String guid)
        {
            this.guid = guid;
        }
    }
}
