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
        /// <summary>
        /// Принимает данные и устанавливает и присваивает ErrorCode.NoCode
        /// </summary>
        public Response(byte[] data) {
            this.Data = data;
            this.Code = ErrorCode.NoCode;
        }
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
