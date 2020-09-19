using Katas;
using Xunit;

namespace Tests
{
    public class DoesMyNumberLookBigInThisTest
    {
        [Fact]
        public void NarcissisticTest()
        {
            Assert.True(DoesMyNumberLookBigInThis.Narcissistic(1));
            Assert.True(DoesMyNumberLookBigInThis.Narcissistic(371));
            Assert.False(DoesMyNumberLookBigInThis.Narcissistic(999));
            Assert.False(DoesMyNumberLookBigInThis.Narcissistic(154));
        }
    }
}
