using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru29
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam=0, carpim=1, karetoplami=0;
            Console.WriteLine("Sayı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < x; i++)
            {
                if (i%2==0)
                {
                    karetoplami += i*i;
                }
                if (i%2==1)
                {
                    toplam += i;
                    carpim *= i;
                }
            }
            Console.WriteLine("Teksayılların toplamı: " + toplam + " Tek sayıların çarpımı: " + carpim);
            Console.WriteLine("Çift sayıların karelerinin toplamı: " + karetoplami);
            Console.ReadLine();


        }
    }
}
