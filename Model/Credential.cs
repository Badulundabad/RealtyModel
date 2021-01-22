using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Credential : INotifyPropertyChanged
    {
        Int32 id = -1;
        String name = "";
        DateTime registrationDate = new DateTime();

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
            get=>name;
            set 
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public String Password { get; set; }
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
        public String Token { get; set; }

        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
