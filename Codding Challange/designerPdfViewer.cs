using System;
using System.Collections.Generic;
using System.IO;

namespace Codding_Challange
{
    // Designer PDF Viewer


    public class designerPdfViewer
    {
        static int designerPdfViewerFunc(int[] h, string word)
        {
            var AlphabetHeightDist = new Dictionary<char,int>();
            int counter = 0;
            int maxHeight = 0;
            var CharArray = word.ToCharArray();

            for(char ch = 'a'; ch <= 'z'; ch++)
            {
                AlphabetHeightDist.Add(ch, h[counter]);
                counter++;
            }
            foreach(var ele in CharArray)
            {
                var height = AlphabetHeightDist[ele];
                if (maxHeight < height)
                {
                    maxHeight = height;
                }
            }
            int area = maxHeight * CharArray.Length;
            return area;
        }

        //static void Main(string[] args)
        //{

        //    int[] h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
        //    string word = "zaba";
        //    int result = designerPdfViewerFunc(h, word);

        //    Console.WriteLine(result);
        //    Console.ReadLine();

            
        //}
    }
}

