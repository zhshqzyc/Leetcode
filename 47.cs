class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 3 };
            var res = PermuteUnique(nums);
        }
        static IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return res;
            Array.Sort(nums);
            bool[] used = new bool[nums.Length];
            List<int> permutation = new List<int>();
            helper(nums, permutation, used, res, 0);
            return res;
        }

        private static void helper(int[] nums, List<int> permutation, bool[] used, List<IList<int>> res, int count)
        {
            if (count == nums.Length)
            {
                res.Add(new List<int>(permutation));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;
                if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
                used[i] = true;
                permutation.Add(nums[i]);
                helper(nums, permutation, used, res, count + 1);
                permutation.RemoveAt(permutation.Count - 1);
                used[i] = false;
            }
        }
    }
