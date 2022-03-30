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
    public class TotalPointsToAccumulateShould
    {
        private TotalPointsToAccumulate _totalPointsToAccumulate;

        [Test]
        public void GetUserInput_PrintMessageAskingForUserInput()
        {
            //arrange
            var pointsToAccumulate = 4;
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadLine()).Returns(pointsToAccumulate.ToString());

            //act
            _totalPointsToAccumulate = new TotalPointsToAccumulate(mockConsoleIO.Object);
            var result = _totalPointsToAccumulate.GetUserInput();

            //assert
            mockConsoleIO.Verify(t => t.Write($"Enter total points to accumulate:"), Times.Once());
        }

        [Test]
        public void GetUserInput_ReturnTotalNumberOfPlayers()
        {
            //arrange
            var pointsToAccumulate = 4;
            var mockConsoleIO = new Mock<IConsoleIO>();
            mockConsoleIO.Setup(t => t.ReadLine()).Returns(pointsToAccumulate.ToString());

            //act
            _totalPointsToAccumulate = new TotalPointsToAccumulate(mockConsoleIO.Object);
            var result = _totalPointsToAccumulate.GetUserInput();

            //assert
            Assert.AreEqual(result, pointsToAccumulate);
        }
    }
}
