using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding_Challange
{

    public class ShippingRoute
    {
        /*Prime Shipping divides shipping route using flight optimization routing
         * The optimal route should be equal to or closest route distance to maxTravelDist combining forwardRouteList and returnRouteList
         * 
         * INPUT
         * maxTravelDist = 10000
         * Forward Route
         *  [ 1 3000],
         *  [ 2 5000],
         *  [ 3 7000],
         *  [ 4 10000]
         * Return Route
         * [1 2000],
         * [2 3000],
         * [3 4000],
         * [4 5000]
         * 
         * OUTPUT 
         * [[2,4],[3,2]]
         */
        public static List<List<int>> OptimizingAirShippingRoute(int maxTravelDist, List<List<int>> forwardRouteList, List<List<int>> returnRouteList)
        {
            var forwardRouteDist = new Dictionary<int, int>();
            var returnRouteDist = new Dictionary<int, int>();
            var totalDistPerRoute = 0;

            var OptimalRouteDist = new Dictionary<List<int>, int>();
            var result = new List<List<int>>();

            //foreach for building forward route dist
            foreach (var element in forwardRouteList)
            {
                int val = 0;
                int key = 0;
                foreach(var item in element)
                {
                    if(key == 0 && val ==0)
                    {
                        key = item;
                        forwardRouteDist.Add(item, val);
                        val++;
                    }
                    else
                    {
                        forwardRouteDist[key] = item;
                    }

                }
            }
            //foreach for building return route dist
            foreach (var element in returnRouteList)
            {
                int val = 0;
                int key = 0;
                foreach (var item in element)
                {
                    if (key == 0 && val == 0 )
                    {
                        key = item;
                        returnRouteDist.Add(item, val);
                        val++;
                    }
                    else
                    {
                        returnRouteDist[key] = item;
                    }

                }
            }

            //Building the dictionary for all possible route
            foreach(var itemforwardRoute in forwardRouteDist)
            {
                foreach(var itemReturnRoute in returnRouteDist)
                {
                    var keylist = new List<int>();
                    keylist.Add(itemforwardRoute.Key);
                    keylist.Add(itemReturnRoute.Key);
                    totalDistPerRoute = itemforwardRoute.Value + itemReturnRoute.Value;
                    if(totalDistPerRoute <= maxTravelDist)
                    {
                        OptimalRouteDist.Add(keylist, totalDistPerRoute);
                    }
                    
                }
            }
            /*select all the route set with distance equal to max travel dist*/
            var optimalEqRouteSorted = OptimalRouteDist.Where(x => x.Value == maxTravelDist).Select(x => x.Key).ToList();


            if (optimalEqRouteSorted != null)
            {
                result = optimalEqRouteSorted;
            } else
            {
                /*select the route set with distance just less than max travel dist*/
                result.Add(OptimalRouteDist.OrderByDescending(x => x.Value)
                                               .Select(x => x.Key).FirstOrDefault()
                                               .ToList());
            }

            return result;
        }
    }
}
