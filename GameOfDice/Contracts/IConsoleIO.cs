namespace GameOfDice.Contracts
{
    /// <summary>
    /// Wrapper for the Console I/O operations
    /// </summary>
    public interface IConsoleIO
    {
        void WriteLine(string s);
        void Write(string s);
        string ReadLine();
        char ReadKey();
    }
}
