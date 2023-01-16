using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPKIK.Classes
{
    internal class ZipHandler : ICompressionHandler
    {
        public string Compress(string inputPath, string outputPath)
        {
            try
            {
                using (FileStream inputStream = File.OpenRead(inputPath))
                using (FileStream outputStream = File.Create(outputPath + ".zip.tmp"))
                using (ZipOutputStream zipStream = new ZipOutputStream(outputStream))
                {
                    var entry = new ZipEntry(Path.GetFileName(inputPath));
                    zipStream.PutNextEntry(entry);
                    inputStream.CopyTo(zipStream);
                    zipStream.CloseEntry();
                }
                return outputPath + ".zip";
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
                FastZip fastZip = new FastZip();
                fastZip.ExtractZip(inputPath + ".tmp", outputPath, null);
                File.Delete(inputPath + ".tmp");
            }
            catch (Exception ex)
            {
                throw new Exception("wystąpił błąd podczas dekompresji " + ex.Message);
            }
        }
    }
}
