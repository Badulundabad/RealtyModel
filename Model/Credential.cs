using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Credential : INotifyPropertyChanged
    {
        Agent agent = new Agent();
        String password = "";
        DateTime registrationDate = new DateTime();

        [NotMapped]
        public Agent Agent { get => agent; set => agent = value; }
        [NotMapped]
        public String IpAddress { get; set; }
        [NotMapped]
        public String Token { get; set; }

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
        

        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
