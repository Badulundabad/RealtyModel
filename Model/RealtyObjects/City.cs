using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RealtyModel.Model
{
    [Serializable]
    public class City : INotifyPropertyChanged
    {
        //private Int32 id;
        //private String name;
        //public Int32 Id
        //{
        //    get => id;
        //    set
        //    {
        //        id = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public String Name
        //{
        //    get => name;
        //    set
        //    {
        //        name = value;
        //        OnPropertyChanged();
        //    }
        //}
        public override string ToString() {
            return this.Name;
        }
        public Int32 Id { get; set; }
        public String Name { get; set; }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
