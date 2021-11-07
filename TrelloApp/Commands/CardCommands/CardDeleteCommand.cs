using System;

namespace TrelloApp.Commands
{
    public class CardDeleteCommand
    {
        public CardDeleteCommand(Guid cardId)
        {
            CardId = cardId;
        }

        public Guid CardId { get; set; }
    }
}