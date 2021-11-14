using System;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        * Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        */
        System.Console.WriteLine("Bir sayi girin:");
        
        int sayi = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(sayi+" tane sayi girin:");
        int[] sayilar = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            Console.Write("Sayi gir:");
            sayilar[i]=Convert.ToInt32(Console.ReadLine());
        }
        sayilar.ciftGoster();

        }

    }
    public static class Extension
    {
        public static void ciftGoster(this int[] param)
        {
            System.Console.WriteLine("Girdiginiz cift sayilar:");
            foreach (var item in param)
            {
                if(item%2==0) Console.Write(item+" ");
            }
        }
    }
}
