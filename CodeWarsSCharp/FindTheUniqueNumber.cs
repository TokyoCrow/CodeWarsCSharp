using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    //https://www.codewars.com/kata/585d7d5adb20cf33cb000235
    public static class FindTheUniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.Distinct().Where(number => numbers.Count(number.Equals) == 1).Single<int>();
        }
    }
}
