using Katas;
using Xunit;

namespace Tests
{
    public class RomanNumeralsDecoderTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("IV", 4)]
        public void SolutionTest(string input, int output)
        {
            Assert.Equal(output, RomanDecode.Solution(input));
        }
    }
}
