using System;
using System.Collections;

namespace Codding_Challange
{
    public class BalancedBracket
    {
        public BalancedBracket()
        {
        }
        static string IsBalanced(string s)
        {
            char[] bracketArray = s.ToCharArray();
            Stack st = new Stack();
            foreach(var bracket in bracketArray)
            {
                if(bracket == '('|| bracket == '{'|| bracket == '[')
                {
                    st.Push(bracket);
                }
                else
                {
                    if(st.Count != 0 && ((bracket == ')'&& (char)st.Peek() == '(')||
                        (bracket == '}' && (char)st.Peek() == '{')||
                        (bracket == ']' && (char)st.Peek() == '[')))
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(bracket);
                    }
                }
            }
            if(st.Count == 0)
            {
                return "YES";
            }
            return "NO";
        }
        /// <summary>
        /// }][}}(}][))]
        /// [](){()}
        /// ()
        /// ({}([][]))[]()
        /// {)[](}]}]}))}(())(
        /// ([[)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var output = IsBalanced("{)[](}]}]}))}(())(");
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
