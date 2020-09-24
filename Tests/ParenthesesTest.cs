using Katas;
using Xunit;

namespace Tests
{
    public class ParenthesesTest
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData(")((((", false)]
        [InlineData(")(", false)]
        [InlineData("())(", false)]
        public void ValidParenthesesTest(string input, bool output)
        {
            Assert.Equal(output, Parentheses.ValidParentheses(input));
        }
    }
}
