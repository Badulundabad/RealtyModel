using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Customer : INotifyPropertyChanged
    {
        Int32 id = -1;
        String name = "";
        String phoneNumbers = "";

        public Int32 Id {
            get => id;
            set {
                id = value;
                OnPropertyChanged();
            }
        }
        public String Name {
            get => name;
            set {
                if (value.Length <= 32) {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public String PhoneNumbers {
            get => phoneNumbers;
            set {
                if (value.Length <= 39) {
                    phoneNumbers = value;
                    OnPropertyChanged();
                }
            }
        }
        [NotMapped]
        public ObservableCollection<String> PhoneNumberList {
            get => new ObservableCollection<String>(phoneNumbers.Trim().Split(new Char[] { ';', ',' }));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String prop = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
