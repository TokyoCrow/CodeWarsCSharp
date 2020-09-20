using Katas;
using Xunit;

namespace Tests
{
    public class FindTheUniqueNumberTest
    {
        [Fact]
        public void GetUniqueTest()
        {
            Assert.Equal(1, FindTheUniqueNumber.GetUnique(new[] { 1, 2, 2, 2 }));
            Assert.Equal(-2, FindTheUniqueNumber.GetUnique(new[] { -2, 2, 2, 2 }));
            Assert.Equal(14, FindTheUniqueNumber.GetUnique(new[] { 11, 11, 14, 11, 11 }));
        }
    }
}
