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
    public class SixFaceDiceShould
    {
        private SixFaceDice _sixFaceDice;

        [Test]
        public void RollDice_ReturnANumberBetween1And6()
        {
            //Arrange
            _sixFaceDice = new SixFaceDice();

            //Act
            var result = _sixFaceDice.RollDice();
            List<int> expected = Enumerable.Range(1, 6).ToList();

            //Assert
            Assert.That(expected.Contains(result), Is.True);
        }
    }
}
