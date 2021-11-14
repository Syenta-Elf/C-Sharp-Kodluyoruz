using System;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               *Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
               *Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
               *Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            */
            System.Console.WriteLine("2 Sayi giriniz:");
            int n= Convert.ToInt32(Console.ReadLine());
            int m= Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine(n+" tane sayi giriniz:");
            int[] dizi = arrayOlustur(n);
            esitVeyaBolunen(dizi,m);
        }

        public static int[] arrayOlustur(int param)
        {
            int[] dizi = new int[param];
            for (int i = 0; i < param; i++)
            {   
                System.Console.Write("Sayi girin:");
                dizi[i]= Convert.ToInt32(Console.ReadLine());
            }
            return dizi;
        }

        public static void esitVeyaBolunen(int[] param,int m)
        {
            System.Console.WriteLine("m'e esit veya bolunen sayilar:");
            foreach (var item in param)
            {
                if(item%m==0 || item==m) Console.Write(item+" ");
            }
        }
    }
    
}
