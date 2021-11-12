using System;

namespace Console_Programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminiz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba "+name+" "+surname);

        }
    }
}
