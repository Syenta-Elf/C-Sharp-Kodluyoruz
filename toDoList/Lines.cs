using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class Lines
    {
        public string name;
         public List<Card> cards = new List<Card>();

        public void getCard(Card card)
        {
            cards.Add(card);
        }
        public void listCard()
        {
            foreach (Card item in cards)
            {
                System.Console.WriteLine("Title:"+item.Title);
                System.Console.WriteLine("Description:"+item.Desc);
                System.Console.WriteLine("Size:"+item.Size);
                System.Console.WriteLine("Person ID:"+item.PersonID);
                System.Console.WriteLine();
            }
        }
    }
}