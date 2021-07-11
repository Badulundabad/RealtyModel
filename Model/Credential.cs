using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace RealtyModel.Model
{
    [Serializable]
    public class Credential : INotifyPropertyChanged
    {
        private Int32 id = 0;
        private String name = "";
        private String password = "";
        private String email = "";
        private DateTime registrationDate = new DateTime();
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        public Credential()
        {

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
        [NotMapped]
        public String IpAddress { get; set; }
        [NotMapped]
        public String Token { get; set; }
        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
