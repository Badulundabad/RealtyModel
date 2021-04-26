using System;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Album : INotifyPropertyChanged
    {
        Int32 id = -1;
        String location = "";
        Byte[] preview = null;
        Byte[] photoList = null;

        public Int32 Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public String Location
        {
            get => location;
            set
            {
                location = value;
                OnPropertyChanged();
            }
        }
        public Byte[] Preview
        {
            get => preview;
            set
            {
                preview = value;
                OnPropertyChanged();
            }
        }
        public Byte[] PhotoList
        {
            get => photoList;
            set
            {
                photoList = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
