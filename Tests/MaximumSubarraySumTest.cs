using Katas;
using Xunit;

namespace Tests
{
    public class MaximumSubarraySumTest
    {
        [Fact]
        public void MaxSequenceTest()
        {
            Assert.Equal(0, MaximumSubarraySum.MaxSequence(new int[0]));
            Assert.Equal(6, MaximumSubarraySum.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}
