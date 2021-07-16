using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    [Serializable]
    public class Credential : INotifyPropertyChanged
    {
        private String name = "";
        private String password = "";
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
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
