using Katas;
using Xunit;

namespace Tests
{
    public class CreditCardMaskTest
    {
        [Theory]
        [InlineData("4556364607935616", "############5616")]
        [InlineData("1", "1")]
        [InlineData("11111", "#1111")]
        public void MaskifyTests(string input, string output)
        {
            Assert.Equal(output, CreditCardMask.Maskify(input));
        }
    }
}