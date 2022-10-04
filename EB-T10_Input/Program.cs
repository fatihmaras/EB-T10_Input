using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anne Adın Nedir");
            string X = Console.ReadLine();

            Console.WriteLine("Baba Adın Nedir");
            string Y = Console.ReadLine();

            Console.WriteLine("Dayının Adı Nedir");
            string Z = Console.ReadLine();

            Console.WriteLine("Halanın Adı Nedir");
            string T = Console.ReadLine();



            Console.WriteLine("Kişinin Anne Adı: " + X);
            Console.WriteLine("Kisinin Baba Adı: " + Y);
            Console.WriteLine("Kisinin Dayı Adı: " + Z);
            Console.WriteLine("Kisinin Hala Adı: " + T);
            Console.WriteLine("Teşekkürler");


            Console.ReadLine();

        }
    }
}
