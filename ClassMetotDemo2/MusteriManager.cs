using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " -> Eklendi");

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " -> Silindi");

        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " -> Guncellendi");

        }
        public void Goruntule(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " -> Goruntulendi");

        }
    }
}
