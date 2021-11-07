using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrelloApp.CommandHandlers;
using TrelloApp.Commands;

namespace AppMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly BoardCommandHandler _commandHandler;
        public UnitTest1()
        {
            _commandHandler = new BoardCommandHandler();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var createCommand = new BoardCreateCommand(new TrelloApp.Models.Board("TestBoard"));
            var result = _commandHandler.CreateBoard(createCommand);
            Assert.AreEqual(result, true);
        }
    }
}
