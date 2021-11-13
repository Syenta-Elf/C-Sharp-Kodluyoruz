using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)

            int x=3;
            x+=3;
            x++;

            //Mantıksal Operatörler (||, &&, !)
            bool t=true;
            bool f=false;
            if(t&&f)
            {
                Console.WriteLine("&&");
            }
            if(t!&&f)
            {
                Console.WriteLine("!&&");
            }
            if(t||f)
            {
                Console.WriteLine("||");
            }
            //İlişkisel Operatörler (==,!=, <, >, >=,<=)
            int a=3;
            int b=5;

            if(a==b)
            {
                Console.WriteLine("a==b");
            }
            if(a!=b)
            {
                Console.WriteLine("a!=b");
            }
            if(a>b)
            {
                Console.WriteLine("a>b");
            }
            if(b>a)
            {
                Console.WriteLine("b>a");
            }

            int k=3;
            k=k+3; // k+=3;
            k++;

            // ?: koşul operatoru
            // kalan=%
        }
    }
}
