using System;
using System.Collections.Generic;
using System.Text;
using TrelloApp.CommandHandlers;
using TrelloApp.Commands;
using TrelloApp.Interfaces;
using TrelloApp.Models;

namespace TrelloApp.Services
{
    public class BoardService
    {
        private readonly IBoardHelper _boardHelper;

        public BoardService()
        {
            _boardHelper = new BoardCommandHandler();
        }
        public void CreateBoard(Board newBoard)
        {
            bool isSuccess = _boardHelper.CreateBoard(new BoardCreateCommand(newBoard));
            if (isSuccess)
            {
                Console.WriteLine($"Created Board: {newBoard.BoardId}");
            }
            else
            {
                Console.WriteLine("Creation of board failed..");
            }
        }

        public void ShowBoard(Guid guid)
        {
            try
            {
                _boardHelper.ShowBoard(new ShowBoardCommand(guid));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception due the following reason:{ex.Message}");
            }
        }

        public void UpdateBoard(Guid guid, string newName = null, dynamic privacy=null)
        {
            bool isSuccess = _boardHelper.UpdateBoard(new UpdateBoardCommand(guid,newName,privacy));
            if (isSuccess)
            {
                Console.WriteLine($"Update of Board successful.");
            }
        }

        public void AddBoardMember(Guid guid, User user)
        {
            bool isSuccess = _boardHelper.AddBoardMember(new AddBoardMemberCommand(guid, user));
            if (isSuccess)
            {
                Console.WriteLine($"Board Member is successfully added.");
            }
        }

        public void DeleteBoard(Guid BoardId)
        {
            bool isSuccess = _boardHelper.DeleteBoard(new DeleteBoardCommand(BoardId));
            if (isSuccess)
            {
                Console.WriteLine($"The board is deleted successfully..");
            }
        }

        public void Display()
        {
            _boardHelper.Display();
        }
    }
}
