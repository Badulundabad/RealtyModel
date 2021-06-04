using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Base
{
    [ComplexType, Serializable]
    public class BaseInfo : INotifyPropertyChanged
    {
        private Int32 year = 1950;
        private Int32 roomCount = 0;
        private Int32 levelCount = 0;
        private Int32 currentLevel = 0;
        private Single general = 0;
        private Single living = 0;
        private Single kitchen = 0;
        private Single ceiling = 0;
        private String description = "";
        private String water = "";
        private String convenience = "";
        private String heating = "";
        private String condition = "";
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

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
        public Int32 LevelCount
        {
            get => levelCount;
            set
            {
                levelCount = value;
                OnPropertyChanged();
            }
        }
        public Int32 CurrentLevel
        {
            get=> currentLevel;
            set
            {
                currentLevel = value;
                OnPropertyChanged();
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
        public Boolean HasBanner { get; set; }
        public Boolean HasExchange { get; set; }

        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
