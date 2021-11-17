using System;

namespace Sinif_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Name="Ellie";
            calisan1.SurName="Morozova";
            calisan1.Depart="Insan Kaynaklari";
            calisan1.No=21234123;

            Calisan calisan2 = new Calisan();
            calisan1.Name="Omer";
            calisan1.SurName="Hacioglu";
            calisan1.Depart="IT Departmani";
            calisan1.No=21234525;

            calisan1.calisanBilgileri();
            calisan2.calisanBilgileri();
        }
    }

    class Calisan
    {
        public string Name;
        public string SurName;
        public string Depart;
        public int No;
        
        public void calisanBilgileri()
        {
            System.Console.WriteLine("Calisan Adi:{0}",Name);
            System.Console.WriteLine("Calisan SoyAdi:{0}",SurName);
            System.Console.WriteLine("Calisan Departman:{0}",Depart);
            System.Console.WriteLine("Calisan No:{0}",No);
        }
    }
}
