using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model
{
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
