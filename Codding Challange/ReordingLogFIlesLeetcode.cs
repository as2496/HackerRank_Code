using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Codding_Challange
{
    /// <summary>
    /// https://massivealgorithms.blogspot.com/2018/11/leetcode-937-reorder-log-files.html
    /// INPUT ["a1 9 2 3 1","g1 act car","zo4 4 7","ab1 off key dog","a8 act zoo"]
    /// OUTPUT ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]
    /// You have an array of logs.  Each log is a space delimited string of words.
    /// For each log, the first word in each log is an alphanumeric identifier.Then, either:
    /// Each word after the identifier will consist only of lowercase letters, or;
    /// Each word after the identifier will consist only of digits.
    /// We will call these two varieties of logs letter-logs and digit-logs.
    /// It is guaranteed that each log has at least one word after its identifier.
    /// Reorder the logs so that all of the letter-logs come before any digit-log.
    /// The letter-logs are ordered lexicographically ignoring identifier, with the identifier used in case of ties.
    /// The digit-logs should be put in their original order.
    /// Return the final order of the logs.
    /// </summary>
    /*
     * 
     */
    public class ReordingLogFIlesLeetcode
    {
        public static List<string> ReordingLogFileSortLexicographycally(int numberOfLines, string[] logFile)
        {
            var returnList = new List<string>();
            StringBuilder sb;
            var integerLog = new Dictionary<string, string>();
            var alphaLog = new Dictionary<string, string>();

            foreach(var ele in logFile)
            {
                sb = new StringBuilder();
                var logStringArray = ele.Split(' ');
                var isAlpha = Regex.IsMatch(logStringArray[1], @"^[a-z]+$");
                for(int i = 1; i < logStringArray.Length; i++)
                {
                    sb.Append(logStringArray[i]).Append(" ");
                }

                if (isAlpha)
                {
                    alphaLog.Add(logStringArray[0], sb.ToString());
                }else
                {
                    integerLog.Add(logStringArray[0], sb.ToString());
                }
            }
            var sortedAlphaLog = alphaLog.OrderBy(x => x.Value).ThenBy(x => x.Key)
                                    .ToDictionary(x => x.Key, x => x.Value);
            foreach(var ele in sortedAlphaLog)
            {
                sb = new StringBuilder();
                sb.Append(ele.Key).Append(" ").Append(ele.Value);
                returnList.Add(sb.ToString());
            }

            foreach (var ele in integerLog)
            {
                sb = new StringBuilder();
                sb.Append(ele.Key).Append(" ").Append(ele.Value);
                returnList.Add(sb.ToString());
            }
            return returnList;
        }
        //static void Main(string[] args)
        //{
        //    string[] arr = new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
        //    List<string> output = ReordingLogFileSortLexicographycally(5, arr);
        //    foreach(var ele in output)
        //        Console.WriteLine(ele);
        //    Console.ReadLine();
        //}
    }
}
