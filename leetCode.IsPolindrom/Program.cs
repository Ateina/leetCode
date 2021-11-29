using System;

namespace leetCode.IsPolindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 122221;
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
