using Katas;
using Xunit;

namespace Tests
{
    public class CreditCardMaskTest
    {
        [Fact]
        public void MaskifyTests()
        {
            Assert.Equal("############5616", CreditCardMask.Maskify("4556364607935616"));
            Assert.Equal("1", CreditCardMask.Maskify("1"));
            Assert.Equal("#1111", CreditCardMask.Maskify("11111"));
        }
    }
}