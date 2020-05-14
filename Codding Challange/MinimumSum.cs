using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Codding_Challange
{
    public class MinimumSum
    {
        /// <summary>
        /// Given an array of integers, perform some k operations.
        /// Each operation consists of removing an element from the
        /// array dividing it by 2 and inserting the ceiling of the
        /// result back to the array.
        /// Minimize the sum of the element in the final array.,
        /// </summary>
        /// <param name="input"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static int GetMinimumSum(List<int> input, int operation)
        {
          while(operation > 0)
            {
                var maxInList = input.Max();
                var pos = input.IndexOf(maxInList);
                input.RemoveAt(pos);
                int computed = (int)Math.Ceiling((decimal)maxInList / 2);
                input.Add(computed);
                operation--;
            }
            return input.Sum();
        }
        //public static void Main(string[] args)
        //{
        //   var input = ReadFromFile(out int itteration);

        //   var sum = GetMinimumSum(input, itteration);
            
        //}
        static List<int> ReadFromFile(out int itteration)
        {
            int counter = 0;
            string line;
            var input = new List<int>();
            itteration = 0;
            var path = Path.GetFullPath(@"/../Input/GetMinSumInput002.txt");
            
            System.IO.StreamReader file =
                new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                if (counter > 0)
                    input.Add(Int32.Parse(line));
                else
                    itteration = Int32.Parse(line);
                counter++;

            }

            file.Close();

            return input;
        }
    }
}
