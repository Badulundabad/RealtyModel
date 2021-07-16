using RealtyModel.Model;
using RealtyModel.Model.Base;
using RealtyModel.Model.Derived;
using RealtyModel.Model.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Tools
{
    [Serializable]
    public class Filtration : INotifyPropertyChanged
    {
        private CityOptions cityOptions = new CityOptions();
        private ObjectTypeOptions typeOptions = new ObjectTypeOptions();
        private ConditionOptions conditionOptions = new ConditionOptions();
        private HeatingOptions heatingOptions = new HeatingOptions();
        private DistrictOptions districtOptions = new DistrictOptions();

        private Int32 minimumPrice = 0;
        private Int32 maximumPrice = 40000;
        private Int32 minimumArea = 0;
        private Int32 maximumArea = 400;
        public void Filter(List<Flat> realtorObjects) {
            realtorObjects.RemoveAll(ro => !(MinimumPrice <= ro.Price && ro.Price <= MaximumPrice));
            realtorObjects.RemoveAll(ro => !(MinimumArea <= ro.GeneralInfo.General && ro.GeneralInfo.General <= MaximumArea));
            TypeOptions.Filter(realtorObjects);
            ConditionOptions.Filter(realtorObjects);
            HeatingOptions.Filter(realtorObjects);
            CityOptions.Filter(realtorObjects);
            DistrictOptions.Filter(realtorObjects);
        }
        public void Filter(List<House> realtorObjects) {
            realtorObjects.RemoveAll(ro => !(MinimumPrice <= ro.Price && ro.Price <= MaximumPrice));
            realtorObjects.RemoveAll(ro => !(MinimumArea <= ro.GeneralInfo.General && ro.GeneralInfo.General <= MaximumArea));
            TypeOptions.Filter(realtorObjects);
            ConditionOptions.Filter(realtorObjects);
            HeatingOptions.Filter(realtorObjects);
            CityOptions.Filter(realtorObjects);
            DistrictOptions.Filter(realtorObjects);
        }
        public int MinimumPrice {
            get => minimumPrice;
            set {
                if (value > maximumPrice) {
                    MaximumPrice = value;
                }
                minimumPrice = value;
                Debug.WriteLine(value);
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
        public CityOptions CityOptions {
            get => cityOptions;
            set => cityOptions = value;
        }
        public ObjectTypeOptions TypeOptions {
            get => typeOptions;
            set => typeOptions = value;
        }
        public ConditionOptions ConditionOptions {
            get => conditionOptions;
            set => conditionOptions = value;
        }
        public HeatingOptions HeatingOptions {
            get => heatingOptions;
            set => heatingOptions = value;
        }
        public DistrictOptions DistrictOptions {
            get => districtOptions;
            set => districtOptions = value;
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
