using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model.Operations
{
    [Serializable]
    public class Response
    {
        private byte[] data;
        private ErrorCode code;
        public Response(byte[] data, ErrorCode error) {
            this.Data = data;
            this.Code = error;
        }
        public byte[] Data {
            get => data;
            set => data = value;
        }
        public ErrorCode Code {
            get => code;
            set => code = value;
        }
    }
}
