using GameOfDice.Contracts;
using GameOfDice.ContractsImplementation;

namespace GameOfDice.Services
{
    /// <summary>
    /// Service responsible for taking user inputs on the console.
    /// </summary>
    public class InputService
    {
        private readonly INumericInputOperations _totalNumberOfPlayers,
            _totalPointsToAccumulate;

        private ICharInputOperations _charInputOperations;

        public InputService(IConsoleIO consoleIO)
        {
            _totalNumberOfPlayers = new TotalNumberOfPlayers(consoleIO);
            _totalPointsToAccumulate = new TotalPointsToAccumulate(consoleIO);
            _charInputOperations = new InputChoice(consoleIO);
        }

        public int TotalNumberOfPlayers()
        {
            return _totalNumberOfPlayers.GetUserInput();
        }

        public int TotalPointsToAccumulate()
        {
            return _totalPointsToAccumulate.GetUserInput();
        }

        /// <summary>
        /// Return choice made by the player
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public char GetUserInput(string playerName)
        {
            return _charInputOperations.GetUserInput(playerName);
        }
    }
}
