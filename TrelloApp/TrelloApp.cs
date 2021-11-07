using System;
using TrelloApp.Models;
using TrelloApp.Services;

namespace TrelloApp
{
    public class TrelloApp
    {
        public static void Main(string[] args)
        {
            var boardService = new BoardService();
            var cardService = new CardService();
            var taskService = new TaskService();

            boardService.CreateBoard(new Board("work@tech"));
            boardService.ShowBoard(Guid.Parse("dsf"));
            boardService.UpdateBoard(Guid.Parse("dsf"), "workattech", Privacy.PRIVATE);
            boardService.Display();

            taskService.CreateTask(Guid.Parse("dsf"), new Task("Create Model"));
        }
    }
}
