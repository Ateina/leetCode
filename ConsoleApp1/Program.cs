using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { -1, 0, 3, 5, 9, 12 };
            int result = Search(array, 9);
            Console.WriteLine(result);
        }

        public static int Search(int[] nums, int target)
        {
            int low = 0;
            int max = nums.Length - 1;
            int mid = max / 2;
            while (low <= max)
            {
                if (nums[mid] == target) return mid;
                if (nums[mid] > target)
                {
                    max = mid - 1;
                    mid = (low + max) / 2;
                }
                if (nums[mid] < target)
                {
                    low = mid + 1;
                    mid = (low + max) / 2;
                }
            }
            return -1;
        }
    }
}
