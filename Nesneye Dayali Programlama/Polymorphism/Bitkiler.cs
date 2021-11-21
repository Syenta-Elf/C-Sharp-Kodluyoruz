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
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Bosaltim();
            base.Beslenme();
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
        }
        public void SporlaCogalma()
        {
            System.Console.WriteLine("Tohumsuz bitkiler sporla cogalir.");
        }
    }
}