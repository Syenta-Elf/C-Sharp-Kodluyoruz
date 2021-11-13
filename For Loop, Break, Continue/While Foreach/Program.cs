using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            int i = 1,toplam=0;
            while(sayac>=i)
            {
                toplam+=i;
                i++;
            }
            
            Console.WriteLine("Ortalama:"+toplam/sayac);
            char character ='a';
            while (character<='z')
            {
                 Console.Write(character);
                 character++;
            }

            Console.WriteLine("\n***Foreach***");

            string[] arabalar = {"bmw","ford","ferrari","toyota"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
