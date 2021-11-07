using System;

using TrelloApp.CommandHandlers;
using TrelloApp.Commands.TaskCommands;
using TrelloApp.Interfaces;
using TrelloApp.Models;

namespace TrelloApp.Services
{
    public class TaskService
    {
        private readonly ITaskHelper _taskHelper;

        public TaskService()
        {
            _taskHelper = new TaskCommandHandler();
        }

        public void CreateTask(Guid boardId,Task t)
        {
            bool isSuccess = _taskHelper.CreateTask(new TaskCreateCommand(boardId, t));
            if (isSuccess)
            {
                Console.WriteLine($"Created list: {t.TaskId}");
            }
            else
            {
                Console.WriteLine("Creation of board failed..");
            }
        }

        public void UpdateTask(Guid TaskId,string TaskName)
        {
            bool isSuccess = _taskHelper.UpdateTask(new TaskUpdateCommand(TaskId, TaskName));
            if (isSuccess)
            {
                Console.WriteLine($"Updated list: {TaskId}");
            }
            else
            {
                Console.WriteLine("Updation of list failed..");
            }
        }

        public void DeleteTask(Guid TaskId)
        {
            bool isSuccess = _taskHelper.DeleteTask(new TaskDeleteCommand(TaskId));
            if (isSuccess)
            {
                Console.WriteLine($"Deleted list: {TaskId}");
            }
            else
            {
                Console.WriteLine("Deletion of list failed..");
            }
        }

        public void Display()
        {
            _taskHelper.Display();
        }
    }
}