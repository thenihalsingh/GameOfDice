namespace GameOfDice.Contracts
{
    internal interface IPlayer
    {
        /// <summary>
        /// Generate random numbers in the range of 1 to N where N is the total number of players in the game.
        /// </summary>
        /// <param name="totalNumberOfPlayers"></param>
        /// <returns></returns>
        int[] GenerateRandomOrders(int totalNumberOfPlayers);
    }
}
