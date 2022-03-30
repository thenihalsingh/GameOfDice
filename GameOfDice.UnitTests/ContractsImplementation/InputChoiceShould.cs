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
    public class InputChoiceShould
    {
        private InputChoice _inputChoice;

        [Test]
        public void GetUserInput_AskChoice_PrintMessageAskingForUserInput()
        {
            //arrange
            var choice = 'r';
            var playerName = "Player-1";
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadKey()).Returns(Convert.ToChar(choice));

            //act
            _inputChoice = new InputChoice(mockConsoleIO.Object);
            var result = _inputChoice.GetUserInput(playerName);

            //assert
            mockConsoleIO.Verify(t => t.Write($"{playerName} its your turn\nPress ‘r’ to roll the dice \nPress 'q' to quit the game: "), Times.Once());
        }

        [Test]
        public void GetUserInput_AskChoice_ReturnUserChoice()
        {
            //arrange
            var choice = 'r';
            var playerName = "Player-1";
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadKey()).Returns(Convert.ToChar(choice));

            //act
            _inputChoice = new InputChoice(mockConsoleIO.Object);
            var result = _inputChoice.GetUserInput(playerName);

            //assert
            Assert.AreEqual(result, choice);
        }
    }
}
