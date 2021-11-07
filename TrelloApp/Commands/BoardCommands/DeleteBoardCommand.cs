using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloApp.Commands
{
    public class DeleteBoardCommand
    {
        public DeleteBoardCommand(Guid BoardId)
        {
            this.BoardId = BoardId;
        }

        public Guid BoardId { get; set; }
    }
}
