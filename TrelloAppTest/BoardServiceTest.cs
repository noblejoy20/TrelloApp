using Moq;
using System;
using TrelloApp.CommandHandlers;
using TrelloApp.Interfaces;
using Xunit;

namespace TrelloAppTest
{
    public class BoardServiceTest
    {
        private readonly Mock<IBoardHelper> _mockBoardHelper;
        private readonly BoardCommandHandler _commandHandler;
        public BoardServiceTest()
        {
            _mockBoardHelper = new Mock<IBoardHelper>();
            _commandHandler = new BoardCommandHandler();
        }
        [Fact]
        public void Test1()
        {
            
        }
    }
}
