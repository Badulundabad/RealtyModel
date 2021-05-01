using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    [ComplexType]
    public class Cost : INotifyPropertyChanged
    {
        Int32 area;
        Int32 price;
        bool hasVAT; // НДС
        bool hasMortgage; //Ипотека
        bool hasPercents;
        public Int32 Area {
            get => area;
            set {
                if (value < 0) {
                    area = 0;
                } else if (value > 1500) {
                    area = 1500;
                } else {
                    area = value;
                }
                OnPropertyChanged();
            }
        }
        public Int32 Price {
            get => price;
            set {
                if (value < 0) {
                    price = 0;
                } else if (value > 20000000) {
                    price = 20000000;
                } else {
                    price = value;
                }
                OnPropertyChanged();
            }
        }
        public bool HasVAT {
            get => hasVAT;
            set {
                hasVAT = value;
                OnPropertyChanged();
            }
        }
        public bool HasMortgage {
            get => hasMortgage;
            set {
                hasMortgage = value;
                OnPropertyChanged();
            }
        }
        public bool HasPercents {
            get => hasPercents;
            set {
                hasPercents = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
