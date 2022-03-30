using GameOfDice.Constant;
using GameOfDice.Contracts;

namespace GameOfDice.ContractsImplementation
{
    public class InputChoice : ICharInputOperations
    {
        private readonly IConsoleIO _consoleIO;
        public InputChoice(IConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
        }
        /// <summary>
        /// Prompts the player to input the choice to play the game.
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public char GetUserInput(string playerName)
        {
            int validInput = Constants.ZERO;
            char choice = ' ';
            while (validInput == Constants.ZERO)
            {
                try
                {
                    _consoleIO.Write($"{playerName} its your turn\nPress ‘r’ to roll the dice \nPress 'q' to quit the game: ");
                    choice = _consoleIO.ReadKey();
                    validInput = char.IsLetter(choice) ? Constants.ONE : throw new Exception(Constants.WRONG_INPUT_TYPE_CHAR);
                }
                catch (Exception)
                {
                    _consoleIO.WriteLine($"\n{Constants.WRONG_INPUT_TYPE_CHAR}");
                    continue;
                }
            }
            return choice;
        }
    }
}
