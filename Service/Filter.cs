﻿using RealtyModel.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Service
{
    public class Filter : INotifyPropertyChanged
    {
        private bool isFlat = true;
        private bool isHouse = true;
        private bool isPlot = true;
        private Int32 minimumPrice = 0;
        private Int32 maximumPrice = 20000000;
        private bool hasMortgage = false;
        private Int32 minimumArea = 0;
        private Int32 maximumArea = 1500;
        private bool isEuro = true;
        private bool isExcellent = true;
        private bool isGood = true;
        private bool isLiving = true;
        private bool isCosmeticRequired = true;
        private bool isMajorRequired = true;
        private bool isWithoutDecoration = true;
        private bool isAGV = true;
        private bool isBoiler = true;
        private bool isLocal = true;
        private bool isStove = true;
        private bool isTPS = true;
        private bool isNozzle = true;
        private bool isElectro = true;
        private List<BaseRealtorObject> filteredObjects = new List<BaseRealtorObject>();
        public List<BaseRealtorObject> CreateFilteredList(List<BaseRealtorObject> allObjects) {
            FilteredObjects.Clear();
            FilteredObjects.AddRange(allObjects.Where(x => MaximumPrice >= x.Cost.Price).Where(x => MinimumPrice <= x.Cost.Price).ToList());
            FilteredObjects = FilteredObjects.Where(x => MaximumArea >= x.Cost.Area).Where(x => MinimumArea <= x.Cost.Area).ToList();
            if (HasMortgage) {
                FilteredObjects.RemoveAll(x => x.Cost.HasMortgage == false);
            }
            FilterByObjectType();
            FilterByCondition();
            FilterByHeating();
            var newFilteredObjects = new List<BaseRealtorObject>();
            for (int i = 0; i < 50; i++) {
                newFilteredObjects.Add(FilteredObjects[i]);
            }
            return newFilteredObjects;
        }
        private void FilterByHeating() {
            if (!IsAGV) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Heating == "АГВ");
            }
            if (!IsBoiler) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Heating == "Котел");
            }
            if (!IsLocal) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Heating == "Местное");
            }
            if (!IsStove) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Heating == "Печное");
            }
            if (!IsTPS) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Heating == "ТЭЦ");
            }
            if (!IsNozzle) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Heating == "Форсунка");
            }
            if (!IsElectro) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Heating == "Электро");
            }
        }
        private void FilterByObjectType() {
            if (!IsPlot) {
                FilteredObjects.RemoveAll(x => x.ObjectType == "Земельный участок");
            }
            if (!IsHouse) {
                FilteredObjects.RemoveAll(x => x.ObjectType == "Частный дом");
            }
            if (!IsFlat) {
                FilteredObjects.RemoveAll(x => x.ObjectType == "Квартира");
            }
        }
        private void FilterByCondition() {
            if (!IsEuro) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Condition == "Евро");
            }
            if (!IsExcellent) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Condition == "Отличное");
            }
            if (!IsGood) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Condition == "Хорошее");
            }
            if (!IsLiving) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Condition == "Жилое");
            }
            if (!IsCosmeticRequired) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Condition == "Требуется косметический ремонт");
            }
            if (!IsMajorRequired) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Condition == "Требуется капитальный ремонт");
            }
            if (!IsWithoutDecoration) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Condition == "Без внутренней отделки");
            }
        }

        public int MinimumPrice {
            get => minimumPrice;
            set {
                if (value > maximumPrice) {
                    MaximumPrice = value;
                }
                minimumPrice = value;
                OnPropertyChanged();
            }
        }
        public int MaximumPrice {
            get => maximumPrice;
            set {
                if (value < minimumPrice) {
                    MinimumPrice = value;
                }
                maximumPrice = value;
                OnPropertyChanged();
            }
        }
        public bool HasMortgage {
            get => hasMortgage;
            set => hasMortgage = value;
        }
        public int MinimumArea {
            get => minimumArea;
            set {
                if (value > maximumArea) {
                    MaximumArea = value;
                }
                minimumArea = value;
                OnPropertyChanged();
            }
        }
        public int MaximumArea {
            get => maximumArea;
            set {
                if (value < minimumArea) {
                    MinimumArea = value;
                }
                maximumArea = value;
                OnPropertyChanged();
            }
        }
        public bool IsFlat {
            get => isFlat;
            set {
                isFlat = value;

                OnPropertyChanged();
            }
        }
        public bool IsHouse {
            get => isHouse;
            set {
                isHouse = value;
                OnPropertyChanged();
            }
        }
        public bool IsPlot {
            get => isPlot;
            set {
                isPlot = value;
                OnPropertyChanged();
            }
        }

        public bool IsEuro {
            get => isEuro;
            set => isEuro = value;
        }
        public bool IsExcellent {
            get => isExcellent;
            set => isExcellent = value;
        }
        public bool IsGood {
            get => isGood;
            set => isGood = value;
        }
        public bool IsLiving {
            get => isLiving;
            set => isLiving = value;
        }
        public bool IsCosmeticRequired {
            get => isCosmeticRequired;
            set => isCosmeticRequired = value;
        }
        public bool IsMajorRequired {
            get => isMajorRequired;
            set => isMajorRequired = value;
        }
        public bool IsWithoutDecoration {
            get => isWithoutDecoration;
            set => isWithoutDecoration = value;
        }
        public bool IsAGV {
            get => isAGV;
            set => isAGV = value;
        }
        public bool IsBoiler {
            get => isBoiler;
            set => isBoiler = value;
        }
        public bool IsLocal {
            get => isLocal;
            set => isLocal = value;
        }
        public bool IsStove {
            get => isStove;
            set => isStove = value;
        }
        public bool IsTPS {
            get => isTPS;
            set => isTPS = value;
        }
        public bool IsNozzle {
            get => isNozzle;
            set => isNozzle = value;
        }
        public bool IsElectro {
            get => isElectro;
            set => isElectro = value;
        }
        public List<BaseRealtorObject> FilteredObjects {
            get => filteredObjects;
            set => filteredObjects = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
