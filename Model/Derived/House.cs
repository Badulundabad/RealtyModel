using RealtyModel.Model.Base;

namespace RealtyModel.Model.Derived
{
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
