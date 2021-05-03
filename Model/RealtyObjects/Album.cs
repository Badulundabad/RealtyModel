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
    public class Album
    {
        public Int32 Id { get; set; }
        public Byte[] Preview { get; set; }
        public String PhotoKeys { get; set; }
        public String Location { get; set; }

        [NotMapped]
        public String JsonPhotoArray { get; set; }
        [JsonIgnore, NotMapped]
        public ObservableCollection<Byte[]> PhotoCollection { get; set; }

        public void Serialize(IEnumerable<Photo> photos)
        {
            UpdatePhotos(photos);
            foreach (Byte[] data in PhotoCollection)
                JsonPhotoArray += JsonSerializer.Serialize(data) + ";";
            JsonPhotoArray = JsonPhotoArray.TrimEnd(';');
        }
        public void Deserialize()
        {
            PhotoCollection = new ObservableCollection<byte[]>();
            String[] strings = JsonPhotoArray.Split(';');
            foreach (String s in strings)
                PhotoCollection.Add(JsonSerializer.Deserialize<Byte[]>(s));
        }
        private void UpdatePhotos(IEnumerable<Photo> photos)
        {
            PhotoCollection = new ObservableCollection<byte[]>();
            Preview = photos.First().Data;
            foreach (Photo photo in photos)
                PhotoCollection.Add(photo.Data);
        }
        public void UpdateKeys(IEnumerable<Photo> photos)
        {
            PhotoKeys = "";
            foreach (Photo photo in photos)
                PhotoKeys += $"{photo.Id};";
            PhotoKeys = PhotoKeys.TrimEnd(';');
        }
        public void GetPhotosFromDB(IEnumerable<Photo> database)
        {
            foreach (Int32 key in GetPhotoKeys())
            {
                Byte[] data = database.First<Photo>(p => p.Id == key)?.Data;
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
