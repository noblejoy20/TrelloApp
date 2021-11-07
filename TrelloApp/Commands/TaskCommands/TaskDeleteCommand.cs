using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloApp.Commands.TaskCommands
{
    public class TaskDeleteCommand
    {
        public TaskDeleteCommand(Guid guid)
        {
            TaskId = guid;
        }

        public Guid TaskId { get; set; }
    }
}
