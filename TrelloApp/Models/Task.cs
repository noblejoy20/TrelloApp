using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloApp.Models
{
    public class Task
    {
        public Task(string name)
        {
            TaskId = Guid.NewGuid();
            TaskName = name;
            Cards = new List<Card>();
        }
        public Guid TaskId { get; set; }
        public string TaskName { get; set; }
        public List<Card> Cards { get; set; }
    }
}
