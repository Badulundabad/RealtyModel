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
        private ObservableCollection<string> cities = new ObservableCollection<string>();
        private ObservableCollection<string> streets = new ObservableCollection<string>();
        private ObservableCollection<string> districts = new ObservableCollection<string>();

        public ObservableCollection<string> Cities {
            get => cities;
            set => cities = value;
        }
        public ObservableCollection<string> Streets {
            get => streets;
            set => streets = value;
        }
        public ObservableCollection<string> Districts {
            get => districts;
            set => districts = value;
        }
    }
}
