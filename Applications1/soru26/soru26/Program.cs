using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru26
{
    class Program
    {
        static void Main(string[] args)
        {
            int maas, cocuk;
            Console.WriteLine("Maaşı giriniz: ");
            maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çocuk sayısı : ");
            cocuk = Convert.ToInt32(Console.ReadLine());

            if (cocuk==1)
            {
                maas = maas + maas * 5 / 100;
                Console.WriteLine("Yeni maaş: "+maas);
            }
            else if (cocuk==2)
            {
                maas = maas + maas * 10 / 100;
                Console.WriteLine("Yeni maaş: "+maas);
            }
            else if (cocuk>=3)
            {
                maas = maas + maas * 15 / 100;
                Console.WriteLine("Yeni maaş: "+maas);
            }
            Console.ReadLine();
        }
    }
}
