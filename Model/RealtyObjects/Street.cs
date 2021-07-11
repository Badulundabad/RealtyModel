using PropertyChanged;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    [Serializable]
    public class Street : INotifyPropertyChanged
    {
        private Int32 id = 0;
        private string name = "";

        public int Id {
            get => id;
            set => id = value;
        }
        public string Name {
            get => name;
            set {
                name = value;
                OnPropertyChanged();
            }
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public override string ToString() {
            return this.Name;
        }
    }
}
