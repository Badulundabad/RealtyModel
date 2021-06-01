using System;
using System.Collections.ObjectModel;

namespace RealtyModel.Model
{
    [Serializable]
    public class LocationOptions
    {
        private ObservableCollection<City> cities = new ObservableCollection<City>();
        private ObservableCollection<District> districts = new ObservableCollection<District>();
        private ObservableCollection<Street> streets = new ObservableCollection<Street>();

        public ObservableCollection<City> Cities {
            get => cities;
            set => cities = value;
        }
        public ObservableCollection<District> Districts {
            get => districts;
            set => districts = value;
        }
        public ObservableCollection<Street> Streets {
            get => streets;
            set => streets = value;
        }
    }
}
