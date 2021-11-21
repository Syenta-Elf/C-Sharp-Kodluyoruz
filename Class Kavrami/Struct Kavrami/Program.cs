using System;

namespace Struct_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            System.Console.WriteLine("class alan hesabi:"+dikdortgen.alanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,4);
            //Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            System.Console.WriteLine("struct alan hesabi:"+dikdortgen_Struct.alanHesapla());
        }
    }
    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;
        public Dikdortgen(){
            kisaKenar=3;
            uzunKenar=4;
        }

        public long alanHesapla()
        {
            return this.kisaKenar*this.uzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }
        public long alanHesapla()
        {
            return this.kisaKenar*this.uzunKenar;
        }
    }
}
