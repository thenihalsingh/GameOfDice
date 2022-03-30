namespace GameOfDice.Contracts
{
    /// <summary>
    /// Exposes the input method which returns a int value and takes input from the user through command line arguments
    /// </summary>
    internal interface INumericInputOperations
    {
        /// <summary>
        /// Returns a value and takes input from the user through command line arguments
        /// </summary>
        /// <returns></returns>
        int GetUserInput();
    }
}
