using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Codding_Challange
{
    public class FirstRepeatedWord
    {
        public static string FirstRepeatedWords(string s)
        {
            Dictionary<string, int> dist = new Dictionary<string, int>();
            //Regex query = new Regex(@" |,|:|;|-|.|\t");
            var splitString = Regex.Split(s, @"\W");
            //var splitString = query.Split(s);
            foreach(var elemet in splitString)
            {
                if(dist.ContainsKey(elemet))
                {
                    dist[elemet]++;
                    if(dist[elemet] == 2)
                    {
                        return elemet;
                    }
                }
                else
                {
                    dist.Add(elemet, 1);
                }
            }

            return "";
        }
    }
}
