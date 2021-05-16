using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Service
{
    public class CheckAndHeightPair : INotifyPropertyChanged
    {
        bool check = false;
        Int16 height = 50;

        public CheckAndHeightPair(bool key, short value) {
            Check = key;
            Height = value;
        }

        public bool Check {
            get => check;
            set {
                check = value;
                OnPropertyChanged();
            }
        }
        public short Height {
            get => height;
            set {
                height = value;
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
