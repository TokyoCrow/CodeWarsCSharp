using Katas;
using Xunit;

namespace Tests
{
    public class BinaryAdditionTest
    {
        [Fact]
        public void AddBinaryTests()
        {
            Assert.Equal("11", BinaryAddition.AddBinary(1, 2));
        }
    }
}
