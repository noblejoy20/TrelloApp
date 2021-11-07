using System;

namespace TrelloApp.Commands
{
    public class MoveCommand
    {
        public MoveCommand(Guid cardId,Guid taskId)
        {
            TaskId = taskId;
            CardId = cardId;
        }

        public Guid TaskId { get; set; }
        public Guid CardId { get; set; }
    }
}