using System;

namespace OOP_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriId = "2";
            musteri1.Ad = "Dilan";
            musteri1.Soyad = "Budak";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 3;
            musteri2.MusteriId = "4";
            musteri2.SirketAdi = "En Büyük Şirket Benim";
            musteri2.VergiNo = "5";


            Musteri musteri3 = new TuzelMusteri();  // Inheritance aldığımzda Base sınıfımız(Musteri) bu şekilde de örnek alabiliyoruz referans oluşturabiliyoruz.
            Musteri musteri4 = new GercekMusteri();   //Yani demek istediğim şey = Çok Önemli Eğer senin bir BASE sınıfın varsa o bir referans tutucudur. 


            MusteriManager customerManager = new MusteriManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

        }
    }
}
