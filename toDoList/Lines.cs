using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public abstract class Lines
    {
        public List<Card> cardList = new List<Card>{};
        public void addCard(Card card)
        {
            cardList.Add(card);
        }
    }
}