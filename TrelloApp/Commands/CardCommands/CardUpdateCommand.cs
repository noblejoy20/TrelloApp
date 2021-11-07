using System;

namespace TrelloApp.Commands
{
    public class CardUpdateCommand
    {
        public CardUpdateCommand(Guid cardId, string name , string description)
        {
            CardId = cardId;
            Name = name;
            Description = description;
        }

        public Guid CardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}