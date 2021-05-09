using RealtyModel.Model.Operations;
using RealtyModel.Model.RealtyObjects;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace RealtyModel.Model.Base
{
    public class BaseRealtorObject : INotifyPropertyChanged
    {
        private Int32 id;
        private Int32 customerId;
        private Int32 albumId;
        private Int32 locationId;
        private Target type = Target.None;
        private String agent = "";
        private Boolean isSold = false;
        private Boolean hasExclusive = false;
        private Boolean hasBaseChanges = false;
        private Boolean hasAlbumChanges = false;
        private Boolean hasCustomerChanges = false;
        private Boolean hasLocationChanges = false;
        private Status status = Status.Active;
        private Cost cost = new Cost();
        private BaseInfo generalInfo;
        private DateTime lastUpdateTime;
        private DateTime registrationDate;


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
        public Int32 CustomerId
        {
            get => customerId;
            set
            {
                customerId = value;
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
        public Target Type
        {
            get => type;
            set
            {
                type = value;
                OnPropertyChanged();
            }
        }
        public Boolean IsSold
        {
            get => isSold;
            set
            {
                isSold = value;
                OnPropertyChanged();
            }
        }
        public Boolean HasExclusive
        {
            get => hasExclusive;
            set
            {
                hasExclusive = value;
                OnPropertyChanged();
            }
        }
        public Status Status
        {
            get => status;
            set => status = value;
        }
        public Cost Cost
        {
            get => cost;
            set
            {
                cost = value;
                OnPropertyChanged();
            }
        }
        public Album Album { get; set; }
        public Customer Customer { get; set; }
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

        [NotMapped]
        public Boolean HasBaseChanges { get => hasBaseChanges; set => hasBaseChanges = value; }
        [NotMapped]
        public Boolean HasAlbumChanges { get => hasAlbumChanges; set => hasAlbumChanges = value; }
        [NotMapped]
        public Boolean HasCustomerChanges { get => hasCustomerChanges; set => hasCustomerChanges = value; }
        [NotMapped]
        public Boolean HasLocationChanges { get => hasLocationChanges; set => hasLocationChanges = value; }

        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
