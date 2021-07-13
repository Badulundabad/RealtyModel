using System;

namespace RealtyModel.Model
{
    [Serializable]
    public class Album
    {
        private Int32 id = 0;
        private byte[] photoCollection = Array.Empty<byte>();

        public int Id {
            get => id;
            set => id = value;
        }
        public byte[] PhotoCollection {
            get => photoCollection;
            set => photoCollection = value;
        }
    }
}
