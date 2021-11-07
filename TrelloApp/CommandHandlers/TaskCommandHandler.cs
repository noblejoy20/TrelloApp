using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TrelloApp.Commands.TaskCommands;
using TrelloApp.DatabaseFactory;
using TrelloApp.Interfaces;
using TrelloApp.Models;

namespace TrelloApp.CommandHandlers
{
    public class TaskCommandHandler : TrelloBoardBase, ITaskHelper
    {
        private readonly List<Board> _boards;
        private readonly HashSet<Task> _tasks;
        public TaskCommandHandler()
        {
            _boards = Boards;
            _tasks = Tasks;
        }
        public bool CreateTask(TaskCreateCommand taskCreateCommand)
        {
            try
            {
                var tasks = _boards.FirstOrDefault(x => x.BoardId == taskCreateCommand.BoardId)?.Tasks;
                if (tasks != null)
                {
                    tasks.Add(taskCreateCommand.Task);
                    _tasks.Add(taskCreateCommand.Task);
                }
                else
                {
                    Console.WriteLine("No board available to add task");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool DeleteTask(TaskDeleteCommand taskDeleteCommand)
        {
            try
            {
                var tasks = _tasks.Where(x => x.TaskId == taskDeleteCommand.TaskId).FirstOrDefault();
                if (tasks != null)
                {
                    foreach (var board in _boards)
                    {
                        if (board.Tasks.Any(b => b.TaskId == taskDeleteCommand.TaskId))
                        {
                            board.Tasks.Remove(tasks);
                            _tasks.Remove(tasks);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The requested task is not found.");
                    return false;
                }
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Display()
        {
            base.display(_tasks);
        }

        public bool UpdateTask(TaskUpdateCommand taskUpdateCommand)
        {
            try
            {
                var tasks = _tasks.Where(x => x.TaskId==taskUpdateCommand.TaskId).FirstOrDefault();
                if (tasks != null)
                {
                    tasks.TaskName = taskUpdateCommand.TaskName;
                }
                else
                {
                    Console.WriteLine("The requested task is not found.");
                    return false;
                }
                return true;

            }
            catch (Exception)
            {
                throw;
            }           
        }
    }
}