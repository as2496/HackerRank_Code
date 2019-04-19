using System;
using System.Collections.Generic;
using System.Linq;

namespace Codding_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = MostCommonSubString.getMaxOccurrences("ababab", 2, 3, 4);
            //Console.WriteLine(result);
            int result = frequentsubstring.getMaxOccurrence("abcde", 2, 5, 3);
            Console.WriteLine(result);


            //IEnumerable<Movie> movies = GetMovieList.GetMoviesAsync("spiderman").GetAwaiter().GetResult();
            //Console.WriteLine($"Retrieved {movies.Count()} movies.");

            //var result = FirstRepeatedWord.FirstRepeatedWords("we work hard bec Hard work pay");

            Console.ReadLine();
        }
    }
}
