using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class ShortestSubArrayWithMaxDegree
    {
        /*Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.

            Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.
            
            Example 1:
            Input: [1, 2, 2, 3, 1]
            Output: 2
            Explanation: 
            The input array has a degree of 2 because both elements 1 and 2 appear twice.
            Of the subarrays that have the same degree:
            [1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
            The shortest length is 2. So return 2.
            Example 2:
            Input: [1,2,2,3,1,4,2]
            Output: 6
            Note:
            
            nums.length will be between 1 and 50,000.
            nums[i] will be an integer between 0 and 49,999.
         
         */
        public static int DegreeOfArray(List<int> arr)
        {

            var dist = new Dictionary<int, int>();
            var substringLengthDist = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dist.ContainsKey(item))
                {
                    dist[item]++;
                }
                else
                {
                    dist.Add(item, 1);
                }
            }

            var degree = dist.Values.Max();

            var prop = dist.Where(x => x.Value == degree).Select(x => x.Key);

            foreach (var item in prop)
            {
                var fisrtIndex = arr.IndexOf(item);
                var lastIndex = arr.LastIndexOf(item);
                var length = lastIndex - fisrtIndex + 1;
                substringLengthDist.Add(item, length);
            }

            return substringLengthDist.Values.Min();
        }
    }
}
