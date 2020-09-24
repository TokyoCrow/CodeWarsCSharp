using Katas;
using Xunit;

namespace Tests
{
    public class MaximumSubarraySumTest
    {
        [Theory]
        [InlineData(new int[0], 0)]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void MaxSequenceTest(int[] input, int output)
        {
            Assert.Equal(output, MaximumSubarraySum.MaxSequence(input));
        }
    }
}
