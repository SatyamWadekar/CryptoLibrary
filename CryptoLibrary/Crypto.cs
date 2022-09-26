using CryptoLibrary.Services;

namespace CryptoLibrary
{
    public class Crypto : ICrypto
    {
        public IRSA RSA { get; set; }
        public IDES DES { get; set; }
        public IAES AES { get; set; }

        public Crypto()
        {
            RSA = new RSA();
            DES = new DES();
            AES = new AES();
        }
    }
}