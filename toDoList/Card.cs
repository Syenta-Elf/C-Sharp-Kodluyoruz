using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class Card
    {
        private string title;
        private string desc;
        private string size;
        private int personID;
        
        
        public string Title { get => title; set => title = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Size { get => size; set => size = value; }

        public int PersonID { get => personID; set => personID = value; }
    }
}