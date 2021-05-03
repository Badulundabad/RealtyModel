using RealtyModel.Model.RealtyObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace RealtyModel.Model
{
    public class Album
    {
        public Int32 Id { get; set; }
        public Byte[] Preview { get; set; }
        public String PhotoKeys { get; set; }
        public String Location { get; set; }

        [NotMapped]
        public ObservableCollection<Byte[]> PhotoList { get; set; }
        public void UpdatePhotos(IEnumerable<Photo> photos)
        {
            Preview = photos.First().Data;
            PhotoList = new ObservableCollection<byte[]>();
            PhotoKeys = "";
            foreach (Photo photo in photos)
            {
                PhotoList.Add(photo.Data);
                PhotoKeys += $"{photo.Id};";
            }
            PhotoKeys = PhotoKeys.TrimEnd(';');
        }
        public void GetPhotos(IEnumerable<Photo> photoArchive)
        {
            foreach (Int32 key in GetPhotoKeys())
            {
                Byte[] data = photoArchive.First<Photo>(p => p.Id == key)?.Data;
                if (data != null)
                    PhotoList.Add(data);
            }
        }
        public Int32[] GetPhotoKeys()
        {
            List<Int32> list = new List<Int32>();
            foreach (String key in PhotoKeys.Split(';'))
                list.Add(Int32.Parse(key));
            return list.ToArray();
        }
    }
}
