using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    [ComplexType]
    public class Cost : INotifyPropertyChanged
    {
        Single area = 0;
        Int32 price = 0;
        bool hasVAT = false; // НДС
        bool hasMortgage = false; //Ипотека

        public Single Area
        {
            get => area;
            set
            {
                area = value;
                OnPropertyChanged();
            }
        }
        public Int32 Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }
        public bool HasVAT
        {
            get => hasVAT;
            set
            {
                hasVAT = value;
                OnPropertyChanged();
            }
        }
        public bool HasMortgage
        {
            get => hasMortgage;
            set
            {
                hasMortgage = value;
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
