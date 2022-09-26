using System.Security.Cryptography;
using CryptoLibrary;

var crypto = new Crypto();

var testString = "test@string";

using (AesManaged aes = new AesManaged())
{
    // Encrypt string    
    var encrypted = crypto.AES.Encrypt(testString, aes.Key, aes.IV);
    Console.WriteLine($"..AES.Encrypt..");
    // Print encrypted string    
    Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
    // Decrypt the bytes to a string.    
    string decrypted = crypto.AES.Decrypt(encrypted, aes.Key, aes.IV);
    // Print decrypted string. It should be same as raw data    
    Console.WriteLine($"Decrypted data: {decrypted}");

    Console.WriteLine($"...");
}


using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
{
    // Encrypt string  
    var encrypted = crypto.DES.Encrypt(testString, tdes.Key, tdes.IV);
    Console.WriteLine($"..DES.Encrypt..");
    // Print encrypted string  
    Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
    // Decrypt the bytes to a string.  
    string decrypted = crypto.DES.Decrypt(encrypted, tdes.Key, tdes.IV);
    // Print decrypted string. It should be same as raw data  
    Console.WriteLine($"Decrypted data: {decrypted}");
    
    Console.WriteLine($"....");
}

using(RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
{
    // Encrypt string  
    var encrypted = crypto.RSA.Encrypt(testString, RSA.ExportParameters(false));

    Console.WriteLine($"..RSA.Encrypt..");
    // Print encrypted string  
    Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
    // Decrypt the bytes to a string.  
    string decrypted = crypto.RSA.Decrypt(encrypted, RSA.ExportParameters(true));
    // Print decrypted string. It should be same as raw data  
    Console.WriteLine($"Decrypted data: {decrypted}");

    Console.WriteLine($"....");
    
}