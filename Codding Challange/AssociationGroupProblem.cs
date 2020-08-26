using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class AssociationGroupProblem
    {
        /// <summary>
        /// Develop a system to provide recomendation 
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        public static List<List<string>> GetAssociatedGruops(List<List<string>> inputList)
        {
            var associationGroup = new Dictionary<List<string>, int>();
            var isAssociatedCheck = new Dictionary<List<string>, bool>();

            // To check if any group did not participate in association at the end
            foreach(var item in inputList)
            {
                if (!isAssociatedCheck.ContainsKey(item))
                    isAssociatedCheck.Add(item, false);
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                
                for (int j = i+1; j < inputList.Count; j++)
                {
                    var intersectedList = inputList[i].Intersect(inputList[j]);
                    Console.WriteLine($"{i}, {j}");


                    if (intersectedList.Any())
                    {
                        // Any group that participate in association market as true
                        if (isAssociatedCheck.ContainsKey(inputList[i]) && isAssociatedCheck[inputList[i]] == false)
                            isAssociatedCheck[inputList[i]] = true;
                        if (isAssociatedCheck.ContainsKey(inputList[j]) && isAssociatedCheck[inputList[j]] == false)
                            isAssociatedCheck[inputList[j]] = true;

                        var newGroup = inputList[i].Union(inputList[j]).ToList();
                        newGroup.Sort();

                        if (!associationGroup.ContainsKey(newGroup))
                        {
                            associationGroup.Add(newGroup, newGroup.Count);
                        }
                            
                    }
                    
                }
                
            }
            foreach(var item in isAssociatedCheck)
            {
                if(item.Value == false)
                associationGroup.Add(item.Key, item.Key.Count);
            }
            var final = associationGroup.OrderByDescending(x => x.Value).Select(x => x.Key).Take(1).ToList();




            return final;
        }
        public static void Main(String[] args)
        {
            var list = new List<List<string>>
            {
                new List<string>
                {
                    "item1","item2"
                },
                new List<string>
                {
                    "item3","item4"
                }
                ,
                new List<string>
                {
                    "item4","item5"
                },
                new List<string>
                {
                    "item1","item3","item6"
                }
            };


            GetAssociatedGruops(list);
        }
    }
}
