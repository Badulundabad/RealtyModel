using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Credential : INotifyPropertyChanged
    {
        String password = "";
        DateTime registrationDate = new DateTime();

        public Int32 Id
        {
            get => Agent.Id;
            set
            {
                Agent.Id = value;
                OnPropertyChanged();
            }
        }
        public String Name
        {
            get => Agent.Name;
            set
            {
                Agent.Name = value;
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
        public Agent Agent { get; set; }
        [NotMapped]
        public String IpAddress { get; set; }
        [NotMapped]
        public String Token { get; set; }

        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
