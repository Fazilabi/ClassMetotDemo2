using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Adi = "Ali", Soyadi = "Aliyev", Shehir = "Baku", TCNo = "123456" };
            Musteri musteri2 = new Musteri() { Adi = "Veli", Soyadi = "Veliyev", Shehir = "Adana", TCNo = "24682468" };
            Musteri musteri3 = new Musteri() { Adi = "Ahmet", Soyadi = "Ahmedov", Shehir = "Sheki", TCNo = "13579135" };
            Musteri musteri4 = new Musteri() { Adi = "Mehmet", Soyadi = "Memmedov", Shehir = "Quba", TCNo = "321654" };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Guncelle(musteri2);
            musteriManager.Sil(musteri4);
            musteriManager.Goruntule(musteri1);
        }
    }
}
