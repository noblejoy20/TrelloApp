using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloApp.Commands
{
    public class ShowBoardCommand
    {
        public ShowBoardCommand(Guid guid)
        {
            Guid = guid;
        }
        public Guid Guid { get; set; }
    }
}
