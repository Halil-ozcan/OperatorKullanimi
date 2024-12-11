using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorlerAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Ekrana iki sayi değeri girer misiniz? ");

            Console.Write("Birinci sayiyi Giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("İkinci sayiyiy Giriniz : ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            decimal toplama = sayi1 + sayi2;
            decimal cikarma = sayi1 - sayi2;
            decimal carpma = sayi1 * sayi2;
            decimal bolme = sayi1 / sayi2;
            decimal mod = sayi1 % sayi2;

            Console.WriteLine("Toplama : " + toplama + " Çıkarma : " + cikarma + " Çarpma : " + carpma + " Bölme : " + bolme + " Mod : " + mod);
            Console.ReadLine();


        }
    }
}
