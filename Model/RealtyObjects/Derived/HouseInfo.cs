using RealtyModel.Model.Base;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Derived
{
    public class HouseInfo : INotifyPropertyChanged
    {
        string typeOfHouse = "";
        int levels = 0;
        int floors = 0;
        bool hasDemarcation = false; //межевание
        string earthCategory = "";
        bool hasSlope = false;
        Single hundreds = 0f;
        Single hectar = 0f;
        bool hasElectricity = false;
        string walls = "";
        string yard = "";
        string roof = "";
        string sewerage = "";
        string gas = "";

        public string Walls
        {
            get => walls;
            set
            {
                walls = value;
                OnPropertyChanged();
            }
        }
        public string Yard
        {
            get => yard;
            set
            {
                yard = value;
                OnPropertyChanged();
            }
        }
        public string Roof
        {
            get => roof;
            set
            {
                roof = value;
                OnPropertyChanged();
            }
        }
        public string Sewerage
        {
            get => sewerage;
            set
            {
                sewerage = value;
                OnPropertyChanged();
            }
        }
        public string Gas
        {
            get => gas;
            set
            {
                gas = value;
                OnPropertyChanged();
            }
        }

        public string TypeOfHouse
        {
            get => typeOfHouse;
            set
            {
                typeOfHouse = value;
                OnPropertyChanged();
            }
        }
        public int Levels
        {
            get => levels;
            set
            {
                levels = value;
                OnPropertyChanged();
            }
        }
        public int Floors
        {
            get => floors;
            set
            {
                floors = value;
                OnPropertyChanged();
            }
        }
        public bool HasDemarcation
        {
            get => hasDemarcation;
            set
            {
                hasDemarcation = value;
                OnPropertyChanged();
            }
        }
        public string EarthCategory
        {
            get => earthCategory;
            set
            {
                earthCategory = value;
                OnPropertyChanged();
            }
        }
        public bool HasSlope
        {
            get => hasSlope;
            set
            {
                hasSlope = value;
                OnPropertyChanged();
            }
        }
        public Single Hundreds
        {
            get => hundreds;
            set
            {
                hundreds = value;
                OnPropertyChanged();
            }
        }
        public Single Hectar
        {
            get => hectar;
            set
            {
                hectar = value;
                OnPropertyChanged();
            }
        }
        public bool HasElectricity
        {
            get => hasElectricity;
            set
            {
                hasElectricity = value;
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
