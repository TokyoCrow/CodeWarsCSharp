using Katas;
using Xunit;

namespace Tests
{
    public class BitCountingTest
    {
        [Fact]
        public void CountBitsTest()
        {
            Assert.Equal(0, BitCounting.CountBits(0));
            Assert.Equal(1, BitCounting.CountBits(4));
            Assert.Equal(3, BitCounting.CountBits(7));
            Assert.Equal(2, BitCounting.CountBits(9));
            Assert.Equal(2, BitCounting.CountBits(10));
        }
    }
}
