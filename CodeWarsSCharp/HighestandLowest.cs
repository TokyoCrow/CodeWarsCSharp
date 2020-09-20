using System;
using System.Collections.Generic;

namespace Katas
{
    //https://www.codewars.com/kata/554b4ac871d6813a03000035
    public static class HighestandLowest
    {
        public static string HighAndLow(string numbers)
        {
            var listOfNumbers = new List<int>();
            foreach (string number in numbers.Split(' '))
                listOfNumbers.Add(Convert.ToInt32(number));
            listOfNumbers.Sort();
            return $"{listOfNumbers[listOfNumbers.Count - 1]} {listOfNumbers[0]}";
        }
    }
}
