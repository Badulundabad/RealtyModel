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
        private int hundreds = 0;
        private int hectar = 0;
        private bool hasElectricity = false;
        private string walls = "";
        private string yard = "";
        private string roof = "";
        private string sewerage = "";
        private string gas = "";
        private float facadeLength = 0;

        public string Walls {
            get => walls;
            set {
                walls = value;
                OnPropertyChanged();
            }
        }
        public string Yard {
            get => yard;
            set {
                yard = value;
                OnPropertyChanged();
            }
        }
        public string Roof {
            get => roof;
            set {
                roof = value;
                OnPropertyChanged();
            }
        }
        public string Sewerage {
            get => sewerage;
            set {
                sewerage = value;
                OnPropertyChanged();
            }
        }
        public string Gas {
            get => gas;
            set {
                gas = value;
                OnPropertyChanged();
            }
        }
        public string Demarcation {
            get => demarcation;
            set {
                demarcation = value;
                OnPropertyChanged();
            }
        }
        public string EarthCategory {
            get => earthCategory;
            set {
                earthCategory = value;
                OnPropertyChanged();
            }
        }
        public bool HasSlope {
            get => hasSlope;
            set {
                hasSlope = value;
                OnPropertyChanged();
            }
        }
        public int Hundreds {
            get => hundreds;
            set {
                if (value >= 0 && value <= 50) {
                    hundreds = value;
                } else if (value > 50) {
                    hundreds = 50;
                } else if (value < 0) {
                    hundreds = 0;
                }
                OnPropertyChanged();
            }
        }
        public int Hectar {
            get => hectar;
            set {
                if (value >= 0 && value <= 50) {
                    hectar = value;
                } else if (value > 50) {
                    hectar = 50;
                } else if (value < 0) {
                    hectar = 0;
                }
                OnPropertyChanged();
            }
        }
        public bool HasElectricity {
            get => hasElectricity;
            set {
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

        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
