using RealtyModel.Model;
using RealtyModel.Model.Base;
using RealtyModel.Model.Derived;
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
        private bool isTPSWater = true;
        private bool isAGVWater = true;
        private bool isBoilerRoomWater = true;
        private bool isStandPipe = true;
        private bool isBoilerWater = true;
        private bool isElectroWater = true;
        private bool isTrulyBoilerWater = true;
        private bool isArchived = false;
        private bool isPlanned = true;
        private bool isActive = true;
        private bool isAllCities = true;
        private bool isAllDistricts = true;
        private string city = "";
        private string district = "";
        private void FilterByLocation() {
            if (!IsAllCities) {
                FilteredObjects.RemoveAll(x => !x.Location.City.Name.ToLower().Contains(City.ToLower()));
            }
            if (!IsAllDistricts) {
                FilteredObjects.RemoveAll(x => !x.Location.District.Name.ToLower().Contains(District.ToLower()));
            }
        }
        private void FilterByStatus() {
            if (!IsActive) {
                FilteredObjects.RemoveAll(x => x.Status == Status.Active);
            }
            if (!IsPlanned) {
                FilteredObjects.RemoveAll(x => x.Status == Status.Planned);
            }
            if (!IsArchived) {
                FilteredObjects.RemoveAll(x => x.Status == Status.Archived);
            }
        }
        private void FilterByHotWater() {
            if (!IsTPSWater) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Water == "ТЭЦ");
            }
            if (!IsAGVWater) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Water == "АГВ");
            }
            if (!IsStandPipe) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Water == "Колонка");
            }
            if (!IsBoilerRoomWater) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Water == "Котельная");
            }
            if (!IsElectroWater) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Water == "Электро");
            }
            if (!IsTrulyBoilerWater) {
                FilteredObjects.RemoveAll(x => x.GeneralInfo.Water == "Бойлер");
            }
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
                FilteredObjects.RemoveAll(x => x.Type == TargetType.Plot);
            }
            if (!IsHouse) {
                FilteredObjects.RemoveAll(x => x.Type == TargetType.House);
            }
            if (!IsFlat) {
                FilteredObjects.RemoveAll(x => x.Type == TargetType.Flat);
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
        private List<BaseRealtorObject> filteredObjects = new List<BaseRealtorObject>();

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
        public bool IsTPSWater {
            get => isTPSWater;
            set => isTPSWater = value;
        }
        public bool IsAGVWater {
            get => isAGVWater;
            set => isAGVWater = value;
        }
        public bool IsBoilerRoomWater {
            get => isBoilerRoomWater;
            set => isBoilerRoomWater = value;
        }
        public bool IsStandPipe {
            get => isStandPipe;
            set => isStandPipe = value;
        }
        public bool IsBoilerWater {
            get => isBoilerWater;
            set => isBoilerWater = value;
        }
        public bool IsElectroWater {
            get => isElectroWater;
            set => isElectroWater = value;
        }
        public bool IsTrulyBoilerWater {
            get => isTrulyBoilerWater;
            set => isTrulyBoilerWater = value;
        }
        public bool IsArchived {
            get => isArchived;
            set => isArchived = value;
        }
        public bool IsPlanned {
            get => isPlanned;
            set => isPlanned = value;
        }
        public bool IsActive {
            get => isActive;
            set => isActive = value;
        }
        public bool IsAllCities {
            get => isAllCities;
            set {
                isAllCities = value;
                OnPropertyChanged();
            }
        }
        public bool IsAllDistricts {
            get => isAllDistricts;
            set {
                isAllDistricts = value;
                OnPropertyChanged();
            }
        }
        public string City {
            get => city;
            set {
                city = value;
                OnPropertyChanged();
            }
        }
        public string District {
            get => district;
            set {
                district = value;
                OnPropertyChanged();
            }
        }

        public List<BaseRealtorObject> FilteredObjects {
            get => filteredObjects;
            set => filteredObjects = value;
        }
        public List<BaseRealtorObject> CreateFilteredList(List<BaseRealtorObject> allObjects) {
            FilteredObjects.Clear();
            FilteredObjects.AddRange(allObjects.Where(x => MaximumPrice >= x.Cost.Price).Where(x => MinimumPrice <= x.Cost.Price).ToList());
            FilteredObjects = FilteredObjects.Where(x => MaximumArea >= x.Cost.Area).Where(x => MinimumArea <= x.Cost.Area).ToList();
            if (HasMortgage) {
                FilteredObjects.RemoveAll(x => x.Cost.HasMortgage == false);
            }
            FilterByObjectType();
            FilterByStatus();
            FilterByCondition();
            FilterByHeating();
            FilterByHotWater();
            FilterByLocation();
            //------------------------------ Потом убрать --------------------------
         
                var newFilteredObjects = new List<BaseRealtorObject>();
                int count = FilteredObjects.Count > 50 ? 50 : FilteredObjects.Count;
                for (int i = 0; i < count; i++) { newFilteredObjects.Add(FilteredObjects[i]); }

            //----------------------------------------------------------------------
            return newFilteredObjects;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
