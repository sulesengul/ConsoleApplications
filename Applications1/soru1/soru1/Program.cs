using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x sayısını girin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine("y sayısını girin: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x>y)
            {
                Console.WriteLine("x en büyük sayıdır" + x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("y en büyük sayıdır" + y);
                Console.ReadLine();
            }

        }
    }
}
