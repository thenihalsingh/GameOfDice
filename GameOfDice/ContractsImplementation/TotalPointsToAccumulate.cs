using GameOfDice.Constant;
using GameOfDice.Contracts;

namespace GameOfDice.ContractsImplementation
{
    public class TotalPointsToAccumulate : INumericInputOperations
    {
        private readonly IConsoleIO _consoleIO;
        public TotalPointsToAccumulate(IConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
        }
        public int GetUserInput()
        {
            int validInput = Constants.ZERO,
                pointsToAccumulate = Constants.ZERO;
            while (validInput == Constants.ZERO)
            {
                try
                {
                    _consoleIO.Write("Enter total points to accumulate:");
                    pointsToAccumulate = Convert.ToInt32(_consoleIO.ReadLine());
                    validInput = pointsToAccumulate < 1 ?Constants.ZERO : Constants.ONE;
                    if (validInput == Constants.ZERO)
                        _consoleIO.WriteLine("Score can not be equal to zero");
                }
                catch (Exception)
                {
                    _consoleIO.WriteLine(Constants.WRONG_INPUT_TYPE_NUMERIC);
                    continue;
                }
            }
            return pointsToAccumulate;
        }
    }
}
