using Katas;
using Xunit;

namespace Tests
{
    public class DoesMyNumberLookBigInThisTest
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(371, true)]
        [InlineData(999, false)]
        [InlineData(154, false)]
        public void NarcissisticTest(int input, bool output)
        {
            Assert.Equal(output, DoesMyNumberLookBigInThis.Narcissistic(input));
        }
    }
}
