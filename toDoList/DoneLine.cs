using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class DoneLine : Lines
    {
        public DoneLine()
        {
            Card card1 = new Card();
            card1.Title = "tD1";
            card1.Description="dD1";
            cardList.Add(card1);
        }

        public void showToDoLine()
        {
            System.Console.WriteLine("Done Line");
            System.Console.WriteLine("*********************************");
            foreach (Card card in cardList)
            {
                System.Console.WriteLine("Başlık:"+card.Title);
                System.Console.WriteLine("Açıklama:"+card.Description);
            }
        }
    }
}