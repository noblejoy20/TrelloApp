using System;
using TrelloApp.CommandHandlers;
using TrelloApp.Commands;
using TrelloApp.Interfaces;
using TrelloApp.Models;

namespace TrelloApp.Services
{
    public class CardService
    {
        private readonly ICardHelper _cardHelper;

        public CardService()
        {
            _cardHelper = new CardCommandHandler();
        }

        public void CreateCard(Guid taskId, Card card)
        {
            _cardHelper.CreateCard(new CardCreateCommand(taskId, card));
        }

        public void UpdateCard(Guid guid,string name = null,string description = null)
        {
            _cardHelper.UpdateCard(new CardUpdateCommand(guid, name, description));
        }
        public void DeleteCard(Guid guid)
        {
            _cardHelper.DeleteCard(new CardDeleteCommand(guid));
        }

        public void AssignCard(Guid guid,User user)
        {
            _cardHelper.AssignCard(new AssignCardCommand(guid, user));
        }

        public void UnAssignCard(Guid guid)
        {
            _cardHelper.UnAssignCard(new UnAssignCommand(guid));
        }

        public void Display()
        {
            _cardHelper.Display();
        }
    }
}