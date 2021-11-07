using System;
using TrelloApp.Models;

namespace TrelloApp.Commands.TaskCommands
{
    public class TaskCreateCommand
    {
        public TaskCreateCommand(Guid boardId, Task task)
        {
            BoardId = boardId;
            Task = task;
        }

        public Guid BoardId { get; set; }
        public Task Task { get; set; }
    }
}