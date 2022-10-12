using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            if (sayi<0)
            {
                Console.WriteLine("Sayı negatiftir.");
                Console.ReadLine();
            }
            else if (sayi==0)
            {
                Console.WriteLine("Sayı sıfırdır.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sayı pozitiftir.");
                Console.ReadLine();
            }
        }
    }
}
