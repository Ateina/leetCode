using System;
using System.Linq;

namespace leetCode.LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"flower","flow","flight"};
            string output = "";
            int minLength = strs.Min(y=>y.Length); // this gets you the shortest length of all elements in names
            string word = strs[0];
            for (int i = 0; i < minLength; i++)
            {
                char letter = word[i];
                Boolean equal = true;
                for(int j = 1; j < strs.Length; j++){
                    
                    if(letter != strs[j][i]) {equal = false; break;}
                }
                if(equal) output = output + letter;
                else{break;}
            }
            Console.WriteLine(output);
        }
    }
}
