class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6] { 2, 0, 2, 1, 1, 0 };
            SortColors(nums);
        }
        static void SortColors(int[] nums)
        {
            int[] counts = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                counts[nums[i]]++;
            }

            int x = 0;
            for (int i = 0; i <= 2; i++)
            {
                while (counts[i] > 0)
                {
                    nums[x] = i;
                    counts[i] -= 1;
                    x++;
                }
            }
        }
    }
