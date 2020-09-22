using Katas;
using Xunit;

namespace Tests
{
    public class NotVerySecureTest
    {
        [Fact]
        public void AlphanumericTest()
        {
            Assert.True(NotVerySecure.Alphanumeric("Mazinkaiser"));
            Assert.False(NotVerySecure.Alphanumeric("hello world_"));
            Assert.True(NotVerySecure.Alphanumeric("PassW0rd"));
            Assert.False(NotVerySecure.Alphanumeric("     "));
        }
    }
}