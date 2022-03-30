using GameOfDice.Constant;

namespace GameOfDice.Enums
{
   public enum rules
    {
        Rule1,
        Rule2
    }

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
