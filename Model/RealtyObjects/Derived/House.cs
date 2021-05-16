using RealtyModel.Model.Base;
using System;

namespace RealtyModel.Model.Derived
{
    [Serializable]
    public class House : BaseRealtorObject
    {
        HouseInfo info = new HouseInfo();

        public HouseInfo Info
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
