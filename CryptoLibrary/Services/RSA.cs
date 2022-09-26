using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary.Services
{
    public class RSA : IRSA
    {
        public byte[] Encrypt(string inputText, RSAParameters RSAKey, bool DoOAEPPadding = false)
        {
            try
            {
                var data = Encoding.UTF8.GetBytes(inputText);
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string Decrypt(byte[] inputText, RSAParameters RSAKey, bool DoOAEPPadding = false)
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(inputText, DoOAEPPadding);
                }
                return Encoding.UTF8.GetString(decryptedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return string.Empty;
            }
        }
    }
}
