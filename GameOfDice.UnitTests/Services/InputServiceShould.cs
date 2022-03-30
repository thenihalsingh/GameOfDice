using GameOfDice.Services;
using NUnit.Framework;
using System;
using Moq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfDice.Contracts;
using GameOfDice.ContractsImplementation;

namespace GameOfDice.UnitTests.Services
{
    [TestFixture]
    public class InputServiceShould
    {
        private InputService _inputService;

        [Test]
        public void TotalNumberOfPlayers_ReturnTotalNumberOfPlayers()
        {
            //arrange
            var numberOfPlayers = 4;
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadLine()).Returns(numberOfPlayers.ToString());

            //act
            _inputService = new InputService(mockConsoleIO.Object);
            var result = _inputService.TotalNumberOfPlayers();

            //assert
            Assert.AreEqual(result, numberOfPlayers);
        }

        [Test]
        public void TotalPointsToAccumulate_ReturnTotalPointsToAccumulate()
        {
            //arrange
            var pointsToAccumulate = 4;
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadLine()).Returns(pointsToAccumulate.ToString());

            //act
            _inputService = new InputService(mockConsoleIO.Object);
            var result = _inputService.TotalPointsToAccumulate();

            //assert
            Assert.AreEqual(result, pointsToAccumulate);
        }

        [Test]
        public void GetUserInput_ReturnUserChoice()
        {
            //arrange
            var choice = 'r';
            var playerName = "Player-1";
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadKey()).Returns(Convert.ToChar(choice));

            //act
            _inputService = new InputService(mockConsoleIO.Object);
            var result = _inputService.GetUserInput(playerName);

            //assert
            Assert.AreEqual(result, choice);
        }
    }
}
