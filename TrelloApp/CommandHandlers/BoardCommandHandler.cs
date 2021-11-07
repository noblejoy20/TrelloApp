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
    public class BoardCommandHandler:TrelloBoardBase,IBoardHelper
    {
        private List<Board> _boards;
        public BoardCommandHandler()
        {
            _boards = Boards;
        }

        public bool CreateBoard(BoardCreateCommand board) 
        {
            try
            {
                board.BoardToBeCreated.URL = URL_NAME + board.BoardToBeCreated.BoardId;
                _boards.Add(board.BoardToBeCreated);
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public Board ShowBoard(ShowBoardCommand showBoard)
        {
            if (_boards.Any(x => x.BoardId == showBoard.Guid))
            {
                return _boards.Where(x => x.BoardId == showBoard.Guid).FirstOrDefault();
            }
            else
            {
                throw new KeyNotFoundException("Board is not found or generated.");
            }
        }

        public bool UpdateBoard(UpdateBoardCommand board)
        {
            try
            {
                if (_boards.Any(x => x.BoardId == board.Guid))
                {
                    var getBoard = _boards.FirstOrDefault(x => x.BoardId == board.Guid);
                    if (board.BoardName != null)
                    {
                        getBoard.Name = board.BoardName;
                    }
                    else
                    {
                        getBoard.Privacy = board.Privacy;
                    }
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool AddBoardMember(AddBoardMemberCommand addBoardMember)
        {
            try
            {
                if (_boards.Any(x => x.BoardId == addBoardMember.BoardId))
                {
                    var board = _boards.FirstOrDefault(x => x.BoardId == addBoardMember.BoardId);
                    board.Members.Add(addBoardMember.BoardMember);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured due to {ex.Message}");
            }
            return false;
        }

        public bool DeleteBoard(DeleteBoardCommand deleteCmd)
        {
            try
            {
                if (_boards.Any(x => x.BoardId == deleteCmd.BoardId))
                {
                    _boards.Remove(_boards.FirstOrDefault(x => x.BoardId == deleteCmd.BoardId));
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured due to {ex.Message}");
            }
            return false;
        }


        public void Display()
        {
            base.display(_boards);
        }
    }
}
