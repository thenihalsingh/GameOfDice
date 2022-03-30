namespace GameOfDice.Models
{
    /// <summary>
    /// PlayerInfo is used to store all the information about the player
    /// </summary>
    public class PlayerInfo
    {
        internal int Order { get; set; }
        internal string Name { get; set; }
        internal int score  { get; set; }
        internal int CounterOfOneFaceValue { get; set; }
        internal int Rank { get; set; }
        internal bool WinningStatus { get; set; }
    }
}
