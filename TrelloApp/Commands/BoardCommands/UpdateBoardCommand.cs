using System;
using System.Collections.Generic;
using System.Text;
using TrelloApp.Models;

namespace TrelloApp.Commands
{
    public class UpdateBoardCommand
    {
        public UpdateBoardCommand(Guid guid,string name,dynamic privacy)
        {
            Guid = guid;
            BoardName = name;
            Privacy = (Privacy)privacy;
        }
        public Guid Guid { get; set; }
        public string BoardName { get; set; }
        public Privacy Privacy { get; set; }
    }
}
