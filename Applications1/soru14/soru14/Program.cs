using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru14
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, i, r;
            Console.WriteLine("Akım değerini giriniz: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Direnç değerini giriniz: ");
            r = Convert.ToInt32(Console.ReadLine());
            v = i * r;
            Console.WriteLine("Gerilim değeri: " + v);
            Console.ReadLine();
            
        }
    }
}
