using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class Board
    {
        private Card card;
        public Lines toDo = new ToDo();
        public Lines progress = new Progress();
        public Lines done = new Done();

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
                int randomLine = rnd.Next(0,3);
                if(randomLine==0)
                toDo.getCard(p);
                else if(randomLine==1)
                progress.getCard(p);
                else
                done.getCard(p);
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
        
        System.Console.WriteLine("*****************************");
        System.Console.WriteLine("Kartı nereye ekleyeceksiniz ?");
        System.Console.WriteLine("[1]ToDo [2]Progress [3]Done");
        System.Console.Write("Seçiminiz:");
        switch(Convert.ToInt16(Console.ReadLine()))
         {
             case 1:
             toDo.getCard(createC);
             break;

             case 2:
             progress.getCard(createC);
             break;

             case 3:
             done.getCard(createC);
             break;
         }


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

     public void listCards()
     {
         System.Console.WriteLine("-------------ToDo Lines-------------");
         toDo.listCard();
         System.Console.WriteLine("-------------Progress Lines-------------");
         progress.listCard();
         System.Console.WriteLine("-------------Done Lines-------------");
         done.listCard();
     }
    }
}