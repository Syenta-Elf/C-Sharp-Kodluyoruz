using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // list.Add("Ayse");
            // list.Add(2);
            // list.Add(true);
            //list.Add('A');

            //icerisindeki verilere erisim

            //System.Console.WriteLine(list[0]);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            //AddRange birden fazla elemani ekleme
            System.Console.WriteLine("*********AddRange**********");
            //string[] renkler = {"mor","kirmizi","mavi","sari","pembe"};
            List<int> sayilar = new List<int>() {1,2,5,4,3};
            
            //list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach (var item in list)
            {
                System.Console.WriteLine(item.ToString());
            }

            //Sort
            System.Console.WriteLine("******Sort*****");
            list.Sort();
            
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            //BinarySearch
            System.Console.WriteLine("*******Binary*******");
            System.Console.WriteLine(list.BinarySearch(3));

            //Reverse
            System.Console.WriteLine("*******Reverse*******");
            list.Reverse();
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            //Clear
            list.Clear(); //listeyi temizle
            System.Console.WriteLine("*******Clear*******");
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
