class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            var result = CanJump(nums);
        }
        static bool CanJump(int[] nums)
        {
            int lastGoodIndexPosition = nums.Length - 1;
            for (int i = nums.Length-1; i>=0; i--)
            {
                if (i + nums[i] >= lastGoodIndexPosition)
                {
                    lastGoodIndexPosition = i;
                }
            }
            return lastGoodIndexPosition == 0;
        }
    }
