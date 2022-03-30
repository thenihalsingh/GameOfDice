using GameOfDice.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDice.UnitTests.Services
{
    [TestFixture]
    public class PlayerServiceShould
    {
        private PlayerService _playerService;

        [SetUp]
        public void Setup()
        {
            //Arrange
            _playerService = new PlayerService();
        }

        [Test]
        public void GetPlayerOrders_InputIs4_ReturnOrdersOfPlayers()
        {
            //Arrange
            int totalNumberOfPlayers = 4;

            //Act
            var result = _playerService.GetPlayerOrders(totalNumberOfPlayers);

            //Assert
            Assert.That(result.Count.Equals(totalNumberOfPlayers), Is.True);
        }

        [Test]
        public void GetPlayerOrders_InputIs4_DoesNotContainDuplicateOrder()
        {
            //Arrange
            int totalNumberOfPlayers = 4;

            //Act
            var result = _playerService.GetPlayerOrders(totalNumberOfPlayers);

            //Assert
            Assert.That(result.Distinct().Count().Equals(totalNumberOfPlayers), Is.True);
        }
    }
}
