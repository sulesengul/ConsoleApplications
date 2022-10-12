using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru20
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi%3==0 && sayi%5==0)
            {
                Console.WriteLine("Tam bölünür.");
            }
            else
            {
                Console.WriteLine("Tam bölünmez.");
            }
            Console.ReadLine();
        }
    }
}
