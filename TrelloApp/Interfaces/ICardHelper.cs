using System;
using System.Collections.Generic;
using System.Text;
using TrelloApp.Commands;

namespace TrelloApp.Interfaces
{
    public interface ICardHelper
    {
        bool CreateCard(CardCreateCommand taskCreateCommand);
        bool UpdateCard(CardUpdateCommand taskUpdateCommand);
        bool DeleteCard(CardDeleteCommand taskDeleteCommand);
        bool AssignCard(AssignCardCommand taskDeleteCommand);
        bool UnAssignCard(UnAssignCommand taskDeleteCommand);
        bool MoveCard(MoveCommand taskDeleteCommand);
        void Display();
    }
}
