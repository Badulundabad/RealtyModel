using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Base
{
    public class BaseRealtorObject : INotifyPropertyChanged
    {
        private Int32 id = -1;
        private Int32 agentId = -1;
        private Int32 customerId = -1;
        private Int32 albumId = -1;
        private Int32 locationId = -1;
        
        private Agent agent = new Agent();
        private Customer customer = new Customer();
        private Album album = new Album();
        private Location location = new Location();
        private Cost cost = new Cost();
        private bool isSold = false;
        private bool hasExclusive = false;
        private DateTime registrationDate = new DateTime();
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
        public Int32 AgentId
        {
            get => agentId;
            set
            {
                agentId = value;
                OnPropertyChanged();
            }
        }
        public Agent Agent
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

        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
