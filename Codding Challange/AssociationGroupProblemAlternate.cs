using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    /// <summary>
    /// 
    /// </summary>
    public class AssociationGroupProblemAlternate
    {
        //public static void Main(String[] args)
        //{
        //    var list = new List<List<string>>
        //    {
        //        new List<string>
        //        {
        //            "item1","item2"
        //        },
        //        new List<string>
        //        {
        //            "item2","item1"
        //        },
        //         new List<string>
        //        {
        //            "item3","item4"
        //        }
        //    };


        //    GetAssociatedGruops(list);
        //}

        private static List<string> GetAssociatedGruops(List<List<string>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var listChanged = false;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if(list[i].Intersect(list[j]).Any())
                    {
                        var unionList = list[i].Union(list[j]).ToList();
                        unionList.Sort();
                        list.Add(unionList);
                        list.Remove(list[i]);
                        list.Remove(list[j-1]);
                        listChanged = true;
                    }
                }
                i = (listChanged) ? i - 1 : i;
            }

            if(list.Count > 1)
            {
                var dist = new Dictionary<List<string>, int>();
                foreach(var item in list)
                {
                    dist.Add(item, item.Count);
                }
                dist.OrderByDescending(x => x.Value);
            }
           var result = (list.Count > 1)? list.OrderByDescending(x => x.Count).Take(1).ToList(): list.ToList();
            return  result.First();
        }
    }
}
