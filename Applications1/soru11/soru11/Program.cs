using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alış fiyatını giriniz: ");
            double alis = Convert.ToDouble( Console.ReadLine());
            double vergi = alis * 10 / 100;
            double kar = alis*20 / 100;
            double satis = alis + vergi + kar;
            Console.WriteLine(satis);
            Console.ReadLine();
        }
    }
}
