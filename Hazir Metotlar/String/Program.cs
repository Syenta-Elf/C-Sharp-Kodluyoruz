using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Lenght
            string deneme = "deneme yazisi C#";
            string degisken= "C#";
            System.Console.WriteLine(deneme.Length);

            //ToUpper , ToLower
            System.Console.WriteLine(deneme.ToLower());
            System.Console.WriteLine(deneme.ToUpper());
            
            //Concat
            Console.WriteLine(string.Concat(deneme,"Selam!"));

            //Compare
            System.Console.WriteLine(deneme.CompareTo(degisken));// 0,1,-1 => esitlerse 0 , soldaki büyükse 1, kucukse -1
            System.Console.WriteLine(string.Compare(deneme,degisken,true));//true iken büyük küçük harf duyarsız,false iken duyarlı

            //Contains
            System.Console.WriteLine(deneme.Contains(degisken));
            System.Console.WriteLine(deneme.EndsWith("C#"));
            System.Console.WriteLine(deneme.StartsWith("degisken"));

            // IndexOf
            System.Console.WriteLine(deneme.IndexOf("C"));
            System.Console.WriteLine(deneme.LastIndexOf("e"));
            
            //Insert
            System.Console.WriteLine(deneme.Insert(0,"ekle ")); // bu kod dizesi içine ekliyor.
            System.Console.WriteLine(deneme);
            
            //PadLeft, PadRight
            System.Console.WriteLine(deneme+degisken.PadLeft(30));
            System.Console.WriteLine(deneme+degisken.PadLeft(30,'*'));
            System.Console.WriteLine(deneme.PadRight(50));
            System.Console.WriteLine(deneme.PadRight(50,'-')+degisken);

            //Remove
            System.Console.WriteLine(deneme.Remove(5));
            System.Console.WriteLine(deneme.Remove(0,3));
            System.Console.WriteLine(deneme.Remove(5,3));

            //Replace
            System.Console.WriteLine(deneme.Replace("yazisi","denemesi"));

            //Split
            System.Console.WriteLine(deneme.Split(' ')[1]);


        }
    }
}
