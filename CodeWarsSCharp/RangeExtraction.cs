using System;
using System.Text;

namespace Katas
{
    //https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
    public static class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            var correctRange = new StringBuilder();
            Array.Sort(args);
            var rangeCounter = 1;
            for (var i = 0; i < args.Length; i++)
            {
                if ((i < args.Length - 1) && (args[i] == (args[i + 1] - 1)))
                    rangeCounter++;
                else
                {
                    if (rangeCounter < 3)
                        for (var j = i - (rangeCounter - 1); j <= i; j++)
                            correctRange.Append($"{args[j]},");
                    else
                        correctRange.Append($"{args[i - (rangeCounter - 1)]}-{args[i]},");
                    rangeCounter = 1;
                }
            }
            return correctRange.Remove(correctRange.Length - 1, 1).ToString();
        }
    }
}
