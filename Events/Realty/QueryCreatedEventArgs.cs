using RealtyModel.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Realty
{
    public class QueryCreatedEventArgs
    {
        public Filter Filter { get; set; }

        public QueryCreatedEventArgs(Filter filter)
        {
            Filter = filter;
        }
    }
}
