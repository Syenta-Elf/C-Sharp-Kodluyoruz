using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            System.Console.WriteLine("Canlilar beslenir.");
        }
        protected void Solunum()
        {
            System.Console.WriteLine("Canlilar Solunum yapar.");
        }
        protected void Bosaltim()
        {
            System.Console.WriteLine("Butun canlilar bosaltim yapar");
        }
        public virtual void UyaranlaraTepki()
        {
            System.Console.WriteLine("Canlilar uyaranlara tepki verir");
        }
    }
}