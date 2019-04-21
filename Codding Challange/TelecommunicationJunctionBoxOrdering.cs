using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class TelecommunicationJunctionBoxOrdering
    {
        /*
         * The following are old and new junction boxes that telecommunication company planned to replace.
         * Old boxes - start with alphanumeric identifier followed by lowercase english string version number
         * Nex Boxes - start with alphanumeric identifier followed by number digits version number
         * Order them such as the oldestbox are returned in the begining follwed by newer boxes
         * order by the version number, if two version number matches then order by alphanumeric identifier for old box
         * return the new boxes in the order that they were receieved.
         * 
         * INPUT
         * ["ykc 82 01"]
         * ["eo first qpx"]
         * [ "09z cat hamster"]
         * ["06f 12 25 6"]
         * [ "az0 first qpx"]
         * [ "236 cat dog rabbit snake" ]
         * 
         * 
         * OUTPUT
         * [ "236 cat dog rabbit snake" ]
         * [ "09z cat hamster"]
         * [ "az0 first qpx"]
         * ["eo first qpx"]
         * ["ykc 82 01"]
         * ["06f 12 25 6"]
         */
        public static List<string> OrderTheJunctionBox(int NumberOfBox, String[] boxList)
        {
            
            StringBuilder sb = new StringBuilder();
            var Listnew = new Dictionary<string, string>();
            var ListOld = new Dictionary<string, string>();

            foreach (var ele in boxList)
            {
                sb.Clear();
                var ar = ele.Split(' ');
                int num;
                bool isNumeric = int.TryParse(ar[1], out num);
                for (int i = 1; i < ar.Length; i++)
                {
                    sb.Append(ar[i]);
                    sb.Append(" ");
                }
                var x = sb.ToString().Trim();
                if (isNumeric)
                {

                    Listnew.Add(ar[0], x);

                }
                else
                {
                    ListOld.Add(ar[0], x);
                }
            }

            var sortOldByVal = ListOld.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var result = new List<string>();
            foreach (var el in sortOldByVal)
            {
                var sb1 = new StringBuilder();
                sb1.Append(el.Key);
                sb1.Append(" ");
                sb1.Append(el.Value);
                result.Add(sb1.ToString());
            }
            foreach (var el in Listnew)
            {
                var sb1 = new StringBuilder();
                sb1.Append(el.Key);
                sb1.Append(" ");
                sb1.Append(el.Value);
                result.Add(sb1.ToString());
            }

            return result;
        }
    }
}
