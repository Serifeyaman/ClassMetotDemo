using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen müşteri: " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Listele(Musteri[] musteriDizisi)
        {
            Console.WriteLine("****Müşteri Listesi****");
            foreach (Musteri musteri in musteriDizisi)
            {
                Console.WriteLine("AD: " + musteri.Ad);
                Console.WriteLine("SOYAD: " + musteri.Soyad);
                Console.WriteLine("TC NO: " + musteri.MusteriTC);
                Console.WriteLine("**********************");
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen müşteri: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
