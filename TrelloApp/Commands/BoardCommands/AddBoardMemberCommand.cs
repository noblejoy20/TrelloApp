using System;
using System.Collections.Generic;
using System.Text;
using TrelloApp.Models;

namespace TrelloApp.Commands
{
    public class AddBoardMemberCommand
    {
        public AddBoardMemberCommand(Guid guid,User user)
        {
            BoardId = guid;
            BoardMember = user;
        }

        public Guid BoardId { get; set; }
        public User BoardMember { get; set; }
    }
}
