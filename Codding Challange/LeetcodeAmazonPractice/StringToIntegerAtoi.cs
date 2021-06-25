using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Codding_Challange.LeetcodeAmazonPractice
{
    public class StringToIntegerAtoi
    {
        public static int ToInteger(string str)
        {
            List<char> datalist = new List<char>();
            datalist.AddRange(str);
            var sb = new StringBuilder();

            foreach(var element in datalist)
            {
                if (element.Equals(' ') && sb.Length == 0)
                    continue;
                else if (element.Equals(' ') && sb.Length > 0)
                    break;
                if ((element.Equals('+') || element.Equals('-')) && (sb.Length == 0))
                {
                    sb.Append(element);
                }
                else if (Char.IsLetter(element))
                    break;
                else if (Char.IsDigit(element))
                {
                    sb.Append(element);
                }
                else
                   break;

            }

            if (sb.Equals("+") || sb.Equals("-")|| sb.Length == 0)
                return 0;

            var isInRange = int.TryParse(sb.ToString(), out int result);
                if (!isInRange && sb[0].Equals('-'))
                {
                    return int.MinValue;
                }
                else if(!isInRange)
                {
                    return int.MaxValue;
                }
            return result;
        }

        /// <summary>
        /// -91283472332
        /// "words and 987" -> 0
        /// "   -43"
        /// words and 987 and 61
        /// "+" -> 0
        /// 3.13465 ->3
        /// "   +0 123" -> 0
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
           var result = ToInteger("2147483648");
        }
    }

}
