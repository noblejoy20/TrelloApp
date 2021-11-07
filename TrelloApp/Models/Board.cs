using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloApp.Models
{
    public class Board
    {

        public Board(string name)
        {
            BoardId = Guid.NewGuid();
            Name = name;
            Privacy = Privacy.PUBLIC;
            Members = new List<User>();
            Tasks = new List<Task>();
        }
        public Guid BoardId { get; set; }
        public string Name { get; set; }
        public Privacy Privacy { get; set; }
        public string URL { get; set; }
        public List<User> Members { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
