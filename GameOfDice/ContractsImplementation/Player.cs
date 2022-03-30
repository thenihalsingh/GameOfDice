using GameOfDice.Contracts;

namespace GameOfDice.ContractsImplementation
{
    public class Player : IPlayer
    {
        private readonly static Random _order = new Random();

        public int[] GenerateRandomOrders(int totalNumberOfPlayers)
        {
            return Enumerable.Range(1, totalNumberOfPlayers).OrderBy(x => _order.Next()).ToArray();
        }
    }
}
