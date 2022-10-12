using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru25
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (0<sayi && sayi<99999)
            {
                while (sayi>0)
                {
                    sayi = sayi / 10;
                    sayac++;
                }
                Console.WriteLine(sayac);
            }
            Console.ReadLine();
  
        }
    }
}
