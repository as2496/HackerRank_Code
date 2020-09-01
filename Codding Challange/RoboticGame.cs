using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class RoboticGame
    {
        /// <summary>
        /// Return an integer total score after going through steps of action
        /// digit -> the current score is that digit and Total score is summation of current score & previous total score
        /// Z ->previous and total score is reset as if privious throw never happened
        /// X -> current score is 2*previous score,Total score is summation of current score & previous total score 
        /// + ->current score is summation of two previous current score, Total score is summation of current score & previous total score
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        public static int GetTotalScore(List<string> blocks)
        {
            var currentScore = 0;
            var previousScore = 0;
            var previousCurrent = 0;
            var TotalScore = 0;
            var prePrevious = 0;
            foreach (var item in blocks)
            {
                bool isDigit = int.TryParse(item, out int result);
                if (isDigit == true)
                {
                    previousScore = TotalScore;
                    previousCurrent = currentScore;
                    currentScore = result;
                    TotalScore = TotalScore + currentScore;
                }
                else if (item.Equals("Z", StringComparison.OrdinalIgnoreCase))
                {
                    TotalScore = previousScore;
                    currentScore = previousCurrent;
                }
                else if (item.Equals("X", StringComparison.OrdinalIgnoreCase))
                {
                    previousCurrent = currentScore;
                    currentScore = currentScore * 2;
                    previousScore = TotalScore;
                    TotalScore = TotalScore + currentScore;
                }
                else if (item.Equals("+"))
                {
                    prePrevious = previousCurrent;
                    previousCurrent = currentScore;
                    previousScore = TotalScore;
                    currentScore = prePrevious + previousCurrent;
                    TotalScore = currentScore + TotalScore;
                }
            }
            
            return TotalScore;
        }
        public static void Main(String[] args)
        {
            var list = new List<string>
            {
                "4","1","2","+","z" //1// exp3
                //"5","-2","4","Z","X","9","+","+"
            };



            GetTotalScore(list);
        }
    }
}
