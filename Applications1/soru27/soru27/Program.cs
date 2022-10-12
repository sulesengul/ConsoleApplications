using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru27
{
    class Program
    {
        static void Main(string[] args)
        {
            int saat, ucret;
            Console.WriteLine("İşçinin çalıştığı saati giriniz: ");
            saat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşçinin saat ücretini giriniz: ");
            ucret = Convert.ToInt32(Console.ReadLine());

            if (saat<40)
            {
                int maas = saat * ucret;
                Console.WriteLine("Alacağı ücret: "+maas);
            }
            else
            {
                int maas = saat * 2 * ucret;
                Console.WriteLine("Alacağı ücret: " + maas);
            }
            Console.ReadLine();
        }
    }
}
