using System;

namespace Karar_Yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            /*
            if( time<11 && time>=6)
            {
                Console.WriteLine("Iyi Sabahlar");
            }

            else if(time<=18)
            {
                Console.WriteLine("Iyi Gunler!");
            }
            else
            {
                Console.WriteLine("Iyi Aksamlar!");
            }
            */
            
            //string sonuc = time<=18 ? "Iyi gunler" : "Iyi Aksamlar"; 
            string sonuc = time >=6 && time<=11 ? "Gunaydin!" : time<=18 ? "Iyi Gunler!" : "Iyi Aksamlar!";
            Console.WriteLine(sonuc);
        }
    }
}
