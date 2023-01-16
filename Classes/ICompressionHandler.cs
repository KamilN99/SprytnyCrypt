using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPKIK.Classes
{
    internal interface ICompressionHandler
    {
        // metoda pozwalająca na kompresje pliku
        // plik skompresowany powinnien być zapisany w lokacji outputPath + "rozszerzenie.tmp" np. outputPath + ".zip.tmp"
        // powinna zwracać ścieżke wyjściową wraz rozszerzeniem np. "folder/plik.zip"
        string Compress(string inputPath, string outputPath);

        // metoda pozwalajaca na dekompresjie pliku
        // scieżka do odczutu pliku: inputPath + ".tmp"
        // po dekompresji należy usunąć plik 'inputPath + ".tmp"'
        void Decompress(string inputPath, string outputPath);
    }
}
