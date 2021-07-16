using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model
{
    [Serializable]
    public class Agent : INotifyPropertyChanged
    {
        int id = 0;
        string nickName = String.Empty;
        string name = String.Empty;
        string surname = String.Empty;
        string patronymic = String.Empty;
        string password = String.Empty;
        string phoneNumber = String.Empty;
        DateTime registrationDate = new DateTime();
        string email = String.Empty;

        public int Id {
            get => id;
            set {
                id = value;
                OnPropertyChanged();
            }
        }
        public string NickName {
            get => nickName;
            set {
                nickName = value;
                OnPropertyChanged();
            }
        }
        public string Name {
            get => name;
            set {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Surname {
            get => surname;
            set {
                surname = value;
                OnPropertyChanged();
            }
        }
        public string Patronymic {
            get => patronymic;
            set {
                patronymic = value;
                OnPropertyChanged();
            }
        }
        public DateTime RegistrationDate {
            get => registrationDate;
            set {
                registrationDate = value;
                OnPropertyChanged();
            }
        }
        public string Email {
            get => email;
            set {
                email = value;
                OnPropertyChanged();
            }
        }
        public string Password {
            get => password;
            set {
                password = value;
                OnPropertyChanged();
            }
        }
        public string PhoneNumber {
            get => phoneNumber;
            set {
                phoneNumber = value;
                OnPropertyChanged();
            }
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
