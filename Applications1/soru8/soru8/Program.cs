using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru8
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 1;


            for (int i = 5; i > 1; i--)
            {
                toplam = toplam*i;
            }
            Console.WriteLine("Faktoriyel: "+toplam);
            Console.ReadLine();
           

        }
    }
}
