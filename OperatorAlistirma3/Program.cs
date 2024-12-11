using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Console.Write("Birinci sinav Notunu Giriniz : ");
            int sinavNotu1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sinav Notunu Giriniz : ");
            int sinavNotu2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sinav Notunu Giriniz : ");
            int sinavNotu3 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            decimal sinavNotOrtalama = (sinavNotu1 + sinavNotu2 + sinavNotu3) / 3;

            bool sonuc = sinavNotOrtalama >= 45;

            Console.WriteLine("sonuc: " + " " + sonuc);
            Console.ReadLine();
        }
    }
}
