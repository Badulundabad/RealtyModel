using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Base
{
    public class BaseInfo : INotifyPropertyChanged
    {
        Int32 year = 0;
        Int32 roomCount = 0;
        Single general = 0;
        Single living = 0;
        Single kitchen = 0;
        string description = "";
        string water = "";
        Single ceiling = 0;
        string convenience = "";
        string heating = "";
        string condition = "";

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
                ceiling = value;
                OnPropertyChanged();
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
                year = value;
                OnPropertyChanged();
            }
        }
        public Int32 RoomCount
        {
            get => roomCount;
            set
            {
                roomCount = value;
                OnPropertyChanged();
            }
        }
        public Single General
        {
            get => general;
            set
            {
                general = value;
                OnPropertyChanged();
            }
        }
        public Single Living
        {
            get => living;
            set
            {
                living = value;
                OnPropertyChanged();
            }
        }
        public Single Kitchen
        {
            get => kitchen;
            set
            {
                kitchen = value;
                OnPropertyChanged();
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
