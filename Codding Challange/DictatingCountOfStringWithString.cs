using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Codding_Challange
{
    class DictatingCountOfStringWithString
    {
        public static string DictateString(string line)
        {
            var line2 = line.Trim();
            StringBuilder sb = new StringBuilder();
            var list = Regex.Split(line2, @"\D+");
            Dictionary<int, int> dist = new Dictionary<int, int>();
            foreach (var element in list)
            {
                var ele = Convert.ToInt32(element);
                if (dist.ContainsKey(ele))
                {
                    dist[ele]++;
                }
                else
                {
                    dist.Add(ele, 1);
                }
            }
            foreach (var ele in dist)
            {
               // Console.Write(ele.Value + " " + ele.Key + " ");
                sb.Append(ele.Value);
                sb.Append(" ");
                sb.Append(ele.Key);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
