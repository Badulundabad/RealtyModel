using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model.Operations
{
    public enum ErrorCode
    {
        Successful,
        WrongData,
        Credential,
        Unknown,
        NoRequiredData,
        ObjectAddedSuccessfuly,
        NoCode,
        NoLocations,
        ServerUnavailable,
        WrongAgent,
        FlatUpdatedSuccessfuly,
        WrongTarget,
        ObjectDuplicate,
        NotFilled,
        WrongFormat,
        AgentExists,
        ObjectUpdatedSuccessfuly,
        CredentialUpdatedSuccessfuly
    }
}
