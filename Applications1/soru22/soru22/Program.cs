using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Sayı giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı giriniz: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x>y)
            {
                Console.WriteLine("İki sayının farkı: " + (x - y));
            }
            else
            {
                Console.WriteLine("İki sayının farkı: " + (y - x));
            }
            Console.ReadLine();
        }
    }
}
