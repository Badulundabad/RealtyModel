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
                
                if (value >= 0 && value <= 10f)
                {
                    ceiling = value;
                    OnPropertyChanged();
                }
                else if (value < 0)
                {
                    ceiling = 0;
                    OnPropertyChanged();
                }
                else if (value > 10)
                {
                    ceiling = 10;
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
                if (value >= 1950 && value <= 2050)
                {
                    year = value;
                    OnPropertyChanged();
                }
                else if (value < 1950)
                {
                    year = 1950;
                    OnPropertyChanged();
                }
                else if (value > 2050)
                {
                    year = 2050;
                    OnPropertyChanged();
                }
            }
        }
        public Int32 RoomCount
        {
            get => roomCount;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roomCount = value;
                    OnPropertyChanged();
                }
                else if (value < 0)
                {
                    roomCount = 0;
                    OnPropertyChanged();
                }
                else if (value > 100)
                {
                    roomCount = 100;
                    OnPropertyChanged();
                }
            }
        }
        public Int32 LevelCount
        {
            get => levelCount;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    levelCount = value;
                    OnPropertyChanged();
                }
                else if (value < 0)
                {
                    levelCount = 0;
                    OnPropertyChanged();
                }
                else if (value > 100)
                {
                    levelCount = 100;
                    OnPropertyChanged();
                }
            }
        }
        public Int32 CurrentLevel
        {
            get => currentLevel;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    currentLevel = value;
                    OnPropertyChanged();
                }
                else if (value < 0)
                {
                    currentLevel = 0;
                    OnPropertyChanged();
                }
                else if (value > 100)
                {
                    currentLevel = 100;
                    OnPropertyChanged();
                }
            }
        }
        public Single General
        {
            get => general;
            set
            {
                if (value >= 0 && value <= 5000f)
                {
                    general = value;
                    OnPropertyChanged();
                }
                else if (value < 0)
                {
                    general = 0;
                    OnPropertyChanged();
                }
                else if (value > 5000)
                {
                    general = 5000;
                    OnPropertyChanged();
                }
            }
        }
        public Single Living
        {
            get => living;
            set
            {
                if (value >= 0 && value <= 500f)
                {
                    living = value;
                    OnPropertyChanged();
                }
                else if (value < 0)
                {
                    living = 0;
                    OnPropertyChanged();
                }
                else if (value > 500)
                {
                    living = 500;
                    OnPropertyChanged();
                }
            }
        }
        public Single Kitchen
        {
            get => kitchen;
            set
            {
                if (value >= 0 && value <= 500f)
                {
                    kitchen = value;
                    OnPropertyChanged();
                }
                else if (value < 0)
                {
                    kitchen = 0;
                    OnPropertyChanged();
                }
                else if (value > 500)
                {
                    kitchen = 500;
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
