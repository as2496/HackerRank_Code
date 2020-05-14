using System;
using System.Collections.Generic;

namespace Codding_Challange
{
    public class MatchingBracketUniquePair
    {
        /// <summary>
        /// Consider a string consisting of the character < and >
        /// The string is balanced only if < appers on the left of >
        /// as a corresponding character.(They do not need to be
        /// adjuscent. Each < and > is a unique set, and neither of
        /// character can be considered as any other part of the
        /// symbol.
        /// To balance the string any > can be replaced by <>.
        /// </summary>
        /// <param name="InputList"></param>
        /// <param Maximum replacement available is PermisibleAdjustment name="PermisibleAdjustment"></param>
        /// <returns></returns>

        private static List<bool> IsMatchUniquePair(List<string> InputList, List<int> PermisibleAdjustment)
        {
            var listOfCharArray = new List<char[]>();
            var resultList = new List<bool>();
            foreach(var input in InputList)
            {
                var charArray = input.ToCharArray();
                listOfCharArray.Add(charArray);
            }
            foreach(var chArr in listOfCharArray)
            {
                var pos = listOfCharArray.IndexOf(chArr);
                var st = new Stack<char>();

                foreach (var ch in chArr)
                {
                    if (ch == '<')
                        st.Push(ch);
                    else if (ch == '>' && st.Count > 0)
                        st.Pop();
                    else if (ch == '>' && st.Count == 0)
                        st.Push(ch);
                }
                
               
                while(st.Count > 0 && PermisibleAdjustment[pos] > 0 && st.Peek() == '>') {
                        st.Pop();
                        PermisibleAdjustment[pos]--;
                    
                }
                
                if (st.Count == 0)
                
                    resultList.Add(true);
                
                else
                    resultList.Add(false);

            }
           return resultList;
        }
        //static void Main(string[] args)
        //{
        //    List<string> inputList = new List<string> {"<<>>","<>","<><>",">>","<<>","><><" };
        //    List<int> adjustment = new List<int> {0,1,2,2,2,2};

        //    var result = IsMatchUniquePair(inputList, adjustment);
        //}
    }
}
