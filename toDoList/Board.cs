using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class Board
    {
        private Card card;
        private Lines toDo = new ToDo();
        private Lines progress = new Progress();
        private Lines done = new Done();


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
                p.Title = "p" + i.ToString();
                p.Desc = "d" + i;
                int size = rnd.Next(0, 5);
                p.Size = ((Sizes)size).ToString();
                p.PersonID = i;
                idList.Add(i);
                int randomLine = rnd.Next(0, 3);
                if (randomLine == 0)
                    toDo.getCard(p);
                else if (randomLine == 1)
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
            createC.Desc = Console.ReadLine();
            System.Console.Write("Size:");
            createC.Size = ((Sizes)Convert.ToInt16(Console.ReadLine())).ToString();
            System.Console.Write("Id:");
            createC.PersonID = isIdExist(Convert.ToInt16(Console.ReadLine().ToString()));

            System.Console.WriteLine("*****************************");
            System.Console.WriteLine("Kartı nereye ekleyeceksiniz ?");
            System.Console.WriteLine("[1]ToDo [2]Progress [3]Done");
            System.Console.Write("Seçiminiz:");
            switch (Convert.ToInt16(Console.ReadLine()))
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
            bool isIdExists = idList.Exists(idList => idList == id);

            while (isIdExists)
            {
                System.Console.WriteLine("Id değiş.");
                System.Console.Write("Id:");
                id = Convert.ToInt16(Console.ReadLine().ToString());
                isIdExists = idList.Exists(idList => idList == id);
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
        int titleControl = 0;
        public void removeCard()
        {
            titleControl=0;
            System.Console.Write("Silmek istediğiniz kartın PersonID'sini girin:");
            int id = Convert.ToInt16(Console.ReadLine());
            checkTitleRemove(toDo, id);
            checkTitleRemove(progress, id);
            checkTitleRemove(done, id);

            if (titleControl == 0)
            {
                System.Console.WriteLine("Aradığınız kart bulunamadı. Lütfen bir seçim yapınız:");
                System.Console.WriteLine("Silmeyi sonlandırmak için [1]");
                System.Console.WriteLine("Yeniden denemek için      [2]");
                int choose = Convert.ToInt16(Console.ReadLine().ToString());
                if (choose == 1)
                    return;
                if (choose == 2)
                    this.removeCard();
            }
        }

        private void checkTitleRemove(Lines arr, int id)
        {

            if (arr.cards.Count > 0 )
            {
                for (int i = 0; i < arr.cards.Count; i++)
                {
                    if (arr.cards[i].PersonID == id)
                    {
                        System.Console.WriteLine("Silmek istediğinize emin misiniz?");
                        System.Console.WriteLine("[1]Evet [2]Hayır");
                        if (Console.ReadLine() == "1")
                        {
                            arr.cards.RemoveAt(i);
                            titleControl++;
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
        int changeTitleLineControl = 0;
        public void changeLine()
        {
            changeTitleLineControl = 0;
            System.Console.Write("Aktarmak istediğiniz kartın PersonID'sini girin:");
            int id = Convert.ToInt16(Console.ReadLine().ToString());

            changeTitleLine(toDo, id);
            changeTitleLine(progress, id);
            changeTitleLine(done, id);

            if (changeTitleLineControl == 0)
            {
                System.Console.WriteLine("Aradığınız kart bulunamadı. Lütfen bir seçim yapınız:");
                System.Console.WriteLine("Aktarmayı sonlandırmak için [1]");
                System.Console.WriteLine("Yeniden denemek için        [2]");
                int choose = Convert.ToInt16(Console.ReadLine().ToString());
                if (choose == 1)
                    
                if (choose == 2)
                    this.removeCard();
            }
        }
        private void changeTitleLine(Lines arr, int id)
        {
            if (arr.cards.Count > 0 && changeTitleLineControl==0 )
            {
                for (int i = 0; i < arr.cards.Count; i++)
                {
                    if (arr.cards[i].PersonID == id)
                    {
                        System.Console.WriteLine("Bulunan kart bilgileri:");
                        System.Console.WriteLine("**********************");
                        System.Console.WriteLine("Title:" + arr.cards[i].Title);
                        System.Console.WriteLine("Description:" + arr.cards[i].Desc);
                        System.Console.WriteLine("Person ID:" + arr.cards[i].PersonID);
                        System.Console.WriteLine("Size:" + arr.cards[i].Size);
                        System.Console.WriteLine("Line:" + arr.name);
                        System.Console.WriteLine("Aktarmak istediğinize emin misiniz?");
                        System.Console.WriteLine("[1]Evet [2]Hayır");
                        if (Console.ReadLine() == "1")
                        {
                            System.Console.WriteLine("Nereye aktaracağınızı seçin:");
                            System.Console.WriteLine("[1]Todo");
                            System.Console.WriteLine("[2]Progress");
                            System.Console.WriteLine("[3]Done");

                            switch (Convert.ToInt16(Console.ReadLine().ToString()))
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