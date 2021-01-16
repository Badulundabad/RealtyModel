using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model
{
    public class Agent : INotifyPropertyChanged
    {
        Int32 id = -1;
        Credential credential = new Credential();
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
        public Credential Credential
        {
            get => credential;
            set
            {
                credential = value;
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

        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
