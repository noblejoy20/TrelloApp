using System;
using System.Collections.Generic;
using System.Text;
using TrelloApp.Models;

namespace TrelloApp.Commands
{
    public class BoardCreateCommand
    {
        public BoardCreateCommand(Board newBoard)
        {
            BoardToBeCreated = newBoard;
        }
        public Board BoardToBeCreated { get; set; }
    }
}
