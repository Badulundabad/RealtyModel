using System;
using RealtyModel.Model.Base;

namespace RealtyModel.Model.Derived
{
    public class Flat : BaseRealtorObject
    {
        private FlatInfo info = new FlatInfo();
        public Flat() {
        }
        public Flat(bool isNewInstance) {
            if (isNewInstance)
                this.RegistrationDate = DateTime.Now;
        }
        public FlatInfo Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged();
            }
        }
    }
}
