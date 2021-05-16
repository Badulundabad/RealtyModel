using RealtyModel.Model.RealtyObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RealtyModel.Model
{
    [Serializable]
    public class Album
    {
        public Int32 Id { get; set; }
        public String PhotoKeys { get; set; }
        public String Location { get; set; }
        public String PreviewJson { get; set; }
        
        [JsonIgnore, NotMapped]
        public Byte[] Preview { get; set; }
        [JsonIgnore, NotMapped]
        public ObservableCollection<Byte[]> PhotoCollection { get; set; }

        public void GetPhotosFromCollection(IEnumerable<Photo> photos)
        {
            PhotoCollection = new ObservableCollection<byte[]>();
            foreach (Photo photo in photos)
                PhotoCollection.Add(photo.Data);
        }
        public void GetPhotosFromDbByKey(IEnumerable<Photo> database)
        {
            PhotoCollection = new ObservableCollection<byte[]>();
            foreach (Int32 key in GetPhotoKeys())
            {
                Byte[] data = database.First<Photo>(p => p.Id == key)?.Data;
                PhotoCollection.Add(data);
            }
        }
        public void GetPhotosFromDbByLocation(IEnumerable<Photo> database)
        {
            PhotoCollection = new ObservableCollection<byte[]>();
            foreach (Int32 key in GetPhotoKeys())
            {
                Byte[] data = database.First<Photo>(p => p.Id == key)?.Data;
                PhotoCollection.Add(data);
            }
        }
        public void UpdateKeys(IEnumerable<Photo> photos)
        {
            PhotoKeys = "";
            foreach (Photo photo in photos)
                PhotoKeys += $"{photo.Id}©";
            PhotoKeys = PhotoKeys.TrimEnd('©');
        }
        public Int32[] GetPhotoKeys()
        {
            List<Int32> list = new List<Int32>();
            foreach (String key in PhotoKeys.Split(';'))
                list.Add(Int32.Parse(key));
            return list?.ToArray();
        }
        public void WriteLocation(Location location)
        {
            Location = $"{location.City.Name};{location.District.Name};{location.Street.Name};{location.HouseNumber};{location.FlatNumber};";
        }
    }
}
