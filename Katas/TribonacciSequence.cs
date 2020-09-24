using System;

namespace Katas
{
    //https://www.codewars.com/kata/556deca17c58da83c00002db
    public static class TribonacciSequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return Array.Empty<double>();
            double[] outputSignature = new double[n];
            Array.Copy(signature, outputSignature, 3);
            for (var i = 3; i < n; i++)
            {
                outputSignature[i] = outputSignature[i - 1] + outputSignature[i - 2] + outputSignature[i - 3];
            }
            return outputSignature;
        }
    }
}
