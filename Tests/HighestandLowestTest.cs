using Katas;
using Xunit;

namespace Tests
{
    public class HighestandLowestTest
    {
        [Fact]
        public void HighAndLowTests()
        {
            Assert.Equal("42 -9", HighestandLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}
