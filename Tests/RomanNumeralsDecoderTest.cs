using Katas;
using Xunit;

namespace Tests
{
    public class RomanNumeralsDecoderTest
    {
        [Fact]
        public void SolutionTest()
        {
            Assert.Equal(1, RomanDecode.Solution("I"));
            Assert.Equal(4, RomanDecode.Solution("IV"));
        }
    }
}
