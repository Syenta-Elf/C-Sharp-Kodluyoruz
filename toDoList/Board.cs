using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class Board
    {
        ToDoLines toDoLines = new ToDoLines();
        ProgressLine progressLine = new ProgressLine();
        DoneLine doneLine = new DoneLine();
        public void createCard()
        {
            
            Card card = new Card();
            System.Console.Write("Başlık:");
            card.Title=Console.ReadLine();
            System.Console.Write("Açıklama:");
            card.Description=Console.ReadLine();
            System.Console.WriteLine("Hangi line'a eklemek istiyorsunuz?");
            System.Console.WriteLine("(1) ToDo Line");
            System.Console.WriteLine("(2) Progg Line");
            System.Console.WriteLine("(3) Done Line");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                toDoLines.addCard(card);
                break;

                case 2:
                progressLine.addCard(card);
                break;
                
                case 3:
                doneLine.addCard(card);
                break;

                default:
                System.Console.WriteLine("Hatalı giriş yaptınız.");
                break;
            }
        }
        public void showLines()
        {   
            toDoLines.showToDoLine();
            progressLine.showProgressLine();
            doneLine.showToDoLine();
            
        }
    }
}