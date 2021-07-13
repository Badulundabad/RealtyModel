using RealtyModel.Model.Base;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Derived
{
    [Serializable]
    public class HouseInfo : INotifyPropertyChanged
    {
        private string demarcation = "";
        private string earthCategory = "";
        private bool hasSlope = false;
        private float hundreds = 0f;
        private float hectar = 0f;
        private bool hasElectricity = false;
        private string walls = "";
        private string yard = "";
        private string roof = "";
        private string sewerage = "";
        private string gas = "";
        private float facadeLength = 0;

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
        public string Demarcation
        {
            get => demarcation;
            set
            {
                demarcation = value;
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
        public float Hundreds
        {
            get => hundreds;
            set
            {
                hundreds = value;
                OnPropertyChanged();
            }
        }
        public float Hectar
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

        public float FacadeLength {
            get => facadeLength;
            set {
                facadeLength = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
