namespace GameOfDice.Contracts
{
    /// <summary>
    /// Exposes the input method which returns a char value and takes input from the user through command line arguments
    /// </summary>
    interface ICharInputOperations
    {
        char GetUserInput(string playerName);
    }
}
