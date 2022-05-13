using System;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = IsValid("401716832807512840963");
            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }

        public static bool IsValid(string s)
        {
            while (IsItSomethingToRemove(s))
            {
                s = CheckForBrackets("()", s);
                s = CheckForBrackets("{}", s);
                s = CheckForBrackets("[]", s);
            }

            return s.Length == 0;
        }

        private static string CheckForBrackets(string bracketsType, string stringToUpdate)
        {
            int bracketsIndex = stringToUpdate.IndexOf(bracketsType);
            if (bracketsIndex != -1)
            {
                stringToUpdate = stringToUpdate.Remove(bracketsIndex, 2);
            }
            return stringToUpdate;
        }

        private static bool IsItSomethingToRemove(string str)
        {
            if (str.IndexOf("()") != -1) return true;
            if (str.IndexOf("{}") != -1) return true;
            if (str.IndexOf("[]") != -1) return true;
            return false;
        }
    }
}
