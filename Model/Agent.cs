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
        private int id = 0;
        private string nickName = String.Empty;
        private string name = String.Empty;
        private string surname = String.Empty;
        private string patronymic = String.Empty;
        private string password = String.Empty;
        private string phoneNumber = String.Empty;
        private DateTime registrationDate = new DateTime();
        private string email = String.Empty;
        private int objectCount = 0;

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

        public int ObjectCount {
            get => objectCount;
            set => objectCount = value;
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
