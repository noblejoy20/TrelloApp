using System;
using TrelloApp.Commands;
using TrelloApp.Models;

namespace TrelloApp.Interfaces
{
    public interface IBoardHelper
    {
        bool CreateBoard(BoardCreateCommand board);
        Board ShowBoard(ShowBoardCommand guid);
        bool UpdateBoard(UpdateBoardCommand board);
        bool AddBoardMember(AddBoardMemberCommand addBoard);
        bool DeleteBoard(DeleteBoardCommand deleteBoard);
        void Display();
    }
}