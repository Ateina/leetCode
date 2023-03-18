using System;
using System.Collections.Generic;

namespace leetCode.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[5];
            int[] result = TwoSum(nums, 9);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];
                if (dict.ContainsKey(compliment))
                {
                    return new int[] { i, dict.GetValueOrDefault(compliment) };
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }

            }
            return null;
        }
    }
}
