using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloApp.Commands.TaskCommands
{
    public class TaskUpdateCommand
    {
        public TaskUpdateCommand(Guid guid,string taskName)
        {
            TaskId = guid;
            TaskName = taskName;
        }

        public Guid TaskId { get; set; }
        public string TaskName { get; set; }
    }
}
