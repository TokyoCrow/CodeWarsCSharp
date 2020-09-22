namespace Katas
{
    //https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c
    public static class MaximumSubarraySum
    {
        public static int MaxSequence(int[] arr)
        {
            int maxSubarraySum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                int subarraySum = arr[i];
                int subarrayMaxSum = subarraySum;
                int subarrayLastIndex = i + 1;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    subarraySum += arr[j];
                    if (subarrayMaxSum < subarraySum)
                    {
                        subarrayMaxSum = subarraySum;
                        subarrayLastIndex = j;
                    }
                }
                if (subarrayMaxSum > maxSubarraySum)
                    maxSubarraySum = subarrayMaxSum;
            }
            return maxSubarraySum > 0 ? maxSubarraySum : 0;
        }
    }
}
