using System;
using System.Collections;
using System.Collections.Generic;

namespace Telefon_Rehberi
{
    class Program
    {
        //A-Z ---- Z-A sıralaması eksik.
        static ArrayList tel_book = new ArrayList();
          
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            liste();

            switch(n)
            {
                case 1:
                Kisi_Ekle();
                break;

                case 2:
                Numara_Sil();
                break;

                case 3:
                Numara_Guncelle();
                break;

                case 4:
                Goster();
                break;

                case 5:
                Rehberde_Ara();
                break;
            }

        }
        static void Kisi_Ekle()
        {
            Rehber yeniKisi = new Rehber();
            Console.Write("İsim:");
            yeniKisi.name=Console.ReadLine();

            Console.Write("Soyisim:");
            yeniKisi.surname=Console.ReadLine();

            Console.Write("Tel:");
            yeniKisi.tel=Console.ReadLine();
            tel_book.Add(yeniKisi);
            Goster();
        }
        static void liste()
        {
            Rehber kisi1 = new Rehber();
            kisi1.name="Sedat";
            kisi1.surname="kisi1";
            kisi1.tel="kisi1";

            Rehber kisi2 = new Rehber();
            kisi2.name="Bahadır";
            kisi2.surname="kisi2";
            kisi2.tel="kisi2";

            Rehber kisi3 = new Rehber();
            kisi3.name="Baran";
            kisi3.surname="kisi3";
            kisi3.tel="kisi3";

            Rehber kisi4 = new Rehber();
            kisi4.name="Berna";
            kisi4.surname="kisi4";
            kisi4.tel="kisi4";

            Rehber kisi5 = new Rehber();
            kisi5.name="Selma";
            kisi5.surname="kisi5";
            kisi5.tel="kisi5";

            tel_book.Add(kisi1);
            tel_book.Add(kisi2);
            tel_book.Add(kisi3);
            tel_book.Add(kisi4);
            tel_book.Add(kisi5);
            
        }
        static void Goster()
        {
            Console.Clear();
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Telefon Rehberi");
            System.Console.WriteLine("**********************************************");
            System.Console.WriteLine(" ");
            foreach (Rehber item in tel_book)
            {
                System.Console.WriteLine("İsim:"+item.name);
                System.Console.WriteLine("Soyisim:"+item.surname);
                System.Console.WriteLine("Tel:"+item.tel);
                System.Console.WriteLine("---");
            }
        }
        static void Rehberde_Ara()
        {   
            System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            System.Console.WriteLine("**********************************************");
            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int k = Convert.ToInt16(Console.ReadLine());

            switch (k)
            {
                case 1:
                Console.Clear();
                System.Console.WriteLine("Arayacağınız kisinin ismi ya da soyismi:");
                string isim_ara = Console.ReadLine();
                int count=0;
                foreach (Rehber item in tel_book)
                {
                    if(item.name.Contains(isim_ara)||item.surname.Contains(isim_ara))
                    {
                        Console.Clear();
                        System.Console.WriteLine("İsim:"+item.name);
                        System.Console.WriteLine("Soyisim:"+item.surname);
                        System.Console.WriteLine("Tel:"+item.tel);
                        count++;
                    }
                }
                
                if(count==0) 
                {
                    Console.Clear();
                    System.Console.WriteLine("Kisi yok.");
                }
                break;

                case 2:
                    Console.Clear();
                    System.Console.WriteLine("Arayacağınız kişinin numarası:");
                    string numara_ara = Console.ReadLine();
                    int count2=0;

                    foreach (Rehber item in tel_book)
                {
                    if(item.tel.Contains(numara_ara))
                    {
                        Console.Clear();
                        System.Console.WriteLine("İsim:"+item.name);
                        System.Console.WriteLine("Soyisim:"+item.surname);
                        System.Console.WriteLine("Tel:"+item.tel);
                        count2++;
                    }
                }
                if(count2==0)
                {
                    Console.Clear();
                    System.Console.WriteLine("Kisi yok.");
                }
                break;
            }   
        }

        static void Numara_Guncelle()
        {
            System.Console.WriteLine("Numarasını guncelleyeceğiniz kişinin ismi ya da soyismi:");
            string ara = Console.ReadLine();
            int count=0;
            foreach (Rehber item in tel_book)
            {
                if(item.name.Contains(ara)||item.surname.Contains(ara))
                {
                    Console.Write("Yeni Numarayı girin.");
                    item.tel = Console.ReadLine();
                    count++;
                }
            }
            if(count==0) System.Console.WriteLine("Kisi yok.");

            Goster();
        }
        static void Numara_Sil()
        {
         System.Console.Write("Numarasını sileceğiniz kişinin ismi ya da soyismi:");
            string ara = Console.ReadLine();
            int count=0,index=0;
            
            foreach (Rehber item in tel_book)
            {
                if(item.name.Contains(ara)||item.surname.Contains(ara))
                {
                    count++;
                    index = tel_book.IndexOf(item);
                }
            }
            
            if(count==0) System.Console.WriteLine("Kisi yok.");
            else
            {
                int onay;

                Console.Write("İşlemi onaylıyorsanız (1) onaylamıyorsanız (2)'ye basın.");
                onay = Convert.ToInt16(Console.ReadLine());
                if(onay == 1) 
                {
                    System.Console.WriteLine("İşlemi onayladınız.");
                    tel_book.RemoveAt(index);
                }
                else
                {
                    System.Console.WriteLine("İşlemi onaylamadınız.");
                }
            }
            Goster();
        }   
        
    }
}
