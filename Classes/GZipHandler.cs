using ICSharpCode.SharpZipLib.GZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPKIK.Classes
{
    internal class GZipHandler: ICompressionHandler
    {
        public string Compress(string inputPath, string outputPath)
        {
            try
            {
                using (FileStream inputStream = File.OpenRead(inputPath))
                using (FileStream outputStream = File.Create(outputPath + ".gz.tmp"))
                using (GZipOutputStream gzipStream = new GZipOutputStream(outputStream))
                {
                    inputStream.CopyTo(gzipStream);
                }
                return outputPath + ".gz";
            }
            catch (Exception ex)
            {
                throw new Exception("wystąpił błąd podczas kompresji " + ex.Message);
            }

        }

        public void Decompress(string inputPath, string outputPath)
        {
            //dekompresja
            try
            {
                using (FileStream inputStream = File.OpenRead(inputPath + ".tmp"))
                using (GZipInputStream gzipStream = new GZipInputStream(inputStream))
                using (FileStream outputStream = File.Create(outputPath))
                {
                    gzipStream.CopyTo(outputStream);
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
