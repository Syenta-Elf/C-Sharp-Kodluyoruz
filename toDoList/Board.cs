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
                p.Title = "p"+i.ToString();
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
       System.Console.WriteLine("*****************************");
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
     int titleControl=0;
    public void removeCard()
     {
         System.Console.Write("Silmek istediğiniz kartın başlığını girin:");
         String title = Console.ReadLine();
         checkTitleRemove(toDo,title);
         checkTitleRemove(progress,title);
         checkTitleRemove(done,title);
         if(titleControl==0)
            {
                System.Console.WriteLine("Aradığınız kart bulunamadı. Lütfen bir seçim yapınız:");
                System.Console.WriteLine("Silmeyi sonlandırmak için [1]");
                System.Console.WriteLine("Yeniden denemek için      [2]");
                int choose = Convert.ToInt16(Console.ReadLine().ToString());
                if(choose==1)
                    return;
                if(choose==2)
                    this.removeCard();
            } 
    }

    private void checkTitleRemove(Lines arr,String title)
    {
        
         if(arr.cards.Count>0)
         {
             for(int i=0;i<arr.cards.Count;i++)
                {
                    if (arr.cards[i].Title == title)
                    {
                         System.Console.WriteLine("Silmek istediğinize emin misiniz?");
                         System.Console.WriteLine("[1]Evet [2]Hayır");
                         if(Console.ReadLine()=="1")
                         {
                             arr.cards.RemoveAt(i);
                             titleControl++;
                             break;
                         }
                         else
                         {
                             System.Console.WriteLine("İşleminiz iptal edildi.");
                             titleControl++;
                             break;
                         }
                    }
                }
                
            }     
    }
    int changeTitleLineControl=0;
    public void changeLine()
    {
        System.Console.Write("Aktarmak istediğiniz kartın başlığını girin:");
        String title = Console.ReadLine();

        changeTitleLine(toDo,title);
        changeTitleLine(progress,title);
        changeTitleLine(done,title);

        if(changeTitleLineControl==0)
            {
                System.Console.WriteLine("Aradığınız kart bulunamadı. Lütfen bir seçim yapınız:");
                System.Console.WriteLine("Aktarmayı sonlandırmak için [1]");
                System.Console.WriteLine("Yeniden denemek için        [2]");
                int choose = Convert.ToInt16(Console.ReadLine().ToString());
                if(choose==1)
                    return;
                if(choose==2)
                    this.removeCard();
            }
    }
    private void changeTitleLine(Lines arr,string title)
    {
         if(arr.cards.Count>0)
         {
             for(int i=0;i<arr.cards.Count;i++)
             {
                 if (arr.cards[i].Title == title)
                    {
                         System.Console.WriteLine("Aktarmak istediğinize emin misiniz?");
                         System.Console.WriteLine("[1]Evet [2]Hayır");
                         if(Console.ReadLine()=="1")
                         {
                             System.Console.WriteLine("Nereye aktaracağınızı seçin:");
                             System.Console.WriteLine("[1]Todo");
                             System.Console.WriteLine("[2]Progress");
                             System.Console.WriteLine("[3]Done");

                             switch(Convert.ToInt16(Console.ReadLine().ToString()))
                             {
                                 case 1:
                                 toDo.getCard(arr.cards[i]);
                                 arr.cards.RemoveAt(i);
                                 break;
                                 case 2:
                                 progress.getCard(arr.cards[i]);
                                 arr.cards.RemoveAt(i);
                                 break;
                                 case 3:
                                 done.getCard(arr.cards[i]);
                                 arr.cards.RemoveAt(i);
                                 break;
                             }
                             changeTitleLineControl++;
                             break;
                         }
                         else
                         {
                             System.Console.WriteLine("İşleminiz iptal edildi.");
                             changeTitleLineControl++;
                             break;
                         }
                    }
             }
         }
    }

        
    }
}