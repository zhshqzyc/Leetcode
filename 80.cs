class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var res = RemoveDuplicates(nums);
        }
        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length < 3)
                return nums.Length;
            int newIndex = 2;

            for (int originalIndex = 2; originalIndex < nums.Length; originalIndex++)
            {
                if(!(nums[originalIndex] == nums[newIndex - 2]))
                {
                    nums[newIndex] = nums[originalIndex];
                    newIndex++;
                }
            }
            
            return newIndex;
        }
    }
