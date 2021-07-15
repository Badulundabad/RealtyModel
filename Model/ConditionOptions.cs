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
    public class ConditionOptions : INotifyPropertyChanged
    {
        private bool isAllConditions = true;
        private bool isEuro = true;
        private bool isExcellent = true;
        private bool isGood = true;
        private bool isLiving = true;
        private bool isCosmeticRequired = true;
        private bool isMajorRequired = true;
        private bool isWithoutDecoration = true;
        private void CheckConditions() {
            if (IsEuro
                && IsExcellent
                && IsGood
                && IsLiving
                && IsCosmeticRequired
                && IsMajorRequired
                && IsWithoutDecoration) {
                IsAllConditions = true;
            } else {
                IsAllConditions = false;
            }
        }
        public void Filter(List<Flat> realtorObjects) {
            if (!IsAllConditions){
                if (!IsEuro) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Евро");
                }
                if (!IsExcellent) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Отличное");
                }
                if (!IsGood) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Хорошее");
                }
                if (!IsLiving) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Жилое");
                }
                if (!IsCosmeticRequired) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Требуется косметический ремонт");
                }
                if (!IsMajorRequired) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Требуется капитальный ремонт");
                }
                if (!IsWithoutDecoration) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Без внутренней отделки");
                }
            }
        }
        public void Filter(List<House> realtorObjects) {
            if (!IsAllConditions) {
                if (!IsEuro) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Евро");
                }
                if (!IsExcellent) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Отличное");
                }
                if (!IsGood) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Хорошее");
                }
                if (!IsLiving) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Жилое");
                }
                if (!IsCosmeticRequired) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Требуется косметический ремонт");
                }
                if (!IsMajorRequired) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Требуется капитальный ремонт");
                }
                if (!IsWithoutDecoration) {
                    realtorObjects.RemoveAll(ro => ro.GeneralInfo.Condition == "Без внутренней отделки");
                }
            }
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public bool IsAllConditions {
            get => isAllConditions;
            set {
                isAllConditions = value;
                if (value) {
                    IsEuro = true;
                    IsGood = true;
                    IsMajorRequired = true;
                    IsCosmeticRequired = true;
                    IsExcellent = true;
                    IsLiving = true;
                    IsWithoutDecoration = true;
                }
            }
        }
        public bool IsEuro {
            get => isEuro;
            set {
                isEuro = value;
                CheckConditions();
                OnPropertyChanged();
            }
        }
        public bool IsExcellent {
            get => isExcellent;
            set {
                isExcellent = value;
                CheckConditions();
                OnPropertyChanged();
            }
        }
        public bool IsGood {
            get => isGood;
            set {
                isGood = value;
                CheckConditions();
                OnPropertyChanged();
            }
        }
        public bool IsLiving {
            get => isLiving;
            set {
                isLiving = value;
                CheckConditions();
                OnPropertyChanged();
            }
        }
        public bool IsCosmeticRequired {
            get => isCosmeticRequired;
            set {
                isCosmeticRequired = value;
                CheckConditions();
                OnPropertyChanged();
            }
        }
        public bool IsMajorRequired {
            get => isMajorRequired;
            set {
                isMajorRequired = value;
                CheckConditions();
                OnPropertyChanged();
            }
        }
        public bool IsWithoutDecoration {
            get => isWithoutDecoration;
            set {
                isWithoutDecoration = value;
                CheckConditions();
                OnPropertyChanged();
            }
        }

    }
}
