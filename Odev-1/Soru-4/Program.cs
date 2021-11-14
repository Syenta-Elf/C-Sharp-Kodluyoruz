using System;

namespace Soru_4
{
    class Program
    {
        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bir cümle girin");
            string cumle = Console.ReadLine();
            kacKelimeVar(cumle);
            kacHarfVar(cumle);
        }

        static void kacKelimeVar(string cumle)
        {
            string[] kelimeler = cumle.Split(" ");
            Console.WriteLine("Kelime Sayisi: "+kelimeler.Length);
        }
        
        static void kacHarfVar(string cumle)
        {
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
            int sayac = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                    sayac++;
            }

            Console.WriteLine("toplam "+sayac+" tane harf vardır.");
        }
    }
}
