using System;
using System.Collections;
using System.Collections.Generic;

namespace Soru_1
{
    class Program
    {
    //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
    // (ArrayList sınıfını kullanara yazınız.)
    // -Negatif ve numeric olmayan girişleri engelleyin.
    // -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    // -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            ArrayList asalSayilar = new ArrayList();
            int sayac=0;

            System.Console.WriteLine("20 sayi giriniz.");
            //try catch negatif sayi veya yanlis format girilmesini engelliyor.
            try
            {
                 for(int i=0;i<20;i++)
                 {  
                     System.Console.Write("Sayi giriniz:");
                     sayilar.Add(Convert.ToUInt32(Console.ReadLine()));
                 }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);   
            }

            for (int i = 0; i < sayilar.Count; i++)
            {
                int sayi = Convert.ToInt32(sayilar[i]);
                for (int j = 2; j <sayi; j++)
                {
                    if(sayi%j==0) sayac++; 
                }

                if(sayi==1 || sayi==0)
                    {
                        asalOlmayanSayilar.Add(sayi);
                    }
                else if(sayac==0) asalSayilar.Add(sayi);
                else asalOlmayanSayilar.Add(sayi);
                sayac=0;
                    
            }
            
            int toplam=0;
            System.Console.WriteLine("*****asal sayilar*****");
            asalSayilar.Sort();
            foreach (var item in asalSayilar)      
                {
                    System.Console.WriteLine(item);
                    toplam+=Convert.ToInt32(item);
                }
            
            System.Console.WriteLine(asalSayilar.Count+" tane asal sayi var.Ortalama:"+toplam/asalSayilar.Count);
            toplam=0;

            System.Console.WriteLine("*****asal olmayan sayilar*****");
            asalOlmayanSayilar.Sort();
            foreach (var item in asalOlmayanSayilar)      
                {
                    System.Console.WriteLine(item);
                    toplam+=Convert.ToInt32(item);
                }

            System.Console.WriteLine(asalOlmayanSayilar.Count+" tane asal olmayan sayi var.Ortalama:"+toplam/asalOlmayanSayilar.Count);
            sayac=0;
 
        }
    }
}
