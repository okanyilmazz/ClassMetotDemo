using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı kişi eklendi");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " adlı kişi Listelendi");
            }
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı kişi silindi");
        }

    }
}
