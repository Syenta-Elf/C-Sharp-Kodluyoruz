using System;

namespace toDoList
{
    class Program
    {
        static Board board = new Board();
        static void Main(string[] args)
        {

            menu();

        }

        static void menu()
        {
            while (true)
            {
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("[1] Board Listelemek");
                System.Console.WriteLine("[2] Board'a Kart Eklemek");
                System.Console.WriteLine("[3] Board'dan Kart Silmek");
                System.Console.WriteLine("[4] Kart Taşımak");
                System.Console.WriteLine("[5] Çıkış");

                System.Console.WriteLine("Seçiminiz:");

                switch (Convert.ToInt16(Console.ReadLine().ToString()))
                {
                    case 1:
                        board.listCards();
                        break;
                    case 2:
                        board.createCard();
                        break;
                    case 3:
                        board.removeCard();
                        break;
                    case 4:
                        board.changeLine();
                        break;
                    case 5:
                        return;
                    default:
                        System.Console.WriteLine("Geçersiz işlem");
                        break;
                }


            }
        }
    }
}
