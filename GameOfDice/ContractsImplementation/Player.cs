using GameOfDice.Contracts;

namespace GameOfDice.ContractsImplementation
{
    public class Player : IPlayer
    {
        private readonly static Random _order = new Random();

        /// <summary>
        /// Generate random numbers in the range of 1 to N where N is the total number of players in the game.
        /// </summary>
        /// <param name="totalNumberOfPlayers"></param>
        /// <returns></returns>
        public int[] GenerateRandomOrders(int totalNumberOfPlayers)
        {
            return Enumerable.Range(1, totalNumberOfPlayers).OrderBy(x => _order.Next()).ToArray();
        }
    }
}
