using GameOfDice.Constant;
using GameOfDice.Contracts;

namespace GameOfDice.ContractsImplementation
{
    public class TotalNumberOfPlayers : INumericInputOperations
    {
        private readonly IConsoleIO _consoleIO;
        public TotalNumberOfPlayers(IConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
        }
        public int GetUserInput()
        {
            int validInput = Constants.ZERO,
                numberOfPlayers = Constants.ZERO;
            while (validInput == Constants.ZERO)
            {
                try
                {
                    _consoleIO.Write("Enter total number of players:");
                    numberOfPlayers = Convert.ToInt32(_consoleIO.ReadLine());
                    validInput = numberOfPlayers < 2 ? Constants.ZERO : Constants.ONE;
                    if (validInput == Constants.ZERO)
                        _consoleIO.WriteLine("Total number of players can not be less than 2");
                }
                catch (Exception)
                {
                    _consoleIO.WriteLine(Constants.WRONG_INPUT_TYPE_NUMERIC);
                    continue;
                }
            }
            return numberOfPlayers;
        }
    }
}
