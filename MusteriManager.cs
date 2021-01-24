using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(string MusteriAdi, string MusteriSoyadi, string MusteriAdres, string MusteriTc)
        {
            Console.WriteLine("Adı:" + MusteriAdi +"Soyadı:" + MusteriSoyadi + "Musterinin Adresi:" + MusteriAdres + "Müsterinin Tc'si:" + MusteriTc);
            }
        public void MusteriListele()
        {

            Console.WriteLine("Listelendiiii.");


        }
    }
}
