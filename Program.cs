using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.MusteriAdi = "Mehmet";
            musteri1.MusteriAdres = "Istanbul";
            musteri1.MusteriSoyadi = "Çelik";
            musteri1.MusteriTc = "010101010";

            musteri2.MusteriAdi = "Nurhan";
            musteri2.MusteriAdres = "Bandırma";
            musteri2.MusteriSoyadi = "Çelik";
            musteri2.MusteriTc = "1010101010";
            Musteri[] musteriler = new Musteri[] { musteri1,musteri2 };
            MusteriManager MstrMngr = new MusteriManager();
            MstrMngr.MusteriEkle("Mehmet","Çelik","İstanbul","010101010");
            foreach (var musteri in musteriler) 
            {
                Console.WriteLine(musteri.MusteriAdi);
                   
            }

            MstrMngr.MusteriListele();


        }
    }
}


