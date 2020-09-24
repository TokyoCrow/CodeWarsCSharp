using Katas;
using Xunit;

namespace Tests
{
    public class EurekaTest
    {
        [Theory]
        [InlineData(1, 10, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [InlineData(1, 100, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 })]
        [InlineData(10, 100, new long[] { 89 })]
        [InlineData(90, 100, new long[] { })]
        [InlineData(90, 150, new long[] { 135 })]
        [InlineData(50, 150, new long[] { 89, 135 })]
        [InlineData(10, 150, new long[] { 89, 135 })]
        public void SumDigPowTest(int inputStartRange, int inputEndRange, long[] output)
        {
            Assert.Equal(output, Eureka.SumDigPow(inputStartRange, inputEndRange));
        }
    }
}
