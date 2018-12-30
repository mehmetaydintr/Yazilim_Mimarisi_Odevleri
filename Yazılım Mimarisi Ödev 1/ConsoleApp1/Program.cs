using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Isimler = { "Serbay ŞİMŞİR", "Mehmet AYDIN", "Hasan KARATAŞ", "Angelina Jolie", "Dilara Güler", "Bilal Hancı", "Bahar Sabah", "Gamze Çiçek", "Mustafa Kemal" };
            string[] KartTipleri = { "enMasterCard", "enVisa", "enAmericanExpress" };
            Banka b = new Banka();
            for (int i = 0; i < Isimler.Length; i = i + 3)
            {
                IProduct p = b.KartiAl(Banka.enProduct.enMasterCard, Isimler[i]);
                Console.WriteLine(p.KartNo + " " + p.Isim + " " + p.SonKullanmaTarihi.ToShortDateString());
                IProduct p2 = b.KartiAl(Banka.enProduct.enVisa, Isimler[i+1]);
                Console.WriteLine(p2.KartNo + " " + p2.Isim + " " + p2.SonKullanmaTarihi.ToShortDateString());
                IProduct p3 = b.KartiAl(Banka.enProduct.enAmericanExpress, Isimler[i+2]);
                Console.WriteLine(p3.KartNo + " " + p3.Isim + " " + p3.SonKullanmaTarihi.ToShortDateString());
            }
            Console.ReadLine();

        }
    }
}
