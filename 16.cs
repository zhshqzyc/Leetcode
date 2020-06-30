class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            var result = ThreeSumClosest(nums, 4);
        }

        static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closest = int.MaxValue;
            int min;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    min = nums[left] + nums[right] + nums[i] - target;
                    if (Math.Abs(min) < Math.Abs(closest)) closest = min;
                    if (min > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return closest + target;
        }
    }
