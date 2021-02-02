using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler.Sisteme eklendiniz :" + musteri.Adi);
        }
        public void Ekle2(string musteriAdi , string Soyadi)
        {
            Console.WriteLine("Silme işleminiz gerçekleştirildi. :" + musteriAdi);
        }
    }
}
