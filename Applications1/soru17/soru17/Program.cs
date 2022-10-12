using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru17
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, sozlu,ort;
            Console.WriteLine("1. notu giriniz: ");
            not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. notu giriniz: ");
            not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sölü notunu giriniz: ");
            sozlu = Convert.ToInt32(Console.ReadLine());

            ort = (not1 + not2 + sozlu) / 3;
            if (ort>=50)
            {
                Console.WriteLine("Geçti.");
            }
            else
            {
                Console.WriteLine("Kaldı.");
            }
            Console.ReadLine();

        }
    }
}
