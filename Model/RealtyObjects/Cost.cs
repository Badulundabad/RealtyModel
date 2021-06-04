using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    [ComplexType, Serializable]
    public class Cost : INotifyPropertyChanged
    {
        Int32 price;
        bool hasMortgage; //Ипотека
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
        public bool HasMortgage {
            get => hasMortgage;
            set {
                hasMortgage = value;
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
