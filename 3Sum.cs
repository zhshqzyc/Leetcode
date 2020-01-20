using System;
using System.Collections.Generic;
using System.Linq;

namespace _15
{
    class Sum3
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            
            var t = ThreeSum(nums);
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> result = new List<List<int>>();
            int i = 0;
            int l = 0;
            int r = 0;
            while(i<nums.Length-2)
            {
                l = i + 1;
                r = nums.Length - 1;
                while(l<r)
                {
                    var l_sum = nums[l];
                    var r_sum = nums[r];
                    if (nums[i] + l_sum + r_sum > 0)
                        r--;
                    else if (nums[i] + l_sum + r_sum < 0)
                        l++;
                    else
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[l]);
                        temp.Add(nums[r]);
                        result.Add(temp);
                        l++;
                        r--;
                        while (r > 0 && nums[r] == r_sum)
                            r--;
                        while (l < nums.Length - 1 && nums[l] == l_sum)
                            l++;
                    }
                }
                i++;
            }
            IList<IList<int>> obj = new List<IList<int>>();
            var middle = result.GroupBy(x => String.Join(",", x))
                         .Select(x => x.First().ToList())
                         .ToList();
            foreach (var item in middle)
            {
                obj.Add(item);
            }
            return obj;
        }
    }
}
