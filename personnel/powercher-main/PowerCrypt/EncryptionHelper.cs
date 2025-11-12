using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.Json;
using DataModel;
using System.Diagnostics;

namespace PowerCrypt
{
    /// <summary>
    /// 
    /// Symmetric encryption with a 32-bytes key usin AES
    /// 
    /// The key is expected to be in the file "power.key" of the "Powercher" folder of the Local AppData.
    /// Format: PowerKey object serialzed in JSon
    /// 
    /// </summary>
    public static class EncryptionHelper
    {
        // The encryption key
        private static byte[]? _key = null;

        /// <summary>
        /// Load and validate the key
        /// </summary>
        /// <returns></returns>
        public static bool Initialize()
        {
            string keyfile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Powercher\power.key";
            try
            {
                PowerKey pk = JsonSerializer.Deserialize<PowerKey>(File.ReadAllText(keyfile));
                if (DateTime.Now > pk.Expiration)
                {
                    Debug.WriteLine("Expired key");
                    return false;
                }
                _key = Convert.FromBase64String(pk.Value);
                if (_key.Length != 32)
                {
                    Debug.WriteLine("Invalid key");
                    return false;
                }
                // Everything looks ok if we get there
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error deserializing key file");
                return false;
            }
        }

        /// <summary>
        /// Perform encryption
        /// </summary>
        public static string EncryptString(string plainText)
        {
            if (_key is null && !Initialize()) throw new Exception("Unitialized EncryptionHelper");

            using (var aes = Aes.Create())
            {
                aes.Key = _key;
                aes.GenerateIV();
                byte[] iv = aes.IV;

                using (var encryptor = aes.CreateEncryptor(aes.Key, iv))
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                    // Perform the encryption
                    byte[] cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

                    // Combine the IV and cipher text into one array
                    byte[] result = new byte[iv.Length + cipherBytes.Length];
                    Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                    Buffer.BlockCopy(cipherBytes, 0, result, iv.Length, cipherBytes.Length);

                    return Convert.ToBase64String(result);
                }
            }
        }

        /// <summary>
        /// Perform decryption
        /// </summary>
        public static string DecryptString(string encryptedText)
        {
            if (_key is null && !Initialize()) throw new Exception("Unitialized EncryptionHelper");

            byte[] cipherBytes = Convert.FromBase64String(encryptedText);

            using (var aes = Aes.Create())
            {
                aes.Key = _key;

                // Extract the IV from the encrypted byte array
                byte[] iv = new byte[aes.BlockSize / 8]; // BlockSize is in bits, IV is in bytes
                byte[] actualCipher = new byte[cipherBytes.Length - iv.Length];

                Buffer.BlockCopy(cipherBytes, 0, iv, 0, iv.Length);
                Buffer.BlockCopy(cipherBytes, iv.Length, actualCipher, 0, actualCipher.Length);

                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    // Perform the decryption
                    byte[] plainBytes = decryptor.TransformFinalBlock(actualCipher, 0, actualCipher.Length);

                    return Encoding.UTF8.GetString(plainBytes);
                }
            }
        }
    }
}
