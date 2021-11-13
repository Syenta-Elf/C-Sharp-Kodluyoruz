using System;

namespace Dizi_Kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = {"mor","kirmizi","sari","pembe","mavi"};
            string[] hayvanlar = new string[5];

            hayvanlar[3]="kopke";
            int[] dizi;
            dizi = new int[5];
            dizi[3]=10;

            Console.WriteLine("***renkler***");
            foreach (var renk in renkler)
            {
                Console.WriteLine(renk);
            }
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[3]);
            //Dongulerle dizi kullanimi

            Console.WriteLine("Lutfen dizinin eleman sayisini girin");
            int elemanS= int.Parse(Console.ReadLine());
            int[] dizi2 = new int[elemanS];
            float toplam=0f;
            
            for(int i=0;i<elemanS;i++)
            {   
                Console.WriteLine("Sayi girin:");
                dizi2[i]=int.Parse(Console.ReadLine());
                toplam+=dizi2[i];
            }

            Console.WriteLine("Dizinin Ortalamasi:"+toplam/elemanS); 
            
        }
    }
}
