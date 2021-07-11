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


        public Boolean CompareWith(Location location) {
            return this.City == location.City
                && this.District == location.District
                && this.Street == location.Street
                && this.HouseNumber == location.HouseNumber
                && this.FlatNumber == location.FlatNumber;
        }
        public override Boolean Equals(object obj) {
            Location location = obj as Location;
            return City == location.City &&
                   District == location.District &&
                   Street == location.Street &&
                   HouseNumber.Equals(location.HouseNumber) &&
                   FlatNumber == FlatNumber;
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
