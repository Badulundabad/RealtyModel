using System;
using RealtyModel.Model.Base;

namespace RealtyModel.Model.Derived
{
    [Serializable]
    public class Flat : BaseRealtorObject
    {
        public FlatInfo Info { get; set; }

        public Flat()
        {
        }
        public Flat(bool isNewInstance)
        {
            Customer = new Customer();
            Album = new Album();
            Location = new Location();
            if (isNewInstance)
                this.RegistrationDate = DateTime.Now;
        }
    }
}
