using Katas;
using Xunit;

namespace Tests
{
    public class NotVerySecureTest
    {
        [Theory]
        [InlineData("Mazinkaiser", true)]
        [InlineData("hello world_", false)]
        [InlineData("PassW0rd", true)]
        [InlineData("     ", false)]
        public void AlphanumericTest(string input, bool output)
        {
            Assert.Equal(output, NotVerySecure.Alphanumeric(input));
        }
    }
}