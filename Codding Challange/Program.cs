using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Codding_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            /**********Camp Systems***********/

            //int result = frequentsubstring.getMaxOccurrence("abcde", 2, 5, 3);



            //IEnumerable<Movie> movies = GetMovieList.GetMoviesAsync("spiderman").GetAwaiter().GetResult();
            //Console.WriteLine($"Retrieved {movies.Count()} movies.");

            //var result = FirstRepeatedWord.FirstRepeatedWords("we work hard bec Hard work pay");





            /**********Expedia***********/

            // var result = DictatingCountOfStringWithString.DictateString("1 2 2 2 4 4 5 5 5 5 ");
            //Console.WriteLine(result);
            //Console.ReadLine();




            //List<String> str = new List<String>();
            //
            //str.Add("2");
            //str.Add("Hello World");
            //str.Add("a");
            //str.Add("the");
            //str.Add("4");
            //str.Add("San Fransisco");
            //NLongestString.FindNInputlongestStrings(str);


            //var result = LongestNonOverlapingReatableSubString.longestRepeatedSubstring("banana");


            /**********Amazon***********/


            //string[] arr = { "ykc 82 01", "eo first qpx", "09z cat hamster", "06f 12 25 6", "az0 first qpx", "236 cat dog rabbit snake" };
            //TelecommunicationJunctionBoxOrdering.OrderTheJunctionBox(6,arr);


            var maxDist = 10000;


            List<List<int>> forwardRoutelist = new List<List<int>>{
                         new List<int> { 1,3000},
                         new List<int> { 2, 5000},
                         new List<int> { 3, 7000},
                         new List<int> { 4, 10000},
                         };
            List<List<int>> returnRoutelist = new List<List<int>>{
                         new List<int> { 1,2000},
                         new List<int> { 2,3000},
                         new List<int> { 3,4000},
                         new List<int> { 4,5000}
                         };
            var result = ShippingRoute.OptimizingAirShippingRoute(maxDist, forwardRoutelist, returnRoutelist);
        }
    }
}
