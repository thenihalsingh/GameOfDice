using GameOfDice.Contracts;

namespace GameOfDice.ContractsImplementation
{
    /// <summary>
    /// Create a wrapper class around System provided Console I/O methods called ConsoleIO
    /// </summary>
    public class ConsoleIO : IConsoleIO
    {
        /// <summary>
        /// Creates a wrapper around <b>Console.ReadLine()</b>
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Creates a wrapper around <b>Console.ReadKey().KeyChar</b>
        /// </summary>
        /// <returns></returns>
        public char ReadKey()
        {
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Creates a wrapper around <b>Console.Write()</b>
        /// </summary>
        /// <returns></returns>
        public void Write(string s)
        {
            Console.Write(s);
        }

        /// <summary>
        /// Creates a wrapper around <b>Console.WriteLine()</b>
        /// </summary>
        /// <returns></returns>
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}
