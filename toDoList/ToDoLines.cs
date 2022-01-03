using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class ToDoLines : Lines
    {
        public ToDoLines()
        {
            Card card1 = new Card();
            card1.Title = "tTD1";
            card1.Description="dTD1";
            cardList.Add(card1);
        }

        public void showToDoLine()
        {
            System.Console.WriteLine("ToDo Line");
            System.Console.WriteLine("*********************************");
            foreach (Card card in cardList)
            {
                System.Console.WriteLine("Başlık:"+card.Title);
                System.Console.WriteLine("Açıklama:"+card.Description);
            }
        }
    }
}