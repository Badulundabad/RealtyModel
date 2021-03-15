using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using RealtyModel.Model.Base;

namespace RealtyModel.Model.Derived
{
    [ComplexType]
    public class FlatInfo : INotifyPropertyChanged
    {
        private string material = "";
        private string fund = "";
        private string type = "";
        private string windows = "";
        private Int32 kvl = 0;
        private bool isPrivatised = false;
        private bool hasImprovedLayout = false;
        private bool hasRenovation = false;
        private bool hasChute = false; //мусоропровод
        private string typeOfRooms = "";
        private string rooms = "";
        private bool hasGarage = false;
        private bool hasElevator = false;
        private bool isCorner = false;
        private string balcony = "";
        private string loggia = "";
        private string bath = "";
        private string bathroom = "";
        private string floor = "";
        private bool isSeparated = true;

        public string Balcony {
            get => balcony;
            set {
                balcony = value;
                OnPropertyChanged();
            }
        }
        public string Loggia {
            get => loggia;
            set {
                loggia = value;
                OnPropertyChanged();
            }
        }
        public string Bath {
            get => bath;
            set {
                bath = value;
                OnPropertyChanged();
            }
        }
        public string Bathroom {
            get => bathroom;
            set {
                bathroom = value;
                OnPropertyChanged();
            }
        }
        public string Floor {
            get => floor;
            set {
                floor = value;
                OnPropertyChanged();
            }
        }
        public string Material {
            get => material;
            set {
                material = value;
                OnPropertyChanged();
            }
        }
        public string Fund {
            get => fund;
            set {
                fund = value;
                OnPropertyChanged();
            }
        }
        public string Type {
            get => type;
            set {
                type = value;
                OnPropertyChanged();
            }
        }
        public string Windows {
            get => windows;
            set {
                if (value.Length <= 25) {
                    windows = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Kvl {
            get => kvl;
            set {
                if (value < 100) {
                    kvl = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool IsPrivatised {
            get => isPrivatised;
            set {
                isPrivatised = value;
                OnPropertyChanged();
            }
        }
        public bool HasImprovedLayout {
            get => hasImprovedLayout;
            set {
                hasImprovedLayout = value;
                OnPropertyChanged();
            }
        }
        public bool HasRenovation {
            get => hasRenovation;
            set {
                hasRenovation = value;
                OnPropertyChanged();
            }
        }
        public bool HasChute {
            get => hasChute;
            set {
                hasChute = value;
                OnPropertyChanged();
            }
        }
        public string TypeOfRooms {
            get => typeOfRooms;
            set {
                typeOfRooms = value;
                OnPropertyChanged();
            }
        }
        public string Rooms {
            get => rooms;
            set {
                if (value.Length <= 24) {
                    rooms = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool HasGarage {
            get => hasGarage;
            set {
                hasGarage = value;
                OnPropertyChanged();
            }
        }
        public bool HasElevator {
            get => hasElevator;
            set {
                hasElevator = value;
                OnPropertyChanged();
            }
        }
        public bool IsCorner {
            get => isCorner;
            set {
                isCorner = value;
                OnPropertyChanged();
            }
        }
        public bool IsSeparated {
            get => isSeparated;
            set {
                isSeparated = value;
                if (isSeparated) {
                    TypeOfRooms = "Раздельные";
                } else {
                    TypeOfRooms = "Смежные";
                }
            }
        }
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
