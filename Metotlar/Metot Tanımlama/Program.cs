using System;

namespace Metot_Tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3,b=4;
            int sonuc =Topla(a,b);
            Console.WriteLine("Sonuc:"+sonuc);
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir("Sonuc: "+sonuc.ToString());
            ornek.EkranaYazdir("Arttir ve topla:"+ornek.ArttirVeTopla(ref a,ref b).ToString());
            Console.WriteLine("a:"+a+" b:"+b);
        }
        static int Topla(int deger1,int deger2)
        {
            return(deger1+deger2);
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {   
            deger1++;deger2++;
            return(deger1+deger2);
        }
    }
}
