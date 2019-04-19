using System;
using System.Collections.Generic;
using System.Text;

namespace Codding_Challange
{
    public class LongestNonOverlapingReatableSubString
    {
        public static String longestRepeatedSubstring(String line)
        {
            int n = line.Length;
            int[,] Array = new int[n + 1, n + 1];

            String result = "";
            int resultlength = 0;


            int i, index = 0;
            for (i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {

                    if (line[i - 1] == line[j - 1]
                            && Array[i - 1, j - 1] < (j - i))
                    {
                        Array[i, j] = Array[i - 1, j - 1] + 1;

                        if (Array[i, j] > resultlength)
                        {
                            resultlength = Array[i, j];
                            index = Math.Max(i, index);
                        }
                    }
                    else
                    {
                        Array[i, j] = 0;
                    }
                }
            }

            if (resultlength > 0)
            {
                for (i = index - resultlength + 1; i <= index; i++)
                {
                    result += line[i - 1];
                }
            }

            return result;
        }
    }
}
