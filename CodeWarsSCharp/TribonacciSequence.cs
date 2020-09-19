using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    //https://www.codewars.com/kata/556deca17c58da83c00002db
    public static class TribonacciSequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return Array.Empty<double>();
            else
            {
                Array.Resize(ref signature, n);
                for(int i = 3; i < n; i++)
                {
                    signature[i] = signature[i-1] + signature[i-2] + signature[i-3];
                }
                return signature;
            }
        }
    }
}
