using System;
using RealtyModel.Model.Base;

namespace RealtyModel.Model.Derived
{
    public class Flat : BaseRealtorObject
    {
        FlatInfo info = new FlatInfo();

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
