using System;

namespace Soru_3
{
    class Program
    {
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        static void Main(string[] args)
        {
           System.Console.WriteLine("Bir sayi girin:");
           int n=Convert.ToInt32(Console.ReadLine());
           string[] kelimeler = kelime(n);
           
           goster(kelimeler);
           reverse(kelimeler);
           goster(kelimeler);
        }

        static string[] kelime (int n)
        {
            string[] kelimeler = new string[n];
            System.Console.WriteLine(n+" tane kelime girin:");
            
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Kelime girin:");
                kelimeler[i]=Console.ReadLine();
            }
            return kelimeler;
        }

        static string[] reverse(string[] kelimeler)
        {
            Array.Reverse(kelimeler);
            return kelimeler;
        }

        static void goster(string[] kelimeler)
        {
            foreach (var kelime in kelimeler)
            {
                System.Console.Write(kelime+" ");
            }
            System.Console.WriteLine("");//alta satira gecmesi icin.
        }
    }
}
