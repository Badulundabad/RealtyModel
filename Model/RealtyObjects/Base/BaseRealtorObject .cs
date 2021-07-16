using RealtyModel.Model.Operations;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace RealtyModel.Model.Base
{
    [Serializable]
    public class BaseRealtorObject : INotifyPropertyChanged
    {
        private Int32 id = 0;
        private Int32 agentId = 0;
        private Int32 albumId = 0;
        private String agent = "";
        private Album album = new Album();
        private BaseInfo generalInfo = new BaseInfo();
        private DateTime lastUpdateTime;
        private DateTime registrationDate;
        private DateTime lastCallTime;
        private Int32 price = 0;
        private bool hasMortgage = false;
        private byte[] preview = Array.Empty<Byte>();
        private string customerName = "";
        private string customerPhoneNumbers = "";
        private Location location = new Location();
        public Int32 Price {
            get => price;
            set {
                if (value < 0) {
                    price = 0;
                } else if (value > 40000) {
                    price = 40000;
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
        public Int32 Id {
            get => id;
            set {
                id = value;
                OnPropertyChanged();
            }
        }
        public Int32 AlbumId {
            get => albumId;
            set {
                albumId = value;
                OnPropertyChanged();
            }
        }
        public String Agent {
            get => agent;
            set {
                agent = value;
                OnPropertyChanged();
            }
        }
        public BaseInfo GeneralInfo {
            get => generalInfo;
            set => generalInfo = value;
        }
        public DateTime LastUpdateTime {
            get => lastUpdateTime;
            set => lastUpdateTime = value;
        }
        public DateTime RegistrationDate {
            get => registrationDate;
            set {
                registrationDate = value;
            }
        }
        public DateTime LastCallTime {
            get => lastCallTime;
            set => lastCallTime = value;
        }
        [NotMapped]
        public Album Album {
            get => album;
            set => album = value;
        }
        [NotMapped]
        public String[] PhoneNumberList => CustomerPhoneNumbers.Split(new char[] { ';', ',' });

        public byte[] Preview {
            get => preview;
            set => preview = value;
        }
        public string CustomerName {
            get => customerName;
            set {
                customerName = value;
                OnPropertyChanged();
            }
        }
        public string CustomerPhoneNumbers {
            get => customerPhoneNumbers;
            set {
                customerPhoneNumbers = value;
                OnPropertyChanged();
            }
        }
        public Location Location {
            get => location;
            set => location = value;
        }
        public int AgentId {
            get => agentId;
            set => agentId = value;
        }

        public void OnPropertyChanged([CallerMemberName] String property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
