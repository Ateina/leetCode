using System;

namespace SearchInsert
{
    class Program
    {
        void Main(string[] args)
        {
            int[] array = new[] { -1, 0, 3, 5, 9, 12 };
            int result = SearchInsert(array, 9);
            Console.WriteLine(result);
        }

        public int SearchInsert(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;
            int mid = (min + max) / 2;
            while (min <= max)
            {
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] < target)
                {
                    min = mid + 1;
                    mid = (min + max) / 2;
                    //Console.WriteLine(min);
                    //Console.WriteLine(mid);
                    //Console.WriteLine();
                }
                if (nums[mid] > target)
                {
                    max = mid - 1;
                    mid = (min + max) / 2;
                }
            }
            //Console.WriteLine(min);
            if (min >= nums.Length)
            {
                return min;
            }
            else
            {
                if (nums[min] < target)
                {
                    return min + 1;
                }
                else { return min; }
            }

        }
    }
}
