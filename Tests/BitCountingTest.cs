using Katas;
using Xunit;

namespace Tests
{
    public class BitCountingTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(4, 1)]
        [InlineData(7, 3)]
        [InlineData(9, 2)]
        [InlineData(10, 2)]
        public void CountBitsTest(int input, int output)
        {
            Assert.Equal(output, BitCounting.CountBits(input));
        }
    }
}
