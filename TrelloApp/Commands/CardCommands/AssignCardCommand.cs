using System;
using TrelloApp.Models;

namespace TrelloApp.Commands
{
    public class AssignCardCommand
    {
        public AssignCardCommand(Guid cardId,User user)
        {
            CardId = cardId;
            User = user;
        }
        public Guid CardId { get; set; }
        public User User { get; set; }
    }
}