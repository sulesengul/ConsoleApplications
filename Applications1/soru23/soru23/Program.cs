using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suyun sıcaklık derecesini giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi<100)
            {
                Console.WriteLine("Katı halindedir.");
            }
            else if (sayi==100)
            {
                Console.WriteLine("Sıvı halindedir.");
            }
            else
            {
                Console.WriteLine("Gaz halindedir.");
            }
            Console.ReadLine();
        }
    }
}
