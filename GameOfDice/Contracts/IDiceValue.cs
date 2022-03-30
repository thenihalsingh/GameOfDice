namespace GameOfDice.Contracts
{
    /// <summary>
    /// Exposes the operations a player can perform on a dice.
    /// </summary>
    public interface IDiceValue
    {
        /// <summary>
        /// Returns a face value of type int after rolling the dice.
        /// </summary>
        /// <returns></returns>
        int RollDice();
        /// <summary>
        /// Simulates the rolling of the dice.
        /// </summary>
        void SimulateDiceRoll();
    }
}
