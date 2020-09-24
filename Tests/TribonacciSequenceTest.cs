using Katas;
using Xunit;

namespace Tests
{
    public class TribonacciSequenceTest
    {
        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 10, new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 })]
        [InlineData(new double[] { 0, 0, 1 }, 10, new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 })]
        [InlineData(new double[] { 0, 1, 1 }, 10, new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 })]
        public void TribonacciTest(double[] inputArr,int inputLength, double[] output)
        {
            Assert.Equal(output, TribonacciSequence.Tribonacci(inputArr, inputLength));
        }
    }
}
