using System;

namespace Enum_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);    
            System.Console.WriteLine((int)Gunler.Cumartesi);
            int sicak = 35;
            if(sicak<=(int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Disariya cikmak icin havanin isinmasini bekleyelim");
            }
            else if (sicak>=(int)HavaDurumu.Sicak)
            {
                System.Console.WriteLine("Disariya cikmak icin cok sicak");
            }
            else if (sicak>=(int)HavaDurumu.Normal&& sicak<(int)HavaDurumu.CokSicak)
            {
                System.Console.WriteLine("Disari cikalim");
            }
        }
    }
    enum Gunler{
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak=30
    }
}
