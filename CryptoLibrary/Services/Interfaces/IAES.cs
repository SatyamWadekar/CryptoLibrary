using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary.Services
{
    public interface IAES
    {
        byte[] Encrypt(string inputText, byte[] Key, byte[] IV);
        string Decrypt(byte[] inputText, byte[] Key, byte[] IV);
    }
}
