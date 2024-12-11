using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama Operatörü
            // int + int (toplama işlemi yapar)

            int s1 = 10;
            int s2 = 20;

            int toplam = s1 + s2;

            byte s3 = 25;
            byte s4 = 26;

            var toplam2 = s3 + s4;

            string metin1 = "Merhaba";
            int s5 = 10;
            
            string toplamStr1 = metin1 + s5;

            string metin2 = "Dünya";

            string toplamStr2 = metin1 + metin2;


            // Çıkartma Operatörü(-)
            // byte, int, double, float, decimal 

            int a = 100;
            int b = 50;

            int sonuc = a - b;

            // Çarpma Operatörü(*)
            // byte int double float decimal

            double d1 = 10.4;
            double d2 = 10.6;

            double sonuc2= d1 * d2;

            int sonucInt = (int) (sonuc2);

            //Bölme

            int sayi = 10;
            int sayi2 = 20;
            int sonuc3 = sayi2 / sayi;

            

            // Mod Alma Operatörleri

            int m1 = 10;
            int m2 = 2;
            int sonucMod = m1 % m2;

            // ++ Operatörü
            int o = 15;
            int operatorSonuc = o++;
            int operatorsonuc2 = ++o;

            // -- Operatörü

            int o2 = 10;

            int OperatorSonuc3 = o--;
            int OperatorSonuc4 = --o;

        }
    }
}
