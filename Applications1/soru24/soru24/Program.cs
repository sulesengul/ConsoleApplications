using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("a değerini giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b değerini giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c değerini giriniz: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            Console.WriteLine("Delta: " + d);
            Console.ReadLine();

            double kok1= b+ Math.Sqrt(d)/2*a;
            double kok2= b+ Math.Sqrt(d)/2*a;


            if (d<0)
            {
                Console.WriteLine("Kök yoktur.");
            }
            else if (d==0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("Tek kök vardır." +x);
            }
            else
            {
                Console.WriteLine("Köklerden biri: " + kok1+" diğeri: " + kok2);
            }
            Console.ReadLine();

        }
    }
}
