using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dosya_İşlemleri__File_I_ve_O_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "C:\\Users\\mitha\\source\\repos\\Dosya İşlemleri (File I ve O)2\\Dosya İşlemleri (File I ve O)2\\ornek2.txt";

            // StreamWriter ile dosyaya yazma
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                sw.WriteLine("C# öğreniyorum.");
                sw.WriteLine("Dosya işlemleri çok önemli.");
                sw.WriteLine("Bu örnekte StreamWriter kullandık.");
            }
            Console.WriteLine("Dosya yazma işlemi tamamlandı.");

            // StreamReader ile dosyayı okuma
            Console.WriteLine("\nDosyadan okunan veriler:");
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    Console.WriteLine(satir);
                }
            }
        }
    }
}
