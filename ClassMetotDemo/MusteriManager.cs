using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + musteri.soyad + "Müşterisi eklendi");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler listelendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + musteri.soyad + "Müşterisi silindi");
        }
    }
}
