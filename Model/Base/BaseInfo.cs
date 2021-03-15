using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Base
{
    public class BaseInfo : INotifyPropertyChanged
    {
        private Int32 year = 0;
        private Int32 roomCount = 0;
        private Single general = 0;
        private Single living = 0;
        private Single kitchen = 0;
        private string description = "";
        private string water = "";
        private Single ceiling = 0;
        private string convenience = "";
        private string heating = "";
        private string condition = "";

        public string Water
        {
            get => water;
            set
            {
                water = value;
                OnPropertyChanged();
            }
        }
        public Single Ceiling
        {
            get => ceiling;
            set
            {
                if (value >= 0 && value <= 10f) {
                    ceiling = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Convenience
        {
            get => convenience;
            set
            {
                convenience = value;
                OnPropertyChanged();
            }
        }
        public string Heating
        {
            get => heating;
            set
            {
                heating = value;
                OnPropertyChanged();
            }
        }

        public string Condition
        {
            get => condition;
            set
            {
                condition = value;
                OnPropertyChanged();
            }
        }

        public Int32 Year
        {
            get => year;
            set
            {
                if (value >= 1950 && value <= 2050) {
                    year = value;
                    OnPropertyChanged();
                }
            }
        }
        public Int32 RoomCount
        {
            get => roomCount;
            set
            {
                if (value >= 0 && value <= 100) {
                    roomCount = value;
                    OnPropertyChanged();
                }
            }
        }
        public Single General
        {
            get => general;
            set
            {
                if (value >= 0 && value <= 500f) {
                    general = value;
                    OnPropertyChanged();
                }
            }
        }
        public Single Living
        {
            get => living;
            set
            {
                if (value >= 0 && value <= 500f) {
                    living = value;
                    OnPropertyChanged();
                }
            }
        }
        public Single Kitchen
        {
            get => kitchen;
            set
            {
                if (value >= 0 && value <= 500f) {
                    kitchen = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
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
