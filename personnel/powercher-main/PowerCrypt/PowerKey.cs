using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PowerCrypt
{
    /// <summary>
    /// Used to hold the symmetric encryption key that guarantees our network's privacy
    /// </summary>
    public class PowerKey
    {
        public string Id {  get; init; }
        public DateTime Expiration { get; init; }
        public string Value { get; init; }

        public PowerKey()
        {
            Id = Guid.NewGuid().ToString();
            Value = GenerateSymmetricKey();
        }

        public PowerKey(DateTime expiration): this()
        {
            Expiration = expiration;
        }

        private static string GenerateSymmetricKey()
        {
            // Use AES to generate a 256-bit symmetric key
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256; // 32 bytes
                aes.GenerateKey();
                return Convert.ToBase64String(aes.Key); // Return the key as a Base64 string
            }
        }
    }
}
