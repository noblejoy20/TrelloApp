using System;
using TrelloApp.Models;

namespace TrelloApp.Commands
{
    public class CardCreateCommand
    {
        public CardCreateCommand(Guid taskId, Card card)
        {
            TaskId = taskId;
            Card = card;
        }

        public Guid TaskId { get; set; }
        public Card Card { get; set; }
    }
}