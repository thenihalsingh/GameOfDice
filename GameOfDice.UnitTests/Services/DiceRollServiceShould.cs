using GameOfDice.ContractsImplementation;
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
    public class DiceRollServiceShould
    {
        private DiceRollService _diceRollService;

        [Test]
        public void RollDice_ReturnANumberBetween1And6()
        {
            //Arrange
            _diceRollService = new DiceRollService(new SixFaceDice());

            //Act
            var result = _diceRollService.RollDice();
            List<int> expected = Enumerable.Range(1, 6).ToList();

            //Assert
            Assert.That(expected.Contains(result), Is.True);
        }
    }
}
