using System;
using System.Linq;

namespace Katas
{
    //https://www.codewars.com/kata/526571aae218b8ee490006f4
    public static class BitCounting
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).ToCharArray().Select(i => int.Parse(i.ToString())).Sum();
        }
    }
}
