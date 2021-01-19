using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    [ComplexType]
    public class Location : INotifyPropertyChanged
    {
        String city = "";
        String district = "";
        String street = "";
        Int16 houseNumber = 0;
        Int16 flatNumber = 0;
        bool banner = false;
        bool exchange = false;

        public String City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }
        public String District
        {
            get => district;
            set
            {
                district = value;
                OnPropertyChanged();
            }
        }
        public String Street
        {
            get => street;
            set
            {
                street = value;
                OnPropertyChanged();
            }
        }
        public Int16 HouseNumber
        {
            get => houseNumber;
            set
            {
                houseNumber = value;
                OnPropertyChanged();
            }
        }
        public Int16 FlatNumber
        {
            get => flatNumber;
            set
            {
                flatNumber = value;
                OnPropertyChanged();
            }
        }

        public bool Exchange
        {
            get => exchange;
            set
            {
                exchange = value;
                OnPropertyChanged();
            }
        }
        public bool Banner
        {
            get => banner;
            set
            {
                banner = value;
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
