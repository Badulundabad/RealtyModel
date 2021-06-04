using System;

namespace RealtyModel.Model
{
    [Serializable]
    public class Street
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
