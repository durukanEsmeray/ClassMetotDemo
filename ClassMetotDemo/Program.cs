using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Musteri musteri1 = new Musteri();
           
            musteri1.Ad = "Durukan";
            musteri1.Soyad = "Esmeray";
            musteri1.Yas = 31;

            Musteri musteri2 = new Musteri();
            
            musteri2.Ad = "Demir";
            musteri2.Soyad = "Duru";
            musteri2.Yas = 8;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Yas);
            }



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
        }
    }
}
