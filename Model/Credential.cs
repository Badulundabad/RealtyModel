using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using RealtyModel.Event;

namespace RealtyModel.Model
{
    public class Credential : INotifyPropertyChanged
    {
        private Int32 id;
        private String name;
        private String password;
        private String email;
        private Boolean isLoggedIn = false;
        private DateTime registrationDate = new DateTime();
        private Dispatcher dispatcher;
        public event PropertyChangedEventHandler PropertyChanged;
        public event LoggedInEventHandler LoggedIn;
        public event LoggedOutEventHandler LoggedOut;
        public event RegisteredEventHandler Registered;

        public Credential()
        {

        }
        public Credential(Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        [NotMapped]
        public IPAddress IpAddress { get; set; }
        [NotMapped]
        public Guid Token { get; set; }
        [NotMapped]
        public Boolean IsLoggedIn
        {
            get => isLoggedIn;
            private set
            {
                isLoggedIn = value;
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
        public String Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public String Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        public String Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        public DateTime RegistrationDate
        {
            get => registrationDate;
            set
            {
                registrationDate = value;
                OnPropertyChanged();
            }
        }

        public void OnLoggedIn()
        {
            IsLoggedIn = true;
            LoggedIn?.Invoke(this, new LoggedInEventArgs(Name));
        }
        public void OnLoggedOut()
        {
            IsLoggedIn = false;
            LoggedOut?.Invoke(this, new LoggedInEventArgs(Name));
        }
        public void OnRegistered()
        {
            dispatcher.Invoke(new Action(() =>
            {
                IsLoggedIn = false;
                Registered?.Invoke(this, new LoggedInEventArgs(Name));
            }));
        }
        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
