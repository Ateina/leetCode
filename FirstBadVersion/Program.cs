using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int FirstBadVersion(int n)
        {
            int low = 1;
            int high = n;
            int mid = low + (high - low) / 2;
            bool firstBadVersionWasFound = false;
            while (!firstBadVersionWasFound)
            {
                if (IsBadVersion(mid) && !IsBadVersion(mid - 1))
                {
                    firstBadVersionWasFound = true;
                    return mid;
                }
                else
                {
                    if (IsBadVersion(mid))
                    {
                        high = mid - 1;
                        mid = low + (high - low) / 2;
                    }
                    else
                    {
                        low = mid + 1;
                        mid = low + (high - low) / 2;
                    }
                }
            }
            return -1;
        }

        private bool IsBadVersion(int number)
        {
            return true;
        }
    }
}
