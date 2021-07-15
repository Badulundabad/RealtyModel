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
    public class HeatingOptions : INotifyPropertyChanged
    {
        private bool isAllHeatings = true;
        private bool isAGV = true;
        private bool isBoiler = true;
        private bool isLocal = true;
        private bool isStove = true;
        private bool isTPS = true;
        private bool isNozzle = true;
        private bool isElectro = true;

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void Filter(List<Flat> realtorObjects) {
            if (!IsAllHeatings) {
                if (!IsAGV) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "АГВ");
                }
                if (!IsBoiler) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Котел");
                }
                if (!IsLocal) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Местное");
                }
                if (!IsStove) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Печное");
                }
                if (!IsTPS) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "ТЭЦ");
                }
                if (!IsNozzle) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Форсунка");
                }
                if (!IsElectro) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Электро");
                }
            }
        }
        public void Filter(List<House> realtorObjects) {
            if (!IsAllHeatings) {
                if (!IsAGV) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "АГВ");
                }
                if (!IsBoiler) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Котел");
                }
                if (!IsLocal) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Местное");
                }
                if (!IsStove) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Печное");
                }
                if (!IsTPS) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "ТЭЦ");
                }
                if (!IsNozzle) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Форсунка");
                }
                if (!IsElectro) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Heating == "Электро");
                }
            }
        }
        private void CheckHeatings() {
            if (IsAGV
                && IsBoiler
                && IsLocal
                && IsStove
                && IsTPS
                && IsNozzle
                && IsElectro) {
                IsAllHeatings = true;
            } else {
                IsAllHeatings = false;
            }
        }
        public bool IsAllHeatings {
            get => isAllHeatings;
            set {
                isAllHeatings = value;
                if (value) {
                    IsAGV = true;
                    IsBoiler = true;
                    IsLocal = true;
                    IsStove = true;
                    IsTPS = true;
                    IsNozzle = true;
                    IsElectro = true;
                }
            }
        }

        public bool IsAGV {
            get => isAGV;
            set {
                isAGV = value;
                CheckHeatings();
                OnPropertyChanged();
            }
        }
        public bool IsBoiler {
            get => isBoiler;
            set {
                isBoiler = value;
                CheckHeatings();
                OnPropertyChanged();
            }
        }
        public bool IsLocal {
            get => isLocal;
            set {
                isLocal = value;
                CheckHeatings();
                OnPropertyChanged();
            }
        }
        public bool IsStove {
            get => isStove;
            set {
                isStove = value;
                CheckHeatings();
                OnPropertyChanged();
            }
        }
        public bool IsTPS {
            get => isTPS;
            set {
                isTPS = value;
                CheckHeatings();
                OnPropertyChanged();
            }
        }
        public bool IsNozzle {
            get => isNozzle;
            set {
                isNozzle = value;
                CheckHeatings();
                OnPropertyChanged();
            }
        }
        public bool IsElectro {
            get => isElectro;
            set {
                isElectro = value;
                CheckHeatings();
                OnPropertyChanged();
            }
        }
    }
}
