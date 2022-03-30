using GameOfDice.Contracts;
using GameOfDice.ContractsImplementation;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDice.UnitTests.ContractsImplementation
{
    [TestFixture]
    public class TotalNumberOfPlayersShould
    {
        private TotalNumberOfPlayers _totalNumberOfPlayers;

        [Test]
        public void GetUserInput_PrintMessageAskingForUserInput()
        {
            //arrange
            var numberOfPlayers = 4;
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadLine()).Returns(numberOfPlayers.ToString());

            //act
            _totalNumberOfPlayers = new TotalNumberOfPlayers(mockConsoleIO.Object);
            var result = _totalNumberOfPlayers.GetUserInput();

            //assert
            mockConsoleIO.Verify(t => t.Write($"Enter total number of players:"), Times.Once());
        }

        [Test]
        public void GetUserInput_ReturnTotalNumberOfPlayers()
        {
            //arrange
            var numberOfPlayers = 4;
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadLine()).Returns(numberOfPlayers.ToString());

            //act
            _totalNumberOfPlayers = new TotalNumberOfPlayers(mockConsoleIO.Object);
            var result = _totalNumberOfPlayers.GetUserInput();

            //assert
            Assert.AreEqual(result, numberOfPlayers);
        }
    }
}
