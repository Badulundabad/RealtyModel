using System;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model
{
    public class Album : INotifyPropertyChanged
    {
        Int32 id;
        string location;
        byte[] preview;
        byte[] photoList;

        public Int32 Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Location
        {
            get => location;
            set
            {
                location = value;
                OnPropertyChanged();
            }
        }
        public byte[] Preview
        {
            get => preview;
            set
            {
                preview = value;
                OnPropertyChanged();
            }
        }
        public byte[] PhotoList
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
