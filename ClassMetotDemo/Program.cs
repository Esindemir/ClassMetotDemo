using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Esin";
            musteri1.Soyadi = "Demir";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Betül";
            musteri2.Soyadi = "Demir";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(".......");
            }

            Console.WriteLine("........Metotlar........");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Ekle2("Bedriye", "Demir");
            musteriManager.Ekle2("Behiye", "Temel");
        }
    }
}
