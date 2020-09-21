using Katas;
using Xunit;

namespace Tests
{
    public class ParenthesesTest
    {
        [Fact]
        public void ValidParenthesesTest()
        {
            Assert.True(Parentheses.ValidParentheses("()"));
            Assert.False(Parentheses.ValidParentheses(")(((("));
            Assert.False(Parentheses.ValidParentheses(")("));
            Assert.False(Parentheses.ValidParentheses("())("));
        }
    }
}
