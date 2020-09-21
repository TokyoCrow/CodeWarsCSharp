using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    //https://www.codewars.com/kata/52b7ed099cdc285c300001cd
    public static class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            var sum = new List<int>();
            foreach ((int, int) interval in intervals)
                for (var i = interval.Item1 + 1; i <= interval.Item2; i++)
                    sum.Add(i);
            return sum.Distinct().Count();
        }
    }
}
