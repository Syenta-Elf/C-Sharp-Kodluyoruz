using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon(){
            System.Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            System.Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        }
        public void SurunerekHareketEtmek()
        {
            System.Console.WriteLine("Surungenler surunerek hareket ederler.");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();

        }
                public void UcarakHareketEtmek()
        {
            System.Console.WriteLine("Kuslar ucar");   
        }
    }
}