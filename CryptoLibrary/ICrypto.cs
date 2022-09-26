using CryptoLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    internal interface ICrypto
    {
        IRSA RSA { get; set; }
        IDES DES { get; set; }
        IAES AES { get; set; }
    }
}
