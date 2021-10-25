using System;
using System.Collections.Generic;
using System.Linq;

namespace largestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(',').ToList().Select(a => Convert.ToInt32(a)).ToList();
            Console.WriteLine(solution(arr.ToArray()));
        }

        public static int solution(int[] A)
        {
            int res = 0;

            HashSet<int> set = new HashSet<int>();
            foreach (var item in A)
            {
                if (set.Contains(item * -1)){
                    res = Math.Max(res, Math.Abs(item));
                }
                else
                {
                    set.Add(item);
                }

            }
            return res;

        }
    }
}
