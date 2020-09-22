namespace Katas
{
    //https://www.codewars.com/kata/52774a314c2333f0a7000688
    public static class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            var brackets = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (((input[i] == ')') && (brackets == 0)) || ((input[i] == '(') && (i == input.Length - 1)))
                    return false;
                else
                {
                    switch (input[i])
                    {
                        case ')':
                            {
                                brackets--;
                                break;
                            }
                        case '(':
                            {
                                brackets++;
                                break;
                            }
                    }
                }
            }
            return brackets == 0;
        }
    }
}
