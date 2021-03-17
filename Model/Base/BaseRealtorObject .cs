using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Base
{
    public class BaseRealtorObject : INotifyPropertyChanged
    {
        private Int32 id;
        private Int32 customerId;
        private Int32 albumId;
        private Int32 locationId;
        
        private BaseInfo generalInfo = new BaseInfo();
        private string objectType = "";
        private String agent;
        private Customer customer;
        private Album album;
        private Location location;
        private Cost cost;
        private bool isSold = false;
        private bool hasExclusive = false;
        private DateTime registrationDate = DateTime.Now;
        private Status status = Status.Active;
        public string ObjectType {
            get => objectType;
            set {
                objectType = value;
                OnPropertyChanged();
            }
        }
        public Int32 Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public bool IsSold
        {
            get => isSold;
            set
            {
                isSold = value;
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
        public Int32 CustomerId
        {
            get => customerId;
            set
            {
                customerId = value;
                OnPropertyChanged();
            }
        }
        public Customer Customer
        {
            get => customer;
            set
            {
                customer = value;
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
        public Album Album
        {
            get => album;
            set
            {
                album = value;
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
        public Location Location
        {
            get => location;
            set
            {
                location = value;
                OnPropertyChanged();
            }
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
        public DateTime RegistrationDate {
            get => registrationDate;
            protected set {
                registrationDate = value;
            }
        }
        public bool HasExclusive {
            get => hasExclusive;
            set {
                hasExclusive = value;
                OnPropertyChanged();
            }
        }
        public BaseInfo GeneralInfo {
            get => generalInfo;
            set => generalInfo = value;
        }
        public Status Status {
            get => status;
            set => status = value;
        }

        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
    public enum Status
    {
        Active,
        Archived,
        Planned
    }
}
