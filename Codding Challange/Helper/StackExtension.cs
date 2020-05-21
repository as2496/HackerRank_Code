using System;
using System.Collections.Generic;
using System.Linq;

namespace Codding_Challange.Helper
{
    /// <summary>
    /// The results are:
    ///Clone1: 318,3766 ms
    ///Clone2: 269,2407 ms
    ///Clone3: 50,6025 ms
    ///Clone4: 37,5233 ms - the winner
    /// </summary>
    public static class StackExtension
    {
        public static Stack<T> Clone1<T>(this Stack<T> original)
        {
            return new Stack<T>(new Stack<T>(original));
        }

        public static Stack<T> Clone2<T>(this Stack<T> original)
        {
            return new Stack<T>(original.Reverse());
        }

        public static Stack<T> Clone3<T>(this Stack<T> original)
        {
            var arr = original.ToArray();
            Array.Reverse(arr);
            return new Stack<T>(arr);
        }

        public static Stack<T> Clone4<T>(this Stack<T> original)
        {
            var arr = new T[original.Count];
            original.CopyTo(arr, 0);
            Array.Reverse(arr);
            return new Stack<T>(arr);
        }
    }
}
