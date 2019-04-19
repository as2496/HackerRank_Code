using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class MostCommonSubString
    {

        /*
            Most Common Substring
            My solution to the Most Common Substring problem.

            Problem
            Given an input string of size N, return the number of occurrences of the most common substring between lengths minLength and maxLength

            Input
            *  1. STRING s
            *  2. INTEGER minLength
            *  3. INTEGER maxLength
            *  4. INTEGER maxUnique
            Sample Input
            5
            2 4 26
            abcde
            Output
            Sample Output
            1
            */
        /*
        * Complete the 'getMaxOccurrences' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. STRING s
        *  2. INTEGER minLength
        *  3. INTEGER maxLength
        *  4. INTEGER maxUnique
        */

        public static int getMaxOccurrences(string s, int minLength, int maxLength, int maxUnique)
        {
            var n = s.Length;
            Dictionary<string, int> substrings = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                int maxbound;
                if (minLength < n - i)
                    maxbound = minLength;
                else
                    maxbound = n - i;
                for (int j = i; j <= maxbound; j++)
                {
                    string substring = s.Substring(i, j);
                    int distChar = substring.Distinct().Count();
                    if (substring.Length >= minLength && substring.Length <= maxLength && distChar <= maxUnique)
                    {
                        if (substrings.ContainsKey(substring))
                        {
                            substrings[substring]++;
                        }
                        else
                        {
                            substrings.Add(substring, 1);
                        }
                    }
                }
            }
            return substrings.Max(x => x.Value);
        }
    }
}
