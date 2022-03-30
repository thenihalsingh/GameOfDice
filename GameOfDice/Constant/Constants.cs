namespace GameOfDice.Constant
{
    internal class Constants
    {
        #region numericConstants

        internal const int ZERO = 0;
        internal const int ONE = 1;
        internal const int TWO = 2;
        internal const int SIX = 6;

        #endregion

        #region wrongInputConstants

        internal const string WRONG_INPUT_TYPE_NUMERIC = "Please input a numeric value";
        internal const string WRONG_INPUT_TYPE_CHAR = "Please input a character";

        #endregion

        #region rulesConstants

        internal const string RULE_ONE = "got 1(one) two consecutives times on the dice roll. Hence, skipping";
        internal const string RULE_TWO = "got a 6(six) on the dice roll. So, here's your another chance to roll the dice";

        #endregion
        
        internal const char ROLLINGCHOICE = 'r';
        internal const char QUITINGCHOICE = 'q';
    }
}
