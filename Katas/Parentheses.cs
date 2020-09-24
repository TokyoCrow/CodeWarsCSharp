namespace Katas
{
    //https://www.codewars.com/kata/52774a314c2333f0a7000688
    public static class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            var brackets = 0;
            if ((input[0] == ')') || (input[input.Length - 1] == '('))
                return false;
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(')'))
                    brackets--;
                if (input[i].Equals('('))
                    brackets++;
            }
            return brackets == 0;
        }
    }
}
