using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class MostCommonSubString
    {

        

        public static int getMaxOccurrences(string s, int minLength, int maxLength, int maxUnique)
        {
            var n = s.Length;
            Dictionary<string, int> substrings = new Dictionary<string, int>();
            for (int i = 0; i <= n; i++)
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
