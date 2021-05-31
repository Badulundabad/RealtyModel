using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model.Operations
{
    public enum ErrorCode
    {
        Successful = 0,
        WrongData = 1,
        Credential = 2,
        Unknown = 3,
        NoRequiredData = 4,
        FlatAddedSuccessfuly = 5,
        NoCode = 6
    }
}
