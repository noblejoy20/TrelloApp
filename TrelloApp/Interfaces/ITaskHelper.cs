using System;
using System.Collections.Generic;
using System.Text;
using TrelloApp.Commands.TaskCommands;

namespace TrelloApp.Interfaces
{
    public interface ITaskHelper
    {
        bool CreateTask(TaskCreateCommand taskCreateCommand);
        bool UpdateTask(TaskUpdateCommand taskUpdateCommand);
        bool DeleteTask(TaskDeleteCommand taskDeleteCommand);
        void Display();
    }
}
