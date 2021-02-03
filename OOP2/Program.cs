using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Hilal";
            musteri1.Soyadi = "Günay";
            musteri1.TcNo = "123";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "25453";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "8855";



            musteri musteri3 = new GercekMusteri();
            musteri musteri4 = new TuzelMusteri();

            //2 referansıda tutabiliyor musterimanager

            CustomerManager customermanager = new CustomerManager();
            customermanager.Ekle(musteri1);
            customermanager.Ekle(musteri2);





            //Gerçek - Tüzel Müsteri
            //SOLID -Yazılım geliştirme prensibi (L)
        }
    }
}
