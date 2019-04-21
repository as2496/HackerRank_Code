using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class NLongestString
    {
        public static void FindNInputlongestStrings(List<string> str)
        {
            var num = Convert.ToInt32(str.First());
            str.RemoveAt(0);


            Dictionary<string, int> dist = new Dictionary<string, int>();
            foreach (var ele in str)
            {
                if (!dist.ContainsKey(ele))
                {
                    int val = ele.ToCharArray().Length;
                    dist.Add(ele, val);
                }
            }
            //var items = from pair in dist
            //            orderby pair.Value descending
            //            select pair;

            var items = dist.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var element in items)
            {
                if (num > 0)
                {
                    Console.WriteLine(element.Key);
                    num--;
                }
            }
        }
    }
}
