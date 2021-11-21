using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez(){
            System.Console.WriteLine("Bitkiler fotosentez yapar");   
        }
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            System.Console.WriteLine("Bitkiler Gunese tepki verir");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Bosaltim();
            base.Beslenme();
            base.UyaranlaraTepki();
        }
        public void TohumluCogalma()
        {
            System.Console.WriteLine("Tohumlu bitkiler tohumla cogalir.");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Bosaltim();
            base.Beslenme();
            base.UyaranlaraTepki();
        }
        public void SporlaCogalma()
        {
            System.Console.WriteLine("Tohumsuz bitkiler sporla cogalir.");
        }
    }
}