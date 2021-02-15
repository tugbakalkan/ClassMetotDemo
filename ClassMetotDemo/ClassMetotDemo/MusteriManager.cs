using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.Soyadi+" : isimli müşteri eklendi. " );
            Console.WriteLine("-----------------------");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.Soyadi + " : isimli müşteri silindi. ");
            Console.WriteLine("-----------------------");
        }
       
        public void Listeleme(Musteri[] musteri)
        {
            foreach (var x in musteri)
            {
                Console.WriteLine(x.Adi + " " + x.Soyadi);
                Console.WriteLine("-----------------------------");
            }
            
        }
    }
}
