using RealtyModel.Model.Operations;
using RealtyModel.Model.RealtyObjects;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace RealtyModel.Model.Base
{
    [Serializable]
    public class BaseRealtorObject : INotifyPropertyChanged
    {
        private Int32 id;
        private Int32 albumId;
        private Int32 locationId;
        private bool hasExclusive;
        private String type = "";
        private String agent = "";
        private Album album = new Album();
        private Cost cost = new Cost();
        private BaseInfo generalInfo;
        private DateTime lastUpdateTime;
        private DateTime registrationDate;
        private DateTime lastCallTime;

        public Int32 Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public Int32 AlbumId
        {
            get => albumId;
            set
            {
                albumId = value;
                OnPropertyChanged();
            }
        }
        public Int32 LocationId
        {
            get => locationId;
            set
            {
                locationId = value;
                OnPropertyChanged();
            }
        }
        public String Agent
        {
            get => agent;
            set
            {
                agent = value;
                OnPropertyChanged();
            }
        }
        public String Type
        {
            get => type;
            set
            {
                type = value;
                OnPropertyChanged();
            }
        }
        public Byte[] Preview { get; set; }
        public String CustomerName { get; set; }
        public String CustomerPhoneNumbers { get; set; }
        public Cost Cost
        {
            get => cost;
            set
            {
                cost = value;
                OnPropertyChanged();
            }
        }
        public Location Location { get; set; }
        public BaseInfo GeneralInfo
        {
            get => generalInfo;
            set => generalInfo = value;
        }
        public DateTime LastUpdateTime
        {
            get => lastUpdateTime;
            set => lastUpdateTime = value;
        }
        public DateTime RegistrationDate
        {
            get => registrationDate;
            set
            {
                registrationDate = value;
            }
        }
        public DateTime LastCallTime
        {
            get => lastCallTime;
            set => lastCallTime = value;
        }
        public bool HasExclusive
        {
            get => hasExclusive;
            set
            {
                hasExclusive = value;
                OnPropertyChanged();
            }
        }

        [NotMapped]
        public Album Album
        {
            get => album;
            set => album = value;
        }
        [NotMapped]
        public String[] PhoneNumberList => CustomerPhoneNumbers.Split(new char[] { ';', ',' });
        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
