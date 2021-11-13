using System;

namespace Try_Catch_Finally_Ve_Mantiksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*try
            {
                Console.WriteLine("Bir sayi girin:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi:"+a);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());
                
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            */
            try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("100000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi uygun degil.");
                Console.WriteLine(ex.Message.ToString());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Cok buyuk veya cok kucuk bir deger girdiniz.");
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Islem basariyla tamamlanmistir.");
            }
            
            
        }
    }
}
