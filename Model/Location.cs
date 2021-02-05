using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Location : INotifyPropertyChanged
    {
        Int32 id = -1;
        City city = new City();
        District district = new District();
        Street street = new Street();
        Int16 houseNumber = 0;
        Int16 flatNumber = 0;
        Boolean hasBanner = false;
        Boolean hasExchange = false;

        public Int32 Id {
            get => id;
            set {
                id = value;
                OnPropertyChanged();
            }
        }
        public Int32 CityId {
            get; set;
        }
        public City City {
            get => city;
            set {
                city = value;
                OnPropertyChanged();
            }
        }
        public Int32 DistrictId {
            get; set;
        }
        public District District {
            get => district;
            set {
                district = value;
                OnPropertyChanged();
            }
        }
        public Int32 StreetId {
            get; set;
        }
        public Street Street {
            get => street;
            set {
                street = value;
                OnPropertyChanged();
            }
        }
        public Int16 HouseNumber {
            get => houseNumber;
            set {
                if (value <= 999) {
                    houseNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public Int16 FlatNumber {
            get => flatNumber;
            set {
                if (value <= 999) {
                    flatNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public Boolean HasExchange {
            get => hasExchange;
            set {
                hasExchange = value;
                OnPropertyChanged();
            }
        }
        public Boolean HasBanner {
            get => hasBanner;
            set {
                hasBanner = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] String property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
