using System;
using System.Collections;

namespace Soru_2
{
    class Program
    {
        //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
        //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
        //(Array sınıfını kullanarak yazınız.)
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            int ort1=0,ort2=0;

            System.Console.WriteLine("20 sayi girin");
            for (int i = 0; i < 20; i++)
                {   
                    System.Console.Write("Sayi girin:");
                    try
                    {
                         sayilar.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch (FormatException)
                    {
                        i--;
                        System.Console.WriteLine("Yanlis formatta sayi girdiniz.Sonraki islemde tekrar deneyiniz.");
                    }
                }

            sayilar.Sort();
                ort1 = deneme(sayilar)/3;

            sayilar.Reverse();
                ort2 = deneme(sayilar)/3;

            System.Console.WriteLine("Kucuk sayilarin ortalamasi:"+ort1+"\n Buyuk sayilarin ortalamasi:"+ort2+"\n Iki ortalamanin toplami:"+(ort1+ort2));

        }

        public static int deneme(ArrayList s)
        {
            int toplam=0;
            for (int i = 0; i < 3; i++)
                {
                    toplam+=Convert.ToInt32(s[i]);
                }
            return toplam;
        }

    }
}
