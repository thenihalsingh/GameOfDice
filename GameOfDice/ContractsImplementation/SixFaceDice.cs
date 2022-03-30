using GameOfDice.Constant;
using GameOfDice.Contracts;

namespace GameOfDice.ContractsImplementation
{
    public class SixFaceDice : IDiceValue
    {
        private int startingRange = Constants.ONE,
            EndingRange = Constants.SIX;
        public int RollDice()
        {
            return new Random().Next(startingRange, EndingRange+1);
        }

        public void SimulateDiceRoll()
        {
            Console.WriteLine("\n\nRolling the dice...");
            Parallel.For(startingRange, EndingRange + Constants.ONE, i =>
            {
                Console.Write($"{i} ");
            });
            Console.WriteLine();
        }
    }
}
