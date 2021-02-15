using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Merve";
            musteri1.Soyadi = "Kalkan";
            musteri1.Meslek = "Hemşire";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Fatma";
            musteri2.Soyadi = "Özen";
            musteri2.Meslek = "Öğretmen";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.Listeleme(musteriler);
        }
    }
}
