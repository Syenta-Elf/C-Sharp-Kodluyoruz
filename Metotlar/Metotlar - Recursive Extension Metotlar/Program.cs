using System;

namespace Metotlar___Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //RECURSIVE
            Islemler ornek = new();
            Console.WriteLine("sonuc: "+ornek.Expo(3,4));
            //Extension Metotlar
            string ifade = "Elif Nur";
            Console.WriteLine(ifade.CheckSpaces());

            if(ifade.CheckSpaces()) 
            Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            
            int[] dizi = {1,5,6,9,4,10,3};
            dizi.SortArray();

            dizi.EkranaYazdir();
            int a=4;
            System.Console.WriteLine(a.IsEvenNumber());

            string deneme = "deneme";
            System.Console.WriteLine(deneme.getFirstCharacter());
        }
        
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
         public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            if(param%2==0) return true;
            return false;
        }
        public static string getFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
    class Islemler
    {
        public int Expo(int sayi,int us)
        {   
            if(us<2)  return sayi;
            return Expo(sayi,us-1)*sayi; // => Expo(sayi,us-1)*sayi*sayi => Expo(sayi,us-1)*sayi*sayi*sayi ...

        }
    }
    
}
