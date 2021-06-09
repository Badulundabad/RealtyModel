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
        NoCode = 6,
        NoLocations = 7,
        ServerUnavailable = 8,
        NoRealtorObjects = 9,
        WrongAgent = 10,
        FlatUpdatedSuccessfuly = 11,
        WrongTarget = 12,
        FlatDuplicate = 13,
        NotFilled = 14,
        WrongFormat = 15
    }
}
