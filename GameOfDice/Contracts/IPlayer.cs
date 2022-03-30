namespace GameOfDice.Contracts
{
    internal interface IPlayer
    {
        /// <summary>
        /// Generate an array of random numbers in the range <b>1</b> to <b>totalNumberOfPlayers</b>
        /// </summary>
        /// <param name="totalNumberOfPlayers"></param>
        /// <returns></returns>
        int[] GenerateRandomOrders(int totalNumberOfPlayers);
    }
}
