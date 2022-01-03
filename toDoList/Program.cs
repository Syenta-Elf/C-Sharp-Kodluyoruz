using System;

namespace toDoList
{
    class Program
    {
        static Board board = new Board();
        static void Main(string[] args)
        {
            while (menu())
            {
                
            }
        }

        static public bool menu()
        {
            System.Console.WriteLine("Hoşgeldiniz bir işlem seçiniz!");
                System.Console.WriteLine("[1] Board'u listele");
                System.Console.WriteLine("[2] Board'a kart ekle");
                System.Console.WriteLine("[3] Board'dan kart sil");
                System.Console.WriteLine("[4] Kart taşımak");
                int select = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("\n\n");
                switch (select)
                {
                    case 1:
                    board.showLines();
                    System.Console.WriteLine("\n\n");
                    return true;
                    
                    case 2:
                    board.createCard();
                    return true;
                    
                    default:
                    return false;
                    
                }  
        }
    }
}
