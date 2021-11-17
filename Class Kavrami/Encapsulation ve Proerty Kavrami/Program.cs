using System;

namespace Encapsulation_ve_Proerty_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci ("Ellie","Morozova",13214,2);
            System.Console.WriteLine("Sinif Atladi");
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
     {
         private string isim;
         private string soyİsim;
         private int ogrenciNo;
         private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyİsim { get => soyİsim; set => soyİsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif;
            
            set { 
                    if(value<1) {
                        Console.WriteLine("Sinif en az 1 olabilir.");
                        sinif=1;
                    }
                    else
                    sinif=value;
                 }
        }
        
        public Ogrenci(string isim, string soyİsim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyİsim = soyİsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}
        
        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("*****Ogrenci Bilgileri*****");
            Console.WriteLine("Ogrenci Adi     :{0}",this.Isim);
            Console.WriteLine("Ogrenci Soyadi  :{0}",this.Soyİsim);
            Console.WriteLine("Ogrenci No      :{0}",this.OgrenciNo);
            Console.WriteLine("Ogrenci Sinif   :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif++;
        }

        public void SinifDusur()
        {
            this.Sinif--;
        }
    }
}
