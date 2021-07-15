using RealtyModel.Model.Derived;
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
    public class CityOptions : INotifyPropertyChanged
    {
        private bool isAllCities = true;
        private bool isAzov = true;
        private bool isBataysk = true;
        private bool isVesna = true;
        private bool isChasha = true;
        private bool isDruzhba = true;
        private bool isSad = true;
        private bool isKuleshovka = true;
        private bool isPolyanka = true;
        private bool isLuch = true;
        private bool isMiliorator = true;
        private bool isBatay = true;
        private bool isOvoschnoy = true;
        private bool isRomashka = true;
        private bool isRostov = true;
        private bool isTrud = true;
        private bool isYagodka = true;

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void Filter(List<Flat> realtorObjects) {
            if (!IsAllCities) {
                if (!IsAzov) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Азов");
                }
                if (!IsBataysk) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Батайск");
                }
                if (!IsVesna) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Весна");
                }
                if (!IsChasha) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Чаша");
                }
                if (!IsDruzhba) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Дружба");
                }
                if (!IsSad) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Красный Сад");
                }
                if (!IsKuleshovka) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Кулешовка");
                }
                if (!IsPolyanka) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Полянка");
                }
                if (!IsLuch) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Луч");
                }
                if (!IsMiliorator) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Милиоратор");
                }
                if (!IsBatay) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Мокрый Батай");
                }
                if (!IsOvoschnoy) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Овощной");
                }
                if (!IsRomashka) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Ромашка");
                }
                if (!IsTrud) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Труд");
                }
                if (!IsRostov) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Ростов-на-Дону");
                }
                if (!IsYagodka) {
                    realtorObjects.RemoveAll(ro => ro.Location.City == "Ягодка");
                }
            }
        }
        public void Filter(List<House> realtorObjects) {

        }
        private void CheckCities() {
            if (IsBataysk
                && IsAzov
                && IsVesna
                && IsChasha
                && IsDruzhba
                && IsSad
                && IsKuleshovka
                && IsPolyanka
                && IsLuch
                && IsMiliorator
                && IsBatay
                && IsOvoschnoy
                && IsRomashka
                && IsRostov
                && IsYagodka
                && isTrud) {
                IsAllCities = true;
            } else {
                IsAllCities = false;
            }
        }
        public bool IsAllCities {
            get => isAllCities;
            set {
                isAllCities = value;
                if (value) {
                    IsAzov = true;
                    IsBataysk = true;
                    IsVesna = true;
                    IsChasha = true;
                    IsDruzhba = true;
                    IsSad = true;
                    IsKuleshovka = true;
                    IsPolyanka = true;
                    IsLuch = true;
                    IsMiliorator = true;
                    IsBatay = true;
                    IsOvoschnoy = true;
                    IsRomashka = true;
                    IsRostov = true;
                    IsYagodka = true;
                    isTrud = true;
                }
                OnPropertyChanged();
            }
        }
        public bool IsAzov {
            get => isAzov;
            set {
                isAzov = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsBataysk {
            get => isBataysk;
            set {
                isBataysk = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsVesna {
            get => isVesna;
            set {
                isVesna = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsChasha {
            get => isChasha;
            set {
                isChasha = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsDruzhba {
            get => isDruzhba;
            set {
                isDruzhba = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsSad {
            get => isSad;
            set {
                isSad = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsKuleshovka {
            get => isKuleshovka;
            set {
                isKuleshovka = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsPolyanka {
            get => isPolyanka;
            set {
                isPolyanka = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsLuch {
            get => isLuch;
            set {
                isLuch = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsMiliorator {
            get => isMiliorator;
            set {
                isMiliorator = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsBatay {
            get => isBatay;
            set {
                isBatay = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsOvoschnoy {
            get => isOvoschnoy;
            set {
                isOvoschnoy = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsRomashka {
            get => isRomashka;
            set {
                isRomashka = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsRostov {
            get => isRostov;
            set {
                isRostov = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsTrud {
            get => isTrud;
            set {
                isTrud = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
        public bool IsYagodka {
            get => isYagodka;
            set {
                isYagodka = value;
                CheckCities();
                OnPropertyChanged();
            }
        }
    }
}
