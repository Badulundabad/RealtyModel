using RealtyModel.Model.Base;
using RealtyModel.Model.Derived;
using RealtyModel.Model.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RealtyModel.Service
{
    [Serializable]
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
        private string city;
        private string district;
        private List<Flat> filteredList = new List<Flat>();

        #region Properties
        public int MinimumPrice
        {
            get => minimumPrice;
            set
            {
                if (value > maximumPrice)
                {
                    MaximumPrice = value;
                }
                minimumPrice = value;
                OnPropertyChanged();
            }
        }
        public int MaximumPrice
        {
            get => maximumPrice;
            set
            {
                if (value < minimumPrice)
                {
                    MinimumPrice = value;
                }
                maximumPrice = value;
                OnPropertyChanged();
            }
        }
        public bool HasMortgage
        {
            get => hasMortgage;
            set => hasMortgage = value;
        }
        public int MinimumArea
        {
            get => minimumArea;
            set
            {
                if (value > maximumArea)
                {
                    MaximumArea = value;
                }
                minimumArea = value;
                OnPropertyChanged();
            }
        }
        public int MaximumArea
        {
            get => maximumArea;
            set
            {
                if (value < minimumArea)
                {
                    MinimumArea = value;
                }
                maximumArea = value;
                OnPropertyChanged();
            }
        }
        public bool IsFlat
        {
            get => isFlat;
            set
            {
                isFlat = value;

                OnPropertyChanged();
            }
        }
        public bool IsHouse
        {
            get => isHouse;
            set
            {
                isHouse = value;
                OnPropertyChanged();
            }
        }
        public bool IsPlot
        {
            get => isPlot;
            set
            {
                isPlot = value;
                OnPropertyChanged();
            }
        }
        public bool IsEuro
        {
            get => isEuro;
            set => isEuro = value;
        }
        public bool IsExcellent
        {
            get => isExcellent;
            set => isExcellent = value;
        }
        public bool IsGood
        {
            get => isGood;
            set => isGood = value;
        }
        public bool IsLiving
        {
            get => isLiving;
            set => isLiving = value;
        }
        public bool IsCosmeticRequired
        {
            get => isCosmeticRequired;
            set => isCosmeticRequired = value;
        }
        public bool IsMajorRequired
        {
            get => isMajorRequired;
            set => isMajorRequired = value;
        }
        public bool IsWithoutDecoration
        {
            get => isWithoutDecoration;
            set => isWithoutDecoration = value;
        }
        public bool IsAGV
        {
            get => isAGV;
            set => isAGV = value;
        }
        public bool IsBoiler
        {
            get => isBoiler;
            set => isBoiler = value;
        }
        public bool IsLocal
        {
            get => isLocal;
            set => isLocal = value;
        }
        public bool IsStove
        {
            get => isStove;
            set => isStove = value;
        }
        public bool IsTPS
        {
            get => isTPS;
            set => isTPS = value;
        }
        public bool IsNozzle
        {
            get => isNozzle;
            set => isNozzle = value;
        }
        public bool IsElectro
        {
            get => isElectro;
            set => isElectro = value;
        }
        public bool IsTPSWater
        {
            get => isTPSWater;
            set => isTPSWater = value;
        }
        public bool IsAGVWater
        {
            get => isAGVWater;
            set => isAGVWater = value;
        }
        public bool IsBoilerRoomWater
        {
            get => isBoilerRoomWater;
            set => isBoilerRoomWater = value;
        }
        public bool IsStandPipe
        {
            get => isStandPipe;
            set => isStandPipe = value;
        }
        public bool IsBoilerWater
        {
            get => isBoilerWater;
            set => isBoilerWater = value;
        }
        public bool IsElectroWater
        {
            get => isElectroWater;
            set => isElectroWater = value;
        }
        public bool IsTrulyBoilerWater
        {
            get => isTrulyBoilerWater;
            set => isTrulyBoilerWater = value;
        }
        public bool IsArchived
        {
            get => isArchived;
            set => isArchived = value;
        }
        public bool IsPlanned
        {
            get => isPlanned;
            set => isPlanned = value;
        }
        public bool IsActive
        {
            get => isActive;
            set => isActive = value;
        }
        public bool IsAllCities
        {
            get => isAllCities;
            set
            {
                isAllCities = value;
                OnPropertyChanged();
            }
        }
        public bool IsAllDistricts
        {
            get => isAllDistricts;
            set
            {
                isAllDistricts = value;
                OnPropertyChanged();
            }
        }
        public string City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }
        public string District
        {
            get => district;
            set
            {
                district = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public Flat[] FilterFlats(Flat[] flats)
        {
            try
            {
                filteredList.Clear();
                filteredList.AddRange(flats.Where(x => MaximumPrice >= x.Price).Where(x => MinimumPrice <= x.Price).ToList());
                filteredList = filteredList.Where(x => MaximumArea >= x.GeneralInfo.General).Where(x => MinimumArea <= x.GeneralInfo.General).ToList();
                if (HasMortgage)
                    filteredList.RemoveAll(x => x.HasMortgage == false);
                FilterByObjectType();
                FilterByCondition();
                FilterByHeating();
                FilterByHotWater();
                FilterByLocation();
                return filteredList.ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
        private void FilterByLocation()
        {
            if (!IsAllCities)
                filteredList.RemoveAll(x => !x.Location.City.Equals(City));
            if (!IsAllDistricts)
                filteredList.RemoveAll(x => !x.Location.District.Equals(District));
        }
        private void FilterByHotWater()
        {
            if (!IsTPSWater)
                filteredList.RemoveAll(x => x.GeneralInfo.Water == "ТЭЦ");
            if (!IsAGVWater)
                filteredList.RemoveAll(x => x.GeneralInfo.Water == "АГВ");
            if (!IsStandPipe)
                filteredList.RemoveAll(x => x.GeneralInfo.Water == "Колонка");
            if (!IsBoilerRoomWater)
                filteredList.RemoveAll(x => x.GeneralInfo.Water == "Котельная");
            if (!IsElectroWater)
                filteredList.RemoveAll(x => x.GeneralInfo.Water == "Электро");
            if (!IsTrulyBoilerWater)
                filteredList.RemoveAll(x => x.GeneralInfo.Water == "Бойлер");
        }
        private void FilterByHeating()
        {
            if (!IsAGV)
                filteredList.RemoveAll(x => x.GeneralInfo.Heating == "АГВ");
            if (!IsBoiler)
                filteredList.RemoveAll(x => x.GeneralInfo.Heating == "Котел");
            if (!IsLocal)
                filteredList.RemoveAll(x => x.GeneralInfo.Heating == "Местное");
            if (!IsStove)
                filteredList.RemoveAll(x => x.GeneralInfo.Heating == "Печное");
            if (!IsTPS)
                filteredList.RemoveAll(x => x.GeneralInfo.Heating == "ТЭЦ");
            if (!IsNozzle)
                filteredList.RemoveAll(x => x.GeneralInfo.Heating == "Форсунка");
            if (!IsElectro)
                filteredList.RemoveAll(x => x.GeneralInfo.Heating == "Электро");
        }
        private void FilterByObjectType()
        {
            if (!IsHouse)
                filteredList.RemoveAll(x => x.Type == "House");
            if (!IsFlat)
                filteredList.RemoveAll(x => x.Type == "Flat");
        }
        private void FilterByCondition()
        {
            if (!IsEuro)
                filteredList.RemoveAll(x => x.GeneralInfo.Condition == "Евро");
            if (!IsExcellent)
                filteredList.RemoveAll(x => x.GeneralInfo.Condition == "Отличное");
            if (!IsGood)
                filteredList.RemoveAll(x => x.GeneralInfo.Condition == "Хорошее");
            if (!IsLiving)
                filteredList.RemoveAll(x => x.GeneralInfo.Condition == "Жилое");
            if (!IsCosmeticRequired)
                filteredList.RemoveAll(x => x.GeneralInfo.Condition == "Требуется косметический ремонт");
            if (!IsMajorRequired)
                filteredList.RemoveAll(x => x.GeneralInfo.Condition == "Требуется капитальный ремонт");
            if (!IsWithoutDecoration)
                filteredList.RemoveAll(x => x.GeneralInfo.Condition == "Без внутренней отделки");
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
