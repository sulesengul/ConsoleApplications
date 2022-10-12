using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru13
{
    class Program
    {
        static void Main(string[] args)
        {
            int taban, yükseklik, alan;
            Console.WriteLine("Üçgenin taban uzunluğunu giriniz: ");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin yüksekliğini giriniz: ");
            yükseklik = Convert.ToInt32(Console.ReadLine());
            alan = taban * yükseklik / 2;
            Console.WriteLine("Üçgenin alanı: " + alan);
            Console.ReadLine();
        }
    }
}
