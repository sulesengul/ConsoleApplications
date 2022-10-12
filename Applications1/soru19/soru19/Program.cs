using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru19
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final, ort;
            Console.WriteLine("Vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            ort = vize * 30 / 100 + final * 70 / 100;

            if (ort>=50 && final>=50)
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
