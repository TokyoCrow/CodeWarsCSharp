using Katas;
using Xunit;

namespace Tests
{
    public class TribonacciSequenceTest
    {
        [Fact]
        public void TribonacciTest()
        {
            Assert.Equal(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, TribonacciSequence.Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.Equal(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, TribonacciSequence.Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.Equal(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, TribonacciSequence.Tribonacci(new double[] { 0, 1, 1 }, 10));
        }
    }
}
