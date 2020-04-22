using System;
namespace Codding_Challange
{
    public class BigSumProblem
    {
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var element in ar)
            {
                sum = sum + element;
            }
            return sum;
        }
        //static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int arCount = Convert.ToInt32(Console.ReadLine());

        //    long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

        //    long result = aVeryBigSum(ar);

        //    Console.WriteLine(result);
        //    Console.ReadLine();

        //    //textWriter.WriteLine(result);

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}
    }
}
