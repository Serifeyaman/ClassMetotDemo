using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Şerife";
            musteri1.Soyad = "YAMAN";
            musteri1.MusteriTC = "12345678910";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Eren";
            musteri2.Soyad = "YAMAN";
            musteri2.MusteriTC = "55558896310";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ali";
            musteri3.Soyad = "VELİ";
            musteri3.MusteriTC = "22553678954";

            MusteriManager islemler = new MusteriManager();

            islemler.Ekle(musteri1);                        //parametre olarak verilen müşteriyi ekler
            islemler.Sil(musteri2);                         //parametre olarak verilen müşteriyi siler

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};
            islemler.Listele(musteriler);                   //tüm müşterileri listeler


        }

       
    }
}
