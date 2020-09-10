using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Codding_Challange.LeetcodeAmazonPractice
{
    class TwoSum
    {
        public static void Main(string[] args)
        {
           //var result = TwoSums(new int[]{3,3 },6);
            var result = TwoSums(new int[]{ 230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221
                    ,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,
                    306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457
                    ,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789}, 542);
            Console.WriteLine();
        }
        private static int[] TwoSums(int[] nums, int target)
        {
           
            var hashNum= new HashSet<int>();
            var hashComplement = new HashSet<int>();
            var firstIndex = 0;
             var lstIndex = 0;
            foreach (var num in nums)
            {

                if (!hashNum.Contains(num))
                {
                    if(!hashComplement.Contains(num))
                    {
                        hashNum.Add(num);
                        hashComplement.Add(target - num);
                    }
                    else
                    {
                        
                        firstIndex = Array.IndexOf(nums, target - num);
                        lstIndex = Array.IndexOf(nums, num);
                        Console.WriteLine($"{target - num} found at index {Array.IndexOf(nums, target - num)} and {num} found at index {Array.IndexOf(nums, num)}");
                        
                    }
                    
                }
                else if(num*2 == target)
                {
                    firstIndex = Array.IndexOf(nums, num);
                    lstIndex = Array.LastIndexOf(nums, num);
                }
            }
           
            return new int[] { firstIndex, lstIndex };
        }
    }
}
