using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSet.Demo
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var listOne = new List<int>() {1, 2, 2, 2, 3, 4, 5 };
            var listTwo = new List<int>() {1, 2, 3, 4 };

            var resultList = Union(listOne, listTwo);
            Console.WriteLine(resultList);
        }

        public static IEnumerable<int> Union(IEnumerable<int> listOne, IEnumerable<int> listTwo)
        {
            //Return the combination of listOne and listTwo without andy duplicates
            // for instance if listOne is 1,2,2,3 and listTwo is 2,3,4 then return 1,2,3,4
            //Do not use .Union or .Distinct from linq
            HashSet<int> union = new HashSet<int>();

            foreach(var item in listOne)
            {
                union.Add(item);
            }

            foreach (var item in listTwo)
            {
                union.Add(item);
            }

            return union.ToList();

        }
    }
}
