using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class frequentsubstring
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
        public static int getMaxOccurrence(string s, int minLength, int maxLength, int maxUnique)
        {
            try
            {
                Dictionary<string, int> substrings = new Dictionary<string, int>();
                List<string> list = new List<string>();
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = i; j < s.Length; j++)
                    {
                        string ss = s.Substring(i, j - i + 1);
                        list.Add(ss);
                    }
                }
                foreach (var element in list)
                {
                    int distChar = element.Distinct().Count();
                    if (element.Length >= minLength && element.Length <= maxLength && distChar <= maxUnique)
                    {
                        if (substrings.ContainsKey(element))
                        {
                            substrings[element]++;
                        }
                        else
                        {
                            substrings.Add(element, 1);
                        }
                    }
                }
                return substrings.Max(x => x.Value); 
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message + s);
            }
            return 0;
        }
    }
}
