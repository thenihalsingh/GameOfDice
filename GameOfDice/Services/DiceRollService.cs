using GameOfDice.Contracts;

namespace GameOfDice.Services
{
    /// <summary>
    /// Service responsible for performing dice functions.
    /// </summary>
    public class DiceRollService
    {
        private IDiceValue _diceValue;
        public DiceRollService(IDiceValue diceValue)
        {
            _diceValue = diceValue;
        }

        /// <summary>
        /// Return a random number representing one of the face value of the dice.
        /// </summary>
        /// <returns></returns>
        public int RollDice()
        {
            return _diceValue.RollDice();
        }
        /// <summary>
        /// Simulate a dice roll. This method will show random numbers representing the face values on the dice.
        /// </summary>
        public void SimulateDiceRoll()
        {
            _diceValue.SimulateDiceRoll();
        }
    }
}
