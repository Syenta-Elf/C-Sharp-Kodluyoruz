using System;
using System.Collections.Generic;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collections.generic;
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1,"Kawai");
            kullanicilar.Add(2,"Ayse");
            kullanicilar.Add(18,"Deniz");
            kullanicilar.Add(21,"Ozcan");
            
            //dizi elemanlarina erisim
            System.Console.WriteLine("*****Erisim*****");
            System.Console.WriteLine(kullanicilar[2]);

            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }

            //Count
            System.Console.WriteLine("****Count****");
            System.Console.WriteLine(kullanicilar.Count);

            //Contains
            System.Console.WriteLine("****Contains****");
            System.Console.WriteLine(kullanicilar.ContainsKey(18));
            System.Console.WriteLine(kullanicilar.ContainsValue("Kawai"));

            //Remove
            System.Console.WriteLine("****Remove****");
            kullanicilar.Remove(21);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item.Key);
            }

            //Keys
            System.Console.WriteLine("****Keys****");
            foreach (var item in kullanicilar.Keys)
            {
                System.Console.WriteLine(item);
            }
            
            //Values
            System.Console.WriteLine("****Values****");
            foreach (var item in kullanicilar.Values)
            {
                System.Console.WriteLine(item);
            }




        }
    }
}
