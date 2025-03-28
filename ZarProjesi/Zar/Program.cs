using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zar
{
    class Program
    {
        static void Main(string[] args)
        {
            Zar zar = new Zar();
            string devamMi;

            do
            {
                Console.WriteLine("Zarı atmak için bir tuşa basınız.");
                Console.ReadKey();
                int sonuc = zar.ZarAt();
                Console.WriteLine("Zarın değeri: " + sonuc);

                Console.WriteLine("Devam etmek istiyor musunuz? (e/h)");
                devamMi = Console.ReadLine();

            } while (devamMi.ToLower() == "e");
            Console.WriteLine("Oyun bitti.Çıkmak için bir tuşa basınız. ");
            Console.ReadKey();
        }
    }
}
