using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri[] musteriler = new Musteri[] { musteri, musteri2 };
            MusteriManager musteriManager = new MusteriManager();



            musteri.Ad = "Okan";
            musteri.Email = "okany4404 @gmail.com";
            musteri.Soyad = "YILMAZ";

            musteri2.Ad = "Ahmet";
            musteri2.Email = "Ahmet@gmail.com";
            musteri2.Soyad = "AHMET";


            musteriManager.MusteriEkle(musteri);
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriSil(musteri);
            musteriManager.MusteriSil(musteri2);

            musteriManager.MusteriListele(musteriler);




        }
    }
}
