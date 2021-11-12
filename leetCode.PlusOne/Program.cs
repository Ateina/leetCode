using System;

namespace leetCode.PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Input: digits = [1,2,3]
            //Output: [1,2,4]
        }

        public int[] PlusOne(int[] digits)
        {
            int varToAdd = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int currentDigit = digits[i];
                currentDigit = currentDigit + varToAdd;
                if (currentDigit > 9)
                {
                    varToAdd = 1;
                    currentDigit = 0;
                    if (i == 0)
                    {
                        digits[i] = currentDigit;
                        int[] newValues = new int[digits.Length + 1];
                        newValues[0] = 1;
                        Array.Copy(digits, 0, newValues, 1, digits.Length);
                        return newValues;
                    }
                }
                else
                {
                    varToAdd = 0;
                }
                digits[i] = currentDigit;

            }
            return digits;
        }
    }
}
