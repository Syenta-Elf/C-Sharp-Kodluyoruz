using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoList
{
    public class Card
    {
        private string title;
        private string description;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }
}