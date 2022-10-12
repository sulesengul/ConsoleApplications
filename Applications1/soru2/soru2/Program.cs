using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vize notunu giriniz:");
            int vize = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("final notunu giriniz:");
            int final = Convert.ToInt32( Console.ReadLine());
            int ortalama = (int) (vize * 0.40) +(int) (final * 0.60);
            Console.WriteLine("ortalama" +ortalama);

            if (ortalama>=35)
            {
                Console.WriteLine("Geçtiniz.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kaldınız.");
                Console.ReadLine();
            }
        }
    }
}
