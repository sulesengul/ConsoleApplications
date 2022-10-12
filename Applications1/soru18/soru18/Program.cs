using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi%2==0)
            {
                Console.WriteLine("Sayı çifttir. ");
            }
            else 
            {
                Console.WriteLine("Sayı tektir. ");
            }
            
            Console.ReadLine();

        }
    }
}
