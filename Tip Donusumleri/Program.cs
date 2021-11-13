using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Implicit Conversion***");
            //Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm) küçük tipi büyültme
            byte a= 5; 
            sbyte b=20;
            short c=30;

            int d = a+b+c;
            Console.WriteLine("d:"+d);

            long f = d;
            Console.WriteLine("f:"+f);

            float i = f;
            Console.WriteLine("i:"+i);

            string k= "kelime";
            char h='h';
            object g = k+h+f;

            Console.WriteLine("g:"+g);

            //Explicit Conversion (Bilinçli ya da açık dönüşüm) Büyük tipi küçültme , veri kaybı yaşanabilir.

            Console.WriteLine("***Explicit Conversion***");

            int x = 4;
            byte y=(byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t= (byte)z;
            Console.WriteLine("t:"+t);

            float w= 13.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+v);


            //*** To String Methodu ***

            Console.WriteLine("*** To String Methodu ***");

            int xx=6;
            string yy= xx.ToString();
            Console.WriteLine("yy:"+yy);  

            string zz = 12.3f.ToString();
            Console.WriteLine("zz:"+zz);

            //*** System.Convert ***

            Console.WriteLine("*** System.Convert Sınıfı ***");

            string s1="10",s2="20";
            int Toplam;

            Toplam=Convert.ToInt32(s1) + Convert.ToInt32(s2);
            Console.WriteLine("Toplam:"+Toplam);

            //*** Parse ***

             Console.WriteLine("*** Parse ***");

             ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1="10";
            string metin2 = "9,20";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("Rakam1:"+rakam1);
            Console.WriteLine("Double1:"+double1);
        }
    }
}
