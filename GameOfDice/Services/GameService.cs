using GameOfDice.Constant;
using GameOfDice.ContractsImplementation;
using GameOfDice.Enums;
using GameOfDice.Models;

namespace GameOfDice.Services
{
    /// <summary>
    /// Main service responsible for calling and executing all other services needed to play the game.
    /// </summary>
    internal class GameService
    {

        private readonly int totalNumberOfPlayers = 0,
            totalPointsToAccumulate = 0;
        private readonly PlayerService _playerService;
        private InputService _inputService;
        private DiceRollService _diceRollService;

        /// <summary>
        /// Initializes <b>PlayerService</b>, <b>InputService</b>, and <b>DiceRollService</b>.
        /// </summary>
        internal GameService()
        {
            #region TakeInitialUserInput

            _inputService = new InputService(new ConsoleIO());
            totalNumberOfPlayers = _inputService.TotalNumberOfPlayers();
            totalPointsToAccumulate = _inputService.TotalPointsToAccumulate();

            #endregion

            #region InitializePlayerService

            _playerService = new PlayerService();

            #endregion

            #region IntializeDiceRollService

            _diceRollService = new DiceRollService(new SixFaceDice());

            #endregion
        }

        /// <summary>
        /// Execution of game logic.
        /// </summary>
        internal void StartGame()
        {
            var playersWithOrders = _playerService.GetPlayerOrders(totalNumberOfPlayers);
            List<PlayerInfo> winningStatus = _playerService.WinningStatusOfPlayers();

            //Loop will run untill all the players reached the total points needed to run the game.
            while (playersWithOrders.Count != 0)
            {
                foreach (var player in playersWithOrders.ToList())
                {
                    //check if player should be peanlised because they rolled ‘1’ twice consecutively
                    if (player.CounterOfOneFaceValue != Constants.TWO)
                    {
                        char choice = _inputService.GetUserInput(player.Name);
                        switch (choice)
                        {
                            //if users preses 'r'.
                            case Constants.ROLLINGCHOICE:
                                if (player.score == totalPointsToAccumulate)
                                {
                                    player.WinningStatus = true;
                                    player.Rank = winningStatus.Count()+1;
                                    winningStatus.Add(player);
                                    playersWithOrders.Remove(player);
                                    Console.WriteLine("\n-------------------------------");
                                    foreach (var ranks in winningStatus)
                                    {
                                        Console.WriteLine($"|  {ranks.Name}  |  ranks is: {ranks.Rank}   |");
                                        Console.WriteLine("-------------------------------");
                                    }
                                    break;
                                }
                                else
                                {
                                    _diceRollService.SimulateDiceRoll();
                                    int faceNumber = -1;
                                    do
                                    {
                                        faceNumber = _diceRollService.RollDice();
                                        Console.WriteLine($"Your Dice Value is....{faceNumber}");
                                        
                                        switch (faceNumber)
                                        {
                                            case Constants.ONE:
                                                player.CounterOfOneFaceValue++;
                                                break;
                                            case Constants.SIX:
                                                rules rules = rules.Rule2;
                                                Console.WriteLine($"Rule Message: {player.Name} {rules.GetRule()}");
                                                player.CounterOfOneFaceValue = 0;
                                                break;
                                            default:
                                                player.CounterOfOneFaceValue = 0;
                                                break;
                                        }

                                        if (player.score + faceNumber <= totalPointsToAccumulate)
                                            player.score += faceNumber;
                                    }
                                    //the user gets another chance because they rolled a ‘6’
                                    while (faceNumber == Constants.SIX);
                                    Console.WriteLine($"{player.Name}'s score = {player.score}");
                                }
                                break;

                            //bonus case added to improve the players experience.
                            //this case is not specified in the assignment
                            case Constants.QUITINGCHOICE:
                                Console.WriteLine($"\n{player.Name} has decided to quit the game...");
                                playersWithOrders.Remove(player);
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        rules rules = rules.Rule1;
                        Console.WriteLine($"Rule Message: {player.Name} {rules.GetRule()}");
                        player.CounterOfOneFaceValue = 0;
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
