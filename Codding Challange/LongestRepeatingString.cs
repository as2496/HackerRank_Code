using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class LongestRepeatingString
    {
        public static void GetLongestRepeatingSubString()
        {
            var s = "banana";
            Dictionary<string, int> substrings = new Dictionary<string, int>();
            Dictionary<string, int> substrings1 = new Dictionary<string, int>();
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
                if (substrings.ContainsKey(element))
                {
                    substrings[element]++;
                    if (!substrings1.ContainsKey(element) && substrings[element] > 1)
                    {
                        substrings1.Add(element, element.ToCharArray().Length);

                    }

                }
                else
                {
                    substrings.Add(element, 1);
                }
            }


            var first = substrings1.OrderByDescending(kvp => kvp.Value).First();
        }
    }
}
