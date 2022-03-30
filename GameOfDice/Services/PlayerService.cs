using GameOfDice.Contracts;
using GameOfDice.ContractsImplementation;
using GameOfDice.Models;

namespace GameOfDice.Services
{
    /// <summary>
    /// Maintains the state of all the players at any point of time in game.
    /// </summary>
    public class PlayerService
    {
        private readonly IPlayer _player;
        public PlayerService()
        {
            _player = new Player();
        }

        /// <summary>
        /// Returns a list all the players with an associated random order and player information.
        /// </summary>
        /// <param name="totalNumberOfPlayers"></param>
        /// <returns></returns>
        public List<PlayerInfo> GetPlayerOrders(int totalNumberOfPlayers)
        {
            List<PlayerInfo> playersWithOrders = new List<PlayerInfo>();

            int[] randomNumbers = _player.GenerateRandomOrders(totalNumberOfPlayers);

            for (int i = 1; i <= totalNumberOfPlayers; i++)
            {
                playersWithOrders.Add(
                    new PlayerInfo
                    {
                        Order = randomNumbers[i - 1],
                        Name = $"Player-{i}",
                        score = 0,
                        CounterOfOneFaceValue = 0,
                        Rank = 0,
                        WinningStatus = false
                    });
            }

            return playersWithOrders.OrderBy(x => x.Order).ToList();
        }

        /// <summary>
        /// Returns an empty list which will store the players as per their ranks as they win the game.
        /// </summary>
        /// <returns></returns>
        public List<PlayerInfo> WinningStatusOfPlayers()
        {
            return new List<PlayerInfo>();
        }
    }
}
