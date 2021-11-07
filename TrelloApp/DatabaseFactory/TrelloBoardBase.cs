using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TrelloApp.Models;

namespace TrelloApp.DatabaseFactory
{
    public abstract class TrelloBoardBase
    {
        protected static List<Board> Boards;
        protected static HashSet<Task> Tasks;
        protected static HashSet<Card> Cards;
        protected static string URL_NAME = "https://trello.com/board/";
        static TrelloBoardBase()
        {
            Boards = new List<Board>();
            Tasks = new HashSet<Task>();
            Cards = new HashSet<Card>();
        }

        public void display<T>(T listData)
        {
            var result = JsonConvert.SerializeObject(listData);
            Console.WriteLine(result);
        }
    }
}
