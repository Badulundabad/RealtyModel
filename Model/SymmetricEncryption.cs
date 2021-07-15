using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RealtyModel.Model
{
    [Serializable]
    public class SymmetricEncryption
    {
        private string key = "";
        private string iv = "";
        private byte[] data;
        private object instance;
        ///<summary>
        ///Преобразует входные ключи в их битовое представление, которое впоследствии использует для настройки шифратора
        ///После настройки протоколирует поток шифрования, возвращая результат оного 
        ///При неправильной длине ключа выдает ошибку
        ///</summary>
        public SymmetricEncryption(object instance) {
            this.instance = instance;
        }

        ///<summary>
        ///Преобразует входные ключи в их битовое представление, которое впоследствии использует для настройки дешифратора.
        ///После настройки протоколирует поток шифрования, возвращая результат оного.
        ///При неправильной длине ключа выдает ошибку
        ///</summary>
        public byte[] Encrypt<T>() {
            this.data = BinarySerializer.Serialize((T)instance);
            CreateKeys();
            byte[] keyBlob = Convert.FromBase64String(key);
            byte[] ivBlob = Convert.FromBase64String(iv);
            using (Aes aes = Aes.Create()) {
                aes.KeySize = 128;
                aes.Key = keyBlob;
                aes.BlockSize = 128;
                aes.IV = ivBlob;
                using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV)) {
                    using (MemoryStream memoryStream = new MemoryStream()) {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)) {
                            cryptoStream.Write(data, 0, data.Length);
                            cryptoStream.FlushFinalBlock();
                            this.data = memoryStream.ToArray();
                            return BinarySerializer.Serialize(this);
                        }
                    }
                }
            }
        }
        public T Decrypt<T>() {
            byte[] keyBlob = Convert.FromBase64String(key);
            byte[] ivBlob = Convert.FromBase64String(iv);
            using (Aes aes = Aes.Create()) {
                aes.KeySize = 128;
                aes.Key = keyBlob;
                aes.BlockSize = 128;
                aes.IV = ivBlob;
                using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV)) {
                    using (MemoryStream memoryStream = new MemoryStream()) {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write)) {
                            cryptoStream.Write(data, 0, data.Length);
                            cryptoStream.FlushFinalBlock();
                            return BinarySerializer.Deserialize<T>(memoryStream.ToArray());
                        }
                    }
                }
            }
        }
        public void CreateKeys() {
            byte[] firstKeySequence = new byte[16];
            byte[] secondKeySequence = new byte[16];
            Random random = new Random();
            random.NextBytes(firstKeySequence);
            random.NextBytes(secondKeySequence);
            key = Convert.ToBase64String(firstKeySequence);
            iv = Convert.ToBase64String(secondKeySequence);
        }
    }
}
