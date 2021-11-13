using System;

namespace Array_Kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayiDizisi = {1,5,6,3,7,12};

            Console.WriteLine("***Sirasiz Liste***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Sort
            Console.WriteLine("***Sirali Liste***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Clear
            Console.WriteLine("***Clear***");
            Array.Clear(sayiDizisi,2,2); // dizi,x,y => x index baslangici| y ne kadar ilerleyeceği
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Reverse
            
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("***IndexOf***");
            Console.WriteLine(Array.IndexOf(sayiDizisi,0));
            //Resize
             Console.WriteLine("***Resize***");
             Array.Resize<int>(ref sayiDizisi,9);
             sayiDizisi[8]=99;
             foreach (var sayi in sayiDizisi)
             {
                 Console.WriteLine(sayi);
             }
        }
    }
}
