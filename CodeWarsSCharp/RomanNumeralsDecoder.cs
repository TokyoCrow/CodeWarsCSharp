using System.Collections.Generic;

namespace Katas
{
    public class RomanDecode
    {
        static Dictionary<char, int> romanNumbers = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
        public static int Solution(string roman)
        {
            var number = 0;
            var minus = 0;
            for (var i = 0; i < roman.Length; i++)
            {
                int thisDigit = romanNumbers[roman[i]] - minus;
                if ((i == roman.Length - 1) || (thisDigit + minus >= romanNumbers[roman[i + 1]]))
                {
                    number += thisDigit;
                    minus = 0;
                }
                else
                {
                    minus = thisDigit;
                }
            }
            return number;
        }
    }
}
