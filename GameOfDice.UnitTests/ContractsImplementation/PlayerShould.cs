using GameOfDice.ContractsImplementation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDice.UnitTests.ContractsImplementation
{
    [TestFixture]
    internal class PlayerShould
    {

        [Test]
        public void GenerateRandomOrders_InputNumberOfPlayers_ReturnRandomOrders()
        {
            //Arrange
            Player player = new Player();
            int numberOfPlayers = 6;

            //Act
            var result = player.GenerateRandomOrders(numberOfPlayers);

            //Assert
            Assert.That(result.Count().Equals(numberOfPlayers), Is.True);
        }

        [Test]
        public void GenerateRandomOrders_InputNumberOfPlayers_NoDuplicateValue()
        {
            //Arrange
            Player player = new Player();
            int numberOfPlayers = 6;

            //Act
            var result = player.GenerateRandomOrders(numberOfPlayers);

            //Assert
            Assert.That(result.Distinct().Count().Equals(numberOfPlayers), Is.True);
        }
    }
}
