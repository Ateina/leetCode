using System;
using System.Collections.Generic;

namespace leetCode.MultiplyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Multiply("401716832807512840963", "167141802233061013023557397451289113296441069");
            Console.WriteLine(result);
        }

        public static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";
            String num1_test = num1;
            String num2_test = num2;

            if (num1.Length > num2.Length)
            {
                num1_test = num1;
                num2_test = num2;
            }
            else
            {
                num1_test = num2;
                num2_test = num1;
            }

            int num1_test_l = num1_test.Length;
            int num2_test_l = num2_test.Length;

            int tempResult = 0;
            string result = "";
            List<string> multiplyResults = new List<string>();

            for (int j = 1; j <= num2_test_l; j++)
            {
                for (int i = 1; i <= num1_test_l; i++)
                {
                    int firstNumber = Int32.Parse(num1_test[num1_test_l - i].ToString());

                    int secondNumber = Int32.Parse(num2_test[num2_test_l - j].ToString());
                    tempResult = firstNumber * secondNumber + firstDigit(tempResult);

                    if (i == num1_test_l)
                    {
                        multiplyResults.Add(tempResult.ToString() + result);
                        result = "";
                        tempResult = 0;
                    }
                    else result = (lastDigit(tempResult)).ToString() + result;
                    if (tempResult < 10) { tempResult = 0; }

                }
            }

            //add nulls to the end
            for (int d = 1; d < multiplyResults.Count; d++)
            {
                multiplyResults[d] = multiplyResults[d] + manyNulls(d);
            }

            //add nulls to the start
            int longest = multiplyResults[multiplyResults.Count - 1].Length;
            for (int d = 0; d < multiplyResults.Count; d++)
            {
                multiplyResults[d] = manyNulls(longest - multiplyResults[d].Length) + multiplyResults[d];
            }

            List<string> sumResults = new List<string>();
            for (int f = 0; f < longest; f++)
            {
                int tempSum = 0;
                multiplyResults.ForEach(item =>
                {
                    int temp = Int32.Parse(item[item.Length - f - 1].ToString());
                    tempSum = tempSum + temp;
                });
                sumResults.Add(tempSum.ToString());
            }

            string res = "";
            int tempAddVar = 0;
            for (int i = 0; i < sumResults.Count; i++)
            {
                int currentNumber = Int32.Parse(sumResults[i]);
                int temp_var;
                if (i == sumResults.Count - 1)
                {
                    temp_var = currentNumber + tempAddVar;
                    tempAddVar = 0;
                }
                else
                {
                    temp_var = lastDigit(currentNumber + tempAddVar);
                }
                res = temp_var.ToString() + res;
                if (currentNumber + tempAddVar < 10) { tempAddVar = 0; }
                else tempAddVar = firstDigit(currentNumber + tempAddVar);
            }

            return res;
        }

        static int firstDigit(int n)
        {
            string value = n.ToString();
            if (value.Length == 1)
            {
                return n;
            }
            else
            {
                value = value.Substring(0, value.Length - 1);
                return Int32.Parse(value);
            }
        }

        static int lastDigit(int n)
        {
            return n % 10;
        }

        static string manyNulls(int amountOfNuuls)
        {
            string result = "";
            for (int i = 0; i < amountOfNuuls; i++)
            {
                result = result + "0";
            }
            return result;
        }
    }
}

