using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());

            for(int i=0;i<=sayac;i++)
            {
                if(i%2==1) Console.WriteLine(i);
            }

            int ciftToplam=0 , tekToplam=0;

            for(int i=0;i<=1000;i++)
            {
                if(i%2==1) tekToplam+=+i;
                else ciftToplam+=+i; 
            }
            Console.WriteLine("Tek Toplam:"+tekToplam+"\nCift Toplam:"+ciftToplam);

            for(int i=0;i<10;i++)
            {   
                Console.WriteLine(i);
                if(i==4) break; //donguden cikti
            }
            for(int i=0;i<10;i++)
            {   
                Console.WriteLine(i);
                if(i==4) continue;//dongu devam etti
            }
        }
    }
}
