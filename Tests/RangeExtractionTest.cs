﻿using Katas;
using Xunit;

namespace Tests
{
    public class RangeExtractionTest
    {
        [Theory]
        [InlineData(new[] { 1, 2 }, "1,2")]
        [InlineData(new[] { 1, 2, 3 }, "1-3")]
        [InlineData(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 },
            "-6,-3-1,3-5,7-11,14,15,17-20")]
        [InlineData(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 },
            "-3--1,2,10,15,16,18-20")]
        public void ExtractTest(int[] input, string output)
        {
            Assert.Equal(output, RangeExtraction.Extract(input));
        }
    }
}
