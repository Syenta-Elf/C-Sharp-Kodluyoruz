using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string a="999";
            
            bool sonuc = int.TryParse(a, out int sayi);

            if(sonuc) 
            {
                Console.WriteLine("Basarili.");
                Console.WriteLine(sayi);
            }
            else Console.WriteLine("Basarisiz");
            Metotlar deneme = new Metotlar();
            deneme.Topla(3,4,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);
            deneme.EkranaYazdir("Merhaba");
            deneme.EkranaYazdir("Merhaba Dunya");
            deneme.EkranaYazdir(1);
        }

    }
    class Metotlar
    {
        public void Topla(int a,int b,out int topla)
        {
            topla=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

    }
}
