using Katas;
using Xunit;

namespace Tests
{
    public class EurekaTest
    {
        [Fact]
        public void SumDigPowTest()
        {
            Assert.Equal(new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, Eureka.SumDigPow(1, 10));
            Assert.Equal(new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 89}, Eureka.SumDigPow(1, 100));
            Assert.Equal(new long[] {89}, Eureka.SumDigPow(10, 100));
            Assert.Equal(new long[] {}, Eureka.SumDigPow(90, 100));
            Assert.Equal(new long[] {135}, Eureka.SumDigPow(90, 150));
            Assert.Equal(new long[] {89, 135}, Eureka.SumDigPow(50, 150));
            Assert.Equal(new long[] {89, 135}, Eureka.SumDigPow(10, 150));
        }
    }
}
