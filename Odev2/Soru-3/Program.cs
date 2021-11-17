using System;
using System.Collections;

namespace Soru_3
{
    class Program
    {
        //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve
        //dizinin elemanlarını sıralayan programı yazınız.
        static void Main(string[] args)
        {   
            System.Console.Write("Bir cumle giriniz:");
            string cumle = Console.ReadLine();
            ArrayList sesliHarfler = new ArrayList();
            string sesliHarfListe = "aeoiu"+"AEOIU";

            for (int i = 0; i < cumle.Length; i++)
                if(sesliHarfListe.Contains(cumle[i])) sesliHarfler.Add(cumle[i]);
            
            System.Console.WriteLine("***siralanmamis***");
            foreach (var item in sesliHarfler)
                System.Console.Write(item+" ");

            sesliHarfler.Sort();
            System.Console.WriteLine("\n***siralanmis***");
             foreach (var item in sesliHarfler)
                System.Console.Write(item+" ");
            
        }
    }
}
