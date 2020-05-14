using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Codding_Challange
{
    public static class GetMovieList
    {
        public static async Task<IEnumerable<Movie>> GetMoviesAsync(string subString)
        {
            var movies = new List<Movie>();
            var url = "http://jsonmock.hackerrank.com/api/movies/search/?Title="+ subString;
            int currentPage = 1;
            int totalPages = 0;
            var nextUrl = $"{url}&page={currentPage}";

            using (var httpClient = new HttpClient())
            {
                do
                {
                    HttpResponseMessage response = await httpClient.GetAsync(nextUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var pageResponse = JsonConvert.DeserializeObject<PageResponse>(json);

                        if (pageResponse != null && pageResponse.Data.Any())
                        {
                            movies.AddRange(pageResponse.Data);
                            Console.WriteLine(movies.Count.ToString());
                            totalPages = pageResponse.TotalPages;

                            currentPage++;
                            nextUrl = $"{url}&page={currentPage}";
                        }
                        else
                        {
                            break; // or throw exception
                        }
                    }
                    else
                    {
                        break; // or throw exception
                    }
                } while (currentPage <= totalPages);
            }

            return movies;
        }
        public static string[] GetMovies(string subString)
        {
            var movies = new List<Movie>();
            var url = "http://jsonmock.hackerrank.com/api/movies/search/?Title=" + subString;
            int currentPage = 1;
            int totalPages = 0;
            var nextUrl = $"{url}&page={currentPage}";

            

            do
            {
                HttpWebRequest request = WebRequest.CreateHttp(nextUrl);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        // Get a reader capable of reading the response stream
                        using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8))
                        {

                            string json = myStreamReader.ReadToEnd();

                            var pageResponse = JsonConvert.DeserializeObject<PageResponse>(json);

                            if (pageResponse != null && pageResponse.Data.Any())
                            {
                                movies.AddRange(pageResponse.Data);
                                Console.WriteLine(movies.Count.ToString());
                                totalPages = pageResponse.TotalPages;

                                currentPage++;
                                nextUrl = $"{url}&page={currentPage}";
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }
            }
            while (currentPage <= totalPages) ;

            return movies.Select(o => o.Title).ToArray();
        }

        //public static void Main(string[] args)
        //{
        //    //var moviesList = GetMoviesAsync("Spiderman").GetAwaiter().GetResult();
        //    var movieTitle = GetMovies("Waterworld");
        //
        //    //moviesList.OrderBy(t => t.Title)
        //    //    .ToList()
        //    //    .ForEach(x => Console.WriteLine(x.Title));
        //
        //
        //    movieTitle.ToList().OrderBy(x => x).ToList().ForEach(s => Console.WriteLine(s));
        //
        //}
    }

    internal class PageResponse
    {
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        public IEnumerable<Movie> Data { get; set; }
    }

    public  class Movie
    {
        public string Poster { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        [JsonProperty("imdbID")]
        public string ImdbId { get; set; }
    }
}
