using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloApp.Models
{
    public class Card
    {
        public Guid CardId { get; set; }
        public string CardName { get; set; }
        public string Description { get; set; }
        public Status IsAssigned { get; set; }
        public User AssignedTo { get; set; }
    }
}
