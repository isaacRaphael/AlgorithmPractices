using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo_Challenge__Greed_is_Good_
{
    
    

    public static class Kata
    {
        public static int Score(int[] dice)
        {
            var workingList = dice.ToList();
            var newList = new List<int>();

            int Singleresult1 = 0;
            int Singleresult5 = 0;

            var query = workingList.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();

            int trippleRest = 0;
            bool more1 = false;
            bool more5 = false;
            foreach (var x in query)
            {
                if (x.Counter >= 3)
                {
                    if (x.Element == 1)
                    {
                        more1 = true;
                        trippleRest = x.Element * 1000 + ((x.Counter - 3) * 100);
                    }
                    else if (x.Element == 5)
                    {
                        more5 = true;
                        trippleRest = x.Element * 100 + ((x.Counter - 3) * 50);
                    }
                    else
                    {
                        trippleRest = x.Element * 100;
                    }
                }
            }

            foreach (var x in workingList)
            {
                if (x == 1)
                {
                    Singleresult1 += 100;
                }
                if (x == 5)
                {
                    Singleresult5 += 50;
                }

            }
            return more1 && more5 ? trippleRest : more1 ? trippleRest + Singleresult5 : more5 ? trippleRest + Singleresult1 : trippleRest + Singleresult1 + Singleresult5;
        }
    }
}
