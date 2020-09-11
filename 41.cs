class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1 };
            var res = FirstMissingPositive(nums);
        }
        static int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while(nums[i]>0 && nums[i]<= nums.Length && nums[nums[i] -1] != nums[i])
                {
                    swap(nums, nums[i]-1, i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] - 1 != i)
                    return i + 1;
            }
            return nums.Length + 1;
        }

        private static void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
