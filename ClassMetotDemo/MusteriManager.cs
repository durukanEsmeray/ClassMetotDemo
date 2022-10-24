using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleme işlemi gerçekleştirildi : " + musteri.Ad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sileme işlemi gerçekleştirildi : " + musteri.Ad);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listeleme işlemi gerçekleştirildi : " + musteri.Ad);
        }
    }
}
