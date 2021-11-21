using System;

namespace Static_Sinif_ve_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Calisan Sayisi:"+Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayse","Yilmaz","IK");
            System.Console.WriteLine("Calisan Sayisi:"+Calisan.CalisanSayisi);
            Islemler.Topla(200,300);
            Islemler.Cikar(100,50);
        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;}

        private string isim;
        private string soyIsim;
        private string departman;
        static Calisan(){
            calisanSayisi=0;

        }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.isim = isim;
            this.soyIsim = soyIsim;
            this.departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
