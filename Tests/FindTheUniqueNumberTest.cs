using Katas;
using Xunit;

namespace Tests
{
    public class FindTheUniqueNumberTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 2, 2 }, 1)]
        [InlineData(new[] { -2, 2, 2, 2 }, -2)]
        [InlineData(new[] { 11, 11, 14, 11, 11 }, 14)]
        public void GetUniqueTest(int[] input, int output)
        {
            Assert.Equal(output, FindTheUniqueNumber.GetUnique(input));
        }
    }
}
