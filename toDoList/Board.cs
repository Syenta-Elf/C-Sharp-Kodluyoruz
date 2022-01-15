using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class Board
    {
        private Card card;

        public Card Card { get => card; set => card = value; }

        private List<int> idList = new List<int>();
        public enum Sizes
        {
            XS,
            S,
            M,
            L,
            XL
        }
        

        public Board()
        {
            //create 5 card
            
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Card p = new Card();
                p.Title = "p"+i;
                p.Desc = "d"+i;
                int size = rnd.Next(0,5);
                p.Size = ((Sizes)size).ToString();
                p.PersonID = i;
                idList.Add(i);
            }

        }

        
     public void createCard()
     {
         Card createC = new Card();
       
        System.Console.Write("Title:");
        createC.Title = Console.ReadLine();
        System.Console.Write("Description:");
        createC.Desc= Console.ReadLine();
        System.Console.Write("Size:");
        createC.Size = ((Sizes)Convert.ToInt16(Console.ReadLine())).ToString();

        System.Console.Write("Id:");
        createC.PersonID=isIdExist(Convert.ToInt16(Console.ReadLine().ToString()));
        
        this.card = createC;  
     }    

     private int isIdExist(int id)
     {
        bool isIdExists = idList.Exists(idList => idList == id );
        while(isIdExists)
        {
            System.Console.WriteLine("Id değiş.");
            System.Console.Write("Id:");
            id = Convert.ToInt16(Console.ReadLine().ToString());
            isIdExists = idList.Exists(idList => idList == id );
        }
        idList.Add(id);

        return id;
        
     }
    }
}