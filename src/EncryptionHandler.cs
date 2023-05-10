using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;

namespace IMS.src
{
    internal class EncryptionHandler
    {
        public EncryptionHandler()
        {

        }
        public string Encrypt(string plaintext)
        {
            byte[] encryptedBytes = null;

            using (Aes aesAlg = Aes.Create())
            {
                string key = ConfigurationManager.AppSettings["Encryption_Key"];
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }

                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
            }
            string encryptedText = Convert.ToBase64String(encryptedBytes);
            return encryptedText;
        }
    }
}
