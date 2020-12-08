class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };
            var result = Subsets(nums);
        }
        static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length == 0) return result;
            Helper(nums, 0, result, new List<int>());
            return result;
        }

        static void Helper(int[] nums, int currentIndex, IList<IList<int>> result, IList<int> currentList)
        {
            result.Add(new List<int>(currentList));
            for (int index = currentIndex; index < nums.Length; index++)
            {
                currentList.Add(nums[index]);
                Helper(nums, index + 1, result, currentList);
                currentList.RemoveAt(currentList.Count - 1);
            }
        }
    }
