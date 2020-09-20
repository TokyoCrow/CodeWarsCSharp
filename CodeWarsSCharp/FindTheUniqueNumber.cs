using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public static class FindTheUniqueNumber
    {
        //
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.Distinct().Where(number => numbers.Count(number.Equals) == 1).Single<int>();
        }
    }
}
