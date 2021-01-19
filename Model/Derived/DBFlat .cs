using System;
using RealtyModel.Model.Base;

namespace RealtyModel.Model.Derived
{
    public class DBFlat : BaseRealtorDBObject
    {
        private FlatInfo info = new FlatInfo();

        public FlatInfo Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged();
            }
        }

        public static DBFlat GetDBFlat(Flat flat)
        {
            DBFlat dBFlat = new DBFlat()
            {
                Cost = flat.Cost,
                Info = flat.Info,
                IsSold = flat.IsSold,
                Location = flat.Location
            };
            return dBFlat;
        }
    }
}
