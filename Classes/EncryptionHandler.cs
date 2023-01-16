using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projektPKIK.Classes
{
    internal class EncryptionHandler
    {
        public void EncryptFile(string outputPath, string password)
        {
            //szyfrowanie
            try
            {
                byte[] salt = SaltGenerator();
                byte[] passwordHash = PasswordController.getPasswordHash(password);
                var key = new Rfc2898DeriveBytes(passwordHash, salt, 10000);
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Padding = PaddingMode.PKCS7;
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Mode = CipherMode.CBC;
                using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
                {
                    fileStream.Write(salt, 0, salt.Length);
                    using (CryptoStream cryptoStream = new CryptoStream(fileStream, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (FileStream inputStream = new FileStream(outputPath + ".tmp", FileMode.Open))
                        {
                            byte[] buffer = new byte[4096];
                            int rd;
                            while ((rd = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cryptoStream.Write(buffer, 0, rd);
                            }
                        }
                    }
                }
                File.Delete(outputPath + ".tmp");
            }
            catch (Exception)
            {
                throw new Exception("wystąpił błąd podczas szyfrowania");
            }
        }
        public void DecryptFile(string inputPath, string password)
        {
            //deszyfrowanie
            try
            {
                byte[] salt = new byte[32];
                byte[] passwordHash = PasswordController.getPasswordHash(password);
                using (FileStream fileStream = new FileStream(inputPath, FileMode.Open))
                {
                    fileStream.Read(salt, 0, salt.Length);
                    var key = new Rfc2898DeriveBytes(passwordHash, salt, 10000);
                    RijndaelManaged AES = new RijndaelManaged();
                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    AES.Padding = PaddingMode.PKCS7;
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;
                    using (CryptoStream cryptoStream = new CryptoStream(fileStream, AES.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (FileStream outputStream = new FileStream(inputPath + ".tmp", FileMode.Create))
                        {
                            byte[] buffer = new byte[4096];
                            int rd;
                            while ((rd = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                outputStream.Write(buffer, 0, rd);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("wystąpił błąd podczas deszyfrowania" + ex.Message);
            }
        }
        private byte[] SaltGenerator()
        {
            byte[] salt = new byte[32];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
    }
}
