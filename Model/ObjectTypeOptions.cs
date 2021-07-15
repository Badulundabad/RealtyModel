using RealtyModel.Model.Base;
using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model
{
    [Serializable]
    public class ObjectTypeOptions : INotifyPropertyChanged
    {
        private bool isAllTypes = true;
        private bool isRoom = true;
        private bool isPart = true;
        private bool isCottage = true;
        private bool isFlat = true;
        private bool isPlot = true;
        private bool isHouse = true;
        public void Filter(List<Flat> realtorObjects) {
            if (!IsAllTypes) {
                Debug.WriteLine("Все объекты отключены");
                if (!IsFlat) {
                    realtorObjects.RemoveAll(rb => rb.GeneralInfo.ObjectType == "Квартира");
                }
                if (!IsRoom) {
                    realtorObjects.RemoveAll(rb => rb.GeneralInfo.ObjectType == "Комната");
                }
            }
        }
        public void Filter(List<House> realtorObjects) {
            if (!IsAllTypes) {
                if (!IsHouse) {
                    realtorObjects.RemoveAll(rb => rb.GeneralInfo.ObjectType == "Дом");
                }
                if (!IsPlot) {
                    realtorObjects.RemoveAll(rb => rb.GeneralInfo.ObjectType == "Участок");
                }
                if (!IsCottage) {
                    realtorObjects.RemoveAll(rb => rb.GeneralInfo.ObjectType == "Коттедж");
                }
                if (!IsPart) {
                    realtorObjects.RemoveAll(rb => rb.GeneralInfo.ObjectType == "Фрагмент дома");
                }
            }
        }
        private void CheckTypes() {
            if (IsFlat
                && IsHouse
                && isPart
                && IsPlot
                && IsCottage
                && IsRoom) {
                IsAllTypes = true;
            } else {
                IsAllTypes = false;
            }
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public bool IsRoom {
            get => isRoom;
            set {
                isRoom = value;
                CheckTypes();
                OnPropertyChanged();
            }
        }
        public bool IsPart {
            get => isPart;
            set {
                isPart = value;
                CheckTypes();
                OnPropertyChanged();
            }
        }
        public bool IsCottage {
            get => isCottage;
            set {
                isCottage = value;
                CheckTypes();
                OnPropertyChanged();
            }
        }
        public bool IsAllTypes {
            get => isAllTypes;
            set {
                isAllTypes = value;
                if (value) {
                    IsPart = true;
                    IsFlat = true;
                    IsRoom = true;
                    IsHouse = true;
                    IsCottage = true;
                    IsPlot = true;
                }
            }
        }
        public bool IsFlat {
            get => isFlat;
            set {
                isFlat = value;
                CheckTypes();
                OnPropertyChanged();
            }
        }
        public bool IsHouse {
            get => isHouse;
            set {
                isHouse = value;
                CheckTypes();
                OnPropertyChanged();
            }
        }
        public bool IsPlot {
            get => isPlot;
            set {
                isPlot = value;
                CheckTypes();
                OnPropertyChanged();
            }
        }
    }
}
