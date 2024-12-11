using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAlistirma6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parola = "halil12";

            bool sonuc = parola.Length > 8 && parola.Any(char.IsUpper) && parola.Any(char.IsLower) && parola.Any(char.IsDigit);

            Console.WriteLine("Sonuc : " +  sonuc);
        }
    }
}
