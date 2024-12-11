using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorlerAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");


            Console.Write("İsiminizi Giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminizi Giriniz: ");
            string soyisim = Console.ReadLine();

            Console.Write("Yılınızı Giriniz: ");
            string yilStr = Console.ReadLine();

            Console.Clear();

            int yil = Convert.ToInt32(yilStr);
            int mevcutYil = 2024;
            int yas = mevcutYil - yil;

            string mesaj = "Merhaba " + isim + " " + soyisim + " " + yas + " Yasindasiniz";

            Console.WriteLine(mesaj);

            Console.ReadLine();
        }
    }
}
