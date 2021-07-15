using System;
using PropertyChanged;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    [Serializable, AddINotifyPropertyChangedInterface]
    public class Location : INotifyPropertyChanged
    {
        private string city = "";
        private string district = "";
        private string street = "";
        private string houseNumber = "";
        private Int16 flatNumber = 0;

        public string City {
            get => city;
            set {
                city = value;
                OnPropertyChanged();
            }
        }
        public string District {
            get => district;
            set {
                district = value;
                OnPropertyChanged();
            }
        }
        public string Street {
            get => street;
            set {
                street = value;
                OnPropertyChanged();
            }
        }
        public string HouseNumber {
            get => houseNumber;
            set {
                houseNumber = value;
                OnPropertyChanged();
            }
        }
        public short FlatNumber {
            get => flatNumber;
            set {
                flatNumber = value;
                OnPropertyChanged();
            }
        }
        
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
