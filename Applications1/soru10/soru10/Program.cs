using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a değerini giriniz: ");
            int a = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("b değerini giriniz: ");
            int b = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("c değerini giriniz: ");
            int c = Convert.ToInt32( Console.ReadLine());
            int d = (b * b) - 4 * a * c;
            
            double kök1,kök2;
            kök1 = b + Math.Sqrt(Convert.ToDouble( d))/2;
            Console.WriteLine(kök1);
            kök2 = b - Math.Sqrt(Convert.ToDouble(d)) / 2;

            if (d>0)
            {
                Console.WriteLine("İki kök vardır.");
                Console.WriteLine("Köklerden bir tanesi : "+kök1 + " Köklerden diğeri : "+kök2);
            }
            else if (d==0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("Tek kök vardır. " +x);
            }
            else
            {
                Console.WriteLine("Kökler reel değil.");
            }
       
            Console.ReadLine();

        }
    }
}
