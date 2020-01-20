using System;
using System.Collections.Generic;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            var res = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                var res1 = GenerateParentesis(i);
                res.AddRange(res1);
            }
           
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static IList<string> GenerateParentesis(int n)
        {
            List<string> res = new List<string>();
            Helper(string.Empty, res, n, 0, 0);
            return res;
            
        }
        public static void Helper(string curr, List<string> res, int n, int left, int right)
        {
            if(right == n)
            {
                res.Add(curr);
                return;
            }
            if(left < n)
            {
                Helper(curr + "(", res, n, left + 1, right);
            }
            if(right <left)
            {
                Helper(curr + ")", res, n, left, right + 1);
            }
        }
    }
}
