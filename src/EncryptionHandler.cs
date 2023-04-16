using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IMS.src
{
    internal class EncryptionHandler
    {
        public EncryptionHandler()
        {
            //Free Space for encyption.
        }
        static void Encrypt(string plaintext) //Encryption plain text string.
        {
            byte[] encryptedBytes = null;//Clear bytes whenever new encryption task is called.

            using (Aes aesAlg = Aes.Create())
            {
                string key = "mySecretKey123";//Key for encryption.
                aesAlg.Key = Encoding.UTF8.GetBytes(key); // convert the key to a byte array
                aesAlg.IV = new byte[16]; // use a new IV each time for better security

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Write the plaintext to the stream
                            swEncrypt.Write(plaintext);
                        }

                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
            }

            string encryptedText = Convert.ToBase64String(encryptedBytes);

            MessageBox.Show("Encrypted Text: {0}", encryptedText);
        }
    }
}
