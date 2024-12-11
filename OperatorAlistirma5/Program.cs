using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAlistirma5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("Üçgen Çizimi için birinci değeri giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçgen Çizimi için İkinci değeri giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçgen Çizimi için Üçüncü değeri giriniz : ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            bool donendeger = sayi1 < sayi2 + sayi3 && sayi2 < sayi1 + sayi3 && sayi3 < sayi1 + sayi2;

            Console.WriteLine("sonuc : " + donendeger);
        }
    }
}
