using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Colections.Generic
            //T-> object turundedir.


            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(32);
            sayiListesi.Add(35);
            sayiListesi.Add(84);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sari");
            renkListesi.Add("Yesil");
            renkListesi.Add("Pembe");
            renkListesi.Add("Mor");

            //Count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            foreach (var item in renkListesi)
            {
                System.Console.WriteLine(item);
            }

            foreach (var item in sayiListesi)
            {
                System.Console.WriteLine(item);
            }

            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));

            //List eleman cikarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yesil");

            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));
            
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));

            //List icinde arama

            if(sayiListesi.Contains(19)) 
                System.Console.WriteLine("19 liste icerisinde bulundu");
            else 
                System.Console.WriteLine(("19 listede bulunamadi"));

            //Eleman ile index'e erisme

            System.Console.WriteLine(renkListesi.BinarySearch("Kirmizi"));

            //Diziyi Listeye cevirme

            string[] hayvanlar = {"kedi","kopek","kus"};

            List<string> hayvanListesi = new List<string>(hayvanlar);
            
            //Listeyi temizleme
            hayvanListesi.Clear();

            //List icerisinde nesne tutmak
            List<kullanicilar> kullanicilarListesi = new List<kullanicilar>();
            
            kullanicilar kullanici1 = new kullanicilar();
            kullanici1.Isim="Elif";
            kullanici1.Soyisim="Telase";
            kullanici1.Yas=18;

            kullanicilar kullanici2 = new kullanicilar();
            kullanici2.Isim="Berk";
            kullanici2.Soyisim="Demir";
            kullanici2.Yas=13;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            List<kullanicilar> yeniListe = new List<kullanicilar>();
            yeniListe.Add(new kullanicilar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas=24
            });

            foreach (kullanicilar kullanici in kullanicilarListesi)
            {
                System.Console.WriteLine("Kullanici adi:"+kullanici.Isim);
                System.Console.WriteLine("Kullanici soyadi:"+kullanici.Soyisim);
                System.Console.WriteLine("Kullanici yas:"+kullanici.Yas);
            }
        }
    }
    public class kullanicilar{
        private string isim;
        private string soyisim; 
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
