using System;

namespace Erisim_belirleyici
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ellie","Morozova","Insan Kaynaklari",1235213);
            // calisan1.Name="Ellie";
            // calisan1.SurName="Morozova";
            // calisan1.Depart="Insan Kaynaklari";
            // calisan1.No=21234123;

            Calisan calisan2 = new Calisan("Omer","Hacioglu");
            // calisan1.Name="Omer";
            // calisan1.SurName="Hacioglu";
            // calisan1.Depart="IT Departmani";
            // calisan1.No=21234525;
            System.Console.WriteLine("*******calisan1*****");
            calisan1.calisanBilgileri();
            System.Console.WriteLine("****calisan2****");
            calisan2.calisanBilgileri();
        }
    }

    class Calisan
    {
        public string Name;
        public string SurName;
        public string Depart;
        public int No;
        
        public Calisan(string name, string surname, string depart,int no)
        {
            this.Name = name;
            this.SurName = surname;
            this.Depart = depart;
            this.No = no;
        }

         public Calisan(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }

        public Calisan(){}
        public void calisanBilgileri()
        {
            System.Console.WriteLine("Calisan Adi:{0}",Name);
            System.Console.WriteLine("Calisan SoyAdi:{0}",SurName);
            System.Console.WriteLine("Calisan Departman:{0}",Depart);
            System.Console.WriteLine("Calisan No:{0}",No);
        }
    }
}
