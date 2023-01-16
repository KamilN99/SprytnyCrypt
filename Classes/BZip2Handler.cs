using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.BZip2;

namespace projektPKIK.Classes
{
    internal class BZip2Handler : ICompressionHandler
    {
        public string Compress(string inputPath, string outputPath)
        {
            try
            {
                using (FileStream inputStream = File.OpenRead(inputPath))
                using (FileStream outputStream = File.Create(outputPath + ".bz2.tmp"))
                using (BZip2OutputStream bzip2Stream = new BZip2OutputStream(outputStream))
                {
                    inputStream.CopyTo(bzip2Stream);
                }
                return outputPath + ".bz2";
            }
            catch (Exception ex)
            {
                throw new Exception("wystąpił błąd podczas kompresji " + ex.Message);
            }
        }
        public void Decompress(string inputPath, string outputPath)
        {
            try
            {
                using (FileStream inputStream = File.OpenRead(inputPath + ".tmp"))
                using (FileStream outputStream = File.Create(outputPath))
                using (BZip2InputStream bzip2Stream = new BZip2InputStream(inputStream))
                {
                    bzip2Stream.CopyTo(outputStream);
                }
                File.Delete(inputPath + ".tmp");
            }
            catch (Exception ex)
            {
                throw new Exception("wystąpił błąd podczas dekompresji " + ex.Message);
            }
            
        }
    }
}
