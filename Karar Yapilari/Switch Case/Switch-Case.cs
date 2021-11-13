using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            
            //Expression
           /* switch(month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;

                case 2:
                    Console.WriteLine("Subat");
                    break;

                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayis");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;


                default:
                    Console.WriteLine("Yanlis Veri.");
                    break;
                }*/
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                    Console.WriteLine("Kis Aylarindasiniz.");
                    break;

                    case 3:
                    case 4:
                    case 5:
                    Console.WriteLine("Ilkbahar Aylarindasiniz");
                    break;

                    case 6:
                    case 7:
                    case 8:
                    Console.WriteLine("Yaz Aylarindasiniz.");
                    break;

                    case 9:
                    case 10:
                    case 11:
                    Console.WriteLine("Sonbahar Aylarindasiniz.");
                    break;
                    
                    default:
                    break;
                }
        }
    }
}
