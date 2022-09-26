using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary.Services
{
    public interface IRSA
    {
        byte[] Encrypt(string inputText, RSAParameters RSAKey, bool DoOAEPPadding = false);
        string Decrypt(byte[] inputText, RSAParameters RSAKey, bool DoOAEPPadding = false);
    }
}
