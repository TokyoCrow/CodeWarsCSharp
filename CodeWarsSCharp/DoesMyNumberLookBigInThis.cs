using System;

namespace Katas
{
    //https://www.codewars.com/kata/5287e858c6b5a9678200083c
    public static class DoesMyNumberLookBigInThis
    {
        public static bool Narcissistic(int value)
        {
            string numbers = Convert.ToString(value);
            var summOfNumbers = 0;
            foreach (char number in numbers)
                summOfNumbers += (int) Math.Pow(Convert.ToInt32(Convert.ToString(number)), numbers.Length);
            return summOfNumbers == value;
        }
    }
}
