using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4. sayıyı giriniz: ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5. sayıyı giriniz: ");
            int sayi5 = Convert.ToInt32(Console.ReadLine());
            int toplam, ort;
            toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;
            ort = toplam / 5;
            Console.WriteLine("Toplam : {0} ortalama: {1}",toplam,ort );
            Console.ReadLine();



        }
    }
}
