using System;

namespace TrelloApp.Commands
{
    public class UnAssignCommand
    {
        public UnAssignCommand(Guid cardId)
        {
            CardId = cardId;
        }

        public Guid CardId { get; set; }
    }
}