using System;
using System.Collections.Generic;
using System.Linq;

namespace Codding_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = MostCommonSubString.getMaxOccurrences("abcde", 2, 4, 26);
            //Console.WriteLine(result);

            IEnumerable<Movie> movies = GetMovieList.GetMoviesAsync("spiderman").GetAwaiter().GetResult();
            Console.WriteLine($"Retrieved {movies.Count()} movies.");

            Console.ReadLine();
        }
    }
}
