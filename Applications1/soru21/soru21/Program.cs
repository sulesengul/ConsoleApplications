using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Sayı giriniz.");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (0<sayi && sayi<100)
            {
                Console.WriteLine("Geçerli.");
            }
            else
            {
                Console.WriteLine("Geçersiz.");
            }
            Console.ReadLine();
        }
    }
}
