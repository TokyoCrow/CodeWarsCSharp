using System;
using System.Collections.Generic;

namespace Katas
{
    //https://www.codewars.com/kata/5626b561280a42ecc50000d1
    public static class Eureka
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> numbers = new List<long>();
            for (long number = a; number <= b; number++)
            {
                string digits = Convert.ToString(number);
                int sumOfNumberDigits = 0;
                for (var digit = 1; digit <= digits.Length; digit++)
                    sumOfNumberDigits += (int) Math.Pow(Convert.ToInt32(Convert.ToString(digits[digit - 1])), digit);
                if (number == sumOfNumberDigits)
                    numbers.Add(number);
            }
            return numbers.ToArray();
        }
    }
}
