using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrelloApp.Commands;
using TrelloApp.DatabaseFactory;
using TrelloApp.Interfaces;
using TrelloApp.Models;

namespace TrelloApp.CommandHandlers
{
    public class CardCommandHandler: TrelloBoardBase, ICardHelper
    {
        private readonly List<Board> _boards;
        private readonly HashSet<Task> _tasks;
        private readonly HashSet<Card> _cards;
        public CardCommandHandler()
        {
            _boards = new List<Board>();
            _tasks = new HashSet<Task>();
            _cards = new HashSet<Card>();
        }

        public bool AssignCard(AssignCardCommand taskDeleteCommand)
        {
            var cardToBeAssigned = _cards.FirstOrDefault(c => c.CardId == taskDeleteCommand.CardId);
            cardToBeAssigned.AssignedTo = taskDeleteCommand.User;
            cardToBeAssigned.IsAssigned = Status.ASSIGNED;
            return true;
        }

        public bool CreateCard(CardCreateCommand taskCreateCommand)
        {
            try
            {
                var cards = _tasks.FirstOrDefault(x => x.TaskId == taskCreateCommand.TaskId)?.Cards;
                if (cards != null)
                {
                    cards.Add(taskCreateCommand.Card);
                    _cards.Add(taskCreateCommand.Card);
                }
                else
                {
                    Console.WriteLine("No Task available to add card");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool DeleteCard(CardDeleteCommand taskDeleteCommand)
        {
            try
            {
                var card = _cards.FirstOrDefault(c => c.CardId == taskDeleteCommand.CardId);
                var tasks = _tasks.Select(t => t.Cards).ToList();
                foreach (var cardItem in tasks)
                {
                    if(cardItem.Any(c=>c.CardId== taskDeleteCommand.CardId))
                    {
                        cardItem.Remove(card);
                        _cards.Remove(card);
                    }
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
            base.display(_cards);
        }

        public bool MoveCard(MoveCommand taskDeleteCommand)
        {
            try
            {
                var card = _cards.FirstOrDefault(c => c.CardId == taskDeleteCommand.CardId);
                var task = _tasks.FirstOrDefault(t => t.TaskId == taskDeleteCommand.TaskId);
                var cardItems = _tasks.Select(t => t.Cards).ToList();
                foreach (var cardItem in cardItems)
                {
                    if (cardItem.Any(c => c.CardId == taskDeleteCommand.CardId))
                    {
                        task.Cards.Add(card);
                        cardItem.Remove(card);
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UnAssignCard(UnAssignCommand taskDeleteCommand)
        {
            var cardToBeAssigned = _cards.FirstOrDefault(c => c.CardId == taskDeleteCommand.CardId);
            cardToBeAssigned.AssignedTo = null;
            cardToBeAssigned.IsAssigned = Status.UNASSIGNED;
            return true;
        }

        public bool UpdateCard(CardUpdateCommand taskUpdateCommand)
        {
            try
            {
                var tasks = _cards.Where(x => x.CardId == taskUpdateCommand.CardId).FirstOrDefault();
                if (tasks != null)
                {
                    if (taskUpdateCommand.Name != null)
                    {
                        tasks.CardName = taskUpdateCommand.Name;
                    }
                    else
                    {
                        tasks.Description = taskUpdateCommand.Description;
                    }                  
                }
                else
                {
                    Console.WriteLine("The requested card is not found.");
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
