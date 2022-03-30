using GameOfDice.Constant;

namespace GameOfDice.Enums
{
    /// <summary>
    /// Rules as descibed in the game.
    /// </summary>
   public enum rules
    {
        Rule1,
        Rule2
    }

    /// <summary>
    /// Return the ruke message as per the selected enum of type rules
    /// </summary>
    public static class RuleExtension
    {
        public static string GetRule(this rules rule)
        {
            switch (rule)
            {
                case rules.Rule1:
                    return Constants.RULE_ONE;
                case rules.Rule2:
                    return Constants.RULE_TWO;
                default:
                    return "NO VALUE GIVEN";
            }
        }
    }
}
