using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projektPKIK.Classes
{
    internal class MainController
    {
        ICompressionHandler _compressionHandler;
        EncryptionHandler encryptionHandler;
        public MainController(ICompressionHandler compressionHandler)
        {
            _compressionHandler = compressionHandler;
            encryptionHandler = new EncryptionHandler();
        }

        public void CreateEncryptedArchive(string inputPath, string outputPath, string password)
        {
            //metoda służąca do tworzenia archiwum
            try
            {
                var tmpFile = _compressionHandler.Compress(inputPath, outputPath);
                encryptionHandler.EncryptFile(tmpFile, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void OpenEncryptedArchive(string inputPath, string outputPath, string password)
        {
            //metoda do otwierania archiwum
            try
            {
                encryptionHandler.DecryptFile(inputPath, password);
                _compressionHandler.Decompress(inputPath, outputPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
