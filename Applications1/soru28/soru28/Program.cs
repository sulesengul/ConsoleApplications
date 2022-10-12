using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru28
{
    class Program
    {
        static void Main(string[] args)
        {
            int numara, saat, ucret,maas;
            Console.WriteLine("Sicil numarasını yazınız: ");
            numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çalışma saatini giriniz: ");
            saat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saat ücretini giriniz: ");
            ucret = Convert.ToInt32(Console.ReadLine());

            maas = saat * ucret;
            Console.WriteLine("Çalışanın maaşı: " + maas);
            Console.ReadLine();

        }
    }
}
