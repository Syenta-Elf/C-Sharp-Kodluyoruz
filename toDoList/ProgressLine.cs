using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class ProgressLine : Lines
    {
        public ProgressLine()
        {
            Card card1 = new Card();
            card1.Title = "tP1";
            card1.Description="dP1";
            cardList.Add(card1);
        }
        public void showProgressLine()
        {
            System.Console.WriteLine("Progress Line");
            System.Console.WriteLine("*********************************");
            foreach (Card card in cardList)
            {
                System.Console.WriteLine("Başlık:"+card.Title);
                System.Console.WriteLine("Açıklama:"+card.Description);
            }
        }
    }
}