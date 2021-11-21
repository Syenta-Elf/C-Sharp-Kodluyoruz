using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumluCogalma();
            System.Console.WriteLine("*************");
            Kuslar kus = new Kuslar();
            kus.UcarakHareketEtmek();
        }
    }
}
