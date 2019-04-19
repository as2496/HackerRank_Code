using System;

namespace Codding_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MostCommonSubString.getMaxOccurrences("abcde", 2, 4, 26);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
