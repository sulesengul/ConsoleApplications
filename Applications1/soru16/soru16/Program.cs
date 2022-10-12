using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru16
{
    class Program
    {
        static void Main(string[] args)
        {
            int not;
            Console.WriteLine("Notu giriniz: ");
            not = Convert.ToInt32(Console.ReadLine());

            if (not>=50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
            Console.ReadLine();
        }
    }
}
