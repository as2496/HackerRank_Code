using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange.LeetcodeAmazonPractice
{
    public class LongestNonRepeatingSubString
    {
        public LongestNonRepeatingSubString()
        {
        }
        private static int LengthOfLongestSubString(string s)
        {
            var possibleSubstr = new Dictionary<string, int>();
            var checkHashSet = new HashSet<string>();
            var sb = new StringBuilder();
            if (s.Equals(""))
                return 0;
            for(int i =0; i< s.Length; i++)
            {
                var valueAtI = s.Substring(i, 1);
                checkHashSet.Add(valueAtI);
                sb.Append(valueAtI);
                for(int j = i+1; j<s.Length; j++)
                {
                    var valueAtJ = s.Substring(j, 1);
                  if (!checkHashSet.Contains(valueAtJ))
                    {
                        checkHashSet.Add(valueAtJ);
                        sb.Append(valueAtJ);
                    }
                  else
                    {
                        break;
                    }
                }
                var subStr = sb.ToString();
                if (!possibleSubstr.ContainsKey(subStr))
                    possibleSubstr.Add(subStr, subStr.Length);
                sb.Clear();
                checkHashSet.Clear();
            }
            var result = possibleSubstr.OrderByDescending(x => x.Value)
                .First();
            return result.Value;
        }
        /// <summary>
        /// Test 1: bbbbb => b
        /// Test 2:pwwkew => wke
        /// Test 3:abcabcbb => abc
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
            var length = LengthOfLongestSubString("bbbbb");
            Console.WriteLine($"length is: {length}");
        }
    }
}
