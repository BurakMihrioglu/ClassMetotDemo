using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Burak";
            musteri1.Soyad = "Mihrioğlu";
            musteri1.TelNo = "1111111111111";
            musteri1.DogumTarihi = 999999;
            



            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.TelNo = "22222222";
            musteri2.DogumTarihi = 8888;
            


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("YENİ MÜŞTERİ EKLEME METODU \n");

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("MÜŞTERİYİ SİSTEMDEN SİLME METODU \n");

            musteriManager.Cikar(musteri1);
            musteriManager.Cikar(musteri2);

            Console.WriteLine("MÜŞTERİ BİLGİLERİNİ LİSTELEME METODU \n");

            musteriManager.Listele(musteriler);

        }
    }
}
