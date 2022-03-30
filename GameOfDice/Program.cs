using GameOfDice.Contracts;
using GameOfDice.ContractsImplementation;
using GameOfDice.Services;

namespace GameOfDice;

/// <summary>
/// Entry point of the application
/// </summary>
public class Program
{
    public static void Main()
    {
        IConsoleIO _consoleIO = new ConsoleIO();
        _consoleIO.WriteLine("Start Game \n\n\n");
        GameService gameService = new GameService();
        gameService.StartGame();
        _consoleIO.WriteLine("Game Finished");
    }
}