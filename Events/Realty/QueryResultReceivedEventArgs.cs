using RealtyModel.Model.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class QueryResultReceivedEventArgs
    {
        private ObservableCollection<BaseRealtorObject> queryObjects = new ObservableCollection<BaseRealtorObject>();
        public ObservableCollection<BaseRealtorObject> QueryObjects { get => queryObjects; set => queryObjects = value; }

        public QueryResultReceivedEventArgs(ObservableCollection<BaseRealtorObject> objects)
        {
            queryObjects = objects;
        }
    }
}
