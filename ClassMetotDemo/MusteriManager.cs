using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Sisteme Kaydedildi!\n\n" + "Müşteri ID: " + musteri.Id + "\n" + "Müşteri Adı: " + musteri.Ad + "\n" + "Müşteri Soyadı: " + musteri.Soyad + "\n" + "Müşteri Telefon Numarası: " + musteri.TelNo + "\nMüşteri Doğum Tarihi: " + musteri.DogumTarihi + "\n" +  "\n");
        }

        public void Cikar(Musteri musteri)
        {
            Console.WriteLine("Aşağıda Belirtilen Müşteri Sistemden Çıkartılmıştır!\n\n" + "Müşteri ID: " + musteri.Id + "\n" + "Müşteri Adı: " + musteri.Ad + "\n" + "Müşteri Soyadı: " + musteri.Soyad + "\n" + "Müşteri Telefon Numarası: " + musteri.TelNo + "\nMüşteri Doğum Tarihi: " + musteri.DogumTarihi + "\n" + "\n");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Bilgileri:\n\n" + "Müşteri ID: " + musteri.Id + "\n" + "Müşteri Adı: " + musteri.Ad + "\n" + "Müşteri Soyadı: " + musteri.Soyad + "\n" + "Müşteri Telefon Numarası: " + musteri.TelNo + "\nMüşteri Doğum Tarihi: " + musteri.DogumTarihi + "\n" + "\n");
            }
        }
    }
}